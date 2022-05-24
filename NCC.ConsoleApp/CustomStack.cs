namespace NCC.ConsoleApp
{
    public class CustomStack
    {
        private int[] _container = new int[5];
        private int counter = -1;

        public void Push(int item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(int);
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }

    public class CustomStackString
    {
        private string[] _container = new string[5];
        private int counter = -1;

        public void Push(string item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(string);
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }

    public class CustomStackTemplated<T>
    {
        private T[] _container = new T[5];
        private int counter = -1;

        public void Push(T item)
        {
            if (counter < 4)
            {
                counter++;
                _container[counter] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                _container[counter] = default(T);
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }
}