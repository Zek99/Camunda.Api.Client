using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskDurationReport : AbstractReport
    {
        /// <summary>
        /// Restrict to tasks that were completed before the given date.
        /// </summary>
        public DateTime? CompletedBefore;
        /// <summary>
        /// Restrict to tasks that were completed after the given date.
        /// </summary>
        public DateTime? CompletedAfter;

        public HistoricTaskDurationReport()
        {
            ReportType = ReportType.Duration;
        }
    }
}
