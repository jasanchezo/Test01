using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            RuntimeImage.Source = ImageSource.FromUri(new Uri("https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png"));

            // throw new NotImplementedException();
        }
    }
}
