namespace NCC.ConsoleApp
{
    public class ParallelProgramming
    {
        public async void Run()
        {
            ////FunctionOne();
            ////FunctionTwo();

            //Thread.Sleep(500);
            //Thread t1 = new Thread(FunctionOne);
            Thread t2 = new Thread(FunctionTwo);
            //t1.Start();
            //t2.Start();

            Task<string> t1 = new Task<string>(FunctionOne);
            Task t2 = new Task(FunctionTwo);
            t1.Start();
            t2.Start();
            var res = await TaskOne();
            Console.WriteLine($"Data from task one is {res}");
        }

        public string FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(950);
            }
            return "Function has ended";
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Function Two Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1450);
            }
        }

        public async Task<string> TaskOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Task One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1150);
            }
            return "Task has ended";
        }
    }
}