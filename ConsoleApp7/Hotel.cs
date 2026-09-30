using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Hotel(string Name, string City, int Stars)
    {
        private int _stars { get; init; } = Stars;
        private int _pricePerNight { get; set; }
        public double Rating { get; set; }
        public bool IsAtLeast4Stars()
        {
            return _stars >= 4;
        }
        public void SetPricePerNight(int newPricePerNight)
        {
            _pricePerNight = newPricePerNight;
        }
        public int PriceCalculation(int nights)
        {
            return _pricePerNight * nights;
        }
    }
}
