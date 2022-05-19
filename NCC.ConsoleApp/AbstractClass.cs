namespace NCC.ConsoleApp
{
    //cannot create the object
    public abstract class ShapeAbs
    {
        public abstract void GetInput();

        protected abstract void Area();

        protected abstract void Perimeter();

        public void Calculate()
        {
            Area();
            Perimeter();
        }
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length of Square");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Area()
        {
            Console.WriteLine($"Area of Square = {Math.Pow(length, 2)}");
        }

        protected override void Perimeter()
        {
            Console.WriteLine($"Perimeter of Square = {4 * length}");
        }
    }
}