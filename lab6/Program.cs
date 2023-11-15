using System;

class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            return 0;
        }
        return a / b;
    }

    public double Modulus(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Операція Modulus з нульовим дільником.");
            return 0;
        }
        return a % b;
    }

    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Введіть перше число:");
        double operand1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double operand2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додавання");
        Console.WriteLine("2. Віднімання");
        Console.WriteLine("3. Множення");
        Console.WriteLine("4. Ділення");
        Console.WriteLine("5. Modulus (Остача від ділення)");
        Console.WriteLine("6. Power (Піднесення до ступеня)");

        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = calculator.Add(operand1, operand2);
                break;
            case 2:
                result = calculator.Subtract(operand1, operand2);
                break;
            case 3:
                result = calculator.Multiply(operand1, operand2);
                break;
            case 4:
                result = calculator.Divide(operand1, operand2);
                break;
            case 5:
                result = calculator.Modulus(operand1, operand2);
                break;
            case 6:
                result = calculator.Power(operand1, operand2);
                break;
            default:
                Console.WriteLine("Неправильний вибір операції.");
                break;
        }

        Console.WriteLine($"Результат: {result}");

        Console.ReadKey();
    }
}

