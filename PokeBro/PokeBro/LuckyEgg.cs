using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PokeBro
{
    internal class LuckyEgg : ContentPage
    {
        //Create the class PD so we can access all Pokemon data.
        PokemonData pokemonData = new PokemonData();

        ObservableCollection<string> listOfAddedMonsters = new ObservableCollection<string>();
        ListView picker;
        Picker pickerMonsterToAdd;
        public Entry inputCandies { get; set; }

        public LuckyEgg()
        {
            var layout = new StackLayout { Padding = new Thickness(15, 15) };
            var scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;
            var labelPicker = new Label { Text = "Your list of monsters (+ amount of candies)", TextColor = Color.Black, FontSize = 16 };
            picker = new ListView();
            picker.ItemTapped += OnTap;

            var labelMonsterToAdd = new Label { Text = "Add every monster you wish to evolve", TextColor = Color.Black, FontSize = 16 };

            //Go through each Pokemon and add them to the list.
            pickerMonsterToAdd = new Picker
            {
                Title = "...",
                VerticalOptions = LayoutOptions.Start,
                Margin = new Thickness(0, 0, 0, 50)
            };
            foreach (string pokemon in pokemonData.listOfPokemon.Keys)
            {
                pickerMonsterToAdd.Items.Add(pokemon);
            }

            var labelInputCandies = new Label { Text = "Candies", TextColor = Color.Black, FontSize = 14 };
            inputCandies = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            var btnAddMonsterToList = new Button
            {
                Text = "Add monster to list",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnAddMonsterToList.Clicked += btnAddMonsterToList_OnClick;

            var btnCalculate = new Button
            {
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
            layout.Children.Add(labelMonsterToAdd);
            layout.Children.Add(pickerMonsterToAdd);
            layout.Children.Add(labelInputCandies);
            layout.Children.Add(inputCandies);
            layout.Children.Add(btnAddMonsterToList);
            layout.Children.Add(btnCalculate);
        }

        void btnAddMonsterToList_OnClick(object sender, EventArgs e)
        {
            //Formula from this reddit thread: https://www.reddit.com/r/TheSilphRoad/comments/4t7r4d/exact_pokemon_cp_formula/
            //DisplayAlert(pickerMonsterToAdd.Items[pickerMonsterToAdd.SelectedIndex], string.Format("Added '{0}' to the list with {1} candies!", pickerMonsterToAdd.Items[pickerMonsterToAdd.SelectedIndex], inputCandies.Text), "OK");
            picker.ItemsSource = listOfAddedMonsters;
            listOfAddedMonsters.Add(pickerMonsterToAdd.Items[pickerMonsterToAdd.SelectedIndex] + " (" + inputCandies.Text + ")");
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            //Formula from this reddit thread: https://www.reddit.com/r/TheSilphRoad/comments/4t7r4d/exact_pokemon_cp_formula/
            //DisplayAlert(pickerMonsterToAdd.Items[pickerMonsterToAdd.SelectedIndex], "Test", "OK");
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