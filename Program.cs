using System;
using IntegrationTasks;
using IntegrationTasks.RectangleIntegration;

class Program
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Clear();
            Console.WriteLine("Wybierz program do uruchomienia:");
            Console.WriteLine("1. Zadanie 1");
            Console.WriteLine("2. Zadanie 2");
            Console.WriteLine("3. Zadanie 3");
            Console.WriteLine("4. Zadanie 4");
            Console.WriteLine("5. Zadanie 5");
            Console.WriteLine("6. Zadanie 6");
            Console.WriteLine("7. Zadanie 7");
            Console.WriteLine("8. Zadanie 8");
            Console.WriteLine("Q. Wyjście");
            Console.Write("Wybierz numer: ");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "1":
                    RunFibonacciCalculator();
                    break;
                case "2":
                    RunFibonacciRangeCalculator();
                    break;
                case "3":
                    RunRectangleIntegration();
                    break;
                case "4":
                    RunRectangleIntegration2();
                    break;
                case "5":
                    RunRectangleIntegration3();
                    break;
                case "6":
                    RunNumericalIntegration();
                    break;
                case "7":
                    RunSineIntegration();
                    break;
                case "8":
                    RunQuadraticIntegration();
                    break;
                case "Q":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void RunFibonacciCalculator()
    {
        Console.Write("Podaj liczbę elementów ciągu Fibonacciego do wyświetlenia: ");
        int numElements = int.Parse(Console.ReadLine());

        FibonacciCalculator calculator = new FibonacciCalculator();
        calculator.GenerateFibonacci(numElements);

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunFibonacciRangeCalculator()
    {
        Console.Write("Podaj indeks początkowy (L1): ");
        if (!int.TryParse(Console.ReadLine(), out int start) || start < 0)
        {
            Console.WriteLine("Podano nieprawidłowy indeks początkowy.");
            return;
        }

        Console.Write("Podaj ilość elementów do wyświetlenia (L2): ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Podano nieprawidłową ilość elementów.");
            return;
        }

        FibonacciRangeCalculator rangeCalculator = new FibonacciRangeCalculator();
        rangeCalculator.DisplayFibonacciRange(start, count);

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunRectangleIntegration()
    {
        Console.WriteLine("Numeryczne obliczanie wartości całki dla funkcji y = 1/2 * x na przedziale od 0 do 2.");
        Console.Write("Podaj liczbę podziałów przedziału (im więcej, tym dokładniejszy wynik): ");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            RectangleIntegration integration = new RectangleIntegration();
            double result = integration.CalculateIntegral(0, 2, n);
            Console.WriteLine($"Przybliżona wartość całki wynosi: {result}");
        }
        else
        {
            Console.WriteLine("Podano nieprawidłową liczbę podziałów.");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunRectangleIntegration2()
    {
        double exactValue = 1.0;
        double a = 0.0, b = 2.0;

        Console.WriteLine("Numeryczne obliczanie wartości całki dla funkcji y = 1/2 * x na przedziale od 0 do 2.");
        Console.WriteLine("Porównanie wyników dla różnych liczby podziałów:\n");

        int[] divisions = { 1, 10, 50, 100, 500, 1000, 5000, 10000, 50000, 100000 };

        RectangleIntegration2 integration = new RectangleIntegration2();

        foreach (int n in divisions)
        {
            double result = integration.CalculateIntegral(a, b, n);
            double error = Math.Abs(result - exactValue);

            Console.WriteLine($"Liczba podziałów: {n}, Przybliżona wartość: {result}, Błąd: {error}");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunRectangleIntegration3()
    {
        double exactValue = 1.0;
        double a = 0.0, b = 2.0;

        Console.WriteLine("Numeryczne obliczanie wartości całki dla funkcji y = 1/2 * x na przedziale od 0 do 2.");
        Console.WriteLine("Porównanie wyników dla różnych liczby podziałów:\n");

        int[] divisions = { 1, 10, 50, 100, 500, 1000, 5000, 10000, 50000, 100000 };
        RectangleIntegration3 integration = new RectangleIntegration3();

        foreach (int n in divisions)
        {
            double leftResult = integration.CalculateLeftIntegral(a, b, n);
            double rightResult = integration.CalculateRightIntegral(a, b, n);
            double midResult = integration.CalculateMidIntegral(a, b, n);
            double leftError = Math.Abs(leftResult - exactValue);
            double rightError = Math.Abs(rightResult - exactValue);
            double midError = Math.Abs(midResult - exactValue);

            Console.WriteLine($"Liczba podziałów: {n}, " +
                              $"Lewa strona: Przybliżona wartość: {leftResult:F6}, Błąd: {leftError:F6}, " +
                              $"Prawa strona: Przybliżona wartość: {rightResult:F6}, Błąd: {rightError:F6}, " +
                              $"Środkowa: Przybliżona wartość: {midResult:F6}, Błąd: {midError:F6}");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunNumericalIntegration()
    {
        int n = 100;
        double a = 0, b = 2;

        NumericalIntegration numericalIntegration = new NumericalIntegration();

        double integralRectangle = numericalIntegration.CalculateRectangle(a, b, n);
        double integralTrapezoid = numericalIntegration.CalculateTrapezoid(a, b, n);

        Console.WriteLine($"Wartość całki metodą prostokątów: {integralRectangle}");
        Console.WriteLine($"Wartość całki metodą trapezów: {integralTrapezoid}");

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunSineIntegration()
    {
        int n = 1000; 
        double a = 0, b = 2 * Math.PI; 

        SineIntegration sineIntegration = new SineIntegration();

        double integralTrapezoid = sineIntegration.CalculateTrapezoid(a, b, n);
        Console.WriteLine($"Wartość całki funkcji sin(x) na przedziale [0, 2π] wynosi: {integralTrapezoid}");

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }

    static void RunQuadraticIntegration()
    {
        Console.Write("Podaj wartość współczynnika a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość współczynnika b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość współczynnika c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj początek przedziału całkowania: ");
        double xStart = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj koniec przedziału całkowania: ");
        double xEnd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj liczbę podziałów (im większa liczba, tym większa dokładność): ");
        int n = Convert.ToInt32(Console.ReadLine());

        QuadraticIntegration quadraticIntegration = new QuadraticIntegration();

        double integralTrapezoid = quadraticIntegration.CalculateTrapezoid(a, b, c, xStart, xEnd, n);
        Console.WriteLine($"Wartość całki dla funkcji {a}x^2 + {b}x + {c} na przedziale [{xStart}, {xEnd}] wynosi: {integralTrapezoid}");

        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
    }
}