using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleApp.Models;

namespace SampleApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class BioPage : ContentPage
     {
          User myUser;
          public BioPage(ref User temp)
          {
               myUser = temp;
               InitializeComponent();
          }
          public async void OnUpdateButtonClicked(object sender, EventArgs e)
          {
               var newBio = bioEditor.Text;
               myUser.bio = newBio;
               //Updates and returns to main page
               await Navigation.PopToRootAsync();

          }
     }
}