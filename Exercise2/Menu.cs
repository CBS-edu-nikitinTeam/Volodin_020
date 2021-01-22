using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double operand1))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            Console.WriteLine("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double operand2))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }

            Console.WriteLine("Введите операцию: ( + , - , * , / )");
            char symbol = Console.ReadKey().KeyChar;
            Console.Write("\n");

            if (!ArithmeticFunc.AllOperations.TryGetValue(symbol, out Operation operation)) {
                Console.WriteLine("Введенной операци не существует!");
                return;
            }
            try
            {
                Console.WriteLine($"{operand1} {symbol} {operand2} = {operation(operand1, operand2)}");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 не разрешено!");
            }
        }
    }
}
