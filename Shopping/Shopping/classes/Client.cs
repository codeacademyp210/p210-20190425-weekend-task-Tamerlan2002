using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.classes
{
    class Client : Person
    {
        public int Id = 0;
        public int IdInc()
        {
            return Id + 1;
        }
        public string ClientId { get; set; }
        public string Adress { get; set; }
        public long Phone { get; set; }
    }
}
