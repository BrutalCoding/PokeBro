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
            if((pickerMonsterToAdd.SelectedIndex >= 0) && !string.IsNullOrEmpty(inputCandies.Text))
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
                    if (candyCost != 0)
                    {
                        pokemonList[i] = pokemonList[i] + ": " + pokemonCandies[i] + " candies / " + candyCost + " = " + (pokemonCandies[i] / candyCost) + " times";
                        amountOfEvolutions += (pokemonCandies[i] / candyCost);
                    }
                    else
                    {
                        break;
                    }
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
                case "Beedrill":
                    return 0;
                case "Pidgey":
                    return 12;
                case "Pidgeotto":
                    return 50;
                case "Pidgeot":
                    return 0;
                case "Rattata":
                    return 25;
                case "Raticate":
                    return 0;
                case "Spearow":
                    return 50;
                case "Fearow":
                    return 0;
                case "Ekans":
                    return 50;
                case "Arbok":
                    return 0;
                case "Pikachu":
                    return 50;
                case "Raichu":
                    return 0;
                case "Sandshrew":
                    return 50;
                case "Sandslash":
                    return 0;
                case "Nidoran♀":
                    return 25;
                case "Nidorina":
                    return 100;
                case "Nidoqueen":
                    return 0;
                case "Nidoran♂":
                    return 25;
                case "Nidorino":
                    return 0;
                case "Nidoking":
                    return 0;
                case "Clefairy":
                    return 50;
                case "Clefable":
                    return 0;
                case "Vulpix":
                    return 50;
                case "Ninetales":
                    return 0;
                case "Jigglypuff":
                    return 50;
                case "Wigglytuff":
                    return 0;
                case "Zubat":
                    return 50;
                case "Golbat":
                    return 0;
                case "Oddish":
                    return 100;
                case "Gloom":
                    return 0;
                case "Vileplume":
                    return 0;
                case "Paras":
                    return 50;
                case "Parasect":
                    return 0;
                case "Venonat":
                    return 50;
                case "Venomoth":
                    return 0;
                case "Diglett":
                    return 50;
                case "Dugtrio":
                    return 0;
                case "Meowth":
                    return 50;
                case "Persian":
                    return 0;
                case "Psyduck":
                    return 50;
                case "Golduck":
                    return 0;
                case "Mankey":
                    return 50;
                case "Primeape":
                    return 0;
                case "Growlithe":
                    return 50;
                case "Arcanine":
                    return 0;
                case "Poliwag":
                    return 25;
                case "Poliwhirl":
                    return 100;
                case "Poliwrath":
                    return 0;
                case "Abra":
                    return 25;
                case "Kadabra":
                    return 100;
                case "Alakazam":
                    return 0;
                case "Machop":
                    return 25;
                case "Machoke":
                    return 100;
                case "Machamp":
                    return 0;
                case "Bellsprout":
                    return 25;
                case "Weepinbell":
                    return 100;
                case "Victreebel":
                    return 0;
                case "Tentacool":
                    return 50;
                case "Tentacruel":
                    return 0;
                case "Geodude":
                    return 25;
                case "Graveler":
                    return 100;
                case "Golem":
                    return 0;
                case "Ponyta":
                    return 50;
                case "Rapidash":
                    return 0;
                case "Slowpoke":
                    return 50;
                case "Slowbro":
                    return 0;
                case "Magnemite":
                    return 50;
                case "Magneton":
                    return 0;
                case "Farfetch'd":
                    return 0;
                case "Doduo":
                    return 50;
                case "Dodrio":
                    return 0;
                case "Seel":
                    return 50;
                case "Dewgong":
                    return 0;
                case "Grimer":
                    return 50;
                case "Muk":
                    return 0;
                case "Shellder":
                    return 50;
                case "Cloyster":
                    return 0;
                case "Gastly":
                    return 25;
                case "Haunter":
                    return 100;
                case "Gengar":
                    return 0;
                case "Onix":
                    return 0;
                case "Drowzee":
                    return 50;
                case "Hypno":
                    return 0;
                case "Krabby":
                    return 50;
                case "Kingler":
                    return 0;
                case "Voltorb":
                    return 50;
                case "Electrode":
                    return 0;
                case "Exeggcute":
                    return 50;
                case "Exeggutor":
                    return 0;
                case "Cubone":
                    return 50;
                case "Marowak":
                    return 0;
                case "Hitmonlee":
                    return 0;
                case "Hitmonchan":
                    return 0;
                case "Lickitung":
                    return 0;
                case "Koffing":
                    return 50;
                case "Weezing":
                    return 0;
                case "Rhyhorn":
                    return 50;
                case "Rhydon":
                    return 0;
                case "Chansey":
                    return 0;
                case "Tangela":
                    return 0;
                case "Kangaskhan":
                    return 0;
                case "Horsea":
                    return 50;
                case "Seadra":
                    return 0;
                case "Goldeen":
                    return 50;
                case "Seaking":
                    return 0;
                case "Staryu":
                    return 50;
                case "Starmie":
                    return 0;
                case "Mr. Mime":
                    return 0;
                case "Scyther":
                    return 0;
                case "Jynx":
                    return 0;
                case "Electabuzz":
                    return 0;
                case "Magmar":
                    return 0;
                case "Pinsir":
                    return 0;
                case "Tauros":
                    return 0;
                case "Magikarp":
                    return 400;
                case "Gyarados":
                    return 0;
                case "Lapras":
                    return 0;
                case "Ditto":
                    return 0;
                case "Eevee":
                    return 25;
                case "Vaporeon":
                    return 0;
                case "Jolteon":
                    return 0;
                case "Flareon":
                    return 0;
                case "Porygon":
                    return 0;
                case "Omanyte":
                    return 50;
                case "Omastar":
                    return 0;
                case "Kabuto":
                    return 50;
                case "Kabutops":
                    return 0;
                case "Aerodactyl":
                    return 0;
                case "Snorlax":
                    return 0;
                case "Articuno":
                    return 0;
                case "Zapdos":
                    return 0;
                case "Moltres":
                    return 0;
                case "Dratini":
                    return 25;
                case "Dragonair":
                    return 100;
                case "Dragonite":
                    return 0;
                case "Mew":
                    return 0;
                case "Mewtwo":
                    return 0;
                default:
                    return 999999;
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