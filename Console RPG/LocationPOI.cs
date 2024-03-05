using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
     abstract class LocationPOI
    {
        public bool isresolved;

        public LocationPOI(bool isresolved)
        {
            this.isresolved = isresolved;
        }

        public abstract void Resolve(List<Player> players);


    }
}
