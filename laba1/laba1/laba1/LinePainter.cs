using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class LinePainter : Painter
    {
        public LinePainter(PointF point)
        {
            Pointst = point;

        }
        public override void Draw(Graphics painter)
        {
            Pen drawpen = new Pen(BorderColor, BorderWidth);
            painter.DrawLine(drawpen, Pointst, new PointF(Pointst.X-50, Pointst.Y-50));
        }

        
    }
}
