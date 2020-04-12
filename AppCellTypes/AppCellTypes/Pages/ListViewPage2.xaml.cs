using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCellTypes.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCellTypes.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage2 : ContentPage
    {
        public ListViewPage2()
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
        private void TrainingAction (object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            CelticsPlayers player = (CelticsPlayers)btn.CommandParameter;

            DisplayAlert("Training Schedule", "The individual training with the player " + player.Name + " are scheduled", "Ok");
        }
    }
}