using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {

        private void Handle_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello", "OK");
        }
        public GreetPage()
        {
            InitializeComponent();
        }

        
    }
}