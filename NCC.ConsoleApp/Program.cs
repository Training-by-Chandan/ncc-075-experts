using System;

namespace NCC.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            //DataTypes();
            ConditionalStatements();
            return;
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