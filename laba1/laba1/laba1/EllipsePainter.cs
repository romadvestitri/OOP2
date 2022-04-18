using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class EllipsePainter: Painter
    {
        protected EllipsePainter()
        {
        }
        public EllipsePainter(PointF point, float RadiusX, float RadiusY)
        {
            Pointst = point;
            this.RadiusX = RadiusX;
            this.RadiusY = RadiusY;
        }
        public float RadiusX { get; set; }
        public float RadiusY { get; set; }

          public override void Draw(Graphics painter)
        {
            Pen drawpen = new Pen(BorderColor, BorderWidth);
            SolidBrush Brush = new SolidBrush(FillColor);
            painter.DrawEllipse(drawpen, (Pointst.X - this.RadiusX), (Pointst.Y - this.RadiusY), (this.RadiusX * 2), (this.RadiusY *2));
            painter.FillEllipse(Brush, (Pointst.X - this.RadiusX), (Pointst.Y - this.RadiusY), (this.RadiusX * 2), (this.RadiusY * 2));
        }
    }
}
