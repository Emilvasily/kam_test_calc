using System;

namespace Calculator.Core.Infrastructure
{
    public class CalcOperation
    {
        SimpleOperation operation;
        double before;

        public double Before
        {
            get
            {
                return before;
            }
            set
            {
                //After = before;
                After = Calculate(After, operation, value);

                operation = SimpleOperation.None;
                before = value;
            }
        }

        public SimpleOperation Operation
        {
            get
            {
                return operation;
            }
            set
            {
                //After = Calculate(After, operation, before);
                operation = value;
            }
        }

        private double Calculate(double before, SimpleOperation value, double after)
        {
            switch (value)
            {
                case SimpleOperation.Addition:
                    after = before + after;
                    break;
                case SimpleOperation.Substraction:
                    after = before - after;
                    break;
                case SimpleOperation.Multiply:
                    after = before * after;
                    break;
                case SimpleOperation.Divide:
                    after = before / after;
                    break;
                case SimpleOperation.Square:
                    after = Math.Pow(before, 2);
                    break;
                default:
                    return after;
            }

            return after;
        }

        public double After { get; private set; }

        


        public void Clear()
        {
            Before = 0;
            After = 0;
            Operation = SimpleOperation.None;
        }
    }
}
