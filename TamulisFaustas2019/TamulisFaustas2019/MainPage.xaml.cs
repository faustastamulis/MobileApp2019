using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TamulisFaustas2019
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new aquarius());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new pisces());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new aries());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Taurus());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new gemini());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new cancer());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new leo());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new virgo());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new libra());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new scorpio());
        }

        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new sagittarius());
        }

        private async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new capricorn());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Signup());
        }
    }
}
