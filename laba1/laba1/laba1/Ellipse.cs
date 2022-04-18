using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Ellipse : Figure
    {
        protected Ellipse()
        {
        }
        public Ellipse(PointF center, double RadiusX, double RadiusY)
        {   
            
            PointStart = center;
            this.RadiusX = RadiusX;
            this.RadiusY = RadiusY;

        }
      /*  public override void Draw(Graphics painter)
        {
            Pen drawpen = new Pen(this.BorderColor, this.BorderWidth);

            painter.DrawEllipse(drawpen, (float)(PointStart.X - this.RadiusX), (float)(PointStart.Y - this.RadiusY), (float)(this.RadiusX * 2), (float)(this.RadiusY *2));
        }*/
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }


    }
}
