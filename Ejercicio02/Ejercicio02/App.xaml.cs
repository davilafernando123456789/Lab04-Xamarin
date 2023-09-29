using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Ejercicio02
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
                                              