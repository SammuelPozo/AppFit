using AppFit.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace AppFit
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

          
        }

        private async void pagina_pecho(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pecho());
        }

        private async void pagina_abdominales(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Abdominales());
        }

        private async void pagina_piernas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Piernas());
        }

        private async void pagina_brazos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Brazos());
        }

        private async void pagina_tutoriales(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tutoriales());
        }
    }
}
