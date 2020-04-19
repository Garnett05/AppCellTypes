using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCellTypes.Pages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCellTypes.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }
        public void GoTextCellPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }
        public void GoImageCellPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }
        public void GoEntryCellPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }
        public void GoSwitchCellPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }        
        public void GoViewCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }
        public void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }
        public void GoListViewPage2(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewPage2());
            IsPresented = false;
        }
    }
}