using System;
using System.Collections.Generic;
using CarouselPagePrograme.ViewModels;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace CarouselPagePrograme.Views
{
    public partial class CarouselViewPage : PopupPage
    {
        public CarouselViewPage()
        {
            try
            {
                InitializeComponent();
                carousel.Position = 1;
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
