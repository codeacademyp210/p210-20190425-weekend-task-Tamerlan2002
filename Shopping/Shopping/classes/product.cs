using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.classes
{
    class Product
    {
        public int Id = 0;
        public int IdInc()
        {
            return Id + 1;
        }
        public string ProName { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
