using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataAccessLayer
{
    internal class clsEventLog
    {
       public static void CreateEventLog(Exception ex)
        {
            // Specify the source name for the event log
            string sourceName = "DVLDApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }


            // save the log event information 
          EventLog.WriteEntry(sourceName,ex.ToString(), EventLogEntryType.Warning) ;

        }
    }
}
