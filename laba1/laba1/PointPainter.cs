using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class PointPainter : Painter
    {

        public PointPainter(PointF point)
        {
            Pointst = point;

        }
        public override void Draw(Graphics painter)
        {
            Pen penObj = new Pen(this.BorderColor, this.BorderWidth);
            painter.DrawLine(penObj, Pointst.X, Pointst.Y, Pointst.X + 3, Pointst.Y);
        }
        
       

    }

}
