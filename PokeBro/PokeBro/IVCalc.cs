using Xamarin.Forms;

namespace PokeBro
{
    internal class IVCalc : ContentPage
    {
        public IVCalc()
        {
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            Content = layout;
            var label = new Label { Text = "Choose your monster", TextColor = Color.FromHex("#77d065"), FontSize = 20};
            layout.Children.Add(label);
        }
    }
}