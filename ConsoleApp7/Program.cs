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
            Console.WriteLine("Phones that released in 2024:");
            foreach (string model in smartphones.Where(x => x.GetReleaseYear() == 2024).Select(x => x.Model).ToList())
            {
                Console.WriteLine($" - {model}");
            }
            Console.WriteLine($"Best rated phone: {smartphones.OrderByDescending(x => x.Rating).Select(x => x.Model).First()}");
            int CountBrand(string brand)
            {
                return smartphones.Where(x => x.Brand == brand).Count();
            }
            Console.WriteLine($"Samsung has: {CountBrand("Samsung")} phones.");
            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel("Grand Palace", "Budapest", 5){ Rating =  9.4 },
                new Hotel("City Hotel", "Budapest", 3) { Rating = 8.2 },
                new Hotel("Blue Sea Resort", "Split", 4) { Rating = 9.1},
                new Hotel("Royal Beach", "Barcelona", 5) { Rating = 9.3},
                new Hotel("Mountain View", "Salzburg", 4) { Rating = 8.8 },
                new Hotel("Central Stay", "Prague", 3) { Rating = 8.5 },
                new Hotel("Luxury Garden", "Vienna", 5){ Rating = 9.2 },
                new Hotel("Sunset Hotel", "Split", 4){ Rating = 8.9 }
            };
            hotels[0].SetPricePerNight(68000);
            hotels[1].SetPricePerNight(32000);
            hotels[2].SetPricePerNight(54000);
            hotels[3].SetPricePerNight(82000);
            hotels[4].SetPricePerNight(46000);
            hotels[5].SetPricePerNight(28000);
            hotels[6].SetPricePerNight(75000);
            hotels[7].SetPricePerNight(49000);
            Console.WriteLine($"Cheapest hotel: {hotels.OrderBy(x => x.PriceCalculation(1)).Select(x => x.Name).First()}");
            Console.WriteLine("Hotels in Budapest:");
            hotels.Where(x => x.City == "Budapest").Select(x => x.Name).ToList().ForEach(x => Console.WriteLine($" - {x}"));
            List<string> lis = hotels.OrderByDescending(x => x.IsAtLeast4Stars()).Select(x => x.Name).ToList();
            Console.WriteLine("Top 3 best rated hotels:");
            Console.WriteLine($" - {lis[0]}");
            Console.WriteLine($" - {lis[1]}");
            Console.WriteLine($" - {lis[2]}");
            List<Laptop> laptops = new List<Laptop>()
            {
                new Laptop("Lenovo", "ThinkPad E14", "Intel i5"){ Memory = 16 },
                new Laptop("Apple", "MacBook Air M3", "Apple M3"){ Memory = 16 },
                new Laptop("Asus", "ROG Strix G16", "Intel i7"){ Memory = 32 },
                new Laptop("Acer", "Aspire 5", "AMD Ryzen 5"){ Memory = 16 },
                new Laptop("HP", "ProBook 450", "Intel i5"){ Memory = 16 },
                new Laptop("Dell", "Inspiron 15", "Intel i7"){ Memory = 32 },
                new Laptop("Lenovo", "IdeaPad Slim 3", "AMD Ryzen 5"){ Memory = 8 },
                new Laptop("Asus", "VivoBook 15", "Intel i5"){ Memory = 8 },
                new Laptop("Apple", "MacBook Pro M3", "Apple M3 Pro"){ Memory = 36 },
                new Laptop("Acer", "Nitro 5", "Intel i7"){ Memory = 32 }
            };
            laptops[0].SetPrice(319000);
            laptops[1].SetPrice(489000);
            laptops[2].SetPrice(649000);
            laptops[3].SetPrice(279000);
            laptops[4].SetPrice(349000);
            laptops[5].SetPrice(399000);
            laptops[6].SetPrice(249000);
            laptops[7].SetPrice(289000);
            laptops[8].SetPrice(799000);
            laptops[9].SetPrice(519000);
            double ave = laptops.Select(x => x.GetPrice()).Average();
            Console.WriteLine($"Average price of all Laptops {ave}");
            Console.WriteLine("Laptops cheaper than average:");
            laptops.Where(x => x.GetPrice() < ave).Select(x => x.Model).ToList().ForEach(x=> Console.WriteLine($" - {x}"));
            Console.WriteLine("Laptops that have at least 16 GB of memory and they are not more than 350000 Ft:");
            laptops.Where(x => x.GetPrice() < 350000 && x.Memory > 16).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine($" - {x}"));
            Console.WriteLine($"Brand with the highest memory laptop: {laptops.OrderByDescending(x => x.Memory).Select(x => x.Brand).First()}");
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant("Bella Italia", "Budapest", "Italian"),
                new Restaurant("Burger House", "Budapest", "Burger"),
                new Restaurant("Sakura", "Budapest", "Japanese"),
                new Restaurant("Pasta Roma", "Rome", "Italian"),
                new Restaurant("Tokyo Garden", "Vienna", "Japanese"),
                new Restaurant("Steak Corner", "Budapest", "Steak"),
                new Restaurant("Pizza Napoli", "Rome", "Italian"),
                new Restaurant("Grill House", "Vienna", "Steak"),
                new Restaurant("Sushi World", "Prague", "Japanese"),
                new Restaurant("Street Burger", "Prague", "Burger")
            };
            restaurants[0].SetPrice(8500);
            restaurants[0].SetRating(9.1);
            restaurants[1].SetPrice(5500);
            restaurants[1].SetRating(8.4);
            restaurants[2].SetPrice(12000);
            restaurants[2].SetRating(9.4);
            restaurants[3].SetPrice(9500);
            restaurants[3].SetRating(8.9);
            restaurants[4].SetPrice(13500);
            restaurants[4].SetRating(9.2);
            restaurants[5].SetPrice(15000);
            restaurants[5].SetRating(9.0);
            restaurants[6].SetPrice(7000);
            restaurants[6].SetRating(8.7);
            restaurants[7].SetPrice(14000);
            restaurants[7].SetRating(8.8);
            restaurants[8].SetPrice(11000);
            restaurants[8].SetRating(9.3);
            restaurants[9].SetPrice(5000);
            restaurants[9].SetRating(8.2);
            Console.WriteLine("Italian restaurants:");
            restaurants.Where(x => x.Category == "Italian").Select(x => x.Name).ToList().ForEach(x => Console.WriteLine($" - {x}"));
            Console.WriteLine($"Number of 9.0+ restaurants: {restaurants.Where(x => x.GetRating() >= 9.0).Count()}");
            Console.WriteLine($"Most expensive restaurant: {restaurants.OrderByDescending(x => x.GetPrice()).Select(x => x.Name).First()}");
            Console.WriteLine("Cities with the restaurants:");
            restaurants.GroupBy(x => x.City).Select(x=> x.Key).ToList().ForEach(x => Console.WriteLine($" - {x}"));
            List<Series> series = new List<Series>()
            {
                new Series("Breaking Bad", "Drama", "AMC"),
                new Series("Stranger Things", "SciFi", "Netflix"),
                new Series("The Boys", "Action", "Amazon"),
                new Series("Dark", "SciFi", "Netflix"),
                new Series("The Crown", "Drama", "Netflix"),
                new Series("Reacher", "Action", "Amazon"),
                new Series("Wednesday", "Fantasy", "Netflix"),
                new Series("House of the Dragon", "Fantasy", "HBO"),
                new Series("The Last of Us", "Drama", "HBO"),
                new Series("Fallout", "SciFi", "Amazon"),
                new Series("Better Call Saul", "Drama", "AMC"),
                new Series("Loki", "Fantasy", "Disney")
            };
            series[0].AddEpisodes(62);
            series[0].SetRating(9.5);
            series[1].AddEpisodes(34);
            series[1].SetRating(8.7);
            series[2].AddEpisodes(32);
            series[2].SetRating(8.7);
            series[3].AddEpisodes(26);
            series[3].SetRating(8.8);
            series[4].AddEpisodes(60);
            series[4].SetRating(8.6);
            series[5].AddEpisodes(24);
            series[5].SetRating(8.5);
            series[6].AddEpisodes(16);
            series[6].SetRating(8.1);
            series[7].AddEpisodes(18);
            series[7].SetRating(8.4);
            series[8].AddEpisodes(18);
            series[8].SetRating(8.8);
            series[9].AddEpisodes(16);
            series[9].SetRating(8.6);
            series[10].AddEpisodes(63);
            series[10].SetRating(9.0);
            series[11].AddEpisodes(12);
            series[11].SetRating(8.2);


        }
    }
}
// .ToList().ForEach(x=> Console.WriteLine($" - {x}"))
