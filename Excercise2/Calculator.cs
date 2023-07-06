namespace Excercise2
{
    internal class Calculator : IAdditional
    {
        ILogger Logger { get; }
        public double Sum(double a, double b)
        {
            try
            {
                return a + b;
            }
            catch (OverflowException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Count()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое слагаемое: ");
                    double one = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе слагаемое: ");
                    double two = Convert.ToDouble(Console.ReadLine());
                    double result = this.Sum(one, two);
                    Logger.Event($"Сумма чисел равна: {result}");
                    break;
                }
                catch (FormatException)
                {
                    Logger.Error("Неправильный формат числа");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Logger.Error("Введенное число слишком большое");
                }
                catch (OverflowException)
                {
                    Logger.Error("Результат вычисления слишком большой");
                }
                catch (Exception)
                {
                    Logger.Error("Непредвиденная ошибка");
                }
                finally
                {
                    Console.WriteLine("====================================");
                }
            }
        }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
    }
}
