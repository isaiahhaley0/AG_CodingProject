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
     public partial class emailPage : ContentPage
     {
          User myUser;
          public emailPage(ref User temp)
          {
               myUser = temp;
               InitializeComponent();
          }

          public async void OnUpdateButtonClicked(object sender, EventArgs e)
          {
               var newEmail = email.Text;
               myUser.email = newEmail;
               //Updates and returns to main page
               await Navigation.PopToRootAsync();
          }
     }
}