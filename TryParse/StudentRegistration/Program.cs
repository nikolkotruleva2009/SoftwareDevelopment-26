namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Възраст: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
              //  Console.WriteLine($"Възраст: {age}");
            }
            else
            {
                Console.WriteLine("Невалидна възраст.");
            }


            Console.WriteLine("Клас на ученика: ");
            if (byte.TryParse(Console.ReadLine(),out byte grade))
            {
                // Console.WriteLine($"Клас: {grade}");
            }
            else
            {
               Console.WriteLine("Невалидна възраст.");
            }


            Console.Write("Среден успех: ");
            if (double.TryParse(Console.ReadLine(), out double average))
            {
               // Console.WriteLine($"Среден успех: ");
            }
            else
            {
                Console.WriteLine($"Невалиден среден успех");
            }


            Console.WriteLine("Такса:");
            if (decimal.TryParse(Console.ReadLine(),out decimal fee))
            {
                Console.WriteLine($"Такса: ");
            }
            else
            {
                Console.WriteLine($"Невалидна такса: ");
            }

            Console.WriteLine("Има ли право на стипендия?");
            if (bool.TryParse(Console.ReadLine(), out bool hasScholarship))
                {
                    Console.WriteLine(hasScholarship);
                }
            else
            {
                Console.WriteLine("Невалидна стойност.");
            }




        }
    }
}
