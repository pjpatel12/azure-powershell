// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>The lab user list management profile.</summary>
    public partial class RosterProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IRosterProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IRosterProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IRosterProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json ? new RosterProfile(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject into a new instance of <see cref="RosterProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RosterProfile(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_activeDirectoryGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("activeDirectoryGroupId"), out var __jsonActiveDirectoryGroupId) ? (string)__jsonActiveDirectoryGroupId : (string)_activeDirectoryGroupId;}
            {_ltiContextId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("ltiContextId"), out var __jsonLtiContextId) ? (string)__jsonLtiContextId : (string)_ltiContextId;}
            {_lmsInstance = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("lmsInstance"), out var __jsonLmsInstance) ? (string)__jsonLmsInstance : (string)_lmsInstance;}
            {_ltiClientId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("ltiClientId"), out var __jsonLtiClientId) ? (string)__jsonLtiClientId : (string)_ltiClientId;}
            {_ltiRosterEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("ltiRosterEndpoint"), out var __jsonLtiRosterEndpoint) ? (string)__jsonLtiRosterEndpoint : (string)_ltiRosterEndpoint;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RosterProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RosterProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._activeDirectoryGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._activeDirectoryGroupId.ToString()) : null, "activeDirectoryGroupId" ,container.Add );
            AddIf( null != (((object)this._ltiContextId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._ltiContextId.ToString()) : null, "ltiContextId" ,container.Add );
            AddIf( null != (((object)this._lmsInstance)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._lmsInstance.ToString()) : null, "lmsInstance" ,container.Add );
            AddIf( null != (((object)this._ltiClientId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._ltiClientId.ToString()) : null, "ltiClientId" ,container.Add );
            AddIf( null != (((object)this._ltiRosterEndpoint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._ltiRosterEndpoint.ToString()) : null, "ltiRosterEndpoint" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}