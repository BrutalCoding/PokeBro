using System.Collections.Generic;
using Xamarin.Forms;

namespace PokeBro
{
    internal class IVCalc : ContentPage
    {
        // Dictionary to get Color from color name.
        List<string> listOfPokemon = new List<string>
        {
            { "Abra"},
            { "Aero"}
        };

        public IVCalc()
        {
            var layout = new StackLayout { Padding = new Thickness(15,15) };
            Content = layout;
            var labelPicker = new Label { Text = "Choose your monster", TextColor = Color.Black, FontSize = 20};

            //Go through each Pokemon and add them to the list.
            Picker picker = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };

            foreach (string pokemon in listOfPokemon)
            {
                picker.Items.Add(pokemon);
            }

            var labelInputCP = new Label { Text = "CP", TextColor = Color.Black, FontSize = 14 };
            var inputCP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var labelInputHP = new Label { Text = "HP", TextColor = Color.Black, FontSize = 14 };
            var inputHP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var labelInputStartdust = new Label { Text = "Stardust", TextColor = Color.Black, FontSize = 14 };
            var inputStartdust = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelInputCP);
            layout.Children.Add(inputCP);
            layout.Children.Add(labelInputHP);
            layout.Children.Add(inputHP);
            layout.Children.Add(labelInputStartdust);
            layout.Children.Add(inputStartdust);
        }
    }
}