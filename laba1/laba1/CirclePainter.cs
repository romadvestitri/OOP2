using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class CirclePainter : EllipsePainter
    {
        public CirclePainter(PointF point, float radius)
        {
            Pointst = point;
            RadiusX = radius;
            RadiusY = radius;
        }
     
    }
}
