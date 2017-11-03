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
        private Report currentReport;
        private List<Report> reportList;
        private ReportManager reportManager;

        public ReportPageDetail()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem("Add", "add_report.png", () =>
            {
                //Navigation?.PushModalAsync(new NavigationPage(new PublishReportPage()));
                Navigation?.PushAsync(new PublishReportPage(), false);
            }));

            currentReport = (Report)Application.Current.Properties["user"];

            reportList = new List<Report>();
            reportManager = new ReportManager();

            reportListView.ItemTemplate = new DataTemplate(typeof(DetailReportPage));

            LoadReport();
        }      

        private async void LoadReport()
        {
            reportList = await reportManager.ListReportWhere(reportSelect => reportSelect.id != currentReport.id);

            if (reportList.Count != 0)
            {
                reportListView.ItemsSource = reportList;
            }
        }

        private void OnSearch(Object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                reportListView.ItemsSource = reportList.Where(reportSelect => reportSelect.title.ToLower().Contains(e.NewTextValue.ToLower())
                    || reportSelect.description.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            else
            {
                reportListView.ItemsSource = reportList;
            }
        }

    }
}