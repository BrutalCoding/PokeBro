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
        public List<Pokemon> pokes { get; set; }
        public List<TypeModel> pokeTypes { get; set; }

        public PokemonBaseStats()
        {

        }

        public PokemonBaseStats(string name, int attack, int defense, int stamina) : this()
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
        }

        public void LoadPokes()
        {
            pokes = new List<Pokemon>();

            pokes.Add(new Pokemon
            {
                PokeIndex = 1,
                Name = PokemonName.Bulbasaur,
                BaseStamina = 90,
                BaseAttack = 126,
                BaseDefend = 126,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 2,
                Name = PokemonName.Ivysaur,
                BaseStamina = 120,
                BaseAttack = 156,
                BaseDefend = 158,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 3,
                Name = PokemonName.Venusaur,
                BaseStamina = 160,
                BaseAttack = 198,
                BaseDefend = 200,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 4,
                Name = PokemonName.Charmander,
                BaseStamina = 78,
                BaseAttack = 128,
                BaseDefend = 108,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 5,
                Name = PokemonName.Charmeleon,
                BaseStamina = 116,
                BaseAttack = 160,
                BaseDefend = 140,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 6,
                Name = PokemonName.Charizard,
                BaseStamina = 156,
                BaseAttack = 212,
                BaseDefend = 182,
                Type1 = "Fire",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 7,
                Name = PokemonName.Squirtle,
                BaseStamina = 88,
                BaseAttack = 112,
                BaseDefend = 142,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 8,
                Name = PokemonName.Wartortle,
                BaseStamina = 118,
                BaseAttack = 144,
                BaseDefend = 176,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 9,
                Name = PokemonName.Blastoise,
                BaseStamina = 158,
                BaseAttack = 186,
                BaseDefend = 222,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 10,
                Name = PokemonName.Caterpie,
                BaseStamina = 90,
                BaseAttack = 62,
                BaseDefend = 66,
                Type1 = "Bug",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 11,
                Name = PokemonName.Metapod,
                BaseStamina = 100,
                BaseAttack = 56,
                BaseDefend = 86,
                Type1 = "Bug",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 12,
                Name = PokemonName.Butterfree,
                BaseStamina = 120,
                BaseAttack = 144,
                BaseDefend = 144,
                Type1 = "Bug",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 13,
                Name = PokemonName.Weedle,
                BaseStamina = 80,
                BaseAttack = 68,
                BaseDefend = 64,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 14,
                Name = PokemonName.Kakuna,
                BaseStamina = 90,
                BaseAttack = 62,
                BaseDefend = 82,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 15,
                Name = PokemonName.Beedrill,
                BaseStamina = 130,
                BaseAttack = 144,
                BaseDefend = 130,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 16,
                Name = PokemonName.Pidgey,
                BaseStamina = 80,
                BaseAttack = 94,
                BaseDefend = 90,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 17,
                Name = PokemonName.Pidgeotto,
                BaseStamina = 126,
                BaseAttack = 126,
                BaseDefend = 122,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 18,
                Name = PokemonName.Pidgeot,
                BaseStamina = 166,
                BaseAttack = 170,
                BaseDefend = 166,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 19,
                Name = PokemonName.Rattata,
                BaseStamina = 60,
                BaseAttack = 92,
                BaseDefend = 86,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 20,
                Name = PokemonName.Raticate,
                BaseStamina = 110,
                BaseAttack = 146,
                BaseDefend = 150,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 21,
                Name = PokemonName.Spearow,
                BaseStamina = 80,
                BaseAttack = 102,
                BaseDefend = 78,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 22,
                Name = PokemonName.Fearow,
                BaseStamina = 130,
                BaseAttack = 168,
                BaseDefend = 146,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 23,
                Name = PokemonName.Ekans,
                BaseStamina = 70,
                BaseAttack = 112,
                BaseDefend = 112,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 24,
                Name = PokemonName.Arbok,
                BaseStamina = 120,
                BaseAttack = 166,
                BaseDefend = 166,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 25,
                Name = PokemonName.Pikachu,
                BaseStamina = 70,
                BaseAttack = 124,
                BaseDefend = 108,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 26,
                Name = PokemonName.Raichu,
                BaseStamina = 120,
                BaseAttack = 200,
                BaseDefend = 154,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 27,
                Name = PokemonName.Sandshrew,
                BaseStamina = 100,
                BaseAttack = 90,
                BaseDefend = 114,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 28,
                Name = PokemonName.Sandslash,
                BaseStamina = 150,
                BaseAttack = 150,
                BaseDefend = 172,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 29,
                Name = PokemonName.NidoranF,
                BaseStamina = 110,
                BaseAttack = 100,
                BaseDefend = 104,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 30,
                Name = PokemonName.Nidorina,
                BaseStamina = 140,
                BaseAttack = 132,
                BaseDefend = 136,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 31,
                Name = PokemonName.Nidoqueen,
                BaseStamina = 180,
                BaseAttack = 184,
                BaseDefend = 190,
                Type1 = "Poison",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 32,
                Name = PokemonName.NidoranM,
                BaseStamina = 92,
                BaseAttack = 110,
                BaseDefend = 94,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 33,
                Name = PokemonName.Nidorino,
                BaseStamina = 122,
                BaseAttack = 142,
                BaseDefend = 128,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 34,
                Name = PokemonName.Nidoking,
                BaseStamina = 162,
                BaseAttack = 204,
                BaseDefend = 170,
                Type1 = "Poison",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 35,
                Name = PokemonName.Clefairy,
                BaseStamina = 140,
                BaseAttack = 116,
                BaseDefend = 124,
                Type1 = "Fairy",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 36,
                Name = PokemonName.Clefable,
                BaseStamina = 190,
                BaseAttack = 178,
                BaseDefend = 178,
                Type1 = "Fairy",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 37,
                Name = PokemonName.Vulpix,
                BaseStamina = 76,
                BaseAttack = 106,
                BaseDefend = 118,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 38,
                Name = PokemonName.Ninetales,
                BaseStamina = 146,
                BaseAttack = 176,
                BaseDefend = 194,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 39,
                Name = PokemonName.Jigglypuff,
                BaseStamina = 230,
                BaseAttack = 98,
                BaseDefend = 54,
                Type1 = "Normal",
                Type2 = "Fairy"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 40,
                Name = PokemonName.Wigglytuff,
                BaseStamina = 280,
                BaseAttack = 168,
                BaseDefend = 108,
                Type1 = "Normal",
                Type2 = "Fairy"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 41,
                Name = PokemonName.Zubat,
                BaseStamina = 80,
                BaseAttack = 88,
                BaseDefend = 90,
                Type1 = "Poison",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 42,
                Name = PokemonName.Golbat,
                BaseStamina = 150,
                BaseAttack = 164,
                BaseDefend = 164,
                Type1 = "Poison",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 43,
                Name = PokemonName.Oddish,
                BaseStamina = 90,
                BaseAttack = 134,
                BaseDefend = 130,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 44,
                Name = PokemonName.Gloom,
                BaseStamina = 120,
                BaseAttack = 162,
                BaseDefend = 158,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 45,
                Name = PokemonName.Vileplume,
                BaseStamina = 150,
                BaseAttack = 202,
                BaseDefend = 190,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 46,
                Name = PokemonName.Paras,
                BaseStamina = 70,
                BaseAttack = 122,
                BaseDefend = 120,
                Type1 = "Bug",
                Type2 = "Grass"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 47,
                Name = PokemonName.Parasect,
                BaseStamina = 120,
                BaseAttack = 162,
                BaseDefend = 170,
                Type1 = "Bug",
                Type2 = "Grass"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 48,
                Name = PokemonName.Venonat,
                BaseStamina = 120,
                BaseAttack = 108,
                BaseDefend = 118,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 49,
                Name = PokemonName.Venomoth,
                BaseStamina = 140,
                BaseAttack = 172,
                BaseDefend = 154,
                Type1 = "Bug",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 50,
                Name = PokemonName.Diglett,
                BaseStamina = 20,
                BaseAttack = 108,
                BaseDefend = 86,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 51,
                Name = PokemonName.Dugtrio,
                BaseStamina = 70,
                BaseAttack = 148,
                BaseDefend = 140,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 52,
                Name = PokemonName.Meowth,
                BaseStamina = 80,
                BaseAttack = 104,
                BaseDefend = 94,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 53,
                Name = PokemonName.Persian,
                BaseStamina = 130,
                BaseAttack = 156,
                BaseDefend = 146,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 54,
                Name = PokemonName.Psyduck,
                BaseStamina = 100,
                BaseAttack = 132,
                BaseDefend = 112,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 55,
                Name = PokemonName.Golduck,
                BaseStamina = 160,
                BaseAttack = 194,
                BaseDefend = 176,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 56,
                Name = PokemonName.Mankey,
                BaseStamina = 80,
                BaseAttack = 122,
                BaseDefend = 96,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 57,
                Name = PokemonName.Primeape,
                BaseStamina = 130,
                BaseAttack = 178,
                BaseDefend = 150,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 58,
                Name = PokemonName.Growlithe,
                BaseStamina = 110,
                BaseAttack = 156,
                BaseDefend = 110,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 59,
                Name = PokemonName.Arcanine,
                BaseStamina = 180,
                BaseAttack = 230,
                BaseDefend = 180,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 60,
                Name = PokemonName.Poliwag,
                BaseStamina = 80,
                BaseAttack = 108,
                BaseDefend = 98,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 61,
                Name = PokemonName.Poliwhirl,
                BaseStamina = 130,
                BaseAttack = 132,
                BaseDefend = 132,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 62,
                Name = PokemonName.Poliwrath,
                BaseStamina = 180,
                BaseAttack = 180,
                BaseDefend = 202,
                Type1 = "Water",
                Type2 = "Fighting"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 63,
                Name = PokemonName.Abra,
                BaseStamina = 50,
                BaseAttack = 110,
                BaseDefend = 76,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 64,
                Name = PokemonName.Kadabra,
                BaseStamina = 80,
                BaseAttack = 150,
                BaseDefend = 112,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 65,
                Name = PokemonName.Alakazam,
                BaseStamina = 110,
                BaseAttack = 186,
                BaseDefend = 152,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 66,
                Name = PokemonName.Machop,
                BaseStamina = 140,
                BaseAttack = 118,
                BaseDefend = 96,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 67,
                Name = PokemonName.Machoke,
                BaseStamina = 160,
                BaseAttack = 154,
                BaseDefend = 144,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 68,
                Name = PokemonName.Machamp,
                BaseStamina = 180,
                BaseAttack = 198,
                BaseDefend = 180,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 69,
                Name = PokemonName.Bellsprout,
                BaseStamina = 100,
                BaseAttack = 158,
                BaseDefend = 78,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 70,
                Name = PokemonName.Weepinbell,
                BaseStamina = 130,
                BaseAttack = 190,
                BaseDefend = 110,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 71,
                Name = PokemonName.Victreebel,
                BaseStamina = 160,
                BaseAttack = 222,
                BaseDefend = 152,
                Type1 = "Grass",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 72,
                Name = PokemonName.Tentacool,
                BaseStamina = 80,
                BaseAttack = 106,
                BaseDefend = 136,
                Type1 = "Water",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 73,
                Name = PokemonName.Tentacruel,
                BaseStamina = 160,
                BaseAttack = 170,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 74,
                Name = PokemonName.Geodude,
                BaseStamina = 80,
                BaseAttack = 106,
                BaseDefend = 118,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 75,
                Name = PokemonName.Graveler,
                BaseStamina = 110,
                BaseAttack = 142,
                BaseDefend = 156,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 76,
                Name = PokemonName.Golem,
                BaseStamina = 160,
                BaseAttack = 176,
                BaseDefend = 198,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 77,
                Name = PokemonName.Ponyta,
                BaseStamina = 100,
                BaseAttack = 168,
                BaseDefend = 138,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 78,
                Name = PokemonName.Rapidash,
                BaseStamina = 130,
                BaseAttack = 200,
                BaseDefend = 170,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 79,
                Name = PokemonName.Slowpoke,
                BaseStamina = 180,
                BaseAttack = 110,
                BaseDefend = 110,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 80,
                Name = PokemonName.Slowbro,
                BaseStamina = 190,
                BaseAttack = 184,
                BaseDefend = 198,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 81,
                Name = PokemonName.Magnemite,
                BaseStamina = 50,
                BaseAttack = 128,
                BaseDefend = 138,
                Type1 = "Electric",
                Type2 = "Steel"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 82,
                Name = PokemonName.Magneton,
                BaseStamina = 100,
                BaseAttack = 186,
                BaseDefend = 180,
                Type1 = "Electric",
                Type2 = "Steel"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 83,
                Name = PokemonName.Farfetchd,
                BaseStamina = 104,
                BaseAttack = 138,
                BaseDefend = 132,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 84,
                Name = PokemonName.Doduo,
                BaseStamina = 70,
                BaseAttack = 126,
                BaseDefend = 96,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 85,
                Name = PokemonName.Dodrio,
                BaseStamina = 120,
                BaseAttack = 182,
                BaseDefend = 150,
                Type1 = "Normal",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 86,
                Name = PokemonName.Seel,
                BaseStamina = 130,
                BaseAttack = 104,
                BaseDefend = 138,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 87,
                Name = PokemonName.Dewgong,
                BaseStamina = 180,
                BaseAttack = 156,
                BaseDefend = 192,
                Type1 = "Water",
                Type2 = "Ice"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 88,
                Name = PokemonName.Grimer,
                BaseStamina = 160,
                BaseAttack = 124,
                BaseDefend = 110,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 89,
                Name = PokemonName.Muk,
                BaseStamina = 210,
                BaseAttack = 180,
                BaseDefend = 188,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 90,
                Name = PokemonName.Shellder,
                BaseStamina = 60,
                BaseAttack = 120,
                BaseDefend = 112,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 91,
                Name = PokemonName.Cloyster,
                BaseStamina = 100,
                BaseAttack = 196,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Ice"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 92,
                Name = PokemonName.Gastly,
                BaseStamina = 60,
                BaseAttack = 136,
                BaseDefend = 82,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 93,
                Name = PokemonName.Haunter,
                BaseStamina = 90,
                BaseAttack = 172,
                BaseDefend = 118,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 94,
                Name = PokemonName.Gengar,
                BaseStamina = 120,
                BaseAttack = 204,
                BaseDefend = 156,
                Type1 = "Ghost",
                Type2 = "Poison"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 95,
                Name = PokemonName.Onix,
                BaseStamina = 70,
                BaseAttack = 90,
                BaseDefend = 186,
                Type1 = "Rock",
                Type2 = "Ground"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 96,
                Name = PokemonName.Drowzee,
                BaseStamina = 120,
                BaseAttack = 104,
                BaseDefend = 140,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 97,
                Name = PokemonName.Hypno,
                BaseStamina = 170,
                BaseAttack = 162,
                BaseDefend = 196,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 98,
                Name = PokemonName.Krabby,
                BaseStamina = 60,
                BaseAttack = 116,
                BaseDefend = 110,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 99,
                Name = PokemonName.Kingler,
                BaseStamina = 110,
                BaseAttack = 178,
                BaseDefend = 168,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 100,
                Name = PokemonName.Voltorb,
                BaseStamina = 80,
                BaseAttack = 102,
                BaseDefend = 124,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 101,
                Name = PokemonName.Electrode,
                BaseStamina = 120,
                BaseAttack = 150,
                BaseDefend = 174,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 102,
                Name = PokemonName.Exeggcute,
                BaseStamina = 120,
                BaseAttack = 110,
                BaseDefend = 132,
                Type1 = "Grass",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 103,
                Name = PokemonName.Exeggutor,
                BaseStamina = 190,
                BaseAttack = 232,
                BaseDefend = 164,
                Type1 = "Grass",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 104,
                Name = PokemonName.Cubone,
                BaseStamina = 100,
                BaseAttack = 102,
                BaseDefend = 150,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 105,
                Name = PokemonName.Marowak,
                BaseStamina = 120,
                BaseAttack = 140,
                BaseDefend = 202,
                Type1 = "Ground",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 106,
                Name = PokemonName.Hitmonlee,
                BaseStamina = 100,
                BaseAttack = 148,
                BaseDefend = 172,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 107,
                Name = PokemonName.Hitmonchan,
                BaseStamina = 100,
                BaseAttack = 138,
                BaseDefend = 204,
                Type1 = "Fighting",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 108,
                Name = PokemonName.Lickitung,
                BaseStamina = 180,
                BaseAttack = 126,
                BaseDefend = 160,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 109,
                Name = PokemonName.Koffing,
                BaseStamina = 80,
                BaseAttack = 136,
                BaseDefend = 142,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 110,
                Name = PokemonName.Weezing,
                BaseStamina = 130,
                BaseAttack = 190,
                BaseDefend = 198,
                Type1 = "Poison",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 111,
                Name = PokemonName.Rhyhorn,
                BaseStamina = 160,
                BaseAttack = 110,
                BaseDefend = 116,
                Type1 = "Ground",
                Type2 = "Rock"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 112,
                Name = PokemonName.Rhydon,
                BaseStamina = 210,
                BaseAttack = 166,
                BaseDefend = 160,
                Type1 = "Ground",
                Type2 = "Rock"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 113,
                Name = PokemonName.Chansey,
                BaseStamina = 500,
                BaseAttack = 40,
                BaseDefend = 60,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 114,
                Name = PokemonName.Tangela,
                BaseStamina = 130,
                BaseAttack = 164,
                BaseDefend = 152,
                Type1 = "Grass",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 115,
                Name = PokemonName.Kangaskhan,
                BaseStamina = 210,
                BaseAttack = 142,
                BaseDefend = 178,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 116,
                Name = PokemonName.Horsea,
                BaseStamina = 60,
                BaseAttack = 122,
                BaseDefend = 100,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 117,
                Name = PokemonName.Seadra,
                BaseStamina = 110,
                BaseAttack = 176,
                BaseDefend = 150,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 118,
                Name = PokemonName.Goldeen,
                BaseStamina = 90,
                BaseAttack = 112,
                BaseDefend = 126,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 119,
                Name = PokemonName.Seaking,
                BaseStamina = 160,
                BaseAttack = 172,
                BaseDefend = 160,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 120,
                Name = PokemonName.Staryu,
                BaseStamina = 60,
                BaseAttack = 130,
                BaseDefend = 128,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 121,
                Name = PokemonName.Starmie,
                BaseStamina = 120,
                BaseAttack = 194,
                BaseDefend = 192,
                Type1 = "Water",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 122,
                Name = PokemonName.MrMime,
                BaseStamina = 80,
                BaseAttack = 154,
                BaseDefend = 196,
                Type1 = "Psychic",
                Type2 = "Fairy"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 123,
                Name = PokemonName.Scyther,
                BaseStamina = 140,
                BaseAttack = 176,
                BaseDefend = 180,
                Type1 = "Bug",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 124,
                Name = PokemonName.Jynx,
                BaseStamina = 130,
                BaseAttack = 172,
                BaseDefend = 134,
                Type1 = "Ice",
                Type2 = "Psychic"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 125,
                Name = PokemonName.Electabuzz,
                BaseStamina = 130,
                BaseAttack = 198,
                BaseDefend = 160,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 126,
                Name = PokemonName.Magmar,
                BaseStamina = 130,
                BaseAttack = 214,
                BaseDefend = 158,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 127,
                Name = PokemonName.Pinsir,
                BaseStamina = 130,
                BaseAttack = 184,
                BaseDefend = 186,
                Type1 = "Bug",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 128,
                Name = PokemonName.Tauros,
                BaseStamina = 150,
                BaseAttack = 148,
                BaseDefend = 184,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 129,
                Name = PokemonName.Magikarp,
                BaseStamina = 40,
                BaseAttack = 42,
                BaseDefend = 84,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 130,
                Name = PokemonName.Gyarados,
                BaseStamina = 190,
                BaseAttack = 192,
                BaseDefend = 196,
                Type1 = "Water",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 131,
                Name = PokemonName.Lapras,
                BaseStamina = 260,
                BaseAttack = 186,
                BaseDefend = 190,
                Type1 = "Water",
                Type2 = "Ice"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 132,
                Name = PokemonName.Ditto,
                BaseStamina = 96,
                BaseAttack = 110,
                BaseDefend = 110,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 133,
                Name = PokemonName.Eevee,
                BaseStamina = 110,
                BaseAttack = 114,
                BaseDefend = 128,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 134,
                Name = PokemonName.Vaporeon,
                BaseStamina = 260,
                BaseAttack = 186,
                BaseDefend = 168,
                Type1 = "Water",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 135,
                Name = PokemonName.Jolteon,
                BaseStamina = 130,
                BaseAttack = 192,
                BaseDefend = 174,
                Type1 = "Electric",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 136,
                Name = PokemonName.Flareon,
                BaseStamina = 130,
                BaseAttack = 238,
                BaseDefend = 178,
                Type1 = "Fire",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 137,
                Name = PokemonName.Porygon,
                BaseStamina = 130,
                BaseAttack = 156,
                BaseDefend = 158,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 138,
                Name = PokemonName.Omanyte,
                BaseStamina = 70,
                BaseAttack = 132,
                BaseDefend = 160,
                Type1 = "Rock",
                Type2 = "Water"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 139,
                Name = PokemonName.Omastar,
                BaseStamina = 140,
                BaseAttack = 180,
                BaseDefend = 202,
                Type1 = "Rock",
                Type2 = "Water"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 140,
                Name = PokemonName.Kabuto,
                BaseStamina = 60,
                BaseAttack = 148,
                BaseDefend = 142,
                Type1 = "Rock",
                Type2 = "Water"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 141,
                Name = PokemonName.Kabutops,
                BaseStamina = 120,
                BaseAttack = 190,
                BaseDefend = 190,
                Type1 = "Rock",
                Type2 = "Water"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 142,
                Name = PokemonName.Aerodactyl,
                BaseStamina = 160,
                BaseAttack = 182,
                BaseDefend = 162,
                Type1 = "Rock",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 143,
                Name = PokemonName.Snorlax,
                BaseStamina = 320,
                BaseAttack = 180,
                BaseDefend = 180,
                Type1 = "Normal",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 144,
                Name = PokemonName.Articuno,
                BaseStamina = 180,
                BaseAttack = 198,
                BaseDefend = 242,
                Type1 = "Ice",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 145,
                Name = PokemonName.Zapdos,
                BaseStamina = 180,
                BaseAttack = 232,
                BaseDefend = 194,
                Type1 = "Electric",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 146,
                Name = PokemonName.Moltres,
                BaseStamina = 180,
                BaseAttack = 242,
                BaseDefend = 194,
                Type1 = "Fire",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 147,
                Name = PokemonName.Dratini,
                BaseStamina = 82,
                BaseAttack = 128,
                BaseDefend = 110,
                Type1 = "Dragon",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 148,
                Name = PokemonName.Dragonair,
                BaseStamina = 122,
                BaseAttack = 170,
                BaseDefend = 152,
                Type1 = "Dragon",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 149,
                Name = PokemonName.Dragonite,
                BaseStamina = 182,
                BaseAttack = 250,
                BaseDefend = 212,
                Type1 = "Dragon",
                Type2 = "Flying"
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 150,
                Name = PokemonName.Mewtwo,
                BaseStamina = 212,
                BaseAttack = 284,
                BaseDefend = 202,
                Type1 = "Psychic",
                Type2 = ""
            });
            pokes.Add(new Pokemon
            {
                PokeIndex = 151,
                Name = PokemonName.Mew,
                BaseStamina = 200,
                BaseAttack = 220,
                BaseDefend = 220,
                Type1 = "Psychic",
                Type2 = ""
            });
        }

        public class TypeModel
        {
            public string PokeType { get; set; } = null;
            public string[] EffectiveAgainst { get; set; } = { };
            public string[] ResistantAgainst { get; set; } = { };
            public string[] TakesZeroFrom { get; set; } = { };
        }

        public void LoadTypes()
        {
            pokeTypes = new List<TypeModel>();

            pokeTypes.Add(new TypeModel
            {
                PokeType = "Bug",
                EffectiveAgainst = new List<string> {
                "Rock",
                "Flying",
                "Fire"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Ground",
                "Grass",
                "Fighting"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Dark",
                EffectiveAgainst = new List<string> {
                "Fighting",
                "Fairy",
                "Bug"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Ghost",
                "Dark",
                "Psychic"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Dragon",
                EffectiveAgainst = new List<string> {
                "Ice",
                "Fairy",
                "Dragon"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Water",
                "Grass",
                "Fire",
                "Electric"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Electric",
                EffectiveAgainst = new List<string> {
                    "Ground"
                }.ToArray(),
                ResistantAgainst = new List<string> {
                "Steel",
                "Flying",
                "Electric"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Fairy",
                EffectiveAgainst = new List<string> {
                "Steel",
                "Poison"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Fighting",
                "Dark",
                "Bug",
                "Dragon"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Fighting",
                EffectiveAgainst = new List<string> {
                "Psychic",
                "Flying",
                "Fairy"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Rock",
                "Dark",
                "Bug"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Fire",
                EffectiveAgainst = new List<string> {
                "Water",
                "Rock",
                "Ground"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Steel",
                "Ice",
                "Grass",
                "Fire",
                "Fairy",
                "Bug"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Flying",
                EffectiveAgainst = new List<string> {
                "Rock",
                "Ice",
                "Electric"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Grass",
                "Fighting",
                "Bug",
                "Ground"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Ghost",
                EffectiveAgainst = new List<string> {
                "Ghost",
                "Dark"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Poison",
                "Bug",
                "Normal"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Grass",
                EffectiveAgainst = new List<string> {
                "Poison",
                "Ice",
                "Flying",
                "Fire",
                "Bug"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Water",
                "Ground",
                "Grass",
                "Electric"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Ground",
                EffectiveAgainst = new List<string> {
                "Water",
                "Ice",
                "Grass"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Rock",
                "Poison",
                "Electric"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Ice",
                EffectiveAgainst = new List<string> {
                "Steel",
                "Rock",
                "Fire",
                "Fighting"
            }.ToArray(),
                ResistantAgainst = new List<string> { "Ground" }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Normal",
                EffectiveAgainst = new List<string> { "Fighting" }.ToArray(),
                ResistantAgainst = new List<string> { "Ghost" }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Poison",
                EffectiveAgainst = new List<string> {
                "Psychic",
                "Ground"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Poison",
                "Grass",
                "Fighting",
                "Fairy",
                "Bug"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Psychic",
                EffectiveAgainst = new List<string> {
                "Ghost",
                "Dark",
                "Bug"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Rock",
                "Fighting"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Rock",
                EffectiveAgainst = new List<string> {
                "Water",
                "Steel",
                "Ground",
                "Grass",
                "Fighting"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Poison",
                "Normal",
                "Flying",
                "Fire"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Steel",
                EffectiveAgainst = new List<string> {
                "Ground",
                "Fire",
                "Fighting"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Steel",
                "Rock",
                "Poison",
                "Ice",
                "Ground",
                "Grass",
                "Flying",
                "Fairy",
                "Dragon",
                "Bug",
                "Poison"
            }.ToArray(),
            });
            pokeTypes.Add(new TypeModel
            {
                PokeType = "Water",
                EffectiveAgainst = new List<string> {
                "Ground",
                "Fairy"
            }.ToArray(),
                ResistantAgainst = new List<string> {
                "Water",
                "Steel",
                "Ice",
                "Fire"
            }.ToArray(),
            });
        }
    }
}
