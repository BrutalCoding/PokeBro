using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PokeBro
{
    internal class IVCalc : ContentPage
    {
        //Create the class PD so we can access all Pokemon data.
        PokemonData pokemonData = new PokemonData();

        public Entry inputCP { get; set; }
        public Entry inputHP { get; set; }
        Picker picker;
        public IVCalc()
        {
            var layout = new StackLayout { Padding = new Thickness(15,15) };
            Content = layout;
            var labelPicker = new Label { Text = "Choose your monster", TextColor = Color.Black, FontSize = 20};

            //Go through each Pokemon and add them to the list.
            picker = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(0, 0, 0, 50)
            };

            foreach (string pokemon in pokemonData.listOfPokemon.Keys)
            {
                picker.Items.Add(pokemon);
            }

            var labelInputCP = new Label { Text = "CP", TextColor = Color.Black, FontSize = 14 };
            inputCP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var labelInputHP = new Label { Text = "HP", TextColor = Color.Black, FontSize = 14 };
            inputHP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var labelInputStartdust = new Label { Text = "Stardust", TextColor = Color.Black, FontSize = 14 };
            var inputStartdust = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var labelSwitch = new Label { Text = "I have power upped this monster", TextColor = Color.Black, FontSize = 14 };
            Switch switcher = new Switch { HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start};
            switcher.Toggled += switcher_Toggled;

            var btnCalculate = new Button {
                Text = "Calculate",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex("#42A5F5"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnCalculate.Clicked += OnButtonClicked;

            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelInputCP);
            layout.Children.Add(inputCP);
            layout.Children.Add(labelInputHP);
            layout.Children.Add(inputHP);
            layout.Children.Add(labelInputStartdust);
            layout.Children.Add(inputStartdust);
            layout.Children.Add(labelSwitch);
            layout.Children.Add(switcher);
            layout.Children.Add(btnCalculate);
        }

        void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            //The chosen pokemon has been power upped, which will give a different result
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            //Formula from this reddit thread: https://www.reddit.com/r/TheSilphRoad/comments/4t7r4d/exact_pokemon_cp_formula/

            double baseAttack = pokemonData.listOfPokemon[picker.Items[picker.SelectedIndex]].attack;
            double baseDefense = pokemonData.listOfPokemon[picker.Items[picker.SelectedIndex]].defense;
            double baseStamina = pokemonData.listOfPokemon[picker.Items[picker.SelectedIndex]].stamina;

            DisplayAlert(picker.Items[picker.SelectedIndex], String.Format("Attack: {0} | Def: {1} | Stamina: {2} \n It", baseAttack.ToString(), baseDefense.ToString(), baseStamina.ToString()), "OK");
            //double IV = 0;
            //double MaxCP = 0.1 * ((baseAttack + IV) * (baseDefense + IV) ^ 0.5 * (baseStamina + IV) ^ 0.5 * (CpM + ACpM) ^ 2);

        }
    }
}