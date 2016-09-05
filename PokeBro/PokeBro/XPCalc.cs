using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace PokeBro
{
    internal class XPCalc : ContentPage
    {
        //Create the class PD so we can access all Pokemon data.
        PokemonData pokemonData = new PokemonData();
        StackLayout layout;
        ObservableCollection<string> listOfAddedMonsters = new ObservableCollection<string>();
        ListView picker;
        Picker pickerMonsterToAdd;
        Label labelPicker;
        Label labelMonsterToAdd;
        Label labelInputCandies;
        Button btnAddMonsterToList;
        Button btnCalculate;

        //Results controls
        ListView resultsList;

        public Entry inputCandies { get; set; }

        public XPCalc()
        {
            layout = new StackLayout { Padding = new Thickness(15, 15) };
            var scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;
            labelPicker = new Label { Text = "Your list of monsters with the amount of candies", TextColor = Color.Black, FontSize = 16 };
            picker = new ListView
            {
                HeightRequest = 75
            };
            picker.ItemTapped += OnTap;

            labelMonsterToAdd = new Label { Text = "Add every monster you wish to evolve", TextColor = Color.Black, FontSize = 16 };

            //Go through each Pokemon and add them to the list.
            pickerMonsterToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };
            foreach (string pokemon in pokemonData.listOfPokemon.Keys)
            {
                pickerMonsterToAdd.Items.Add(pokemon);
            }

            labelInputCandies = new Label { Text = "Candies", TextColor = Color.Black, FontSize = 14 };
            inputCandies = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            btnAddMonsterToList = new Button
            {
                Text = "Add monster to list",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            btnAddMonsterToList.Clicked += btnAddMonsterToList_OnClick;

            btnCalculate = new Button
            {
                Text = "Calculate",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex("#42A5F5"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            btnCalculate.Clicked += btnCalculate_OnClick ;

            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelMonsterToAdd);
            layout.Children.Add(pickerMonsterToAdd);
            layout.Children.Add(labelInputCandies);
            layout.Children.Add(inputCandies);
            layout.Children.Add(btnAddMonsterToList);
            layout.Children.Add(btnCalculate);
        }

        void btnAddMonsterToList_OnClick(object sender, EventArgs e)
        {
            //Check if all fields were filled in
            if((pickerMonsterToAdd.SelectedIndex > 0) && !string.IsNullOrEmpty(inputCandies.Text))
            {
                picker.ItemsSource = listOfAddedMonsters;
                listOfAddedMonsters.Add(pickerMonsterToAdd.Items[pickerMonsterToAdd.SelectedIndex] + ">" + inputCandies.Text);
            }
            else
            {
                DisplayAlert("Oops, try again!", "Make sure that you choosed a monster with the corresponding candies!", "OK");
            }

        }

        void btnCalculate_OnClick(object sender, EventArgs e)
        {
            if ((pickerMonsterToAdd.SelectedIndex >= 0) && !string.IsNullOrEmpty(inputCandies.Text))
            {
                //Copy the list with all pokemon that the user added, this list may be altered etc
                ObservableCollection<string> listOfAddedMonstersTemp = listOfAddedMonsters;



                ObservableCollection<string> pokemonList = new ObservableCollection<string>();
                List<int> pokemonCandies = new List<int>();
                //List<Pokemon> listOfConvertedPokemon = new List<Pokemon>();
                foreach (var pokemon in listOfAddedMonstersTemp.ToList())
                {
                    //Split at space so we can seperate the full pokemon name and amount of candies
                    char splitChar = '>';

                    string[] singlePokemon = pokemon.Split(splitChar);

                    string tempName = singlePokemon[0];
                    int tempCandies = int.Parse(singlePokemon[1]);

                    if (listOfAddedMonstersTemp.Contains(tempName + splitChar + tempCandies))
                    {
                        //Let's check if we already have that pokemon in our list, we don't want duplicates in this list.
                        if (pokemonList.Contains(tempName))
                        {
                            //We found a duplicate name, just add the candies to this one.
                            //Find the index number of the pokemon
                            int index = pokemonList.IndexOf(tempName);

                            //Use same index number to find the corresponding candies
                            pokemonCandies[index] += tempCandies;
                        }
                        else
                        {
                            //First occurence, add it to the list
                            pokemonList.Add(tempName);
                            pokemonCandies.Add(tempCandies);
                        }

                        //After we located the pokemon in the list, we no longer need it after counting the candies
                        listOfAddedMonstersTemp.Remove(tempName + splitChar + tempCandies);
                    }
                    else
                    {
                    }
                    //listOfConvertedPokemon.Add(newPoke);
                }

                //Clear the whole layout and make the result layout
                layout.Children.Clear();

                //Add our new controls to the blank layout
                var labelInfo = new Label { Text = "Total amount of candies per monster you added", TextColor = Color.Black, FontSize = 16 };
                resultsList = new ListView
                {
                    HeightRequest = 75
                };

                //Some variables to use: it takes 12 to 15 seconds for EACH evolution, and EACH evolution grants the user 500xp
                int amountOfEvolutions = 0;
                int amountOfXPPerEvo = 500;
                int minSecondsPerEvo = 12;
                int maxSecondsPerEvo = 15;

                //The pokemonlist only contained names, now we are going to add the corresponding candies to it
                for (int i = 0; i < pokemonList.Count; i++)
                {
                    //Look up the pokemon and know with what to divide with (e.g. Bulbasaur = 25 candies)
                    int candyCost = calcAmountOfEvolvesPossible(pokemonList[i]);
                    pokemonList[i] = pokemonList[i] + ": " + pokemonCandies[i] + " candies / " + candyCost + " = " + (pokemonCandies[i] / candyCost) + " times";
                    amountOfEvolutions += (pokemonCandies[i] / candyCost);
                }

                int XPGained = amountOfEvolutions * amountOfXPPerEvo;
                int minTimeMin = (amountOfEvolutions * minSecondsPerEvo) / 60;
                int maxTimeMin = (amountOfEvolutions * maxSecondsPerEvo) / 60;
                int luckyEggDuration = 1800;
                var labelConclusionTitle = new Label { Text = "PokéBro thinks that..", TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 25, HorizontalTextAlignment = TextAlignment.Center, VerticalOptions = LayoutOptions.Start };
                var labelConclusionText = new Label { Text = string.Format("You can make {0}XP in {1} to {2} minutes. You should use {4} lucky egg(s) to get {5}XP!\n\nThe total amount of evolve(s) is {3} time(s).", XPGained, minTimeMin, maxTimeMin, amountOfEvolutions, (maxTimeMin*60) / luckyEggDuration, XPGained*2), TextColor = Color.Black, FontSize = 18 };

                //The list has been combined with candies, display this to the user in the listview
                resultsList.ItemsSource = pokemonList;

                var btnGoBack = new Button
                {
                    Text = "Go back",
                    Font = Font.SystemFontOfSize(NamedSize.Large),
                    BorderWidth = 1,
                    BackgroundColor = Color.FromHex("#42A5F5"),
                    TextColor = Color.White,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.EndAndExpand
                };
                btnGoBack.Clicked += btnGoBack_OnClick;

                //Add everything to the layout so it will really get displayed, else it will be invisible.
                layout.Children.Add(labelInfo);
                layout.Children.Add(resultsList);
                layout.Children.Add(labelConclusionTitle);
                layout.Children.Add(labelConclusionText);
                layout.Children.Add(btnGoBack);
                //Loop through each pokemon (this time without duplicates!) and show the total candies


                //DisplayAlert("Finished", "You added this amount:" + pokemonList.Count, "OK"); 
            }
            else
            {
                DisplayAlert("Oops, try again!", "Make sure that you choosed a monster with the corresponding candies!", "OK");
            }
        }
        
        void btnGoBack_OnClick(object sender, EventArgs e)
        {
            layout.Children.Clear();
            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelMonsterToAdd);
            layout.Children.Add(pickerMonsterToAdd);
            layout.Children.Add(labelInputCandies);
            layout.Children.Add(inputCandies);
            layout.Children.Add(btnAddMonsterToList);
            layout.Children.Add(btnCalculate);
        }

        private int calcAmountOfEvolvesPossible(string name)
        {
            switch(name)
            {
                case "Bulbasaur":
                    return 25;
                case "Ivysaur":
                    return 100;
                case "Venusaur":
                    return 0;
                case "Charmander":
                    return 25;
                case "Charmeleon":
                    return 100;
                case "Charizard":
                    return 0;
                case "Squirtle":
                    return 25;
                case "Wartortle":
                    return 100;
                case "Blastoise":
                    return 0;
                case "Caterpie":
                    return 12;
                case "Metapod":
                    return 50;
                case "Butterfree":
                    return 0;
                case "Weedle":
                    return 12;
                case "Kakuna":
                    return 50;
                //case "Beedrill":
                //    return PokemonName.Beedrill;
                //case "Pidgey":
                //    return PokemonName.Pidgey;
                //case "Pidgeotto":
                //    return PokemonName.Pidgeotto;
                //case "Pidgeot":
                //    return PokemonName.Pidgeot;
                //case "Rattata":
                //    return PokemonName.Rattata;
                //case "Raticate":
                //    return PokemonName.Raticate;
                //case "Spearow":
                //    return PokemonName.Spearow;
                //case "Fearow":
                //    return PokemonName.Fearow;
                //case "Ekans":
                //    return PokemonName.Ekans;
                //case "Arbok":
                //    return PokemonName.Arbok;
                //case "Pikachu":
                //    return PokemonName.Pikachu;
                //case "Raichu":
                //    return PokemonName.Raichu;
                //case "Sandshrew":
                //    return PokemonName.Sandshrew;
                //case "Sandslash":
                //    return PokemonName.Sandslash;
                //case "Nidoran♀":
                //    return PokemonName.NidoranF;
                //case "Nidorina":
                //    return PokemonName.Nidorina;
                //case "Nidoqueen":
                //    return PokemonName.Nidoqueen;
                //case "Nidoran♂":
                //    return PokemonName.NidoranM;
                //case "Nidorino":
                //    return PokemonName.Nidorino;
                //case "Nidoking":
                //    return PokemonName.Nidoking;
                //case "Clefairy":
                //    return PokemonName.Clefairy;
                //case "Clefable":
                //    return PokemonName.Clefable;
                //case "Vulpix":
                //    return PokemonName.Vulpix;
                //case "Ninetales":
                //    return PokemonName.Ninetales;
                //case "Jigglypuff":
                //    return PokemonName.Jigglypuff;
                //case "Wigglytuff":
                //    return PokemonName.Wigglytuff;
                //case "Zubat":
                //    return PokemonName.Zubat;
                //case "Golbat":
                //    return PokemonName.Golbat;
                //case "Oddish":
                //    return PokemonName.Oddish;
                //case "Gloom":
                //    return PokemonName.Gloom;
                //case "Vileplume":
                //    return PokemonName.Vileplume;
                //case "Paras":
                //    return PokemonName.Paras;
                //case "Parasect":
                //    return PokemonName.Parasect;
                //case "Venonat":
                //    return PokemonName.Venonat;
                //case "Venomoth":
                //    return PokemonName.Venomoth;
                //case "Diglett":
                //    return PokemonName.Diglett;
                //case "Dugtrio":
                //    return PokemonName.Dugtrio;
                //case "Meowth":
                //    return PokemonName.Meowth;
                //case "Persian":
                //    return PokemonName.Persian;
                //case "Psyduck":
                //    return PokemonName.Psyduck;
                //case "Golduck":
                //    return PokemonName.Golduck;
                //case "Mankey":
                //    return PokemonName.Mankey;
                //case "Primeape":
                //    return PokemonName.Primeape;
                //case "Growlithe":
                //    return PokemonName.Growlithe;
                //case "Arcanine":
                //    return PokemonName.Arcanine;
                //case "Poliwag":
                //    return PokemonName.Poliwag;
                //case "Poliwhirl":
                //    return PokemonName.Poliwhirl;
                //case "Poliwrath":
                //    return PokemonName.Poliwrath;
                //case "Abra":
                //    return PokemonName.Abra;
                //case "Kadabra":
                //    return PokemonName.Kadabra;
                //case "Alakazam":
                //    return PokemonName.Alakazam;
                //case "Machop":
                //    return PokemonName.Machop;
                //case "Machoke":
                //    return PokemonName.Machoke;
                //case "Machamp":
                //    return PokemonName.Machamp;
                //case "Bellsprout":
                //    return PokemonName.Bellsprout;
                //case "Weepinbell":
                //    return PokemonName.Weepinbell;
                //case "Victreebel":
                //    return PokemonName.Victreebel;
                //case "Tentacool":
                //    return PokemonName.Tentacool;
                //case "Tentacruel":
                //    return PokemonName.Tentacruel;
                //case "Geodude":
                //    return PokemonName.Geodude;
                //case "Graveler":
                //    return PokemonName.Graveler;
                //case "Golem":
                //    return PokemonName.Golem;
                //case "Ponyta":
                //    return PokemonName.Ponyta;
                //case "Rapidash":
                //    return PokemonName.Rapidash;
                //case "Slowpoke":
                //    return PokemonName.Slowpoke;
                //case "Slowbro":
                //    return PokemonName.Slowbro;
                //case "Magnemite":
                //    return PokemonName.Magnemite;
                //case "Magneton":
                //    return PokemonName.Magneton;
                //case "Farfetch'd":
                //    return PokemonName.Farfetchd;
                //case "Doduo":
                //    return PokemonName.Doduo;
                //case "Dodrio":
                //    return PokemonName.Dodrio;
                //case "Seel":
                //    return PokemonName.Seel;
                //case "Dewgong":
                //    return PokemonName.Dewgong;
                //case "Grimer":
                //    return PokemonName.Grimer;
                //case "Muk":
                //    return PokemonName.Muk;
                //case "Shellder":
                //    return PokemonName.Shellder;
                //case "Cloyster":
                //    return PokemonName.Cloyster;
                //case "Gastly":
                //    return PokemonName.Gastly;
                //case "Haunter":
                //    return PokemonName.Haunter;
                //case "Gengar":
                //    return PokemonName.Gengar;
                //case "Onix":
                //    return PokemonName.Onix;
                //case "Drowzee":
                //    return PokemonName.Drowzee;
                //case "Hypno":
                //    return PokemonName.Hypno;
                //case "Krabby":
                //    return PokemonName.Krabby;
                //case "Kingler":
                //    return PokemonName.Kingler;
                //case "Voltorb":
                //    return PokemonName.Voltorb;
                //case "Electrode":
                //    return PokemonName.Electrode;
                //case "Exeggcute":
                //    return PokemonName.Exeggcute;
                //case "Exeggutor":
                //    return PokemonName.Exeggutor;
                //case "Cubone":
                //    return PokemonName.Cubone;
                //case "Marowak":
                //    return PokemonName.Marowak;
                //case "Hitmonlee":
                //    return PokemonName.Hitmonlee;
                //case "Hitmonchan":
                //    return PokemonName.Hitmonchan;
                //case "Lickitung":
                //    return PokemonName.Lickitung;
                //case "Koffing":
                //    return PokemonName.Koffing;
                //case "Weezing":
                //    return PokemonName.Weezing;
                //case "Rhyhorn":
                //    return PokemonName.Rhyhorn;
                //case "Rhydon":
                //    return PokemonName.Rhydon;
                //case "Chansey":
                //    return PokemonName.Chansey;
                //case "Tangela":
                //    return PokemonName.Tangela;
                //case "Kangaskhan":
                //    return PokemonName.Kangaskhan;
                //case "Horsea":
                //    return PokemonName.Horsea;
                //case "Seadra":
                //    return PokemonName.Seadra;
                //case "Goldeen":
                //    return PokemonName.Goldeen;
                //case "Seaking":
                //    return PokemonName.Seaking;
                //case "Staryu":
                //    return PokemonName.Staryu;
                //case "Starmie":
                //    return PokemonName.Starmie;
                //case "Mr. Mime":
                //    return PokemonName.MrMime;
                //case "Scyther":
                //    return PokemonName.Scyther;
                //case "Jynx":
                //    return PokemonName.Jynx;
                //case "Electabuzz":
                //    return PokemonName.Electabuzz;
                //case "Magmar":
                //    return PokemonName.Magmar;
                //case "Pinsir":
                //    return PokemonName.Pinsir;
                //case "Tauros":
                //    return PokemonName.Tauros;
                //case "Magikarp":
                //    return PokemonName.Magikarp;
                //case "Gyarados":
                //    return PokemonName.Gyarados;
                //case "Lapras":
                //    return PokemonName.Lapras;
                //case "Ditto":
                //    return PokemonName.Ditto;
                //case "Eevee":
                //    return PokemonName.Eevee;
                //case "Vaporeon":
                //    return PokemonName.Vaporeon;
                //case "Jolteon":
                //    return PokemonName.Jolteon;
                //case "Flareon":
                //    return PokemonName.Flareon;
                //case "Porygon":
                //    return PokemonName.Porygon;
                //case "Omanyte":
                //    return PokemonName.Omanyte;
                //case "Omastar":
                //    return PokemonName.Omastar;
                //case "Kabuto":
                //    return PokemonName.Kabuto;
                //case "Kabutops":
                //    return PokemonName.Kabutops;
                //case "Aerodactyl":
                //    return PokemonName.Aerodactyl;
                //case "Snorlax":
                //    return PokemonName.Snorlax;
                //case "Articuno":
                //    return PokemonName.Articuno;
                //case "Zapdos":
                //    return PokemonName.Zapdos;
                //case "Moltres":
                //    return PokemonName.Moltres;
                //case "Dratini":
                //    return PokemonName.Dratini;
                //case "Dragonair":
                //    return PokemonName.Dragonair;
                //case "Dragonite":
                //    return PokemonName.Dragonite;
                //case "Mew":
                //    return PokemonName.Mew;
                //case "Mewtwo":
                //    return PokemonName.Mewtwo;
                default:
                    return 999;
            }
        }

        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            var answer = await DisplayAlert("Are you sure?", string.Format("Would you like to remove {0} from the list?", e.Item.ToString()), "Yes remove it", "No");
            if(answer == true)
            {
                listOfAddedMonsters.Remove(e.Item.ToString());
            }
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }
    }
}