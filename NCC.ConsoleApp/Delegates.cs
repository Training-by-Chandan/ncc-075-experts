﻿namespace NCC.ConsoleApp
{
    //pointer to function
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public delegate void Accelerate();

        public event MathOps MathHandler;

        public void Run(int a, int b)
        {
            MathHandler.Invoke(a, b);
        }

        public void Run()
        {
            CarRun();
            // CallingAnonymousFunction();

            UnicasDelegate();

            MulticastDelegate();
        }

        private void CallingAnonymousFunction()
        {
            MathOps m = new MathOps(Add);
            m(10, 5);
            m = (int x, int y) =>
            {
                Console.WriteLine($"Remainder = {x % y}");
            };
            m(10, 5);
        }

        private void CarRun()
        {
            Accelerate a = Neutral;
            a();
            a += Reverse;
            a();
            a += GearOne;
            a();
            a += GearSix;
            a();
        }

        private void Neutral()
        {
            Console.WriteLine("Car is in neutral cannot run");
        }

        private void GearOne()
        {
            Console.WriteLine("Car is moving too slow");
        }

        private void Reverse()
        {
            Console.WriteLine("Car ta pachadi gayo hai");
        }

        private void GearSix()
        {
            Console.WriteLine("Dhoom machale");
        }

        private void UnicasDelegate()
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
        }

        private void MulticastDelegate()
        {
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