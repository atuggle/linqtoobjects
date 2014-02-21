using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    public class Pet : IComparable
    {
        public String Name { get; set; }
        public Boolean Vaccinated { get; set; }

        public int CompareTo(object obj)
        {
            Pet otherPet = obj as Pet;
            if (this.Name.Equals(otherPet.Name) && this.Vaccinated.Equals(otherPet.Vaccinated))
                return 0;

            return -1;
        }
    }
}
