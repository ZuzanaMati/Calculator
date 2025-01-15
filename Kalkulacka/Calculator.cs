namespace Kalkulacka
{
    internal class Calculator
    {
        private double Result;

        public Calculator(double result)
        {
            Result = result;
        }

        public bool OperatorIsValid(string oper)
        {
            if (oper == "+" || oper == "-" || oper == "*" || oper == "/" || oper == "=")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(double numnber)
        {
            Result += numnber;

        }

        public void Subtract(double numnber)
        {
            Result -= numnber;

        }

        public void Multiply(double numnber)
        {
            Result *= numnber;

        }

        public void Divide(double numnber)
        {
            Result /= numnber;

        }

        public void SetResult(double number)
        {
            Result = number;
        }

        public double GetResult()
        {
            return Result;
        }

        public double ResetResult()
        {
            Result = 0;
            return Result;
        }
    }
}
