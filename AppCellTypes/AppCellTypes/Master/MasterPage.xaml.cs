﻿using System;
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
        public void GoTextCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new TextCellPage());
        }
    }
}