namespace NCC.ConsoleApp
{
    [Custom]
    public class Test
    {
        [Custom]
        public string Name { get; set; }

        [Custom]
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                throw new CustomException("The first number cannot be zero");
            }
            return a + b;
        }
    }
}