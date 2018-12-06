﻿using Refit;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public abstract class AbstractReport : IQueryParameters
    {
        /// <summary>
        /// Specifies the granularity of the report.
        /// </summary>
        public PeriodUnit PeriodUnit;
        /// <summary>
        /// Specifies the type of the report to retrieve.
        /// </summary>
        public ReportType ReportType;

        IDictionary<string, string> IQueryParameters.GetParameters() => this.CreateQueryParameters();
    }

    public class GroupedReport : AbstractReport
    {
        /// <summary>
        /// Groups the tasks report by a given criterion.
        /// </summary>
        public GroupBy GroupBy;
    }

    public enum PeriodUnit
    {
        /// <summary>
        /// Represents a unit for a quarter of the year.
        /// </summary>
        [EnumMember(Value = "quarter")]
        Quarter,

        /// <summary>
        /// Represents a unit for a month of the year.
        /// </summary>
        [EnumMember(Value = "month")]
        Month
    }

    public enum ReportType
    {
        [EnumMember(Value = "duration")]
        Duration,

        [EnumMember(Value = "count")]
        Count
    }

    public enum GroupBy
    {
        /// <summary>
        /// Represents a unit for a quarter of the year.
        /// </summary>
        [EnumMember(Value = "taskName")]
        TaskName,

        /// <summary>
        /// Represents a unit for a month of the year.
        /// </summary>
        [EnumMember(Value = "processDefinition")]
        ProcessDefinition
    }
}
