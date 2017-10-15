using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberhelp.Controls
{
    public class TodoItem
    {
        public string id;
        public string ReportType;
        public string DatePublicationReport;
        public string ReportTitle;
        public string ReportDescription;
        public bool Done;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "ReportType")]
        public string reportType
        {
            get { return ReportType; }
            set { ReportType = value; }
        }

        [JsonProperty(PropertyName = "ReportTitle")]
        public string reportTitle
        {
            get { return ReportTitle; }
            set { ReportTitle = value; }
        }

        [JsonProperty(PropertyName = "ReportDescription")]
        public string reportDescription
        {
            get { return ReportDescription; }
            set { ReportDescription = value; }
        }

        [JsonProperty(PropertyName = "Done")]
        public bool done
        {
            get { return Done; }
            set { Done = value; }
        }


        [Version]
        public string Version { get; set; }

        public TodoItem()
        {
            DatePublicationReport = DateTime.Now.ToString("");
        }
    }
}

