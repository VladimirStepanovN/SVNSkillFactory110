namespace Excercise2
{
    internal class Program
    {
        static ILogger Logger = new Logger();
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(Logger);
            calc.Count();
        }
    }
}