using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SampleApp.Views;
using SampleApp.Models;

namespace SampleApp
{
     public partial class App : Application
     {
          public App()
          {
               InitializeComponent();

               MainPage = new NavigationPage(new MainPage(new User()));
             
          }

          protected override void OnStart()
          {
          }

          protected override void OnSleep()
          {
          }

          protected override void OnResume()
          {
          }
     }
}
