using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Cyberhelp.Models;
using Cyberhelp.Controls;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace Cyberhelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPageDetail : ContentPage
    {
        //IMobileServiceSyncTable<TodoItem> itemsTable; 
        private List<TodoItem> myListReport;


        public ReportPageDetail()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem("Add", "icon.png", () =>
            {
                //Navigation?.PushModalAsync(new NavigationPage(new PublishReportPage()));
                Navigation?.PushAsync(new PublishReportPage(), false);
            }));

            this.myListReport = new List<TodoItem>();



            /*for (var i = 0; i <=20; i++)
            {
                this.myListReport.Add(new TodoItem { ReportTitle = $"TestTitle{i}", ReportDescription = $"TestDesc{i}"});
            }*/

            this.searchSearch.TextChanged += SearchSearch_TextChanged; ;
            this.listReports.ItemsSource = this.showList();
        }

        private void SearchSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.listReports.ItemsSource = this.showList(this.searchSearch.Text);
        }

        public IEnumerable<MyListReport<string, TodoItem>> showList(string filter = "")
        {
            IEnumerable<TodoItem> listFilter = this.myListReport;

            if (!string.IsNullOrEmpty(filter))
                listFilter = this.myListReport.Where(l => (l.ReportTitle.ToLower().Contains(filter.ToLower())) ||
                    l.ReportDescription.ToLower().Contains(filter.ToLower()));

            return from list in listFilter
                   group list by list.ReportTitle into groups
                   select new MyListReport<string, TodoItem>(groups.Key, groups);
        }

        private void listReports_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem; 
            Navigation?.PushModalAsync(new NavigationPage(new DetailReportPage()));

        }

        /*public async Task<IEnumerable<TodoItem>> GetItemsAsync(bool forceRefresh = false)
        {

            return await itemsTable.ToEnumerableAsync();
                

        }*/

    }
}