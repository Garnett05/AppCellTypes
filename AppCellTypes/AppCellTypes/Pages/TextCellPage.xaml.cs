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
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
        {
            InitializeComponent();

            List <CelticsPlayers> list = new List<CelticsPlayers>();
            list.Add(new CelticsPlayers() { Name = "Kemba Walker", Position = "Point God" });
            list.Add(new CelticsPlayers() { Name = "Jaylen Brown", Position = "Shooting Guard" });
            list.Add(new CelticsPlayers() { Name = "Jaylen Brown", Position = "Small Foward" });
            list.Add(new CelticsPlayers() { Name = "Gordon Hayward", Position = "Power Foward" });
            list.Add(new CelticsPlayers() { Name = "Marcus Smarf", Position = "Everything/Captain" });

            listCellPage.ItemsSource = list;
        }
    }
}