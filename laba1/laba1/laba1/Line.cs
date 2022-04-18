using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Line : Figure
    {   
        public Line(PointF point)
        {
            PointStart = point;
            
        }
        /*public override void Draw(Graphics painter)
        {
            Pen drawpen = new Pen(BorderColor, BorderWidth);
            painter.DrawLine(drawpen, PointStart, new PointF(PointStart.X-50, PointStart.Y-50));
        }*/

        public PointF PointEnd { get; set; } 
    }
}
