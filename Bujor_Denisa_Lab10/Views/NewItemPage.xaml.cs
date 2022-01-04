using Bujor_Denisa_Lab10.Models;
using Bujor_Denisa_Lab10.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bujor_Denisa_Lab10.Views
{
    public partial class NewItemPage : ContentPage
    {
        public ShopList Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}