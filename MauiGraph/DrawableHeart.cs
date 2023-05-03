using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics = Microsoft.Maui.Graphics;

namespace MauiGraph
{
    public class DrawableHeart : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.ResetState();
            canvas.Antialias = true;
            canvas.BlendMode = BlendMode.Color;

            PointF pnt1 = new PointF(70f, 50f);
            PointF pnt2 = new PointF(40f, 120f);
            PointF pnt3 = new PointF(100f, 200f);

            PointF pnt4 = new PointF(160, 120f);
            PointF pnt5 = new PointF(130f, 50f);
            PointF pnt6 = new PointF(100f, 150f);
            
        }
    }
}

