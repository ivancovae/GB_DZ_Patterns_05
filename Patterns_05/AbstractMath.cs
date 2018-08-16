using System;

namespace Patterns_05
{
    abstract class AbstractMath
    {
        public abstract double Addition(double fOper, double sOper);
        public abstract double Multiplication(double fOper, double sOper);
        public abstract double Division(double fOper, double sOper);
        public abstract double Subtraction(double fOper, double sOper);

        public abstract double Max(double fOper, double sOper);
        public abstract double Min(double fOper, double sOper);
    }
}
