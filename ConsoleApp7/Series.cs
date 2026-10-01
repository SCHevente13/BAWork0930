using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Series(string Title, string Genre, string Studio)
    {
        private int _episodes { get; set; } = 0;
        private double _rating { get; set; }
        public void SetRating(double newRating)
        {
            _rating = newRating;
        }
        public void AddEpisodes(int newEpisodes)
        {
            _episodes += newEpisodes;
        }
        public bool IsLong()
        {
            if (_episodes >= 40)
            {
                return true;
            } 
            return false;
        }
    }
}
