using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberhelp.Controls;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace Cyberhelp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublishReportPage : ContentPage
    {

        private ReportManager manager;

        public PublishReportPage()
        {
            InitializeComponent();

            manager = new ReportManager();
        }

        async Task AddNewReport(Report report)
        {
            Report reportResponse = await manager.SaveGetReportAsync(report);
            Application.Current.Properties["report"] = reportResponse;
        }

        public async void OnAdd(Object sender, EventArgs e)
        {

            string title = storyTitle.Text;
            string description = storyDescription.Text;

            if (!string.IsNullOrEmpty(title) && !!string.IsNullOrEmpty(description))
            {

                var report = new Report
                {
                    title = title,
                    description = description
                };

                await AddNewReport(report);
                await Navigation.PushModalAsync(new ReportPageDetail());
                await Navigation.PopAsync();
            }
        }

        
    }
}   