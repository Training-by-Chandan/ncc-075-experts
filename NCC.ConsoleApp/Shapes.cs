namespace NCC.ConsoleApp
{
    public class Square : IShape
    {
        private double length;

        public double Length
        {
            get
            {
                return length;
            }
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of Square");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Square = {Math.Pow(length, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Square = {4 * length}");
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of Rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Rectangle = {length * breadth}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Rectangle = {2 * (length + breadth)}");
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public void GetInput()
        {
            Console.WriteLine("Enter the radius of circle");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Circle = {Math.PI * Math.Pow(radius, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Circumference of circle = {2 * radius}");
        }
    }

    public class EquilateralTriangle : IShape
    {
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void GetInput()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}