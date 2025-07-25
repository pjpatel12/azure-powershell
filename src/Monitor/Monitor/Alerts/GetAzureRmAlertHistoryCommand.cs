﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Insights.OutputClasses;
using Microsoft.Azure.Management.Monitor.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Insights.Alerts
{
    /// <summary>
    /// Get the history of events related to an Alert rule
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AlertHistory"), OutputType(typeof(PSEventData))]
    public class GetAzureRmAlertHistoryCommand : LogsCmdletBase
    {
        private static readonly TimeSpan DefaultQueryTimeRange = TimeSpan.FromHours(24);

        public const string AlertResourceType = "Microsoft.Insights/alertrules";

        #region Parameters declarations

        /// <summary>
        /// Gets or sets the resourceId parameter of the cmdlet
        /// </summary>
        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = "ResourceId")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        #endregion

        /// <summary>
        /// Gets the default query time range
        /// </summary>
        /// <returns>The default query time range for this class</returns>
        protected override TimeSpan GetDefaultQueryTimeRange()
        {
            return DefaultQueryTimeRange;
        }

        /// <summary>
        /// A predicate to filter in/out the records from original list of records obtained from the SDK.
        /// <para>This method is intended to allow descendants of this class to further filter the results.</para>
        /// <para>An example of this is when the filtering is needed based on EventSource and ResourceUri at the same time. 
        /// The SDK does not allow these two fields to be in the query filter together. So the call should filter by one and then use this function to filter by the second one.</para>
        /// </summary>
        /// <param name="record">A record from the original list of records obtained from the sdk</param>
        /// <returns>true if the record should kept in the result, false if it should be filtered out</returns>
        protected override bool KeepTheRecord(EventData record)
        {
            return string.IsNullOrWhiteSpace(this.ResourceId) || string.Equals(record.ResourceId, this.ResourceId, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Processes the particular parameters if this cmdlet.
        /// <para>In this case it adds the condition for eventSource to be of a particular value in order to retrieve only alert-related events</para>
        /// </summary>
        /// <param name="currentQueryFilter">The current query filter</param>
        /// <returns>Modified query filter including the condition for eventSource</returns>
        protected override string ProcessParticularParameters(string currentQueryFilter)
        {
            // Make sure only events for alerts come back
            return this.AddConditionIfPResent(currentQueryFilter, "resourceType", AlertResourceType);
        }
    }
}
