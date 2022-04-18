using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Triangle : Figure
    {
        
        public Triangle(PointF point1)
        {
            PointStart = point1;
                       
        }

        /*public override void Draw(Graphics painter)
        {
            
            PointF[] ThreePoints = { PointStart, new PointF(PointStart.X+50, PointStart.Y+50), new PointF(PointStart.X - 100, PointStart.Y + 100)  };

            Pen drawpen = new Pen(BorderColor, BorderWidth);

            painter.DrawPolygon(drawpen, ThreePoints);
        }*/

       


       
        

    }
}
