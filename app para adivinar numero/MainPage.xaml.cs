using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var numero = double.Parse(Numero1.Text);
            var por_dos = double.Parse(Numero2.Text);
            var sumale_8 = double.Parse(Sum8.Text);
            var multi_5 = double.Parse(mult5.Text);

            var result = (numero * por_dos);

            var resull = result + sumale_8;

            var resulll = resull * multi_5;
            Resultado.Text = resulll.ToString();
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var resultsin = double.Parse(Resin.Text);
            var resta = double.Parse(Rest.Text);

            var total = resultsin - resta;

            Resultadoo.Text = total.ToString();


        }
    }
}
