// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.PowerShell;

    /// <summary>
    /// ControlPlaneNodeConfiguration represents the selection of virtual machines and size of the control plane for a Kubernetes
    /// cluster.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ControlPlaneNodeConfigurationTypeConverter))]
    public partial class ControlPlaneNodeConfiguration
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ControlPlaneNodeConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ControlPlaneNodeConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AdministratorConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministratorConfiguration) content.GetValueForProperty("AdministratorConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministratorConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AvailabilityZone = (string[]) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Count"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).Count = (long) content.GetValueForProperty("Count",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).Count, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VMSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).VMSkuName = (string) content.GetValueForProperty("VMSkuName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).VMSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorConfigurationAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationAdminUsername = (string) content.GetValueForProperty("AdministratorConfigurationAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorConfigurationSshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationSshPublicKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[]) content.GetValueForProperty("AdministratorConfigurationSshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationSshPublicKey, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.SshPublicKeyTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ControlPlaneNodeConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ControlPlaneNodeConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AdministratorConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministratorConfiguration) content.GetValueForProperty("AdministratorConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfiguration, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministratorConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AvailabilityZone = (string[]) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Count"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).Count = (long) content.GetValueForProperty("Count",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).Count, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VMSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).VMSkuName = (string) content.GetValueForProperty("VMSkuName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).VMSkuName, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorConfigurationAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationAdminUsername = (string) content.GetValueForProperty("AdministratorConfigurationAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdministratorConfigurationSshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationSshPublicKey = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[]) content.GetValueForProperty("AdministratorConfigurationSshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfigurationInternal)this).AdministratorConfigurationSshPublicKey, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.SshPublicKeyTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ControlPlaneNodeConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ControlPlaneNodeConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ControlPlaneNodeConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ControlPlaneNodeConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ControlPlaneNodeConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ControlPlaneNodeConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IControlPlaneNodeConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// ControlPlaneNodeConfiguration represents the selection of virtual machines and size of the control plane for a Kubernetes
    /// cluster.
    [System.ComponentModel.TypeConverter(typeof(ControlPlaneNodeConfigurationTypeConverter))]
    public partial interface IControlPlaneNodeConfiguration

    {

    }
}