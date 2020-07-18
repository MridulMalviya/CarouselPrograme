using System;
using Rg.Plugins.Popup.Pages;

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
                throw ex;
            }
           
        }
    }
}
