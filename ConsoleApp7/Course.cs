using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal record Course(string Name, string Category, string Teacher)
    {
        private int _price { get; set; }
        private int _studentCount { get; set; }
        public void AddStudents(int newStudents)
        {
            _studentCount += newStudents;
        }
        public int TotalIncome()
        {
            return _price * _studentCount;
        }
    }
}
