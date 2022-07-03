using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YourDailyPic.Services;

namespace YourDailyPic.ViewModels
{
    internal class MainPageViewModel : BaseViewModel
    {
        private string _imageSource;
        public MainPageViewModel()
        {
            ImageService service = new ImageService();
            var response = Task.Run(async () => await service.GetImages("Nature")).Result;
            ImageSource = response.src?.portrait ?? string.Empty;
        }

        public string ImageSource
        {
            get 
            { 
                return _imageSource; 
            }
            set 
            { 
                _imageSource = value;
                OnPropertyChanged();
            }
        }
    }
}
