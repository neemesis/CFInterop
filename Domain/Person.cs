using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {
    public class Person {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Years { get; set; }

        public Person(string name, int height, int years) {
            Name = name;
            Height = height;
            Years = years;
        }
    }
}