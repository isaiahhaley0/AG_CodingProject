using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleApp.Models;
using Xamarin.Essentials;
namespace SampleApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class PhotoPage : ContentPage
     {
          User myUser;
          public PhotoPage(ref User temp)
          {
               myUser = temp;
               
               InitializeComponent();
               BindingContext = myUser;
          }
          public async void OnPhotoClicked(object sender, EventArgs e)
          {
               var newPhoto = await MediaPicker.PickPhotoAsync();
               await GetPhotoName(newPhoto);
               Console.WriteLine(newPhoto);
          }
          public async Task GetPhotoName(FileResult photo)
          {
               Console.WriteLine(photo.FullPath);
               myUser.profilePicture = photo.FullPath;
          }
          public async void OnUpdateButtonClicked(object sender, EventArgs e)
          {
               
               await Navigation.PopToRootAsync();
          }
     }
}