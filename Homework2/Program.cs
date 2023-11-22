using System.Net.Http.Headers;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = CreateAnimal();
            Test(animal);
        }

        public static Animal CreateAnimal()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"{name} - собака (1) или кошка (2)?: ");
            int choice = int.Parse(Console.ReadLine());

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
        public static void Test(Animal animal)
        {
            while (animal.IsAlive)
            {
                Console.Write($"Покормить (1) или наказать (2) {animal.Name}?: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Введите количество еды для кормления или интенсивность наказания: ");
                int count = int.Parse(Console.ReadLine()); 
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