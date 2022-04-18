using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class TrianglePainter : Painter
    {

        public TrianglePainter(PointF point)
        {
            Pointst = point;

        }

        public override void Draw(Graphics painter)
        {

            PointF[] ThreePoints = { Pointst, new PointF(Pointst.X + 50, Pointst.Y + 50), new PointF(Pointst.X - 100, Pointst.Y + 100) };
            Pen drawpen = new Pen(BorderColor, BorderWidth);
            SolidBrush Brush = new SolidBrush(FillColor);
            painter.DrawPolygon(drawpen, ThreePoints);
            painter.FillPolygon(Brush, ThreePoints);
        }
    }

 }
