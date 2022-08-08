using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Demo_MVVM.Models;
using Xamarin.Forms;

namespace Demo_MVVM.Pages
{
    public partial class StaffListPage : ContentPage
    {

        public StaffListPage()
        {
            InitializeComponent();
        }

        void btnSignin_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("click ok");
        }


    }
}

