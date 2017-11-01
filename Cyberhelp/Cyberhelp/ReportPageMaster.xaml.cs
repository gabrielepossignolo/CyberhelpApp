using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cyberhelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPageMaster : ContentPage
    {
        
        public ReportPageMaster()
        {
            InitializeComponent();

            btnAbout.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new AboutPage());
            };

            btnMyReports.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new MyReportsPage());
            };
        }

        
    }
}