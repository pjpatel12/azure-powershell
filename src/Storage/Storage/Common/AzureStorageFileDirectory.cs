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
// ---------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel
{
    using System;
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using Microsoft.Azure.Storage.File;
    using global::Azure.Storage.Files.Shares;
    using Microsoft.WindowsAzure.Commands.Storage.Common;
    using global::Azure.Storage.Files.Shares.Models;
    using Microsoft.Azure.Storage.Auth;

    /// <summary>
    /// Azure storage file object
    /// </summary>
    public class AzureStorageFileDirectory : AzureStorageBase
    {
        /// <summary>
        /// file last modified time
        /// </summary>
        [Ps1Xml(Label = "LastModified", Target = ViewControl.Table, ScriptBlock = "$_.LastModified.UtcDateTime.ToString(\"u\")", Position = 2, TableColumnWidth = 20)]
        public DateTimeOffset? LastModified { get; private set; }

        /// <summary>
        /// XSCL Track2 File Client, used to run file APIs
        /// </summary>
        public ShareDirectoryClient ShareDirectoryClient
        {
            get
            {
                return privateFileDirClient;
            }
        }
        private ShareDirectoryClient privateFileDirClient = null;

        /// <summary>
        /// XSCL Track2 File properties, will retrieve the properties on server and return to user
        /// </summary>
        public global::Azure.Storage.Files.Shares.Models.ShareDirectoryProperties ShareDirectoryProperties
        {
            get
            {
                if (privateFileDirProperties == null)
                {
                    privateFileDirProperties = ShareDirectoryClient.GetProperties().Value;
                }
                return privateFileDirProperties;
            }
        }
        private global::Azure.Storage.Files.Shares.Models.ShareDirectoryProperties privateFileDirProperties = null;

        /// <summary>
        /// XSCL Track2 File List properties
        /// </summary>
        public global::Azure.Storage.Files.Shares.Models.ShareFileItem ListFileProperties { get; private set; }

        private ShareClientOptions shareClientOptions { get; set; }

        /// <summary>
        /// Azure storage file constructor from Track2 list file item
        /// </summary>
        /// <param name="shareDirectoryClient"></param>
        /// <param name="storageContext"></param>
        /// <param name="shareFileItem"></param>
        /// <param name="clientOptions"></param>
        public AzureStorageFileDirectory(ShareDirectoryClient shareDirectoryClient, AzureStorageContext storageContext, ShareFileItem shareFileItem, ShareClientOptions clientOptions = null)
        {
            Name = shareDirectoryClient.Name;
            this.privateFileDirClient = shareDirectoryClient;
            if (shareFileItem != null)
            {
                ListFileProperties = shareFileItem;
                if (shareFileItem.Properties != null)
                {
                    LastModified = shareFileItem.Properties.LastModified;
                }
            }
            Context = storageContext;
            shareClientOptions = clientOptions;
        }

        /// <summary>
        /// Azure storage file constructor from Track2 get file properties output
        /// </summary>
        /// <param name="shareDirectoryClient"></param>
        /// <param name="storageContext"></param>
        /// <param name="shareDirectoryProperties"></param>
        /// <param name="clientOptions"></param>
        public AzureStorageFileDirectory(ShareDirectoryClient shareDirectoryClient, AzureStorageContext storageContext, ShareDirectoryProperties shareDirectoryProperties = null, ShareClientOptions clientOptions = null)
        {
            Name = shareDirectoryClient.Name;
            this.privateFileDirClient = shareDirectoryClient;
            if (shareDirectoryProperties != null)
            {
                privateFileDirProperties = shareDirectoryProperties;
                LastModified = shareDirectoryProperties.LastModified;
            }
            Context = storageContext;
            shareClientOptions = clientOptions;
        }

        // Convert Track2 File Dir object to Track 1 file Dir object
        public static CloudFileDirectory GetTrack1FileDirClient(ShareDirectoryClient shareFileDirClient, StorageCredentials credentials, ShareClientOptions clientOptions = null, bool skipTrailingDotCheck = false)
        {
            if (credentials.IsToken)
            {
                return new InvalidCloudFileDirectory(shareFileDirClient.Uri, credentials);
            }
            // Track1 File not support Trailing Dot
            if (!skipTrailingDotCheck && Util.PathContainsTrailingDot(shareFileDirClient.Path) && (clientOptions != null && clientOptions.AllowTrailingDot != null && clientOptions.AllowTrailingDot.Value))
            {
                return new InvalidCloudFileDirectory(shareFileDirClient.Uri, credentials);
            }
            if (credentials.IsSAS) // the Uri already contains credential.
            {
                credentials = null;
            }
            CloudFileDirectory track1CloudFileDir;
            track1CloudFileDir = new CloudFileDirectory(shareFileDirClient.Uri, credentials);
            return track1CloudFileDir;
        }
    }
}
