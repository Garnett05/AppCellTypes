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
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<CelticsPlayers> list = new List<CelticsPlayers>();
            list.Add(new CelticsPlayers() { Photo = "kembaWalker.jpg", Name = "Kemba Walker", Position = "Poing God"  });
            list.Add(new CelticsPlayers() { Photo = "jaylenBrown.jpg", Name = "Jaylen Brown", Position = "Shooting Guard" });
            list.Add(new CelticsPlayers() { Photo = "jaysonTatum.jpg", Name = "Jayson Tatum", Position = "Small Foward" });
            list.Add(new CelticsPlayers() { Photo = "gordonHayward.jpg", Name = "Gordon Hayward", Position = "Power Foward" });
            list.Add(new CelticsPlayers() { Photo = "marcusSmarf.jpg", Name = "Marcus Smarf", Position = "Everything/My Captain" });

            listViewCell.ItemsSource = list;
            listImageCell.ItemsSource = list;
        }
    }
}