using Plugin.Share;
using Xamarin.Forms;

namespace PokeBro
{
    internal class PageTabs : TabbedPage
    {
        public PageTabs()
        {
            Title = "PokéBro - Your Very Own Pocket Bro!";

            //Share button details
            var title = "PokéBro";
            var message = "Sup, need a bro who can help you with Pokémon? Look in the Play Store for 'PokéBro - All In One Guide'!";
            //var url = ""; //Link of the app in the Play Store
            ToolbarItems.Add(new ToolbarItem("Share", "ic_share_white_24dp.png", async () =>
            {
                // Share message and an optional title.
                await CrossShare.Current.Share(message, title);
            }));

            Children.Add(new About() { Title = "Start" });
            Children.Add(new BattleHelper() { Title = "Battle Helper" });
            Children.Add(new XPCalc() { Title = "XP Calc" });
            Children.Add(new IVCalc() { Title = "IV Calc" });
            //Children.Add(new Badges() { Title = "Badges" });

        }
    }
}