using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Podaj druga liczbe: ");
        double b = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Podaj operacje (+, -, *, /): ");
        string op = Console.ReadLine().Trim();

        switch (op)
        {
            case "+":
                Console.WriteLine("Wynik: " + (a + b));
                break;
            case "-":
                Console.WriteLine("Wynik: " + (a - b));
                break;
            case "*":
                Console.WriteLine("Wynik: " + (a * b));
                break;
            case "/":
                if (b == 0)
                    Console.WriteLine("Blad: dzielenie przez zero!");
                else
                    Console.WriteLine("Wynik: " + (a / b));
                break;
            default:
                Console.WriteLine("Nieznana operacja.");
                break;
        }
    }
}
