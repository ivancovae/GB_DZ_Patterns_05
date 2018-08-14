using System.Drawing;

namespace Patterns_05
{
    /// <summary>
    /// Класс отрисовки круга
    /// </summary>
    class CicleObject : IDrawAPI
    {
        private Pen pen;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CicleObject()
        {
            pen = new Pen(Color.Blue, 6);
        }

        /// <summary>
        /// отрисовка круга
        /// </summary>
        /// <param name="context">контекст куда отрисовывать</param>
        /// <param name="location">позиция</param>
        /// <param name="size">размер</param>
        public void Draw(Graphics context, Point location, Size size)
        {
            context.DrawEllipse(pen, new Rectangle(location, size));
        }
    }
}
