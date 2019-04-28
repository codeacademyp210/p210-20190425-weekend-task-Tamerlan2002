﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.classes
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Birthday { get; set; }
        public int CardId { get; set; }

        public string FullName()
        {
            return Name + " " + Surname;
        }
    }
}
