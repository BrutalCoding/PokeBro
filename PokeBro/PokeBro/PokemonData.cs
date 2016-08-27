﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBro
{
    class PokemonData
    {
        public PokemonData()
        {

        }

        //public PokemonData(string name, int attack, int defense, int stamina, string evolution) : this()
        //{
        //    this.name = name;
        //    this.attack = attack;
        //    this.defense = defense;
        //    this.stamina = stamina;
        //    this.evolution = evolution;
        //}
        // List of each Pokemon (Gen 1)
        public SortedDictionary<string, PokemonBaseStats> listOfPokemon = new SortedDictionary<string, PokemonBaseStats>()
        {
            {"Bulbasaur", new PokemonBaseStats("Bulbasaur", 126, 126, 90)},
            {"Ivysaur", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Venusaur", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Charmander", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Charmeleon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Charizard", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Squirtle", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Wartortle", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Blastoise", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Caterpie", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Metapod", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Butterfree", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Weedle", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kakuna", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Beedrill", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Pidgey", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Pidgeotto", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Pidgeot", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Rattata", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Raticate", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Spearow", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Fearow", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Ekans", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Arbok", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Pikachu", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Raichu", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Sandshrew", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Sandslash", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidoran♀", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidorina", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidoqueen", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidoran♂", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidorino", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Nidoking", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Clefairy", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Clefable", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Vulpix", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Ninetales", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Jigglypuff", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Wigglytuff", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Zubat", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Golbat", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Oddish", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Gloom", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Vileplume", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Paras", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Parasect", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Venonat", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Venomoth", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Diglett", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dugtrio", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Meowth", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Persian", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Psyduck", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Golduck", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Mankey", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Primeape", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Growlithe", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Arcanine", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Poliwag", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Poliwhirl", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Poliwrath", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Abra", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kadabra", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Alakazam", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Machop", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Machoke", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Machamp", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Bellsprout", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Weepinbell", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Victreebel", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Tentacool", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Tentacruel", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Geodude", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Graveler", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Golem", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Ponyta", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Rapidash", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Slowpoke", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Slowbro", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Magnemite", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Magneton", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Farfetch'd", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Doduo", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dodrio", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Seel", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dewgong", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Grimer", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Muk", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Shellder", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Cloyster", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Gastly", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Haunter", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Gengar", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Onix", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Drowzee", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Hypno", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Krabby", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kingler", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Voltorb", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Electrode", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Exeggcute", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Exeggutor", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Cubone", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Marowak", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Hitmonlee", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Hitmonchan", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Lickitung", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Koffing", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Weezing", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Rhyhorn", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Rhydon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Chansey", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Tangela", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kangaskhan", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Horsea", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Seadra", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Goldeen", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Seaking", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Staryu", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Starmie", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Mr. Mime", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Scyther", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Jynx", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Electabuzz", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Magmar", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Pinsir", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Tauros", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Magikarp", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Gyarados", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Lapras", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Ditto", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Eevee", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Vaporeon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Jolteon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Flareon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Porygon", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Omanyte", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Omastar", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kabuto", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Kabutops", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Aerodactyl", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Snorlax", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Articuno", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Zapdos", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Moltres", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dratini", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dragonair", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Dragonite", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Mewtwo", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)},
            {"Mew", new PokemonBaseStats("PLACEHOLDER", 0, 0, 0)}
        };
    }
}