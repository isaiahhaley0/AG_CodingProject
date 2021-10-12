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
          public NamePage(ref User myUser)
          {
               InitializeComponent();
          }
     }
}