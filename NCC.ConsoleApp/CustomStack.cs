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

    public class CustomStackObjects
    {
        private object[] _container = new object[5];
        private int counter = -1;

        public void Push(object item)
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
                _container[counter] = default(object);
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

    public class CustomStackTemplated<T, U, X>
        where T : ShapeAbs
        where U : IShape
        where X : LivingThings
    {
        public X[] _container3 = new X[5];
        public T[] _container4 = new T[5];
        public U[] _container2 = new U[5];
        public T[] _container = new T[5];
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