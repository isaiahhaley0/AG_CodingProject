using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class NamePage : ContentPage
     {
          User temp;
          public NamePage(ref User myUser)
          {
               InitializeComponent();
               temp = myUser;
               

          }
          public async void OnButtonCliked(object sender, EventArgs e)
          {
               var newFirstName = fName.Text;
               temp.firstName = newFirstName;
               var newLastName = lName.Text;
               temp.lastName = newLastName;
               await Navigation.PopToRootAsync();
          }
     }
}