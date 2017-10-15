using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cyberhelp.Controls;

namespace Cyberhelp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailReportPage : ContentPage
	{
        public ObservableCollection<TagAnswer> ListItems { get; }

        public DetailReportPage ()
		{
			InitializeComponent ();

            ToolbarItems.Add(new ToolbarItem("Add", "icon.png", () =>
            {
                Navigation?.PushAsync(new PsychologistRegistryPage(), false);
            }));

            ListItems = new ObservableCollection<TagAnswer>();
            listAnswers.ItemsSource = ListItems;
        }


        private void btnSendAnswer_Clicked(object sender, EventArgs e)
        {
            ListItems.Add(new TagAnswer { Answer = entryAnswer.Text });
            entryAnswer.Text = "";
        }

        private void listAnswers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listAnswers.SelectedItem = null;
        }


        public void Details(string title, string description)
        {
            title = labelTitle.Text;
            description = labelDescription.Text;
        }
    }
}