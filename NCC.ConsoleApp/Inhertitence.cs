namespace NCC.ConsoleApp
{
    //inheritence
    //1. Sharing and code reusability
    //2. a class can inherit only one class

    public class LivingThings
    {
        public int PublicVariable = 10;
        private int _privateVariable = 15;
        protected int protectedVariable = 20;

        public LivingThings()
        {
        }

        public LivingThings(int i)
        {
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base(15)
        {
        }

        public Animal(int i) : base(i)
        {
        }

        public void FunctionOne()
        {
            PublicVariable = 20;
            protectedVariable = 25;
        }
    }

    public class Plants : LivingThings
    {
        public Plants() : base()
        {
        }

        public Plants(int i) : base(i)
        {
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates() : base()
        {
        }
    }

    public sealed class Human : Vertibrates
    {
    }
}