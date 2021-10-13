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
     public partial class PhonePage : ContentPage
     {
          User myUser;
          public PhonePage(ref User temp)
          {
               myUser = temp;
               InitializeComponent();
          }
          public async void OnUpdateButtonClicked(object sender, EventArgs e)
          {
               var newPhone = PhoneEditor.Text;
               //format the phone number for better readability
               string formattedPhone = "(";
               for(int i = 0; i < newPhone.Length; i++)
               {
                    formattedPhone += newPhone[i];
                    if(i == 2)
                    {
                         formattedPhone += ") ";
                    }
                    if(i == 5)
                    {
                         formattedPhone += "-";
                    }
               }
               //Updates and returns to main page
               myUser.phoneNumber = formattedPhone;
               await Navigation.PopToRootAsync();

          }
     }
}