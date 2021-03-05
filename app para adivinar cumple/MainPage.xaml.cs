using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cumple
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
            var mul_20 = double.Parse(multi20.Text);
            var sum_73 = double.Parse(sum73.Text);
            var mult_5 = double.Parse(multi5.Text);
            var sum_m = double.Parse(mes.Text);

            var resu = numero * mul_20;

            var resul = resu + sum_73;

            var result = resul * mult_5;

            var resulta = result + sum_m;
            Resultado.Text = resulta.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var ress = double.Parse(resul.Text);
  
            var rest = double.Parse(resta.Text);


            

            var resultad = (ress - rest);
            Resultadoo.Text = resultad.ToString();

        }
    }
}
