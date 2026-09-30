namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Smartphone> smartphones = new List<Smartphone>() 
            {
            new Smartphone("Samsung", "Galaxy S24", 2024){Rating = 9.1},
            new Smartphone("Apple", "iPhone 15", 2023){Rating = 9.3},
            new Smartphone("Xiaomi", "Redmi Note 13", 2024){Rating = 8.4},
            new Smartphone("Google", "Pixel 8", 2023){Rating = 9.0},
            new Smartphone("Samsung", "Galaxy A55", 2024){Rating = 8.6},
            new Smartphone("OnePlus", "OnePlus 12", 2024){Rating = 8.9},
            new Smartphone("Apple", "iPhone 14", 2022){Rating = 8.8},
            new Smartphone("Xiaomi", "Xiaomi 14", 2024){Rating = 9.2}
            };
            smartphones[0].SetPrice(329000);
            smartphones[1].SetPrice(349000);
            smartphones[2].SetPrice(119000);
            smartphones[3].SetPrice(279000);
            smartphones[4].SetPrice(169000);
            smartphones[5].SetPrice(299000);
            smartphones[6].SetPrice(289000);
            smartphones[7].SetPrice(319000);
        }
    }
}
