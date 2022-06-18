namespace NCC.ConsoleApp
{
    public class ParallelProgramming
    {
        public async void Run()
        {
            //FunctionOne();
            //FunctionTwo();

            //Thread.Sleep(500);
            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);
            //t1.Start();
            //t2.Start();

            //Task<int> t1 = new Task<int>(TaskTwo);
            //Task<string> t2 = new Task<string>(TaskThree);

            //t1.Start();
            //t2.Start();

            //Console.WriteLine($"Result of Task Three = {t2.Result}");
            //Console.WriteLine($"Result of Task Two = {t1.Result}");

            TaskTwo();
            TaskThree();

            TaskFour(10);
            TaskFive();

            //Task<string> t1 = new Task<string>(FunctionOne);
            //Task t2 = new Task(FunctionTwo);
            //t1.Start();
            //t2.Start();
            //var res = await TaskOne();
            //Console.WriteLine($"Data from task one is {res}");
        }

        public void FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(950);
            }
            //return "Function has ended";
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

        public int TaskTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Task Two Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(950);
            }
            return 10;
        }

        public string TaskThree()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Task Three Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1850);
            }

            return "Task Three is completed";
        }

        public async Task<int> TaskFour(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Task Four Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                //Thread.Sleep(950);
                await Task.Delay(950);
            }
            return 10;
        }

        public async Task<string> TaskFive()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Task Five Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                await Task.Delay(1850);
            }

            return "Task Three is completed";
        }
    }
}