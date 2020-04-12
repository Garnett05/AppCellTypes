using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCellTypes.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCellTypes.Pages.Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(CelticsPlayers player)
        {
            InitializeComponent();

            txtName.Text = player.Name;
        }
    }
}