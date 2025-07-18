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

using System;
using System.Management.Automation;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Microsoft.Azure.Commands.Insights.OutputClasses;
using Microsoft.Azure.Management.Monitor.Models;

namespace Microsoft.Azure.Commands.Insights
{
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Static class containing common functions
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Gets the file version of the currently (executing) dll.
        /// </summary>
        /// <returns>The string with the file version of the current dll or null if an error happened</returns>
        public static string GetCurrentDllFileVersion()
        {
            Assembly CurrentAssembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(CurrentAssembly.Location);
            return fileVersionInfo.FileVersion;
        }

        /// <summary>
        /// Gets a string with a default description for artifacts like alert rules or autoscale settings
        /// </summary>
        /// <param name="artifactName">The name of the artifact to describe, e.g.: alert rule, autoscale setting</param>
        /// <returns>A string with a default description for artifacts like alert rules or autoscale settings</returns>
        public static string GetDefaultDescription(string artifactName)
        {
            const string fileVersionTemplate = "This {0} was created from Powershell version: {1}";
            return string.Format(CultureInfo.InvariantCulture, fileVersionTemplate, artifactName, GetCurrentDllFileVersion() ?? "Unknown");
        }

        /// <summary>
        /// Checks if the given string represents a valid uri
        /// </summary>
        /// <param name="uri">The string representing a uri</param>
        /// <param name="argName">The name of the argument to report as invalid</param>
        public static void ValidateUri(string uri, string argName = "Uri")
        {
            Uri tempUri;
            if (!Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out tempUri))
            {
                throw new ArgumentException(string.Format("Invalid {0}: {1}", argName, uri));
            }
        }

        public static void ExtractCollectionFromResult(this IEnumerator<EventData> enumerator, bool fullDetails, List<PSEventData> records, Func<EventData, bool> keepTheRecord)
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (keepTheRecord(current))
                {
                    records.Add(fullDetails ? new PSEventData(current) : new PSEventDataNoDetails(current));
                }
            }
        }

        public static string ReadFileContent(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException(path);
            using (TextReader reader = new StreamReader(path))
                return reader.ReadToEnd();
        }

        public static bool IsGuid(string str)
        {
            return Guid.TryParse(str, out _);
        }
    }
}
