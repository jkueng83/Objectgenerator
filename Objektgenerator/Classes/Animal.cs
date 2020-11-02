using System;
using System.Collections.Generic;
using System.Text;

namespace Cage.Classes
{
    class Animal
    {
        public Animal()
        {

        }

        public Animal(string name)
        {
            this.name = name;
        }

        public string animalSpecies { get; set; }
        public string name { get; set; }

    }
}
