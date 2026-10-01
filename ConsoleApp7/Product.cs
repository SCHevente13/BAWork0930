using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Product(string Name, string Category, string Manufacturer)
    {
        private int _price { get; set; }
        private int _stock { get; set; }
        public void AddStock(int newStocks)
        {
            _stock += newStocks;
        }
        public int TotalPrice()
        {
            return _price * _stock;
        }
    }
}
