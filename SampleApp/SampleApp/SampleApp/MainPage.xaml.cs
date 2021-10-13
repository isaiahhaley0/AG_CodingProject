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

          public string myName { get { return sample.Name; } }
          public MainPage(User user)
          {
               sample = user;

               InitializeComponent();
            
               BindingContext = sample;

          }

          private async void OnNameTapped(object sender, EventArgs e)
          {
               var nameEditor = new NamePage(ref sample);
               nameEditor.BindingContext = sample;
               await Navigation.PushAsync(nameEditor);

          }
          private async void OnEmailTapped(object sender, EventArgs e)
          {
               var emailEditor = new emailPage(ref sample);
               await Navigation.PushAsync(emailEditor);
          }

          private async void OnBioTapped(object sender, EventArgs e)
          {
               var bioEditor = new BioPage(ref sample);
               await Navigation.PushAsync(bioEditor);
          }
     }
}
