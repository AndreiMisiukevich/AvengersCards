using System;
using Xamarin.Forms;

namespace MarvelCards
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Expander_Experimental" });
            MainPage = new MainPage();
        }
    }
}
