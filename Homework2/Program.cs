using System.Net.Http.Headers;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = CreateAnimal();

            if(animal is null)
            {
                Console.WriteLine("Неизвестное животное");
                return;
            }

            Test(animal);
        }

        public static Animal CreateAnimal()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            int age = GetNumberWithRetry("Введите возраст: ");

            int choice = GetNumberWithRetry($"{name} - собака (1) или кошка (2)?: ");

            Animal animal;
            switch (choice)
            {
                case 1:
                    animal = new Dog(name, age);
                    break;

                case 2:
                    animal = new Cat(name, age);
                    break;

                default:
                    animal = null;
                    break;
            }

            return animal;
        }

        private static int GetNumberWithRetry(string message)
        {
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write(message);

                string value = Console.ReadLine();
                if (!int.TryParse(value, out int result))
                {
                    Console.WriteLine("Повторите ввод!");
                }
                else
                {
                    return result;
                }
            }

            return 0;
        }

        public static void Test(Animal animal)
        {
            while (animal.IsAlive)
            {
                int choice = GetNumberWithRetry($"Покормить (1) или наказать (2) {animal.Name}?: ");

                int count = GetNumberWithRetry("Введите количество еды для кормления или интенсивность наказания: ");

                switch (choice)
                {
                    case 1:
                        animal.Feed(count);
                        break;

                    case 2:
                        animal.Punish(count);
                        break; 
                }

                Color color = animal.GetHealthIndicator();
                if (color == Color.Green)
                {
                    Console.WriteLine("Индикатор здоровья: зеленый"); 
                }
                else
                {
                    Console.WriteLine("Индикатор здоровья: белый");
                }
            }
        }
    }
}