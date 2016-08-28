using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
namespace PokeBro
{
    internal class Pokemon
    {
        public PokemonName Name { get; set; }
        // ReSharper disable once InconsistentNaming
        public int CP { get; set; }
        public int Health { get; set; }
        public int Stardust { get; set; }
        public string GivenName { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public FastMoves FastAttack { get; set; }
        public SpecialMoves SpecialAttack { get; set; }
        public List<Levels> Levels { get; set; }

        public Pokemon()
        {
            Levels = new List<Levels>();
        }
        private PokemonName GetPokemon()
        {
            switch (GivenName)
            {
                case "Bulbasaur":
                    return PokemonName.Bulbasaur;
                case "Ivysaur":
                    return PokemonName.Ivysaur;
                case "Venusaur":
                    return PokemonName.Venusaur;
                case "Charmander":
                    return PokemonName.Charmander;
                case "Charmeleon":
                    return PokemonName.Charmeleon;
                case "Charizard":
                    return PokemonName.Charizard;
                case "Squirtle":
                    return PokemonName.Squirtle;
                case "Wartortle":
                    return PokemonName.Wartortle;
                case "Blastoise":
                    return PokemonName.Blastoise;
                case "Caterpie":
                    return PokemonName.Caterpie;
                case "Metapod":
                    return PokemonName.Metapod;
                case "Butterfree":
                    return PokemonName.Butterfree;
                case "Weedle":
                    return PokemonName.Weedle;
                case "Kakuna":
                    return PokemonName.Kakuna;
                case "Beedrill":
                    return PokemonName.Beedrill;
                case "Pidgey":
                    return PokemonName.Pidgey;
                case "Pidgeotto":
                    return PokemonName.Pidgeotto;
                case "Pidgeot":
                    return PokemonName.Pidgeot;
                case "Rattata":
                    return PokemonName.Rattata;
                case "Raticate":
                    return PokemonName.Raticate;
                case "Spearow":
                    return PokemonName.Spearow;
                case "Fearow":
                    return PokemonName.Fearow;
                case "Ekans":
                    return PokemonName.Ekans;
                case "Arbok":
                    return PokemonName.Arbok;
                case "Pikachu":
                    return PokemonName.Pikachu;
                case "Raichu":
                    return PokemonName.Raichu;
                case "Sandshrew":
                    return PokemonName.Sandshrew;
                case "Sandslash":
                    return PokemonName.Sandslash;
                case "Nidoran♀":
                    return PokemonName.NidoranF;
                case "Nidorina":
                    return PokemonName.Nidorina;
                case "Nidoqueen":
                    return PokemonName.Nidoqueen;
                case "Nidoran♂":
                    return PokemonName.NidoranM;
                case "Nidorino":
                    return PokemonName.Nidorino;
                case "Nidoking":
                    return PokemonName.Nidoking;
                case "Clefairy":
                    return PokemonName.Clefairy;
                case "Clefable":
                    return PokemonName.Clefable;
                case "Vulpix":
                    return PokemonName.Vulpix;
                case "Ninetales":
                    return PokemonName.Ninetales;
                case "Jigglypuff":
                    return PokemonName.Jigglypuff;
                case "Wigglytuff":
                    return PokemonName.Wigglytuff;
                case "Zubat":
                    return PokemonName.Zubat;
                case "Golbat":
                    return PokemonName.Golbat;
                case "Oddish":
                    return PokemonName.Oddish;
                case "Gloom":
                    return PokemonName.Gloom;
                case "Vileplume":
                    return PokemonName.Vileplume;
                case "Paras":
                    return PokemonName.Paras;
                case "Parasect":
                    return PokemonName.Parasect;
                case "Venonat":
                    return PokemonName.Venonat;
                case "Venomoth":
                    return PokemonName.Venomoth;
                case "Diglett":
                    return PokemonName.Diglett;
                case "Dugtrio":
                    return PokemonName.Dugtrio;
                case "Meowth":
                    return PokemonName.Meowth;
                case "Persian":
                    return PokemonName.Persian;
                case "Psyduck":
                    return PokemonName.Psyduck;
                case "Golduck":
                    return PokemonName.Golduck;
                case "Mankey":
                    return PokemonName.Mankey;
                case "Primeape":
                    return PokemonName.Primeape;
                case "Growlithe":
                    return PokemonName.Growlithe;
                case "Arcanine":
                    return PokemonName.Arcanine;
                case "Poliwag":
                    return PokemonName.Poliwag;
                case "Poliwhirl":
                    return PokemonName.Poliwhirl;
                case "Poliwrath":
                    return PokemonName.Poliwrath;
                case "Abra":
                    return PokemonName.Abra;
                case "Kadabra":
                    return PokemonName.Kadabra;
                case "Alakazam":
                    return PokemonName.Alakazam;
                case "Machop":
                    return PokemonName.Machop;
                case "Machoke":
                    return PokemonName.Machoke;
                case "Machamp":
                    return PokemonName.Machamp;
                case "Bellsprout":
                    return PokemonName.Bellsprout;
                case "Weepinbell":
                    return PokemonName.Weepinbell;
                case "Victreebel":
                    return PokemonName.Victreebel;
                case "Tentacool":
                    return PokemonName.Tentacool;
                case "Tentacruel":
                    return PokemonName.Tentacruel;
                case "Geodude":
                    return PokemonName.Geodude;
                case "Graveler":
                    return PokemonName.Graveler;
                case "Golem":
                    return PokemonName.Golem;
                case "Ponyta":
                    return PokemonName.Ponyta;
                case "Rapidash":
                    return PokemonName.Rapidash;
                case "Slowpoke":
                    return PokemonName.Slowpoke;
                case "Slowbro":
                    return PokemonName.Slowbro;
                case "Magnemite":
                    return PokemonName.Magnemite;
                case "Magneton":
                    return PokemonName.Magneton;
                case "Farfetch'd":
                    return PokemonName.Farfetchd;
                case "Doduo":
                    return PokemonName.Doduo;
                case "Dodrio":
                    return PokemonName.Dodrio;
                case "Seel":
                    return PokemonName.Seel;
                case "Dewgong":
                    return PokemonName.Dewgong;
                case "Grimer":
                    return PokemonName.Grimer;
                case "Muk":
                    return PokemonName.Muk;
                case "Shellder":
                    return PokemonName.Shellder;
                case "Cloyster":
                    return PokemonName.Cloyster;
                case "Gastly":
                    return PokemonName.Gastly;
                case "Haunter":
                    return PokemonName.Haunter;
                case "Gengar":
                    return PokemonName.Gengar;
                case "Onix":
                    return PokemonName.Onix;
                case "Drowzee":
                    return PokemonName.Drowzee;
                case "Hypno":
                    return PokemonName.Hypno;
                case "Krabby":
                    return PokemonName.Krabby;
                case "Kingler":
                    return PokemonName.Kingler;
                case "Voltorb":
                    return PokemonName.Voltorb;
                case "Electrode":
                    return PokemonName.Electrode;
                case "Exeggcute":
                    return PokemonName.Exeggcute;
                case "Exeggutor":
                    return PokemonName.Exeggutor;
                case "Cubone":
                    return PokemonName.Cubone;
                case "Marowak":
                    return PokemonName.Marowak;
                case "Hitmonlee":
                    return PokemonName.Hitmonlee;
                case "Hitmonchan":
                    return PokemonName.Hitmonchan;
                case "Lickitung":
                    return PokemonName.Lickitung;
                case "Koffing":
                    return PokemonName.Koffing;
                case "Weezing":
                    return PokemonName.Weezing;
                case "Rhyhorn":
                    return PokemonName.Rhyhorn;
                case "Rhydon":
                    return PokemonName.Rhydon;
                case "Chansey":
                    return PokemonName.Chansey;
                case "Tangela":
                    return PokemonName.Tangela;
                case "Kangaskhan":
                    return PokemonName.Kangaskhan;
                case "Horsea":
                    return PokemonName.Horsea;
                case "Seadra":
                    return PokemonName.Seadra;
                case "Goldeen":
                    return PokemonName.Goldeen;
                case "Seaking":
                    return PokemonName.Seaking;
                case "Staryu":
                    return PokemonName.Staryu;
                case "Starmie":
                    return PokemonName.Starmie;
                case "Mr. Mime":
                    return PokemonName.MrMime;
                case "Scyther":
                    return PokemonName.Scyther;
                case "Jynx":
                    return PokemonName.Jynx;
                case "Electabuzz":
                    return PokemonName.Electabuzz;
                case "Magmar":
                    return PokemonName.Magmar;
                case "Pinsir":
                    return PokemonName.Pinsir;
                case "Tauros":
                    return PokemonName.Tauros;
                case "Magikarp":
                    return PokemonName.Magikarp;
                case "Gyarados":
                    return PokemonName.Gyarados;
                case "Lapras":
                    return PokemonName.Lapras;
                case "Ditto":
                    return PokemonName.Ditto;
                case "Eevee":
                    return PokemonName.Eevee;
                case "Vaporeon":
                    return PokemonName.Vaporeon;
                case "Jolteon":
                    return PokemonName.Jolteon;
                case "Flareon":
                    return PokemonName.Flareon;
                case "Porygon":
                    return PokemonName.Porygon;
                case "Omanyte":
                    return PokemonName.Omanyte;
                case "Omastar":
                    return PokemonName.Omastar;
                case "Kabuto":
                    return PokemonName.Kabuto;
                case "Kabutops":
                    return PokemonName.Kabutops;
                case "Aerodactyl":
                    return PokemonName.Aerodactyl;
                case "Snorlax":
                    return PokemonName.Snorlax;
                case "Articuno":
                    return PokemonName.Articuno;
                case "Zapdos":
                    return PokemonName.Zapdos;
                case "Moltres":
                    return PokemonName.Moltres;
                case "Dratini":
                    return PokemonName.Dratini;
                case "Dragonair":
                    return PokemonName.Dragonair;
                case "Dragonite":
                    return PokemonName.Dragonite;
                case "Mew":
                    return PokemonName.Mew;
                case "Mewtwo":
                    return PokemonName.Mewtwo;
                default:
                    return PokemonName.Mew;
            }
        }

        public void Calculate()
        {
            Name = GetPokemon();

            for (var i = MinLevel(); i <= MaxLevel(); i += 0.5)
            {
                for (var j = 0; j < 16; j++)
                {
                    if (Health != Math.Max((int)(CPM(i) * (BaseStam() + j)), 10)) continue;
                    for (var k = 0; k < 16; k++)
                        for (var l = 0; l < 16; l++)
                            if (CP ==
                                Math.Max(
                                    (int)
                                    ((BaseAtk() + k) * Math.Pow((BaseDef() + l), 0.5) * Math.Pow((BaseStam() + j), 0.5) *
                                     Math.Pow(CPM(i), 2) / 10), 10))

                                Levels.Add(new Levels()
                                {
                                    Level = i,
                                    Aiv = k,
                                    Div = l,
                                    Siv = j
                                }
                                );
                }
            }
        }

        private double MinLevel()
        {
            switch (Stardust)
            {
                case 200:
                    return 1;
                case 400:
                    return 3;
                case 600:
                    return 5;
                case 800:
                    return 7;
                case 1000:
                    return 9;
                case 1300:
                    return 11;
                case 1600:
                    return 13;
                case 1900:
                    return 15;
                case 2200:
                    return 17;
                case 2500:
                    return 19;
                case 3000:
                    return 21;
                case 3500:
                    return 23;
                case 4000:
                    return 25;
                case 4500:
                    return 27;
                case 5000:
                    return 29;
                case 6000:
                    return 31;
                case 7000:
                    return 33;
                case 8000:
                    return 35;
                case 9000:
                    return 37;
                case 10000:
                    return 39;
                default:
                    return 40;
            }
        }
        private double MaxLevel()
        {
            switch (Stardust)
            {
                case 200:
                    return 2.5;
                case 400:
                    return 4.5;
                case 600:
                    return 6.5;
                case 800:
                    return 8.5;
                case 1000:
                    return 10.5;
                case 1300:
                    return 12.5;
                case 1600:
                    return 14.5;
                case 1900:
                    return 16.5;
                case 2200:
                    return 18.5;
                case 2500:
                    return 20.5;
                case 3000:
                    return 23.5;
                case 3500:
                    return 24.5;
                case 4000:
                    return 26.5;
                case 4500:
                    return 28.5;
                case 5000:
                    return 30.5;
                case 6000:
                    return 32.5;
                case 7000:
                    return 34.5;
                case 8000:
                    return 36.5;
                case 9000:
                    return 38.5;
                case 10000:
                    return 39.5;
                case 0:
                    return 40;
                default:
                    return 40;
            }
        }

        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        // ReSharper disable once InconsistentNaming
        private static double CPM(double level)
        {
            if (level == 1) return 0.094;
            if (level == 1.5) return 0.135137432;
            if (level == 2) return 0.16639787;
            if (level == 2.5) return 0.192650919;
            if (level == 3) return 0.21573247;
            if (level == 3.5) return 0.236572661;
            if (level == 4) return 0.25572005;
            if (level == 4.5) return 0.273530381;
            if (level == 5) return 0.29024988;
            if (level == 5.5) return 0.306057377;
            if (level == 6) return 0.3210876;
            if (level == 6.5) return 0.335445036;
            if (level == 7) return 0.34921268;
            if (level == 7.5) return 0.362457751;
            if (level == 8) return 0.37523559;
            if (level == 8.5) return 0.387592406;
            if (level == 9) return 0.39956728;
            if (level == 9.5) return 0.411193551;
            if (level == 10) return 0.42250001;
            if (level == 10.5) return 0.432926419;
            if (level == 11) return 0.44310755;
            if (level == 11.5) return 0.4530599578;
            if (level == 12) return 0.46279839;
            if (level == 12.5) return 0.472336083;
            if (level == 13) return 0.48168495;
            if (level == 13.5) return 0.4908558;
            if (level == 14) return 0.49985844;
            if (level == 14.5) return 0.508701765;
            if (level == 15) return 0.51739395;
            if (level == 15.5) return 0.525942511;
            if (level == 16) return 0.53435433;
            if (level == 16.5) return 0.542635767;
            if (level == 17) return 0.55079269;
            if (level == 17.5) return 0.558830576;
            if (level == 18) return 0.56675452;
            if (level == 18.5) return 0.574569153;
            if (level == 19) return 0.58227891;
            if (level == 19.5) return 0.589887917;
            if (level == 20) return 0.59740001;
            if (level == 20.5) return 0.604818814;
            if (level == 21) return 0.61215729;
            if (level == 21.5) return 0.619399365;
            if (level == 22) return 0.62656713;
            if (level == 22.5) return 0.633644533;
            if (level == 23) return 0.64065295;
            if (level == 23.5) return 0.647576426;
            if (level == 24) return 0.65443563;
            if (level == 24.5) return 0.661214806;
            if (level == 25) return 0.667934;
            if (level == 25.5) return 0.674577537;
            if (level == 26) return 0.68116492;
            if (level == 26.5) return 0.687680648;
            if (level == 27) return 0.69414365;
            if (level == 27.5) return 0.700538673;
            if (level == 28) return 0.70688421;
            if (level == 28.5) return 0.713164996;
            if (level == 29) return 0.71939909;
            if (level == 29.5) return 0.725571552;
            if (level == 30) return 0.7317;
            if (level == 30.5) return 0.734741009;
            if (level == 31) return 0.73776948;
            if (level == 31.5) return 0.740785574;
            if (level == 32) return 0.74378943;
            if (level == 32.5) return 0.746781211;
            if (level == 33) return 0.74976104;
            if (level == 33.5) return 0.752729087;
            if (level == 34) return 0.75568551;
            if (level == 34.5) return 0.758630378;
            if (level == 35) return 0.76156384;
            if (level == 35.5) return 0.764486065;
            if (level == 36) return 0.76739717;
            if (level == 36.5) return 0.770297266;
            if (level == 37) return 0.7731865;
            if (level == 37.5) return 0.776064962;
            if (level == 38) return 0.77893275;
            if (level == 38.5) return 0.781790055;
            if (level == 39) return 0.78463697;
            if (level == 39.5) return 0.787473578;
            if (level == 40) return 0.79030001;
            return 0;
        }

        private int BaseStam()
        {
            switch (Name)
            {
                case PokemonName.Bulbasaur:
                    return 90;
                case PokemonName.Ivysaur:
                    return 120;
                case PokemonName.Venusaur:
                    return 160;
                case PokemonName.Charmander:
                    return 78;
                case PokemonName.Charmeleon:
                    return 116;
                case PokemonName.Charizard:
                    return 156;
                case PokemonName.Squirtle:
                    return 88;
                case PokemonName.Wartortle:
                    return 118;
                case PokemonName.Blastoise:
                    return 158;
                case PokemonName.Caterpie:
                    return 90;
                case PokemonName.Metapod:
                    return 100;
                case PokemonName.Butterfree:
                    return 120;
                case PokemonName.Weedle:
                    return 80;
                case PokemonName.Kakuna:
                    return 90;
                case PokemonName.Beedrill:
                    return 130;
                case PokemonName.Pidgey:
                    return 80;
                case PokemonName.Pidgeotto:
                    return 126;
                case PokemonName.Pidgeot:
                    return 166;
                case PokemonName.Rattata:
                    return 60;
                case PokemonName.Raticate:
                    return 110;
                case PokemonName.Spearow:
                    return 80;
                case PokemonName.Fearow:
                    return 130;
                case PokemonName.Ekans:
                    return 70;
                case PokemonName.Arbok:
                    return 120;
                case PokemonName.Pikachu:
                    return 70;
                case PokemonName.Raichu:
                    return 120;
                case PokemonName.Sandshrew:
                    return 100;
                case PokemonName.Sandslash:
                    return 150;
                case PokemonName.NidoranF:
                    return 110;
                case PokemonName.Nidorina:
                    return 140;
                case PokemonName.Nidoqueen:
                    return 180;
                case PokemonName.NidoranM:
                    return 92;
                case PokemonName.Nidorino:
                    return 122;
                case PokemonName.Nidoking:
                    return 162;
                case PokemonName.Clefairy:
                    return 140;
                case PokemonName.Clefable:
                    return 190;
                case PokemonName.Vulpix:
                    return 76;
                case PokemonName.Ninetales:
                    return 146;
                case PokemonName.Jigglypuff:
                    return 230;
                case PokemonName.Wigglytuff:
                    return 280;
                case PokemonName.Zubat:
                    return 80;
                case PokemonName.Golbat:
                    return 150;
                case PokemonName.Oddish:
                    return 90;
                case PokemonName.Gloom:
                    return 120;
                case PokemonName.Vileplume:
                    return 150;
                case PokemonName.Paras:
                    return 70;
                case PokemonName.Parasect:
                    return 120;
                case PokemonName.Venonat:
                    return 120;
                case PokemonName.Venomoth:
                    return 140;
                case PokemonName.Diglett:
                    return 20;
                case PokemonName.Dugtrio:
                    return 70;
                case PokemonName.Meowth:
                    return 80;
                case PokemonName.Persian:
                    return 130;
                case PokemonName.Psyduck:
                    return 100;
                case PokemonName.Golduck:
                    return 160;
                case PokemonName.Mankey:
                    return 80;
                case PokemonName.Primeape:
                    return 130;
                case PokemonName.Growlithe:
                    return 110;
                case PokemonName.Arcanine:
                    return 180;
                case PokemonName.Poliwag:
                    return 80;
                case PokemonName.Poliwhirl:
                    return 130;
                case PokemonName.Poliwrath:
                    return 180;
                case PokemonName.Abra:
                    return 50;
                case PokemonName.Kadabra:
                    return 80;
                case PokemonName.Alakazam:
                    return 110;
                case PokemonName.Machop:
                    return 140;
                case PokemonName.Machoke:
                    return 160;
                case PokemonName.Machamp:
                    return 180;
                case PokemonName.Bellsprout:
                    return 100;
                case PokemonName.Weepinbell:
                    return 130;
                case PokemonName.Victreebel:
                    return 160;
                case PokemonName.Tentacool:
                    return 80;
                case PokemonName.Tentacruel:
                    return 160;
                case PokemonName.Geodude:
                    return 80;
                case PokemonName.Graveler:
                    return 110;
                case PokemonName.Golem:
                    return 160;
                case PokemonName.Ponyta:
                    return 100;
                case PokemonName.Rapidash:
                    return 130;
                case PokemonName.Slowpoke:
                    return 180;
                case PokemonName.Slowbro:
                    return 190;
                case PokemonName.Magnemite:
                    return 50;
                case PokemonName.Magneton:
                    return 100;
                case PokemonName.Farfetchd:
                    return 104;
                case PokemonName.Doduo:
                    return 70;
                case PokemonName.Dodrio:
                    return 120;
                case PokemonName.Seel:
                    return 130;
                case PokemonName.Dewgong:
                    return 180;
                case PokemonName.Grimer:
                    return 160;
                case PokemonName.Muk:
                    return 210;
                case PokemonName.Shellder:
                    return 60;
                case PokemonName.Cloyster:
                    return 100;
                case PokemonName.Gastly:
                    return 60;
                case PokemonName.Haunter:
                    return 90;
                case PokemonName.Gengar:
                    return 120;
                case PokemonName.Onix:
                    return 70;
                case PokemonName.Drowzee:
                    return 120;
                case PokemonName.Hypno:
                    return 170;
                case PokemonName.Krabby:
                    return 60;
                case PokemonName.Kingler:
                    return 110;
                case PokemonName.Voltorb:
                    return 80;
                case PokemonName.Electrode:
                    return 120;
                case PokemonName.Exeggcute:
                    return 120;
                case PokemonName.Exeggutor:
                    return 190;
                case PokemonName.Cubone:
                    return 100;
                case PokemonName.Marowak:
                    return 120;
                case PokemonName.Hitmonlee:
                    return 100;
                case PokemonName.Hitmonchan:
                    return 100;
                case PokemonName.Lickitung:
                    return 180;
                case PokemonName.Koffing:
                    return 80;
                case PokemonName.Weezing:
                    return 130;
                case PokemonName.Rhyhorn:
                    return 160;
                case PokemonName.Rhydon:
                    return 210;
                case PokemonName.Chansey:
                    return 500;
                case PokemonName.Tangela:
                    return 130;
                case PokemonName.Kangaskhan:
                    return 210;
                case PokemonName.Horsea:
                    return 60;
                case PokemonName.Seadra:
                    return 110;
                case PokemonName.Goldeen:
                    return 90;
                case PokemonName.Seaking:
                    return 160;
                case PokemonName.Staryu:
                    return 60;
                case PokemonName.Starmie:
                    return 120;
                case PokemonName.MrMime:
                    return 80;
                case PokemonName.Scyther:
                    return 140;
                case PokemonName.Jynx:
                    return 130;
                case PokemonName.Electabuzz:
                    return 130;
                case PokemonName.Magmar:
                    return 130;
                case PokemonName.Pinsir:
                    return 130;
                case PokemonName.Tauros:
                    return 150;
                case PokemonName.Magikarp:
                    return 40;
                case PokemonName.Gyarados:
                    return 190;
                case PokemonName.Lapras:
                    return 260;
                case PokemonName.Ditto:
                    return 96;
                case PokemonName.Eevee:
                    return 110;
                case PokemonName.Vaporeon:
                    return 260;
                case PokemonName.Jolteon:
                    return 130;
                case PokemonName.Flareon:
                    return 130;
                case PokemonName.Porygon:
                    return 130;
                case PokemonName.Omanyte:
                    return 70;
                case PokemonName.Omastar:
                    return 140;
                case PokemonName.Kabuto:
                    return 60;
                case PokemonName.Kabutops:
                    return 120;
                case PokemonName.Aerodactyl:
                    return 160;
                case PokemonName.Snorlax:
                    return 320;
                case PokemonName.Articuno:
                    return 180;
                case PokemonName.Zapdos:
                    return 180;
                case PokemonName.Moltres:
                    return 180;
                case PokemonName.Dratini:
                    return 82;
                case PokemonName.Dragonair:
                    return 122;
                case PokemonName.Dragonite:
                    return 182;
                case PokemonName.Mewtwo:
                    return 212;
                case PokemonName.Mew:
                    return 200;
                default:
                    return 0;
            }
        }

        private int BaseAtk()
        {
            switch (Name)
            {
                case PokemonName.Bulbasaur:
                    return 126;
                case PokemonName.Ivysaur:
                    return 156;
                case PokemonName.Venusaur:
                    return 198;
                case PokemonName.Charmander:
                    return 128;
                case PokemonName.Charmeleon:
                    return 160;
                case PokemonName.Charizard:
                    return 212;
                case PokemonName.Squirtle:
                    return 112;
                case PokemonName.Wartortle:
                    return 144;
                case PokemonName.Blastoise:
                    return 186;
                case PokemonName.Caterpie:
                    return 62;
                case PokemonName.Metapod:
                    return 56;
                case PokemonName.Butterfree:
                    return 144;
                case PokemonName.Weedle:
                    return 68;
                case PokemonName.Kakuna:
                    return 62;
                case PokemonName.Beedrill:
                    return 144;
                case PokemonName.Pidgey:
                    return 94;
                case PokemonName.Pidgeotto:
                    return 126;
                case PokemonName.Pidgeot:
                    return 170;
                case PokemonName.Rattata:
                    return 92;
                case PokemonName.Raticate:
                    return 146;
                case PokemonName.Spearow:
                    return 102;
                case PokemonName.Fearow:
                    return 168;
                case PokemonName.Ekans:
                    return 112;
                case PokemonName.Arbok:
                    return 166;
                case PokemonName.Pikachu:
                    return 124;
                case PokemonName.Raichu:
                    return 200;
                case PokemonName.Sandshrew:
                    return 90;
                case PokemonName.Sandslash:
                    return 150;
                case PokemonName.NidoranF:
                    return 100;
                case PokemonName.Nidorina:
                    return 132;
                case PokemonName.Nidoqueen:
                    return 184;
                case PokemonName.NidoranM:
                    return 110;
                case PokemonName.Nidorino:
                    return 142;
                case PokemonName.Nidoking:
                    return 204;
                case PokemonName.Clefairy:
                    return 116;
                case PokemonName.Clefable:
                    return 178;
                case PokemonName.Vulpix:
                    return 106;
                case PokemonName.Ninetales:
                    return 176;
                case PokemonName.Jigglypuff:
                    return 98;
                case PokemonName.Wigglytuff:
                    return 168;
                case PokemonName.Zubat:
                    return 88;
                case PokemonName.Golbat:
                    return 164;
                case PokemonName.Oddish:
                    return 134;
                case PokemonName.Gloom:
                    return 162;
                case PokemonName.Vileplume:
                    return 202;
                case PokemonName.Paras:
                    return 122;
                case PokemonName.Parasect:
                    return 162;
                case PokemonName.Venonat:
                    return 108;
                case PokemonName.Venomoth:
                    return 172;
                case PokemonName.Diglett:
                    return 108;
                case PokemonName.Dugtrio:
                    return 148;
                case PokemonName.Meowth:
                    return 104;
                case PokemonName.Persian:
                    return 156;
                case PokemonName.Psyduck:
                    return 132;
                case PokemonName.Golduck:
                    return 194;
                case PokemonName.Mankey:
                    return 122;
                case PokemonName.Primeape:
                    return 178;
                case PokemonName.Growlithe:
                    return 156;
                case PokemonName.Arcanine:
                    return 230;
                case PokemonName.Poliwag:
                    return 108;
                case PokemonName.Poliwhirl:
                    return 132;
                case PokemonName.Poliwrath:
                    return 180;
                case PokemonName.Abra:
                    return 110;
                case PokemonName.Kadabra:
                    return 150;
                case PokemonName.Alakazam:
                    return 186;
                case PokemonName.Machop:
                    return 118;
                case PokemonName.Machoke:
                    return 154;
                case PokemonName.Machamp:
                    return 198;
                case PokemonName.Bellsprout:
                    return 158;
                case PokemonName.Weepinbell:
                    return 190;
                case PokemonName.Victreebel:
                    return 222;
                case PokemonName.Tentacool:
                    return 106;
                case PokemonName.Tentacruel:
                    return 170;
                case PokemonName.Geodude:
                    return 106;
                case PokemonName.Graveler:
                    return 142;
                case PokemonName.Golem:
                    return 176;
                case PokemonName.Ponyta:
                    return 168;
                case PokemonName.Rapidash:
                    return 200;
                case PokemonName.Slowpoke:
                    return 110;
                case PokemonName.Slowbro:
                    return 184;
                case PokemonName.Magnemite:
                    return 128;
                case PokemonName.Magneton:
                    return 186;
                case PokemonName.Farfetchd:
                    return 138;
                case PokemonName.Doduo:
                    return 126;
                case PokemonName.Dodrio:
                    return 182;
                case PokemonName.Seel:
                    return 104;
                case PokemonName.Dewgong:
                    return 156;
                case PokemonName.Grimer:
                    return 124;
                case PokemonName.Muk:
                    return 180;
                case PokemonName.Shellder:
                    return 120;
                case PokemonName.Cloyster:
                    return 196;
                case PokemonName.Gastly:
                    return 136;
                case PokemonName.Haunter:
                    return 172;
                case PokemonName.Gengar:
                    return 204;
                case PokemonName.Onix:
                    return 90;
                case PokemonName.Drowzee:
                    return 104;
                case PokemonName.Hypno:
                    return 162;
                case PokemonName.Krabby:
                    return 116;
                case PokemonName.Kingler:
                    return 178;
                case PokemonName.Voltorb:
                    return 102;
                case PokemonName.Electrode:
                    return 150;
                case PokemonName.Exeggcute:
                    return 110;
                case PokemonName.Exeggutor:
                    return 232;
                case PokemonName.Cubone:
                    return 102;
                case PokemonName.Marowak:
                    return 140;
                case PokemonName.Hitmonlee:
                    return 148;
                case PokemonName.Hitmonchan:
                    return 138;
                case PokemonName.Lickitung:
                    return 126;
                case PokemonName.Koffing:
                    return 136;
                case PokemonName.Weezing:
                    return 190;
                case PokemonName.Rhyhorn:
                    return 110;
                case PokemonName.Rhydon:
                    return 166;
                case PokemonName.Chansey:
                    return 40;
                case PokemonName.Tangela:
                    return 164;
                case PokemonName.Kangaskhan:
                    return 142;
                case PokemonName.Horsea:
                    return 122;
                case PokemonName.Seadra:
                    return 176;
                case PokemonName.Goldeen:
                    return 112;
                case PokemonName.Seaking:
                    return 172;
                case PokemonName.Staryu:
                    return 130;
                case PokemonName.Starmie:
                    return 194;
                case PokemonName.MrMime:
                    return 154;
                case PokemonName.Scyther:
                    return 176;
                case PokemonName.Jynx:
                    return 172;
                case PokemonName.Electabuzz:
                    return 198;
                case PokemonName.Magmar:
                    return 214;
                case PokemonName.Pinsir:
                    return 184;
                case PokemonName.Tauros:
                    return 148;
                case PokemonName.Magikarp:
                    return 42;
                case PokemonName.Gyarados:
                    return 192;
                case PokemonName.Lapras:
                    return 186;
                case PokemonName.Ditto:
                    return 110;
                case PokemonName.Eevee:
                    return 114;
                case PokemonName.Vaporeon:
                    return 186;
                case PokemonName.Jolteon:
                    return 192;
                case PokemonName.Flareon:
                    return 238;
                case PokemonName.Porygon:
                    return 156;
                case PokemonName.Omanyte:
                    return 132;
                case PokemonName.Omastar:
                    return 180;
                case PokemonName.Kabuto:
                    return 148;
                case PokemonName.Kabutops:
                    return 190;
                case PokemonName.Aerodactyl:
                    return 182;
                case PokemonName.Snorlax:
                    return 180;
                case PokemonName.Articuno:
                    return 198;
                case PokemonName.Zapdos:
                    return 232;
                case PokemonName.Moltres:
                    return 242;
                case PokemonName.Dratini:
                    return 128;
                case PokemonName.Dragonair:
                    return 170;
                case PokemonName.Dragonite:
                    return 250;
                case PokemonName.Mewtwo:
                    return 284;
                case PokemonName.Mew:
                    return 220;
                default:
                    return 0;
            }
        }

        private int BaseDef()
        {
            switch (Name)
            {
                case PokemonName.Bulbasaur:
                    return 126;
                case PokemonName.Ivysaur:
                    return 158;
                case PokemonName.Venusaur:
                    return 200;
                case PokemonName.Charmander:
                    return 108;
                case PokemonName.Charmeleon:
                    return 140;
                case PokemonName.Charizard:
                    return 182;
                case PokemonName.Squirtle:
                    return 142;
                case PokemonName.Wartortle:
                    return 176;
                case PokemonName.Blastoise:
                    return 222;
                case PokemonName.Caterpie:
                    return 66;
                case PokemonName.Metapod:
                    return 86;
                case PokemonName.Butterfree:
                    return 144;
                case PokemonName.Weedle:
                    return 64;
                case PokemonName.Kakuna:
                    return 82;
                case PokemonName.Beedrill:
                    return 130;
                case PokemonName.Pidgey:
                    return 90;
                case PokemonName.Pidgeotto:
                    return 122;
                case PokemonName.Pidgeot:
                    return 166;
                case PokemonName.Rattata:
                    return 86;
                case PokemonName.Raticate:
                    return 150;
                case PokemonName.Spearow:
                    return 78;
                case PokemonName.Fearow:
                    return 146;
                case PokemonName.Ekans:
                    return 112;
                case PokemonName.Arbok:
                    return 166;
                case PokemonName.Pikachu:
                    return 108;
                case PokemonName.Raichu:
                    return 154;
                case PokemonName.Sandshrew:
                    return 114;
                case PokemonName.Sandslash:
                    return 172;
                case PokemonName.NidoranF:
                    return 104;
                case PokemonName.Nidorina:
                    return 136;
                case PokemonName.Nidoqueen:
                    return 190;
                case PokemonName.NidoranM:
                    return 94;
                case PokemonName.Nidorino:
                    return 128;
                case PokemonName.Nidoking:
                    return 170;
                case PokemonName.Clefairy:
                    return 124;
                case PokemonName.Clefable:
                    return 178;
                case PokemonName.Vulpix:
                    return 118;
                case PokemonName.Ninetales:
                    return 194;
                case PokemonName.Jigglypuff:
                    return 54;
                case PokemonName.Wigglytuff:
                    return 108;
                case PokemonName.Zubat:
                    return 90;
                case PokemonName.Golbat:
                    return 164;
                case PokemonName.Oddish:
                    return 130;
                case PokemonName.Gloom:
                    return 158;
                case PokemonName.Vileplume:
                    return 190;
                case PokemonName.Paras:
                    return 120;
                case PokemonName.Parasect:
                    return 170;
                case PokemonName.Venonat:
                    return 118;
                case PokemonName.Venomoth:
                    return 154;
                case PokemonName.Diglett:
                    return 86;
                case PokemonName.Dugtrio:
                    return 140;
                case PokemonName.Meowth:
                    return 94;
                case PokemonName.Persian:
                    return 146;
                case PokemonName.Psyduck:
                    return 112;
                case PokemonName.Golduck:
                    return 176;
                case PokemonName.Mankey:
                    return 96;
                case PokemonName.Primeape:
                    return 150;
                case PokemonName.Growlithe:
                    return 110;
                case PokemonName.Arcanine:
                    return 180;
                case PokemonName.Poliwag:
                    return 98;
                case PokemonName.Poliwhirl:
                    return 132;
                case PokemonName.Poliwrath:
                    return 202;
                case PokemonName.Abra:
                    return 76;
                case PokemonName.Kadabra:
                    return 112;
                case PokemonName.Alakazam:
                    return 152;
                case PokemonName.Machop:
                    return 96;
                case PokemonName.Machoke:
                    return 144;
                case PokemonName.Machamp:
                    return 180;
                case PokemonName.Bellsprout:
                    return 78;
                case PokemonName.Weepinbell:
                    return 110;
                case PokemonName.Victreebel:
                    return 152;
                case PokemonName.Tentacool:
                    return 136;
                case PokemonName.Tentacruel:
                    return 196;
                case PokemonName.Geodude:
                    return 118;
                case PokemonName.Graveler:
                    return 156;
                case PokemonName.Golem:
                    return 198;
                case PokemonName.Ponyta:
                    return 138;
                case PokemonName.Rapidash:
                    return 170;
                case PokemonName.Slowpoke:
                    return 110;
                case PokemonName.Slowbro:
                    return 198;
                case PokemonName.Magnemite:
                    return 138;
                case PokemonName.Magneton:
                    return 180;
                case PokemonName.Farfetchd:
                    return 132;
                case PokemonName.Doduo:
                    return 96;
                case PokemonName.Dodrio:
                    return 150;
                case PokemonName.Seel:
                    return 138;
                case PokemonName.Dewgong:
                    return 192;
                case PokemonName.Grimer:
                    return 110;
                case PokemonName.Muk:
                    return 188;
                case PokemonName.Shellder:
                    return 112;
                case PokemonName.Cloyster:
                    return 196;
                case PokemonName.Gastly:
                    return 82;
                case PokemonName.Haunter:
                    return 118;
                case PokemonName.Gengar:
                    return 156;
                case PokemonName.Onix:
                    return 186;
                case PokemonName.Drowzee:
                    return 140;
                case PokemonName.Hypno:
                    return 196;
                case PokemonName.Krabby:
                    return 110;
                case PokemonName.Kingler:
                    return 168;
                case PokemonName.Voltorb:
                    return 124;
                case PokemonName.Electrode:
                    return 174;
                case PokemonName.Exeggcute:
                    return 132;
                case PokemonName.Exeggutor:
                    return 164;
                case PokemonName.Cubone:
                    return 150;
                case PokemonName.Marowak:
                    return 202;
                case PokemonName.Hitmonlee:
                    return 172;
                case PokemonName.Hitmonchan:
                    return 204;
                case PokemonName.Lickitung:
                    return 160;
                case PokemonName.Koffing:
                    return 142;
                case PokemonName.Weezing:
                    return 198;
                case PokemonName.Rhyhorn:
                    return 116;
                case PokemonName.Rhydon:
                    return 160;
                case PokemonName.Chansey:
                    return 60;
                case PokemonName.Tangela:
                    return 152;
                case PokemonName.Kangaskhan:
                    return 178;
                case PokemonName.Horsea:
                    return 100;
                case PokemonName.Seadra:
                    return 150;
                case PokemonName.Goldeen:
                    return 126;
                case PokemonName.Seaking:
                    return 160;
                case PokemonName.Staryu:
                    return 128;
                case PokemonName.Starmie:
                    return 192;
                case PokemonName.MrMime:
                    return 196;
                case PokemonName.Scyther:
                    return 180;
                case PokemonName.Jynx:
                    return 134;
                case PokemonName.Electabuzz:
                    return 160;
                case PokemonName.Magmar:
                    return 158;
                case PokemonName.Pinsir:
                    return 186;
                case PokemonName.Tauros:
                    return 184;
                case PokemonName.Magikarp:
                    return 84;
                case PokemonName.Gyarados:
                    return 196;
                case PokemonName.Lapras:
                    return 190;
                case PokemonName.Ditto:
                    return 110;
                case PokemonName.Eevee:
                    return 128;
                case PokemonName.Vaporeon:
                    return 168;
                case PokemonName.Jolteon:
                    return 174;
                case PokemonName.Flareon:
                    return 178;
                case PokemonName.Porygon:
                    return 158;
                case PokemonName.Omanyte:
                    return 160;
                case PokemonName.Omastar:
                    return 202;
                case PokemonName.Kabuto:
                    return 142;
                case PokemonName.Kabutops:
                    return 190;
                case PokemonName.Aerodactyl:
                    return 162;
                case PokemonName.Snorlax:
                    return 180;
                case PokemonName.Articuno:
                    return 242;
                case PokemonName.Zapdos:
                    return 194;
                case PokemonName.Moltres:
                    return 194;
                case PokemonName.Dratini:
                    return 110;
                case PokemonName.Dragonair:
                    return 152;
                case PokemonName.Dragonite:
                    return 212;
                case PokemonName.Mewtwo:
                    return 202;
                case PokemonName.Mew:
                    return 220;
                default:
                    return 0;
            }
        }
    }
}

internal struct Levels
{
    public double Level;
    public int Siv;
    public int Aiv;
    public int Div;
}

internal enum PokemonName
{
    Bulbasaur,
    Ivysaur,
    Venusaur,
    Charmander,
    Charmeleon,
    Charizard,
    Squirtle,
    Wartortle,
    Blastoise,
    Caterpie,
    Metapod,
    Butterfree,
    Weedle,
    Kakuna,
    Beedrill,
    Pidgey,
    Pidgeotto,
    Pidgeot,
    Rattata,
    Raticate,
    Spearow,
    Fearow,
    Ekans,
    Arbok,
    Pikachu,
    Raichu,
    Sandshrew,
    Sandslash,
    NidoranF,
    Nidorina,
    Nidoqueen,
    NidoranM,
    Nidorino,
    Nidoking,
    Clefairy,
    Clefable,
    Vulpix,
    Ninetales,
    Jigglypuff,
    Wigglytuff,
    Zubat,
    Golbat,
    Oddish,
    Gloom,
    Vileplume,
    Paras,
    Parasect,
    Venonat,
    Venomoth,
    Diglett,
    Dugtrio,
    Meowth,
    Persian,
    Psyduck,
    Golduck,
    Mankey,
    Primeape,
    Growlithe,
    Arcanine,
    Poliwag,
    Poliwhirl,
    Poliwrath,
    Abra,
    Kadabra,
    Alakazam,
    Machop,
    Machoke,
    Machamp,
    Bellsprout,
    Weepinbell,
    Victreebel,
    Tentacool,
    Tentacruel,
    Geodude,
    Graveler,
    Golem,
    Ponyta,
    Rapidash,
    Slowpoke,
    Slowbro,
    Magnemite,
    Magneton,
    Farfetchd,
    Doduo,
    Dodrio,
    Seel,
    Dewgong,
    Grimer,
    Muk,
    Shellder,
    Cloyster,
    Gastly,
    Haunter,
    Gengar,
    Onix,
    Drowzee,
    Hypno,
    Krabby,
    Kingler,
    Voltorb,
    Electrode,
    Exeggcute,
    Exeggutor,
    Cubone,
    Marowak,
    Hitmonlee,
    Hitmonchan,
    Lickitung,
    Koffing,
    Weezing,
    Rhyhorn,
    Rhydon,
    Chansey,
    Tangela,
    Kangaskhan,
    Horsea,
    Seadra,
    Goldeen,
    Seaking,
    Staryu,
    Starmie,
    MrMime,
    Scyther,
    Jynx,
    Electabuzz,
    Magmar,
    Pinsir,
    Tauros,
    Magikarp,
    Gyarados,
    Lapras,
    Ditto,
    Eevee,
    Vaporeon,
    Jolteon,
    Flareon,
    Porygon,
    Omanyte,
    Omastar,
    Kabuto,
    Kabutops,
    Aerodactyl,
    Snorlax,
    Articuno,
    Zapdos,
    Moltres,
    Dratini,
    Dragonair,
    Dragonite,
    Mewtwo,
    Mew
}

internal enum FastMoves
{
    FuryCutter,
    BugBite,
    Bite,
    SuckerPunch,
    DragonBreath,
    ThunderShock,
    Spark,
    LowKick,
    KarateChop,
    Ember,
    WingAttack,
    Peck,
    Lick,
    ShadowClaw,
    VineWhip,
    RazorLeaf,
    MudShot,
    IceShard,
    FrostBreath,
    QuickAttack,
    Scratch,
    Tackle,
    Pound,
    Cut,
    PoisonJab,
    Acid,
    PsychoCut,
    RockThrow,
    MetalClaw,
    BulletPunch,
    WaterGun,
    Splash,
    MudSlap,
    ZenHeadbutt,
    Confusion,
    PoisonSting,
    Bubble,
    FeintAttack,
    SteelWing,
    FireFang,
    RockSmash
}

internal enum SpecialMoves
{
    Wrap,
    HyperBeam,
    DarkPulse,
    Sludge,
    ViceGrip,
    FlameWheel,
    Megahorn,
    Flamethrower,
    Dig,
    CrossChop,
    Psybeam,
    Earthquake,
    StoneEdge,
    IcePunch,
    HeartStamp,
    Discharge,
    FlashCannon,
    DrillPeck,
    IceBeam,
    Blizzard,
    HeatWave,
    AerialAce,
    DrillRun,
    PetalBlizzard,
    MegaDrain,
    BugBuzz,
    PoisonFang,
    NightSlash,
    BubbleBeam,
    Submission,
    LowSweep,
    AquaJet,
    AquaTail,
    SeedBomb,
    Psyshock,
    AncientPower,
    RockTomb,
    RockSlide,
    PowerGem,
    ShadowSneak,
    ShadowPunch,
    OminousWind,
    ShadowBall,
    MagnetBomb,
    IronHead,
    ParabolicCharge,
    ThunderPunch,
    Thunder,
    Thunderbolt,
    Twister,
    DragonPulse,
    DragonClaw,
    DisarmingVoice,
    DrainingKiss,
    DazzlingGleam,
    Moonblast,
    PlayRough,
    CrossPoison,
    SludgeBomb,
    SludgeWave,
    GunkShot,
    BoneClub,
    Bulldoze,
    MudBomb,
    SignalBeam,
    XScissor,
    FlameCharge,
    FlameBurst,
    FireBlast,
    Brine,
    WaterPulse,
    Scald,
    HydroPump,
    Psychic,
    Psystrike,
    IcyWind,
    GigaDrain,
    FirePunch,
    SolarBeam,
    LeafBlade,
    PowerWhip,
    AirCutter,
    Hurricane,
    BrickBreak,
    Swift,
    HornAttack,
    Stomp,
    HyperFang,
    BodySlam,
    Rest,
    Struggle
}

