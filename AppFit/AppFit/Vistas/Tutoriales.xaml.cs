using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFit.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tutoriales : ContentPage
    {
        public Tutoriales()
        {
            InitializeComponent();

            var htmlcontent = new HtmlWebViewSource();
            htmlcontent.Html = "<html><head></head><body>=" +
                " <iframe width='560' height='315' src='https://www.youtube.com/embed/c_IdhmpFtqM'frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"+
            "</body></html>";
            Video.Source = htmlcontent;
        }
    }
}