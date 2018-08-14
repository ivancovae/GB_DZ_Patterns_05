using System.Drawing;

namespace Patterns_05
{
    /// <summary>
    /// Класс отрисовки прямоугольников
    /// </summary>
    class RectangleObject : IDrawAPI
    {
        private Pen pen;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public RectangleObject()
        {
            pen = new Pen(Color.Red, 6);
        }

        /// <summary>
        /// отрисовка прямоугольника
        /// </summary>
        /// <param name="context">контекст куда отрисовывать</param>
        /// <param name="location">позиция</param>
        /// <param name="size">размер</param>
        public void Draw(Graphics context, Point location, Size size)
        {
            context.DrawRectangle(pen, new Rectangle(location, size));
        }
    }
}
