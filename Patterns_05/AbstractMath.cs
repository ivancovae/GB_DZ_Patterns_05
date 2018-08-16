namespace Patterns_05
{
    /// <summary>
    /// Абстрактный класс "математики"
    /// </summary>
    abstract class AbstractMath
    {
        /// <summary>
        /// Абстрактный метод сложения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>сумма</returns>
        public abstract double Addition(double fOper, double sOper);
        /// <summary>
        /// Абстрактный метод умножение
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>произведение</returns>
        public abstract double Multiplication(double fOper, double sOper);
        /// <summary>
        /// Абстрактный метод деления
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>результат деления</returns>
        public abstract double Division(double fOper, double sOper);
        /// <summary>
        /// Абстрактный метод вычитания
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>разница</returns>
        public abstract double Subtraction(double fOper, double sOper);

        /// <summary>
        /// Абстрактный метод максимального значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>максимальное значение</returns>
        public abstract double Max(double fOper, double sOper);
        /// <summary>
        /// Абстрактный метод минимального значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>минимальное значение</returns>
        public abstract double Min(double fOper, double sOper);
    }
}
