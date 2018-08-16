namespace Patterns_05
{
    /// <summary>
    /// класс "математики"
    /// </summary>
    class Math : AbstractMath
    {
        /// <summary>
        /// метод сложения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>сумма</returns>
        public override double Addition(double fOper, double sOper)
        {
            return fOper + sOper;
        }
        /// <summary>
        /// метод деления
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>результат деления</returns>
        public override double Division(double fOper, double sOper)
        {
            return fOper / sOper;
        }
        /// <summary>
        /// метод максимального значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>максимальное значение</returns>
        public override double Max(double fOper, double sOper)
        {
            return fOper > sOper ? fOper : sOper;
        }
        /// <summary>
        /// метод минимального значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>минимальное значение</returns>
        public override double Min(double fOper, double sOper)
        {
            return fOper < sOper ? fOper : sOper;
        }
        /// <summary>
        /// метод умножение
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>произведение</returns>
        public override double Multiplication(double fOper, double sOper)
        {
            return fOper * sOper;
        }
        /// <summary>
        /// метод вычитания
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>разница</returns>
        public override double Subtraction(double fOper, double sOper)
        {
            return fOper - sOper;
        }
    }
}
