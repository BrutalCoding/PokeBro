using System;
using Xamarin.Forms;
namespace PokeBro
{
    internal class BattleHelper : ContentPage
    {
        StackLayout layout;
        Label labelMonster1Text;
        Label labelVersus;
        Label labelMonster2Text;
        Picker pickerMonster1ToAdd;
        Picker pickerMonster2ToAdd;
        PokemonData pokemonData = new PokemonData();
        Button btnCalculate;
        public BattleHelper()
        {
            layout = new StackLayout { Padding = new Thickness(15, 15) };
            var scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;
            labelMonster1Text = new Label { Text = "Monster 1", TextColor = Color.Black, FontSize = 25, VerticalTextAlignment = TextAlignment.Center };
            //Go through each Pokemon and add them to the list.
            pickerMonster1ToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };
            foreach (string pokemon in pokemonData.listOfPokemon.Keys)
            {
                pickerMonster1ToAdd.Items.Add(pokemon);
            }
            
            labelVersus = new Label { Text = "Versus", TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 20, VerticalTextAlignment = TextAlignment.Center };

            labelMonster2Text = new Label { Text = "Monster 2", TextColor = Color.Black, FontSize = 25, VerticalTextAlignment = TextAlignment.Center };
            //Go through each Pokemon and add them to the list.
            pickerMonster2ToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start
            };
            foreach (string pokemon in pokemonData.listOfPokemon.Keys)
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
                DisplayAlert("And the winner is..", string.Format(""), "OK");
            }
            else
            {
                DisplayAlert("Oops, try again!", "Make sure that monster 1 and 2 are selected!", "OK");
            }
        }
    }
}