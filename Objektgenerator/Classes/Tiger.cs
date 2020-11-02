using System;
using System.Collections.Generic;
using System.Text;

namespace Cage.Classes
{
    class Tiger : Animal
    {

        public Tiger()
        {
            animalSpecies = "tiger";
        }

        public Tiger(string name) : base (name)
        {
            animalSpecies = "tiger";
        }

    }
}
