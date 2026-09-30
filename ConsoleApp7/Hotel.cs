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

    }
}
