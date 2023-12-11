using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSocialNetwork.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSocialNetwork.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string subtitleImage;

        [ObservableProperty]
        string pathImage;

        [RelayCommand]
        void ShowImage()
        {
            App.Current.MainPage.Navigation.PushAsync(new MediaViewer());
        }

        public MainViewModel()
        {
            subtitleImage = "Hello let's to make a good memories! 🌹";
            pathImage = "image_2";
        }
    }
}
