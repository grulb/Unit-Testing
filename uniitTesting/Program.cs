using System;

namespace calculatorProgram
{
    public class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");

            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
        strt:
            Console.Clear();
            Console.WriteLine("Введите первое число");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите действие: \n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление\n5.Возведение в квадрат");
            int choose = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            try
            {
                switch (choose)
                {
                    case 1:
                        result = Calculator.Plus(firstNumber, secondNumber);
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                        break;
                    case 2:
                        result = Calculator.Minus(firstNumber, secondNumber);
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                        break;
                    case 3:
                        result = Calculator.Multiply(firstNumber, secondNumber);
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                        break;
                    case 4:
                        result = Calculator.Divide(firstNumber, secondNumber);
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор");
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Нажмите любую кнопку, чтобы начать заново");
            Console.ReadKey();

            goto strt;
        }
    }
}