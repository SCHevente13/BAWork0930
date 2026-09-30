using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Smartphone(string Brand, string Model, int ReleaseYear)
    {
        private int _releaseYear { get; init; } = ReleaseYear;
        private int _price { get; set; }
        public double Rating { get; set; }
        public int GetReleaseYear()
        {
            return _releaseYear;
        }
        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }
        public void UpdatePrice(int percent)
        {
            _price = (int)(_price * (100 - percent) / 100);
        }
        public 
    }
}
