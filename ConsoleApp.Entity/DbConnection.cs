namespace ConsoleApp.Entity
{
    public static class DbConnection
    {
        private static DefaultContext db = new DefaultContext();

        public static void GetAll()
        {
            var data = db.Students.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id = {item.Id}");
                Console.WriteLine($"Name = {item.Name}");
                Console.WriteLine($"Email = {item.Email}");
                Console.WriteLine($"Phone = {item.Phone}");
                Console.WriteLine("===========================================");
            }
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the ID");
            var id = Convert.ToInt32(Console.ReadLine());

            var item = db.Students.Find(id);

            Console.WriteLine($"Id = {item.Id}");
            Console.WriteLine($"Name = {item.Name}");
            Console.WriteLine($"Email = {item.Email}");
            Console.WriteLine($"Phone = {item.Phone}");
            Console.WriteLine("===========================================");
        }

        public static void Create()
        {
            var student = new Student();
            Console.WriteLine("Enter the name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            student.Phone = Console.ReadLine();

            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the ID");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing != null)
            {
                Console.WriteLine("Enter the name");
                existing.Name = Console.ReadLine();
                Console.WriteLine("Enter the email");
                existing.Email = Console.ReadLine();
                Console.WriteLine("Enter the phone");
                existing.Phone = Console.ReadLine();

                db.Students.Update(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the ID");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                db.Students.Remove(existing);
                db.SaveChanges();
            }
        }
    }
}