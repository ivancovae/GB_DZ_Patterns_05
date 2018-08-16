namespace Patterns_05
{
    /// <summary>
    /// класс заместитель "математики"
    /// </summary>
    class ProxyMath : AbstractMath
    {
        private Math math;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ProxyMath()
        {
            math = new Math();
        }

        /// <summary>
        /// метод сложения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>сумма</returns>
        public override double Addition(double fOper, double sOper)
        {
            return math.Addition(fOper, sOper);
        }
        /// <summary>
        /// метод деления
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>результат деления</returns>
        public override double Division(double fOper, double sOper)
        {
            return math.Addition(fOper, sOper);
        }
        /// <summary>
        /// метод максимального значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <exception cref="System.NotImplementedException">Недопустимый метод</exception>
        /// <returns>максимальное значение</returns>
        public override double Max(double fOper, double sOper)
        {
            throw new System.NotImplementedException("Max");
        }
        /// <summary>
        /// метод минимальный значения
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <exception cref="System.NotImplementedException">Недопустимый метод</exception>
        /// <returns>минимальное значение</returns>
        public override double Min(double fOper, double sOper)
        {
            throw new System.NotImplementedException("Min");
        }
        /// <summary>
        /// метод умножение
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>произведение</returns>
        public override double Multiplication(double fOper, double sOper)
        {
            return math.Multiplication(fOper, sOper);
        }
        /// <summary>
        /// метод вычитания
        /// </summary>
        /// <param name="fOper">первый оператор</param>
        /// <param name="sOper">второй оператор</param>
        /// <returns>разница</returns>
        public override double Subtraction(double fOper, double sOper)
        {
            return math.Subtraction(fOper, sOper);
        }
    }
}
