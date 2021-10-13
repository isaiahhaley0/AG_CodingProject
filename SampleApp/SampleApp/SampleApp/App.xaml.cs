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
               var test = new User();
               test.firstName = "Isaiah";
               test.lastName = "Haley";
               test.phoneNumber = "(303)885-2465";
               test.email = "isaiah.haley.0@gmail.com";
               test.bio = "Test about me text";
               MainPage = new NavigationPage(new MainPage(test));
             
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
