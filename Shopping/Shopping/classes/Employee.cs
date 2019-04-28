using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.classes
{
    class Employee : Person
    {
        public int Id = 0;
        public int IdInc()
        {
            return Id + 1;
        }
        public string Position { get; set; }
        public int Salary { get; set; }


    }
}
