using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Point : Figure
    {
        public Point(PointF point1) : base()
        {
            PointStart = point1;
        }

        public Point(float X, float Y) : base()
        {
            PointStart = new PointF(X, Y);
        }
       /* public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, PointStart.X, PointStart.Y, PointStart.X + 3, PointStart.Y);
        }*/
    }
    
}
