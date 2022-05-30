namespace NCC.ConsoleApp
{
    public class Test
    {
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                throw new ArgumentException("The first number cannot be zero");
            }
            return a + b;
        }
    }
}