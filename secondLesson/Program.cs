using System;

namespace secondLesson
{
    internal class Program
    {
        private static int numberOfproducts = 0;

        static String UniqueName(string ProductName)
        {
            numberOfproducts++;
            Console.WriteLine();
            return "Produkt " + ProductName + " ilość: "+numberOfproducts;
        }

        private static void Main(string[] args)
        {
            var taskName = "Sprawdź czy number jest parzysta?";
            Console.WriteLine(taskName);
            var number = 11;
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");


            taskName = "Wózek widłowy";
            Console.WriteLine(taskName);
            int distance = -1;
            float averageDistance = 0;
            int index = 0;
            while (distance != 0)
            {
                distance = Convert.ToInt32(Console.ReadLine());
                averageDistance += distance;
                index++;
            }

            averageDistance = averageDistance / (index - 1);
            Console.WriteLine(averageDistance);


            taskName = "Produkty";
            Console.WriteLine(taskName);
            string escape = "exit";
            string response = "";

            while (response != escape)
            {
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine(UniqueName("1"));
                        break;
                    case "2":
                        Console.WriteLine(UniqueName("2"));
                        break;
                    case "3":
                        Console.WriteLine(UniqueName("3"));
                        break;
                    case "exit":
                        Console.WriteLine("Kończenie działania programu");
                        break;
                    default:
                        Console.WriteLine("błędna wartość");
                        break;
                }
            }
        }
    }
}