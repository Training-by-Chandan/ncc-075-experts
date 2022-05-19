namespace NCC.ConsoleApp
{
    //cannot create the object
    public abstract class ShapeAbsV2
    {
        protected double area;
        protected double perimeter;

        protected abstract void getInput();

        protected abstract void calculate();

        public void GetInput()
        {
            getInput();
            calculate();
        }

        public void Area()
        {
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }

    public class SquareAbsV2 : ShapeAbsV2
    {
        private double length;

        protected override void getInput()
        {
            Console.WriteLine("Enter the Length of Square");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void calculate()
        {
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbsV2 : ShapeAbsV2
    {
        private double length;
        private double breadth;

        protected override void calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }

        protected override void getInput()
        {
            Console.WriteLine("Enter the Length of Rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());
        }
    }
}