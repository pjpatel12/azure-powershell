// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class TeradataCredentialScanProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITeradataCredentialScanProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITeradataCredentialScanProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITeradataCredentialScanProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json ? new TeradataCredentialScanProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject into a new instance of <see cref="TeradataCredentialScanProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal TeradataCredentialScanProperties(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __mitiScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.MitiScanProperties(json);
            {_credential = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("credential"), out var __jsonCredential) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TeradataCredentialScanPropertiesCredential.FromJson(__jsonCredential) : _credential;}
            {_schema = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("schema"), out var __jsonSchema) ? (string)__jsonSchema : (string)_schema;}
            {_driverLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString>("driverLocation"), out var __jsonDriverLocation) ? (string)__jsonDriverLocation : (string)_driverLocation;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="TeradataCredentialScanProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="TeradataCredentialScanProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __mitiScanProperties?.ToJson(container, serializationMode);
            AddIf( null != this._credential ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._credential.ToJson(null,serializationMode) : null, "credential" ,container.Add );
            AddIf( null != (((object)this._schema)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._schema.ToString()) : null, "schema" ,container.Add );
            AddIf( null != (((object)this._driverLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(this._driverLocation.ToString()) : null, "driverLocation" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}