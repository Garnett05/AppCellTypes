using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppCellTypes.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCellTypes.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<CelticsPlayers> list = new List<CelticsPlayers>();
            list.Add(new CelticsPlayers() { Name = "Kemba Walker", Position = "Point God" });
            list.Add(new CelticsPlayers() { Name = "Jaylen Brown", Position = "Shooting Guard" });
            list.Add(new CelticsPlayers() { Name = "Jayson Tatum", Position = "Small Foward" });
            list.Add(new CelticsPlayers() { Name = "Gordon Hayward", Position = "Power Foward" });
            list.Add(new CelticsPlayers() { Name = "Marcus Smarf", Position = "Everything/Captain" });

            celticPlayers.ItemsSource = list;
                        
        }
        private void ItemSelectedAction (object sender, SelectedItemChangedEventArgs args)
        {
            CelticsPlayers player = (CelticsPlayers)args.SelectedItem;
            Navigation.PushAsync(new AppCellTypes.Pages.Detail.DetailPage(player));
        }
        private void InjuryAction (object sender, EventArgs args)
        {
            MenuItem button = (MenuItem)sender;
            CelticsPlayers player = (CelticsPlayers)button.CommandParameter;
            DisplayAlert("Title: " + player.Name, "Message: " + player.Name + " - " + player.Position, "Ok");
        }
        private void SuspendedAction(object sender, EventArgs args)
        {
            MenuItem button = (MenuItem)sender;
            CelticsPlayers player = (CelticsPlayers)button.CommandParameter;
            DisplayAlert("Title: " + player.Name, "Message: " + player.Name + " - " + player.Position, "Ok");
        }
    }
}