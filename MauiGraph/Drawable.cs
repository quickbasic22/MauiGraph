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
    public class Drawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.ResetState();
            canvas.Antialias = true;
            canvas.BlendMode = BlendMode.Color;

            

            // Set the origin to the center of the canvas
            float centerX = dirtyRect.Width / 2;
            float centerY = dirtyRect.Height / 2;
            canvas.Translate(centerX, centerY);

            // Set the scale of the canvas so that x-axis ranges from -10 to 10 and y-axis ranges from -6 to 6
            float scaleX = dirtyRect.Width / 60;
            float scaleY = dirtyRect.Height / 36;
            canvas.Scale(scaleX, -scaleY);

            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 0.1f;
            canvas.DrawLine(new PointF(-30, 0), new PointF(30, 0));
            canvas.DrawLine(new PointF(0, -36), new PointF(0, 36));

            // Set the line color and thickness
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 0.15f;

            // Graph a parabola
           
            for (float x = -10f; x <= 10f; x += 0.1f)
            {
                float y = x * x + 5;
                canvas.DrawLine(x, y, x + 0.1f, (x + 0.1f) * (x + 0.1f) + 5);
            }

            canvas.StrokeColor = Colors.MediumPurple;
            for (float x = -10f; x <= 10f; x += 0.1f)
            {
                float y = x * x * x;
                canvas.DrawLine(x, y, x + 0.1f, (x + 0.1f) * (x + 0.1f) * (x + 0.1f));
            }




            //canvas.StrokeColor = Colors.DarkRed;
            //canvas.StrokeSize = 6;

            //canvas.DrawLine(new Point(-10, 0), new Point(10, 0));
            //canvas.DrawLine(new Point(0, -6), new Point(0, 6));

            canvas.SaveState();



            //canvas.StrokeColor = Colors.DarkBlue;
            //canvas.StrokeSize = 12;

            //canvas.DrawRectangle(new Rect(100, 200, 250, 250));

            //canvas.StrokeColor = Colors.Red;
            //canvas.StrokeSize = 20;

            //canvas.DrawCircle(new Point(100.0, 100.0), 200.0);





        }
    }
}

