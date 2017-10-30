using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberhelp.Controls;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cyberhelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublishReportPage : ContentPage
    {
        /*public static MobileServiceClient MobileService =
            new MobileServiceClient("https://cyberhelpapp.azurewebsites.net");*/
        //public static IMobileServiceTable<TodoItem> myListReport;
        //public List<TodoItem> myListReport;

        public PublishReportPage()
        {
            InitializeComponent();
        }

        /*public async Task btnPublishStory_ClickedAsync(object sender, EventArgs e)
       {
           //Navigation?.PushModalAsync(new NavigationPage(new DetailsReportPage()));
           //Navigation?.PushAsync(new DetailsReportPage(), false);
           // TodoItem item = new TodoItem { ReportTitle = storyTitle.Text, ReportDescription = storyDescription.Text };

           /*TodoItem item = new TodoItem { ReportTitle = storyTitle.Text, ReportDescription = storyDescription.Text };
           await MobileService.GetTable<TodoItem>().InsertAsync(item);

       }*/

        public void OnAdd(object sender, EventArgs e)
        {

        }

        // Event handlers
        public void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}