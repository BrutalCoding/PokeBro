using Xamarin.Forms;
namespace PokeBro
{
    internal class About : ContentPage
    {
        StackLayout background;
        StackLayout layoutTitleBar;
        StackLayout layoutBody;
        StackLayout layoutFooter;
        public About()
        {
            background = new StackLayout { Padding = new Thickness(15, 15), BackgroundColor = Color.FromHex("#E3F2FD") };
            layoutTitleBar = new StackLayout { Padding = new Thickness(0,15,0,15), BackgroundColor = Color.FromHex("#90CAF9"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start };
            var labelTitle = new Label { Text = "Hi.", TextColor = Color.White, FontAttributes = FontAttributes.Bold, FontSize = 20, HorizontalOptions = LayoutOptions.Center };
            layoutTitleBar.Children.Add(labelTitle);

            layoutBody = new StackLayout { Padding = new Thickness(0, 15, 0, 15), BackgroundColor = Color.FromHex("#BBDEFB"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
            var imageWelcome = new Image { Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center };
            imageWelcome.Source = ImageSource.FromFile("dickbutt_charmander.png");
            layoutBody.Children.Add(imageWelcome);

            layoutFooter = new StackLayout { Padding = new Thickness(0, 5, 0, 5), BackgroundColor = Color.FromHex("#90CAF9"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.End};
            var labelDisclaimer = new Label { Text = "PokéBro is not affiliated with Niantic in any way ", TextColor = Color.White, FontAttributes = FontAttributes.Bold, FontSize = 12, HorizontalOptions = LayoutOptions.Center };
            layoutFooter.Children.Add(labelDisclaimer);

            background.Children.Add(layoutTitleBar);
            background.Children.Add(layoutBody);
            background.Children.Add(layoutFooter);
            Content = background;
        }
    }
}
