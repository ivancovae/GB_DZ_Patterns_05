using System.Drawing;

namespace Patterns_05
{
    class BlueCicle : IDrawCicleAPI
    {
        Pen pen;

        public BlueCicle()
        {
            pen = new Pen(Color.Blue, 6);
        }

        public void DrawCicle(Graphics context, Point location, Size size)
        {
            context.DrawEllipse(pen, new Rectangle(location, size));
        }
    }
}
