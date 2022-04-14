using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.src.Entities
{
    public class Hero
    {
        public Hero()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }


        public override string ToString()
        {
            return Name + " " + Level + " " + HeroType; 
        }

        public virtual string Attack()
        {
            return $"{Name} Atacou com sua espada";
        }

    }
}
