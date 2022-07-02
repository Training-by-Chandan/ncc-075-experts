namespace ConsoleApp.Data
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res = "N";
            do
            {
                Console.Clear();
                try
                {
                    var choice = getChoice();
                    Run(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void Run(int choice)
        {
            switch (choice)
            {
                case 1:
                    DbConnection.GetAll();
                    break;

                case 2:
                    DbConnection.GetById();
                    break;

                case 3:
                    DbConnection.Create();
                    break;

                case 4:
                    DbConnection.Edit();
                    break;

                case 5:
                    DbConnection.Delete();
                    break;

                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

        private static int getChoice()
        {
            Console.WriteLine("Press");
            Console.WriteLine("1 to get all the records");
            Console.WriteLine("2 to get the record by ID");
            Console.WriteLine("3 to create the record");
            Console.WriteLine("4 to edit the record");
            Console.WriteLine("5 to delete the record");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}