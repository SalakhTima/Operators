namespace Operators
{
    class Program
    {
        static void Main()
        {
            RationalNumbers a = new RationalNumbers(2, 3);
            RationalNumbers b = new RationalNumbers(3, 4);

            RationalNumbers addition = a + b;
            Console.WriteLine($"Результат сложения: {addition}\n");

            RationalNumbers substraction = a - b;
            Console.WriteLine($"Результат вычитания: {substraction}\n");

            RationalNumbers multiplication = a * b;
            Console.WriteLine($"Результат умножения: {multiplication}\n");

            RationalNumbers division = a / b;
            Console.WriteLine($"Результат деления: {division}\n");

            bool isGreater = a > b;
            Console.WriteLine($"Первая дробь больше второй? {isGreater}\n");

            bool isLess = a < b;
            Console.WriteLine($"Первая дробь меньше второй? {isLess}\n");

            bool isEquals = a == b;
            Console.WriteLine($"Обе дроби равны? {isEquals}\n");

            bool isNotEquals = a != b;
            Console.WriteLine($"Обе дроби не равны? {isNotEquals}\n");
        }
    }
}