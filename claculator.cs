using System;

namespace Orozzzz
{
    class Claculator
    {
        public static void Main()
        {
            double num1, num2;
            string operating;
            bool inputValid;

            // Ввод первого числа с проверкой
            do
            {
                Console.Write("Enter first number: ");
                inputValid = double.TryParse(Console.ReadLine(), out num1);
                if (!inputValid)
                {
                    Console.WriteLine("Error! Please enter a correct number.");
                }
            } while (!inputValid);

            // Ввод второго числа с проверкой
            do
            {
                Console.Write("Enter second number: ");
                inputValid = double.TryParse(Console.ReadLine(), out num2);
                if (!inputValid)
                {
                    Console.WriteLine("Error! Please enter a correct number.");
                }
            } while (!inputValid);

            // Ввод операции с проверкой
            do
            {
                Console.Write("Enter operation (+, -, *, /): ");
                operating = Console.ReadLine();
                inputValid = operating == "+" || operating == "-" || operating == "*" || operating == "/";
                if (!inputValid)
                {
                    Console.WriteLine("Error! Please enter a correct operation (+, -, *, /).");
                }
            } while (!inputValid);

            // Выполнение операции
            double res = 0;
            switch (operating)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                        return;
                    }
                    res = num1 / num2;
                    break;
            }

            Console.WriteLine($"Result: {res}");
        }
    }
}