using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Circle : Ellipse
    {
        public Circle(PointF center, double radius)
        {
            PointStart = center;
            RadiusX = radius;
            RadiusY = radius;
            
        }
    }
}
