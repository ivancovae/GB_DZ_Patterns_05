using System.Drawing;

namespace Patterns_05
{
    interface IDrawRectangleAPI
    {
        void DrawRectangle(Graphics context, Point location, Size size);
    }
}
