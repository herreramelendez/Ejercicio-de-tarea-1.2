using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCalcular : ContentPage
    {
        public PageCalcular()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("SUMA",Convert.ToString(Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text)), "OK");
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("RESTA", Convert.ToString(Convert.ToDouble(numero1.Text) - Convert.ToDouble(numero2.Text)), "OK");
        }

        private async void btnMulti_Clicked(object sender, EventArgs e)
        {
           await DisplayAlert("MULTIPLICACION", Convert.ToString(Convert.ToDouble(numero1.Text) * Convert.ToDouble(numero2.Text)), "OK");
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
          await DisplayAlert("DIVISION", Convert.ToString(Convert.ToDouble(numero1.Text) / Convert.ToDouble(numero2.Text)), "OK");
            
        }

       
    }
}