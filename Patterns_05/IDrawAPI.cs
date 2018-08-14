using System.Drawing;

namespace Patterns_05
{
    /// <summary>
    /// Интерфейс отрисовки фигуры
    /// </summary>
    interface IDrawAPI
    {
        /// <summary>
        /// Отрисовка фигуры
        /// </summary>
        /// <param name="context">контекст куда отрисовывать</param>
        /// <param name="location">позиция</param>
        /// <param name="size">размер</param>
        void Draw(Graphics context, Point location, Size size);
    }
}
