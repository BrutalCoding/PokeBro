using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PokeBro
{
    internal class IVCalc : ContentPage
    {
        //Create the class PD so we can access all Pokemon data.
        PokemonData pokemonData = new PokemonData();

        public Entry inputCP { get; set; }
        public Entry inputHP { get; set; }
        public Entry inputStardust { get; set; }
        Picker picker;
        public IVCalc()
        {
            var layout = new StackLayout { Padding = new Thickness(15,15) };
            var scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;
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

            var labelInputStardust = new Label { Text = "Stardust", TextColor = Color.Black, FontSize = 14 };
            inputStardust = new Entry { Text = "", Keyboard = Keyboard.Numeric };

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
            layout.Children.Add(labelInputStardust);
            layout.Children.Add(inputStardust);
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
            var newPoke = new Pokemon()
            {
                CP = int.Parse(inputCP.Text),
                Health = int.Parse(inputHP.Text),
                GivenName = picker.Items[picker.SelectedIndex],
                Stardust = int.Parse(inputStardust.Text)
            };
            newPoke.Calculate();
            ShowStats(newPoke);
            //DisplayAlert(picker.Items[picker.SelectedIndex], String.Format("Attack: {0} | Def: {1} | Stamina: {2} \nCombinations possible: {3}", newPoke.FastAttack, baseDefense.ToString(), baseStamina.ToString(), newPoke.Levels.Count), "OK");
        }

        private void ShowStats(Pokemon pokemon)
        {
            double max = 0, min = 100, avg = 0;
            int cnt = 0;
            foreach (var stats in pokemon.Levels.Select(levels => new StatSet(levels.Level, levels.Siv, levels.Aiv, levels.Div,
                (cnt - 5) / 5 * 27 + 27, ref max, ref min, ref avg)))
            {
                cnt += 5;
            }

            inputCP.Text = $"{max / 45:P0}";
            inputHP.Text = $"{min / 45:P0}";
            inputStardust.Text = $"{avg / pokemon.Levels.Count / 45:P0}";
        }

        private struct StatSet
        {
            public readonly Label Lvl;
            public readonly Label Sta;
            public readonly Label Atk;
            public readonly Label Def;
            public readonly Label Perfection;

            public StatSet(double level, int sta, int atk, int def, int y, ref double max, ref double min, ref double avg)
            {
                Lvl = new Label()
                {
                    Text = level.ToString()
                };

                Sta = new Label()
                {
                    Text = sta.ToString()
                };
                Atk = new Label()
                {
                    Text = atk.ToString()
                };
                Def = new Label()
                {
                    Text = def.ToString()
                };
                Perfection = new Label()
                {
                    Text = $"{(double)(atk + def + sta) / 45:P}"
                };
                max = max < atk + def + sta ? atk + def + sta : max;
                min = min > atk + def + sta ? atk + def + sta : min;
                avg += atk + def + sta;
            }
        }
    }
}