using Xamarin.Forms;

namespace PokeBro
{
    internal class PageTabs : TabbedPage
    {
        public PageTabs()
        {
            Title = "PokéBro - All In One Guide";
            ToolbarItems.Add(new ToolbarItem("Share", "ic_share_white_24dp.png", () =>
            {
            }));
            Children.Add(new About() { Title = "Start" });
            Children.Add(new BattleHelper() { Title = "Battle Helper" });
            Children.Add(new XPCalc() { Title = "XP Calc" });
            Children.Add(new IVCalc() { Title = "IV Calc" });
            //Children.Add(new Badges() { Title = "Badges" });

        }
    }
}