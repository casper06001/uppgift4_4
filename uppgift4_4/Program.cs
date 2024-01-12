using System;
namespace uppgift4__4
{
    class Program
    {
        static void Main()
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Välj ett av följande alternativ:");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                Console.Write("Ange ditt val (1-3): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            SubtractNumbers();
                            break;
                        case 2:
                            DivideNumbers();
                            break;
                        case 3:
                            programRunning = false;
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Skriv ett giltigt nummer. Försök igen.");
                }
            }
        }

        static void SubtractNumbers()
        {
            double num1, num2;

            if (GetUserInput("Ange det första talet: ", out num1) && GetUserInput("Ange det andra talet: ", out num2))
            {
                double result = num1 - num2;
                Console.WriteLine($"Resultatet av subtraktionen är: {result}");
            }
        }

        static void DivideNumbers()
        {
            double num1, num2;

            if (GetUserInput("Ange det första talet: ", out num1) && GetUserInput("Ange det andra talet: ", out num2))
            {
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    Console.WriteLine($"Resultatet av divisionen är: {result}");
                }
                else
                {
                    Console.WriteLine("Det går inte att dividera med noll. Försök igen.");
                }
            }
        }

        static bool GetUserInput(string prompt, out double result)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Skriv ett giltigt nummer. Försök igen.");
                return false;
            }
        }
    }
}
