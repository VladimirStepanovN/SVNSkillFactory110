namespace Excercise1
{
    internal class Calculator : IAdditional
    {
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
                    Console.WriteLine($"Сумма чисел равна: {result}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильный формат числа");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Введенное число слишком большое");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Результат вычисления слишком большой");
                }
                catch (Exception)
                {
                    Console.WriteLine("Непредвиденная ошибка");
                }
                finally
                {
                    Console.WriteLine("====================================");
                }
            }
        }
    }
}
