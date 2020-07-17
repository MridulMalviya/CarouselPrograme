using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarouselPagePrograme.Models;

namespace CarouselPagePrograme.ViewModels
{
    public class CarouselViewModel
    {
        public ObservableCollection<CarouselModel> StudentList { get; set; }

        public CarouselViewModel()
        {
            CarouselModel carouselModel1 = new CarouselModel() { Name="Page1", Age="index value 0", Location="position=0" };
            CarouselModel carouselModel2 = new CarouselModel() { Name = "Page2", Age = "index value 1", Location = "position=1" };
            CarouselModel carouselModel3 = new CarouselModel() { Name = "Page3", Age = "index value 2", Location = "position=2" };

            List<CarouselModel> list = new List<CarouselModel>
            {
                carouselModel1,
                carouselModel2,
                carouselModel3
            };

            StudentList = new ObservableCollection<CarouselModel>(list);
        }
    }
}
