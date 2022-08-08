using System;
using Demo_MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<StaffListViewModel>();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

