using Cross2020.Pages;
using Cross2020.ViewModel;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Cross2020
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var vm = new MainViewModel();
            this.BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}
