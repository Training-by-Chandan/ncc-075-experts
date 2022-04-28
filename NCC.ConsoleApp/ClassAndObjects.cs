namespace NCC.ConsoleApp
{
    public class ClassAndObject
    {
        //constructors
        //1. Special Functions
        //2. Can be called only once in its lifetime i.e. during the instantiation of a class
        //3. Name should be same as that of classname
        //4. Does not have return type i.e. does not return
        //5. Can be overloaded
        //
        public ClassAndObject()
        {
        }

        public ClassAndObject(int i)
        {
            this.i = i;
            SProp = "Test";
        }

        public ClassAndObject(string s, int x)
        {
        }

        public ClassAndObject(int x, string s)
        {
        }

        //variables
        public int i = 10;

        public string s = "";

        //properties
        public string SProp { get; set; }

        private string lName;

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        private string fname = "";

        public string FName
        {
            get
            {
                return fname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = "Babu";
                }
                fname = value;
            }
        }

        //methods / functions

        //destructors
        //delegates and events
    }
}