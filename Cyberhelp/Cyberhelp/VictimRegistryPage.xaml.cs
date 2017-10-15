using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cyberhelp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VictimRegistryPage : ContentPage
	{
		public VictimRegistryPage ()
		{
			InitializeComponent ();

		}

        private void btnVictimRegistry_Clicked(object sender, EventArgs e)
        {
            //Navigation?.PushModalAsync(new NavigationPage(new ForgetPasswordPage()));
            Navigation?.PushAsync(new ForgetPasswordPage(), false);
        }
    }
}