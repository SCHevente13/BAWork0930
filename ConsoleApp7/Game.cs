using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Game(string Title, string Genre, string Publisher)
    {
        private int _price { get; set; }
        private double _rating { get; set; }
        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }
        public void SetRating(double newRating)
        {
            _rating = newRating;
        }
        public void Sale(int percent)
        {
            _price = (int)(_price * (100 - percent) / 100);
        }
        public bool IsReallyGood()
        {
            if (_rating >= 9.0)
            {
                return true;
            }
            return false;
        }
    }
}
