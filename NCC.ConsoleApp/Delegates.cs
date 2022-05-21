namespace NCC.ConsoleApp
{
    //pointer to function
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public void Run()
        {
            //unicast delegate
            MathOps m = new MathOps(Add);
            m(2, 3);
            m = Subtract;
            m(2, 3);
            m = Multiply;
            m(2, 3);
            m = Divide;
            m(2, 3);

            //multicast delegate
            MathOps math = Add;
            math += Subtract;
            math += Multiply;
            math += Divide;
            math += Add;
            math(10, 5);

            math -= Add;
            math -= Multiply;
            math(10, 10);

            math -= Multiply;
            math(10, 10);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference = {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product = {a * b}");
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine($"Quotient = {a / b}");
        }
    }
}