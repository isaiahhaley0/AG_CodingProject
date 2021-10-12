using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SampleApp.Models;
using SampleApp.Views;


namespace SampleApp
{
     public partial class MainPage : ContentPage
     {
          User sample;
          public MainPage(User user)
          {
               sample = user;

               InitializeComponent();
               nameDisplay.Text = "\n" + sample.Name;
               phoneDisplay.Text = "\n" + sample.phoneNumber;
               emailDisplay.Text = "\n" + sample.email;
               bioDisplay.Text = "\n" + sample.bio;
               BindingContext = this;

          }

          private async void OnNameTapped(object sender, EventArgs e)
          {
               var nameEditor = new NamePage(ref sample);
               await Navigation.PushAsync(nameEditor);

          }

     }
}
