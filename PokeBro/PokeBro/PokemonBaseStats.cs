using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBro
{
    class PokemonBaseStats
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int stamina { get; set; }
        public string evolution { get; set; }

        public PokemonBaseStats(string name, int attack, int defense, int stamina)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
        }
    }
}
