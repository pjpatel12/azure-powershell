// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Runtime.PowerShell;

    /// <summary>The updatable properties of the OrganizationResource.</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceUpdatePropertiesTypeConverter))]
    public partial class OrganizationResourceUpdateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationResourceUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationResourceUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationResourceUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="OrganizationResourceUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationResourceUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IUserDetailsUpdate) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.UserDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IPartnerPropertiesUpdate) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.PartnerPropertiesUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("UserCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserCompanyName = (string) content.GetValueForProperty("UserCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationId = (string) content.GetValueForProperty("PartnerPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRedirectUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyRedirectUrl = (string) content.GetValueForProperty("PartnerPropertyRedirectUrl",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyRedirectUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationName = (string) content.GetValueForProperty("PartnerPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationResourceUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IUserDetailsUpdate) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.UserDetailsUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IPartnerPropertiesUpdate) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.PartnerPropertiesUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("UserCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserCompanyName = (string) content.GetValueForProperty("UserCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationId = (string) content.GetValueForProperty("PartnerPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyRedirectUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyRedirectUrl = (string) content.GetValueForProperty("PartnerPropertyRedirectUrl",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyRedirectUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationName = (string) content.GetValueForProperty("PartnerPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerPropertyOrganizationName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MongoDB.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The updatable properties of the OrganizationResource.
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceUpdatePropertiesTypeConverter))]
    public partial interface IOrganizationResourceUpdateProperties

    {

    }
}