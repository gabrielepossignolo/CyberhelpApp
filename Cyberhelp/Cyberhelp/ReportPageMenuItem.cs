using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberhelp
{

    public class ReportPageMenuItem
    {
        public ReportPageMenuItem()
        {
            TargetType = typeof(ReportPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}