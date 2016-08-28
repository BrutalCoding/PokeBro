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

        //Define layout so we can adjust it from every method
        StackLayout layout;
        Entry inputCP;
        Entry inputHP;
        Entry inputStardust;

        Label labelPicker;
        Label labelInputCP;
        Label labelInputHP;
        Label labelInputStardust;

        Button btnCalculate;
        Button btnGoBack;
        Picker picker;

        string IVScoreAverage;
        string IVScoreBest;
        string IVScoreWorst;

        public IVCalc()
        {
            layout = new StackLayout { Padding = new Thickness(15,15) };
            var scrollview = new ScrollView { Padding = new Thickness(5, 5), Content = layout };
            Content = scrollview;
            labelPicker = new Label { Text = "Choose your monster", TextColor = Color.Black, FontSize = 20};

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

            labelInputCP = new Label { Text = "CP", TextColor = Color.Black, FontSize = 14 };
            inputCP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            labelInputHP = new Label { Text = "HP", TextColor = Color.Black, FontSize = 14 };
            inputHP = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            labelInputStardust = new Label { Text = "Stardust", TextColor = Color.Black, FontSize = 14 };
            inputStardust = new Entry { Text = "", Keyboard = Keyboard.Numeric };

            btnCalculate = new Button {
                Text = "Calculate",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex("#42A5F5"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnCalculate.Clicked += btnCalculate_OnClick;

            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelInputCP);
            layout.Children.Add(inputCP);
            layout.Children.Add(labelInputHP);
            layout.Children.Add(inputHP);
            layout.Children.Add(labelInputStardust);
            layout.Children.Add(inputStardust);
            layout.Children.Add(btnCalculate);
        }

        void btnCalculate_OnClick(object sender, EventArgs e)
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

            layout.Children.Clear();

            var labelPossible = new Label { Text = "Possible combinations", TextColor = Color.Black, FontSize = 25, HorizontalTextAlignment = TextAlignment.Center };
            var labelPossibleAmount = new Label { Text = newPoke.Levels.Count.ToString(), FontAttributes = FontAttributes.Bold, TextColor = Color.Black, FontSize = 35, HorizontalTextAlignment = TextAlignment.Center };
            layout.Children.Add(labelPossible);
            layout.Children.Add(labelPossibleAmount);
            if (newPoke.Levels.Count > 1)
            {
                //If more than 1 combinations are found, inform the user what this means
                var labelNotice = new Label { Text = "More than 1 possibility found, these are your cases: ", TextColor = Color.Black, FontSize = 12, HorizontalTextAlignment = TextAlignment.Center };
                layout.Children.Add(labelNotice);
            }
            var labelMaximum = new Label { Text = "Best: " + IVScoreBest, TextColor = Color.Black, FontSize = 16};
            var labelAverage = new Label { Text = "Average: " + IVScoreAverage, TextColor = Color.Black, FontSize = 16};
            var labelWorst = new Label { Text = "Worst: " + IVScoreWorst, TextColor = Color.Black, FontSize = 16};

            layout.Children.Add(labelMaximum);
            layout.Children.Add(labelAverage);
            layout.Children.Add(labelWorst);
            

            btnGoBack = new Button
            {
                Text = "Calculate",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex("#42A5F5"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btnGoBack.Clicked += btnGoBack_OnClick;

            //DisplayAlert(picker.Items[picker.SelectedIndex], String.Format("Attack: {0} | Def: {1} | Stamina: {2} \nCombinations possible: {3}", newPoke.FastAttack, baseDefense.ToString(), baseStamina.ToString(), newPoke.Levels.Count), "OK");
        }

        void btnGoBack_OnClick(object sender, EventArgs e)
        {
            layout.Children.Clear();
            layout.Children.Add(labelPicker);
            layout.Children.Add(picker);
            layout.Children.Add(labelInputCP);
            layout.Children.Add(inputCP);
            layout.Children.Add(labelInputHP);
            layout.Children.Add(inputHP);
            layout.Children.Add(labelInputStardust);
            layout.Children.Add(inputStardust);
            layout.Children.Add(btnCalculate);
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

            IVScoreBest = $"{max / 45:P0}";
            IVScoreWorst = $"{min / 45:P0}";
            IVScoreAverage= $"{avg / pokemon.Levels.Count / 45:P0}";
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