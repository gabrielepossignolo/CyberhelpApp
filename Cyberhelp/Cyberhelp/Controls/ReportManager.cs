using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cyberhelp.Controls
{
    public class ReportManager
    {

        IMobileServiceTable<Report> reportTable;
        MobileServiceClient client;

        public ReportManager()
        {
            client = new MobileServiceClient(Constants.ApplicationURL);

            reportTable = client.GetTable<Report>();
        }

        public async Task<Report> GetReportWhere(Expression<Func<Report, bool>> linq)
        {
            try
            {
                List<Report> newReport = await reportTable.Where(linq).Take(1).ToListAsync();
                return newReport.First();
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"INVALID {0}", msioe.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"ERROR {0}", e.Message);
            }

            return null;
        }

        public async Task<Report> SaveGetReportAsync(Report report)
        {
            if (report.id == null)
            {
                await reportTable.InsertAsync(report);
            }
            else
            {
                await reportTable.UpdateAsync(report);
            }

            try
            {
                List<Report> newReport = await reportTable.Where(reportSelect => reportSelect.username == report.username).ToListAsync();
                return newReport.First();
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"INVALID {0}", msioe.Message);   
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"ERROR {0}", e.Message);
            }

            return null;
        }

        public async Task<List<Report>> ListReportWhere(Expression<Func<Report, bool>> linq)
        {
            try
            {
                return new List<Report>
                (

                    await reportTable.Where(linq).ToListAsync()
                );
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"INVALID {0}", msioe.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"ERROR {0}", e.Message);
            }

            return null;
        }

    }
}
