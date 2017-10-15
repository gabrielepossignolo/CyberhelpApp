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
	public partial class PsychologistRegistryPage : ContentPage
	{
		public PsychologistRegistryPage ()
		{
			InitializeComponent ();
		}

        private void btnPsychologistRegistry_Clicked(object sender, EventArgs e)
        {
            //Navigation?.PushModalAsync(new NavigationPage(new VictimRegistryPage()));
            Navigation?.PushAsync(new VictimRegistryPage(), false);
        }
    }
}