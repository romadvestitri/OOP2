using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class RectanglePainter : Painter
    {
        public RectanglePainter(int point2, int point3)
        {
            Point2 = point2;
            Point3 = point3;
        }

         public override void Draw(Graphics painter)
         {
             Pen drawpen = new Pen(BorderColor, BorderWidth);
             SolidBrush Brush = new SolidBrush(FillColor);
             painter.DrawRectangle(drawpen, Pointst.X, Pointst.Y, Point2, Point3);
             painter.FillRectangle(Brush, Pointst.X, Pointst.Y, Point2, Point3);

        }

        public int Point2 { get; set; }
        public int Point3 { get; set; }

    }
}
