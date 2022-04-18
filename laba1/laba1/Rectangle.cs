using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Rectangle : Figure
    {
        public Rectangle(int point2, int point3)
        {
            Point2 = point2;
            Point3 = point3;
        }

       /* public override void Draw(Graphics painter)
        {
            Pen drawpen = new Pen(BorderColor, BorderWidth);
            painter.DrawRectangle(drawpen, PointStart.X, PointStart.Y, Point2, Point3);
        }*/

        public int Point2 { get; set; }
        public int Point3 { get; set; }
        
    }
}
