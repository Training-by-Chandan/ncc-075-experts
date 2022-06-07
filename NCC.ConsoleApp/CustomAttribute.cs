namespace NCC.ConsoleApp
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class CustomAttribute : Attribute
    {
        private readonly string positionalString;

        // This is a positional argument
        public CustomAttribute()
        {
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
    }
}