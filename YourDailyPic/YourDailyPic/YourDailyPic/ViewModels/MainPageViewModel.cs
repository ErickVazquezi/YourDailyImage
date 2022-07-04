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
        private string _photographer;
        private string _photoName;
        public MainPageViewModel()
        {
            ImageService service = new ImageService();
            var response = Task.Run(async () => await service.GetImages("Nature")).Result;
            ImageSource = response.src?.portrait ?? string.Empty;
            Photographer = response.photographer ?? string.Empty;
            PhotoName = response.alt ?? string.Empty;
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

        public string Photographer
        {
            get
            {
                return _photographer;
            }
            set
            {
                _photographer = value;
                OnPropertyChanged();
            }
        }

        public string PhotoName
        {
            get
            {
                return _photoName;
            }
            set
            {
                _photoName = value;
                OnPropertyChanged();
            }
        }
    }
}
