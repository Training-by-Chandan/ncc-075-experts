using System;
using System.Text;

namespace NCC.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            var res = "n";
            do
            {
                //DataTypes();
                //ConditionalStatements();
                //LoopingStatements();
                //DaysLoop();
                //ClassAndObjectExample();
                PropertiesExample();

                Console.WriteLine("Do you want to continue more(y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            return;
        }

        private static void PropertiesExample()
        {
            MarksInfo mi = new MarksInfo();
            mi.MathMarks = 50.75;
            mi.ScienceMarks = 70.85;
            Console.WriteLine($"Total => {mi.Total}");
            Console.WriteLine($"Percentage => {mi.Percentage}");
            Console.WriteLine($"Division => {mi.Division}");
            mi.ScienceMarks = 40;
            Console.WriteLine($"Total => {mi.Total}");
            Console.WriteLine($"Percentage => {mi.Percentage}");
            Console.WriteLine($"Division => {mi.Division}");
        }

        private static void ClassAndObjectExample()
        {
            ClassAndObject c1 = new ClassAndObject();
            var c2 = new ClassAndObject(0);
            c1.FName = "Bibek";
            Console.WriteLine(c1.FName);
        }

        private static void StringManipulation()
        {
            string a = "Hello";
            string b = "NCC";
            //string concatenation
            var res = a + " " + b;

            //string formatting
            string templ = "{0} {1}";
            var res1 = string.Format(templ, a, b);
            Console.WriteLine("{0} {1}", a, b);

            //string interpolation
            var res3 = $"{a}! {b} {a}";

            //stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");

            var res4 = sb.ToString();
        }

        private static int DaysLoop()
        {
            int i;
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("\nUsing For loop");
            for (i = 0; i < days.Length; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Day => " + days[i]);
            }

            Console.WriteLine("\nUsing foreach");

            foreach (var item in days)
            {
                Console.WriteLine("Day => " + item);
            }

            return i;
        }

        private static void LoopingStatements()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            //doing tasks repeatedly
            //Initialization, Condition, Increament/Decrement
            //unknown quantities
            //known quantities
            Console.WriteLine("Using while loop");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
                i++;
            }
            i = 1;
            Console.WriteLine("Using Do While Loop");
            do
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
                i++;
            } while (i <= 10);

            Console.WriteLine("Using for loop");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }

            //i = DaysLoop();
            //infinite loop using for
            //for (; ; )
            //{
            //}
            //for (i=1;i<=10 ; )
            //{
            //}
            //for (i=1;i>0;i++)
            //{
            //}
        }

        private static void ConditionalStatements()
        {
            //todo do this later
            string days = "";
            Console.WriteLine("Enter the day");
            var choice = Convert.ToInt32(Console.ReadLine());
            days = IfBlock(choice);

            days = SwitchBlock(choice);
        }

        private static string SwitchBlock(int choice)
        {
            string days;
            switch (choice)
            {
                case 1:
                    days = "Sunday";
                    break;

                case 2:
                    days = "Monday";
                    break;

                case 3://TODO Bibek will do this later
                    days = "Tuesday";
                    break;

                case 4:
                    days = "Wednesday";
                    break;

                case 5:
                    days = "Thursday";
                    break;

                case 6:
                    days = "Friday";
                    break;

                case 7:
                    days = "Saturday";
                    break;

                default:
                    days = "Not a valid day";
                    break;
            }

            return days;
        }

        private static string IfBlock(int choice)
        {
            string days;
            if (choice == 1) days = "Sunday";
            else if (choice == 2) days = "Monday";
            else if (choice == 3) days = "Tuesday";
            else if (choice == 4) days = "Wednesday";
            else if (choice == 5) days = "Thursday";
            else if (choice == 6) days = "Friday";
            else if (choice == 7) days = "Saturday";
            else days = "Not a Valid day";

            //ternary operator
            //(condition) ? <True value> : <false value>
            days = choice == 1 ? "Sunday" : choice == 2 ? "Monday" : choice == 3 ? "Tuesday" : choice == 4 ? "Wednesday" : choice == 5 ? "Thursday" : choice == 6 ? "Friday" : choice == 7 ? "Saturday" : "Not a valid day";
            return days;
        }

        private static void DataTypes()
        {
            int i = 10;
            i = 20;

            //char => int => long => float => double
            char c = 'C';
            i = c;
            long l = i;
            float f = l;
            double d = f;

            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;

            var x = 1;
            x = 10;

            object o = "";
            o = 1;
            o = 2f;

            var y = (float)o;

            var a = "1";
            var b = 2;

            object o1 = "";
            object o2 = 1;

            var str = i.ToString();
        }
    }
}