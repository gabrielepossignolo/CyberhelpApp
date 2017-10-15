using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;


namespace Cyberhelp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 

            var tapImageHelp = new TapGestureRecognizer();
            tapImageHelp.Tapped += tapImageHelp_Tapped;
            imageHelp.GestureRecognizers.Add(tapImageHelp);

        }

        private void btnEnter_OnClicked(object sender, EventArgs e)
        {
            //Navigation?.PushModalAsync(new NavigationPage(new ForgetPasswordPage()));
            Navigation?.PushModalAsync(new NavigationPage(new ReportPage()));            
        }

        void tapImageHelp_Tapped(object sender, EventArgs e)
        {
            Navigation?.PushModalAsync(new NavigationPage(new AboutPage()));
        }        
    }
}
