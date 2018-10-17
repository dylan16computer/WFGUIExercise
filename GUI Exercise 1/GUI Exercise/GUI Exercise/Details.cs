using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Exercise
{
    class Details
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }

        public string DisplayName()
        {
            return $"First Name: {FName}\nLast Name: {LName}";
        }
    }
}
