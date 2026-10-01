using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Laptop(string Brand, string Model, string Processor)
    {
        private string _processor { get; init; } = Processor;
        private int _price { get; set; }
        public int Memory { get; set; }
        public string GetProcessor()
        {
            return _processor;
        }
        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }
        public void AddMemory(int newMemory)
        {
            Memory += newMemory;
        }
    }
}
