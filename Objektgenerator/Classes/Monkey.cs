using System;
using System.Collections.Generic;
using System.Text;

namespace Cage.Classes
{
    class Monkey : Animal
    {
        public Monkey()
        {
            animalSpecies = "monkey";
        }

        public Monkey( string name) : base (name)
        {
            animalSpecies = "monkey";
        }
    }

}
