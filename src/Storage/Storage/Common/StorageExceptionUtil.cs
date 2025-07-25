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

namespace Microsoft.WindowsAzure.Commands.Storage.Common
{
    using Microsoft.Azure.Storage;
    using System;

    /// <summary>
    /// Storage exception utility
    /// </summary>
    public static class StorageExceptionUtil
    {
        /// <summary>
        /// Whether the storage exception is resource not found exception or not.
        /// </summary>
        /// <param name="e">StorageException from storage client</param>
        /// <returns>Whether the storageexception is caused by resource not found</returns>
        public static bool IsNotFoundException(this StorageException e)
        {
            return e.RequestInformation != null && e.RequestInformation.HttpStatusCode == 404;
        }

        /// <summary>
        /// Whether the storage exception is Forbidden exception or not.
        /// </summary>
        /// <param name="e">StorageException from storage client</param>
        /// <returns>Whether the storageexception is caused by Forbidden</returns>
        public static bool IsForbiddenException(this StorageException e)
        {
            return e.RequestInformation != null && e.RequestInformation.HttpStatusCode == 403;
        }

        /// <summary>
        /// Whether the storage exception is 409 conflict exception
        /// </summary>
        /// <param name="e">StorageException from the storage client</param>
        /// <returns>True if the storage exception is 409 conflict, otherwise false.</returns>
        public static bool IsConflictException(this StorageException e)
        {
            return e.RequestInformation != null && e.RequestInformation.HttpStatusCode == 409;
        }

        /// <summary>
        /// Is the storage exception thrown with 2xx http status code
        /// </summary>
        /// <param name="e">Storage exception</param>
        /// <returns>True if the http status code is 2xx, otherwise false</returns>
        public static bool IsSuccessfulResponse(this StorageException e)
        {
            return e.RequestInformation != null && (e.RequestInformation.HttpStatusCode / 100 == 2);
        }

        /// <summary>
        /// Replace storage exception to expose more information in Message.
        /// </summary>
        /// <param name="e">StorageException from storage client</param>
        /// <returns>A new storage exception with detailed error message</returns>
        public static StorageException RepackStorageException(this StorageException e)
        {
            if (null != e.RequestInformation &&
                null != e.RequestInformation.HttpStatusMessage)
            {
                String msg = string.Format(
                    "{0} HTTP Status Code: {1} - HTTP Error Message: {2}",
                    e.Message,
                    e.RequestInformation.HttpStatusCode,
                    e.RequestInformation.HttpStatusMessage);

                if (e.RequestInformation.ExtendedErrorInformation != null)
                {
                    String extendErrorInfo = String.Format(
                        "\nErrorCode: {0}\nErrorMessage: {1}",
                        e.RequestInformation.ExtendedErrorInformation.ErrorCode,
                        e.RequestInformation.ExtendedErrorInformation.ErrorMessage);

                    if (e.RequestInformation.ExtendedErrorInformation.AdditionalDetails != null
                        && e.RequestInformation.ExtendedErrorInformation.AdditionalDetails.Count > 0)
                    {
                        string additionalDetails = string.Empty;
                        foreach (var key in e.RequestInformation.ExtendedErrorInformation.AdditionalDetails)
                        {
                            additionalDetails += String.Format("\n{0}: {1}", key.Key, key.Value);
                        }
                        extendErrorInfo += additionalDetails;
                    }
                    msg += extendErrorInfo;
                }
                else
                {
                    String errorInfo = String.Format(
                        "\nErrorCode: {0}\nErrorMessage: {1}\nRequestId: {2}\nTime: {3}",
                        e.RequestInformation.ErrorCode,
                        e.RequestInformation.HttpStatusMessage,
                        e.RequestInformation.ServiceRequestID,
                        e.RequestInformation.RequestDate);
                    msg += errorInfo;
                }
                e = new StorageException(e.RequestInformation, msg, e);
            }
            return e;
        }
    }
}
