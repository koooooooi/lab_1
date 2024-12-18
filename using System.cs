using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привіт! Це простий калькулятор.");
        
        // Введення першого числа
        Console.Write("Введи перше число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        // Введення оператора
        Console.Write("Введи операцію (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        // Введення другого числа
        Console.Write("Введи друге число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        // Результат операції
        double result;
        switch (operation)
        {
            case '+':
                result = number1 + number2;
                Console.WriteLine($"Результат: {number1} + {number2} = {result}");
                break;
            case '-':
                result = number1 - number2;
                Console.WriteLine($"Результат: {number1} - {number2} = {result}");
                break;
            case '*':
                result = number1 * number2;
                Console.WriteLine($"Результат: {number1} * {number2} = {result}");
                break;
            case '/':
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine($"Результат: {number1} / {number2} = {result}");
                }
                else
                {
                    Console.WriteLine("Помилка: ділення на нуль неможливе.");
                }
                break;
            default:
                Console.WriteLine("Помилка: невідома операція.");
                break;
        }

        Console.WriteLine("Дякую, що скористався калькулятором!");
    }
}
