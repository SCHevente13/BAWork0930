using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Restaurant(string Name, string City, string Category)
    {
        private int _averagePrice { get; set; }
        private double _rating { get; set; }
        public double GetRating()
        {
            return _rating;
        }
        public int GetPrice()
        {
            return _averagePrice;
        }
        public void SetPrice(int newPrice)
        {
            _averagePrice = newPrice;
        }
        public void SetRating(double newRating)
        {
            _rating = newRating;
        }
        public void UpdateRating(double newRating)
        {
            if (newRating > 0 && newRating < 10)
            {
                _rating = newRating;
            }
        }
        public bool IsExpensive()
        {
            if (_averagePrice >= 12000)
            {
                return true;
            }
            return false;
        }
    }
}
