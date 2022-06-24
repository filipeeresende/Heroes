using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.src.Entities
{
    public abstract class Hero
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public string Knight { get; set; }
        public int Hp { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Knight;
        }

    }
}
