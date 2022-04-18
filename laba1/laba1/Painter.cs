using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public abstract class Painter
    {
        public Painter()
        {
            FillColor = Color.Blue;
            BorderColor = Color.Black;
            BorderWidth = 2;
        }
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public PointF Pointst { get; set; }
        public PointF Pointend { get; set; }
        public abstract void Draw(Graphics painter);


    }
}
  

