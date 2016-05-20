using System;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace LightTracing
{
    public class Renderer
    {      
        public float Percent = 0;
        private int _iteration;

        const int CanvasWidth = 512;
        const int CanvasHeight = 512;

        CColor[,] _ccolors;

        Bitmap _canvas;
        float _pixelWidth, _pixelHeight; // use for convertion from screen size to canvas size

        List<Shape> _scene;

        readonly Vector _eyePos = new Vector(-2.0f, 4.0f, -5.0f);
        Rectangle _screen;
        float _screenWidth;
        float _screenHeight;

        readonly Vector _lightPos = new Vector(0.0f, 8f, 2.5f);
        readonly Vector _windowLeftFarPos = new Vector(-1.0f, 6.0f, 3.0f);
        readonly Vector _windowRightClosePos = new Vector(1.0f, 6.0f, 2.0f);
        float _step = 0.005f;

        const int MaxDepth = 8;
        private Random _rand;

        public event EventHandler OnPercentChange;

        protected virtual void OnOnPercentChange()
        {
            var handler = OnPercentChange;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public void Render(float step, float lightCoeff, ref PictureBox pb)
        {
            _step = step;
            _rand = new Random();

            #region CColor init

            _ccolors = new CColor[CanvasHeight, CanvasWidth];
            for (var i = 0; i < CanvasHeight; i++)
                for (var j = 0; j < CanvasWidth; j++)
                    _ccolors[i, j] = new CColor();

            #endregion

            _canvas = new Bitmap(CanvasWidth, CanvasHeight);

            #region Screen

            _screen = new Rectangle(new Vector(-3.0f, 6.0f, 0.0f),
                                   new Vector(3.0f, 6.0f, 0.0f),
                                   new Vector(-3.0f, 0.0f, 0.0f),
                                   new Vector(3.0f, 0.0f, 0.0f),
                                   new Vector(0.0f, 0.0f, 1.0f),
                                   null,
                                   Color.FromArgb(0, 0, 0));
            _screenWidth = Math.Abs(_screen.T0.V0.X - _screen.T1.V0.X);
            _screenHeight = Math.Abs(_screen.T0.V0.Y - _screen.T1.V0.Y);

            _pixelWidth = CanvasWidth / _screenWidth;
            _pixelHeight = CanvasHeight / _screenHeight;

            #endregion

            _scene = new List<Shape>();

            #region Shapes

            var diffuseSphere = new Sphere(new Vector(2.0f, 1.0f, 3.0f),
                                              0.5f,
                                              new Material(Material.MaterialType.Diffuse),
                                              Color.FromArgb(255, 255, 255));
            _scene.Add(diffuseSphere);
            
            var specularSphere = new Sphere(new Vector(-2.0f, 1.0f, 4.0f),
                                               1.0f,
                                               new Material(Material.MaterialType.Specular),
                                               Color.FromArgb(255, 255, 255));
            _scene.Add(specularSphere);

            var tetr = new Tetrahedron(new Vector(0.0f, 3.0f, 2.0f),
                                               new Vector(1f, 1.0f, 2.5f),
                                               new Vector(-1f, 1.0f, 2.5f),
                                               new Vector(0.0f, 1.0f, 1.5f),
                                               new Material(Material.MaterialType.Transparent),
                                               Color.FromArgb(255, 255, 255));

            _scene.Add(tetr);

            #endregion

            #region Walls

            var left = new Rectangle(new Vector(-3.0f, 6.0f, 0.0f),
                                           new Vector(-3.0f, 6.0f, 5.0f),
                                           new Vector(-3.0f, 0.0f, 0.0f),
                                           new Vector(-3.0f, 0.0f, 5.0f),
                                           new Vector(1.0f, 0.0f, 0.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(200, 75, 75));
            _scene.Add(left);

            var right = new Rectangle(new Vector(3.0f, 6.0f, 5.0f),
                                            new Vector(3.0f, 6.0f, 0.0f),
                                            new Vector(3.0f, 0.0f, 5.0f),
                                            new Vector(3.0f, 0.0f, 0.0f),
                                            new Vector(-1.0f, 0.0f, 0.0f),
                                            new Material(Material.MaterialType.Diffuse),
                                            Color.FromArgb(75, 200, 75));
            _scene.Add(right);

            var bottom = new Rectangle(new Vector(-3.0f, 0.0f, 7.0f),
                                             new Vector(3.0f, 0.0f, 7.0f),
                                             new Vector(-3.0f, 0.0f, 0.0f),
                                             new Vector(3.0f, 0.0f, 0.0f),
                                             new Vector(0.0f, 1.0f, 0.0f),
                                             new Material(Material.MaterialType.Diffuse),
                                             Color.FromArgb(230, 230, 230));
            _scene.Add(bottom);

            var back = new Rectangle(new Vector(-3.0f, 6.0f, 5.0f),
                                           new Vector(3.0f, 6.0f, 5.0f),
                                           new Vector(-3.0f, 0.0f, 5.0f),
                                           new Vector(3.0f, 0.0f, 5.0f),
                                           new Vector(0.0f, 0.0f, -1.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(75, 75, 200));
            _scene.Add(back);

            var top0 = new Rectangle(new Vector(-3.0f, 6.0f, 5.0f),
                                           new Vector(-1.0f, 6.0f, 5.0f),
                                           new Vector(-3.0f, 6.0f, 0.0f),
                                           new Vector(-1.0f, 6.0f, 0.0f),
                                           new Vector(0.0f, -1.0f, 0.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(230, 230, 230));
            _scene.Add(top0);

            var top1 = new Rectangle(new Vector(1.0f, 6.0f, 5.0f),
                                           new Vector(3.0f, 6.0f, 5.0f),
                                           new Vector(1.0f, 6.0f, 0.0f),
                                           new Vector(3.0f, 6.0f, 0.0f),
                                           new Vector(0.0f, -1.0f, 0.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(230, 230, 230));
            _scene.Add(top1);

            var top2 = new Rectangle(new Vector(-1.0f, 6.0f, 5.0f),
                                           new Vector(1.0f, 6.0f, 5.0f),
                                           new Vector(-1.0f, 6.0f, 3.0f),
                                           new Vector(1.0f, 6.0f, 3.0f),
                                           new Vector(0.0f, -1.0f, 0.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(230, 230, 230));
            _scene.Add(top2);

            var top3 = new Rectangle(new Vector(-1.0f, 6.0f, 2.0f),
                                           new Vector(1.0f, 6.0f, 2.0f),
                                           new Vector(-1.0f, 6.0f, 0.0f),
                                           new Vector(1.0f, 6.0f, 0.0f),
                                           new Vector(0.0f, -1.0f, 0.0f),
                                           new Material(Material.MaterialType.Diffuse),
                                           Color.FromArgb(230, 230, 230));
            _scene.Add(top3);

            #endregion

            #region Trace Execute

            var len = (_windowLeftFarPos.Z - _windowRightClosePos.Z) / step;
            Percent = len / 100.0f;
            _iteration = 0;
            for (var j = _windowRightClosePos.Z; j < _windowLeftFarPos.Z; j += step, _iteration++)
            {
                Percent = (_iteration * 100) / len;
                OnOnPercentChange();

                for (var i = _windowLeftFarPos.X; i < _windowRightClosePos.X; i += step)
                {
                    /*var direction = new Vector(i + (float)_rand.NextDouble(), 0, j + (float)_rand.NextDouble()) - _lightPos;
                    direction.Normalize();
                    var ray = new Ray(_lightPos, direction);*/

                    var direction = (new Vector(i, _windowLeftFarPos.Y, j)) - _lightPos;
                    direction.Normalize();
                    var ray = new Ray(_lightPos, direction);
                    Trace(ray, 1, Color.FromArgb(Convert.ToInt32(255 * lightCoeff), 
                        Convert.ToInt32(255 * lightCoeff), 
                        Convert.ToInt32(255 * lightCoeff)));
                }
            }

            #endregion

            #region Canvas Output

            for (var i = 0; i < CanvasHeight; i++)
                for (var j = 0; j < CanvasWidth; j++)
                {
                    _canvas.SetPixel(j, i, _ccolors[i, j].Get());
                }

            _canvas.RotateFlip(RotateFlipType.RotateNoneFlipY);
            _canvas.Save("output.png");

            pb.Image = _canvas;

            #endregion
        }

        void CheckIntersection(ref Ray ray)
        {
            foreach (var shp in _scene)
            {
                shp.Intersect(ref ray);

                if (ray.LastHitDistance < ray.ClosestHitDistance && ray.LastHitDistance > 0)
                {
                    ray.ClosestHitObject = shp;
                    ray.ClosestHitDistance = ray.LastHitDistance;
                }
            }

            ray.HitPoint = ray.Origin + (ray.Direction * ray.ClosestHitDistance);
        }

        bool Visible(Vector p, ref Ray rayToEye)
        {
            CheckIntersection(ref rayToEye);
            
            if (rayToEye.ClosestHitObject != null)
                return false;

            _screen.Intersect(ref rayToEye);
            rayToEye.HitPoint = p + (rayToEye.Direction * rayToEye.LastHitDistance);
            
            return true;
        }

        void Trace(Ray ray, int currentDepth, Color incomingColor)
        {
            var colorVect = new Vector(incomingColor.R, incomingColor.G, incomingColor.B);

            if (Vector.Dot(colorVect, colorVect) < 0.001)
            {
                //луч затух
                return;
            }

            if (currentDepth >= MaxDepth)
                return;

            CheckIntersection(ref ray);

            if (ray.ClosestHitObject == null)
                return;

            var rayToEye = new Ray(ray.HitPoint, _eyePos - ray.HitPoint);
            rayToEye.Direction.Normalize();

            var r = (int)(incomingColor.R * ray.ClosestHitObject.Color.R / 255.0f);
            var g = (int)(incomingColor.G * ray.ClosestHitObject.Color.G / 255.0f);
            var b = (int)(incomingColor.B * ray.ClosestHitObject.Color.B / 255.0f);

            var color = Color.FromArgb(255, r, g, b);
           
            var m = ray.ClosestHitObject.Material;

            var newColor = new Color();

            var newDirection = m.Sample3(ray.ClosestHitObject.Material.Type,
                                 ray,
                                 ray.ClosestHitObject.GetNormalAtPoint(ray.HitPoint),
                                 color,
                                 ref newColor);

            var nextRay = new Ray(ray.HitPoint, newDirection);

            /*newColor = Color.FromArgb(
                    newColor.A,
                    Convert.ToInt32(newColor.R * CoeffAttenuationRay),
                    Convert.ToInt32(newColor.G * CoeffAttenuationRay),
                    Convert.ToInt32(newColor.B * CoeffAttenuationRay));*/

            if (Visible(rayToEye.Origin, ref rayToEye))
            {
                var canvasX = (int)((rayToEye.HitPoint.X - _screen.T0.V0.X) * _pixelWidth);
                if (canvasX < 0)
                    canvasX = 0;
                else if (canvasX >= CanvasWidth)
                    canvasX = CanvasWidth - 1;

                var canvasY = (int)((rayToEye.HitPoint.Y - _screen.T1.V0.Y) * _pixelHeight);
                if (canvasY < 0)
                    canvasY = 0;
                else if (canvasY >= CanvasHeight)
                    canvasY = CanvasHeight - 1;

                /*var newDirection = Material.Sample3(ray.ClosestHitObject.Material.Type,
                    ray,
                    ray.ClosestHitObject.GetNormalAtPoint(ray.HitPoint),
                    newColor);*/

                /*var nextRay = Material.Sample(ray.ClosestHitObject.material.type,
                                              ray,
                                              ray.ClosestHitObject.GetNormalAtPoint(ray.HitPoint));*/

                _ccolors[canvasY, canvasX].Add(newColor.R, newColor.G, newColor.B);
            }

            Trace(nextRay, currentDepth + 1, Color.FromArgb(newColor.R, newColor.G, newColor.B));
        }

        private const float CoeffAttenuationRay = 0.9f;
    }
}