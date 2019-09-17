using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elasticsearch_kibana_logging.Monitoring
{
    public static class KPI
    {
        public const string AD_CLICK = "AD_CLICK";
        public const string AD_VIEW = "AD_VIEW";

        public static void LogKPI(string KPI)
        {
            Log.Information(KPI);
        }

        public static void LogKPI(string KPI, string message)
        {
            Log.Information(KPI + message);
        }
    }
}

