using System.Drawing;

namespace Patterns_05
{
    class RedRectangle : IDrawRectangleAPI
    {
        Pen pen;

        public RedRectangle()
        {
            pen = new Pen(Color.Red, 6);
        }

        public void DrawRectangle(Graphics context, Point location, Size size)
        {
            context.DrawRectangle(pen, new Rectangle(location, size));
        }
    }
}
