using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace CarouselPagePrograme.Views
{
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
        }

        [Obsolete]
        private async void OnClickCommand(object sender, EventArgs e)
        {
            //  Navigation.PushAsync(new Views.CarouselViewPage());
            await PopupNavigation.PushAsync(new CarouselViewPage());
        }
    }
}
