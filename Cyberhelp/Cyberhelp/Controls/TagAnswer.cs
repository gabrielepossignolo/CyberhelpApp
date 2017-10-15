using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberhelp.Controls
{
    public class TagAnswer
    {
        public int IdAnswer { get; set; }
        public string UserAnswer { get; set; }
        public string ReportAnswerDate { get; }
        public string Answer { get; set; }
        public string UserType { get; set; }
        public string TitleReportDetail { get; set; }
        public string DescriptionReportDetail { get; set; }

        public TagAnswer()
        {
            ReportAnswerDate = DateTime.Now.ToString("");
        }
    }
}
