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
            list.Add(new CelticsPlayers("Kemba Walker", "Point God", "None"));
            list.Add(new CelticsPlayers("Jaylen Brown", "Shooting Guard", "None"));
            list.Add(new CelticsPlayers("Jayson Tatum", "Small Foward", "None"));
            list.Add(new CelticsPlayers("Gordon Hayward", "Small Foward", "None"));
            list.Add(new CelticsPlayers("Marcus Smart", "Everything", "None"));

            listCellPage.ItemsSource = list;
        }
    }
}