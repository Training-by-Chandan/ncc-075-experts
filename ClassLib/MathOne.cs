namespace ClassLib
{
    public class MathOne
    {
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                throw new ArgumentNullException("a cannot be zero");
            }
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}