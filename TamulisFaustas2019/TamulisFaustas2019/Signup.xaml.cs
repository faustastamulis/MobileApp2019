using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TamulisFaustas2019
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signup : ContentPage
	{
        public Signup()
        {
            InitializeComponent();

            btnStore.Clicked += BtnStore_Clicked;
            btnGet.Clicked += BtnGet_Clicked;
        }


     
        
        private void BtnGet_Clicked(object sender, EventArgs e)
        {
            //Get all Values
            if (Application.Current.Properties.ContainsKey("ID"))
            {
                lblId.Text = Application.Current.Properties["ID"].ToString();
                lblName.Text = Application.Current.Properties["Name"].ToString();
            }
        }
        private void BtnStore_Clicked(object sender, EventArgs e)
        {
            // Store all  Values
            Application.Current.Properties["ID"] = txtId.Text;
            Application.Current.Properties["Name"] = txtName.Text;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            DisplayAlert("Thanks", "Account Created", "OK");
        }
       
    }
}