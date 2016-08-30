using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace PokeBro
{
    internal class BattleHelper : ContentPage
    {
        StackLayout layout;
        ScrollView scrollview;
        SortedDictionary<string, Pokemon> pokesTemp;
        Label labelMonster1Text;
        Label labelVersus;
        Label labelMonster2Text;
        Picker pickerMonster1ToAdd;
        Picker pickerMonster2ToAdd;
        //PokemonData pokemonData = new PokemonData();
        PokemonBaseStats pokemonData = new PokemonBaseStats();
        Button btnCalculate;

        Label labelInfoType;
        Label labelInfoEffective;
        public BattleHelper()
        {
            layout = new StackLayout { Padding = new Thickness(15, 15) };
            scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;

            //Load all pokemon data
            pokemonData.LoadPokes();
            pokemonData.LoadTypes();

            //We want the list from pokemondata converted to ObservableCollection so we can order it
            pokesTemp = new SortedDictionary<string, Pokemon>();
            foreach (var poke in pokemonData.pokes)
                pokesTemp.Add(poke.Name.ToString(), poke);
            

            labelMonster1Text = new Label { Text = "Monster 1", TextColor = Color.Black, FontSize = 25, VerticalTextAlignment = TextAlignment.Center };
            //Go through each Pokemon and add them to the list.
            pickerMonster1ToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };
            foreach (string pokemon in pokesTemp.Keys)
            {
                pickerMonster1ToAdd.Items.Add(pokemon);
            }
            
            labelVersus = new Label { Text = "Versus", TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 20, HorizontalOptions= LayoutOptions.Center};

            labelMonster2Text = new Label { Text = "Monster 2", TextColor = Color.Black, FontSize = 25, VerticalTextAlignment = TextAlignment.Center };
            //Go through each Pokemon and add them to the list.
            pickerMonster2ToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };
            foreach (string pokemon in pokesTemp.Keys)
            {
                pickerMonster2ToAdd.Items.Add(pokemon);
            }

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
            btnCalculate.Clicked += btnCalculate_OnClick;

            layout.Children.Add(labelMonster1Text);
            layout.Children.Add(pickerMonster1ToAdd);
            layout.Children.Add(labelVersus);
            layout.Children.Add(labelMonster2Text);
            layout.Children.Add(pickerMonster2ToAdd);
            layout.Children.Add(btnCalculate);
        }

        private void btnCalculate_OnClick(object sender, EventArgs e)
        {
            //Check if all fields were filled in
            if(pickerMonster1ToAdd.SelectedIndex >= 0 && pickerMonster2ToAdd.SelectedIndex >= 0)
            {
                var pokemonList = pokemonData.pokes;
                var pokemonTypes = pokemonData.pokeTypes;

                //Find the selected items
                string monster1Name = pickerMonster1ToAdd.Items[pickerMonster1ToAdd.SelectedIndex];
                string monster2Name = pickerMonster2ToAdd.Items[pickerMonster2ToAdd.SelectedIndex];

                //Prepare the variables, we use 62 (Abra) as placeholder
                Pokemon monster1 = pokemonData.pokes[62];
                Pokemon monster2 = pokemonData.pokes[62];

                //Find the real data from these names
                foreach(var pokemon in pokesTemp)
                {
                    if(pokemon.Key == monster1Name)
                    {
                        monster1 = pokemon.Value;
                    }

                    if(pokemon.Key == monster2Name)
                    {
                        monster2 = pokemon.Value;
                    }
                }

                //Some pokemon don't have a 2nd type, so we check this first before adding the text
                string monster1HasSecType = "";
                string monster2HasSecType = "";
                if (!string.IsNullOrEmpty(monster1.Type2))
                    monster1HasSecType = " and " + monster1.Type2 + " ";
                if (!string.IsNullOrEmpty(monster2.Type2))
                    monster2HasSecType = " and " + monster2.Type2 + " ";

                //Lets create the text to show what the results are
                labelInfoType = new Label { Text = string.Format("Alright lets see what we got here..\n{0} has {2}{3} while {1} has {4}{5}", monster1.Name, monster2.Name, monster1.Type1, monster1HasSecType, monster2.Type1, monster2HasSecType), TextColor = Color.Black, FontSize = 18, HorizontalOptions = LayoutOptions.Center, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.End };
                labelInfoEffective = new Label { Text = string.Format("Hmm, sorry bro, your {0} doesn't have effective moves against {1}!", monster1.Name, monster2.Name), FontSize = 14, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center};
                foreach (var type in pokemonTypes)
                {
                    if(type.PokeType == monster1.Type1 || type.PokeType == monster1.Type2)
                    {
                        //We found the type in the list, now lets check if it is effective against monster 2
                        foreach(var effective in type.EffectiveAgainst)
                        {
                            if(effective == monster2.Type1 || effective == monster2.Type2)
                            {
                                labelInfoEffective = new Label { Text = string.Format("{0} has {1} which is effective against {3}. That's because {1} is more powerful than {2}!", monster1.Name, type.PokeType, effective, monster2.Name), TextColor = Color.Black, FontSize = 20, VerticalTextAlignment = TextAlignment.End };
                            }
                        }
                    }
                }

                //Remove the labels to avoid old answers
                layout.Children.Clear();

                //Add everything back
                layout.Children.Add(labelMonster1Text);
                layout.Children.Add(pickerMonster1ToAdd);
                layout.Children.Add(labelVersus);
                layout.Children.Add(labelMonster2Text);
                layout.Children.Add(pickerMonster2ToAdd);

                //Now add the fresh answers
                layout.Children.Add(labelInfoType);
                layout.Children.Add(labelInfoEffective);

                //Now add the button below all other controls
                layout.Children.Add(btnCalculate);
            }
            else
            {
                DisplayAlert("Oops, try again!", "Make sure that monster 1 and 2 are selected!", "OK");
            }
        }
    }
}