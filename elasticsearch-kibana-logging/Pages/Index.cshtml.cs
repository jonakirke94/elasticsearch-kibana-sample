using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elasticsearch_kibana_logging.Monitoring;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace elasticsearch_kibana_logging.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Log.Error("Test error from index.cshtml");

            KPI.LogKPI(KPI.AD_CLICK);
            KPI.LogKPI(KPI.AD_VIEW);

        }
    }
}
