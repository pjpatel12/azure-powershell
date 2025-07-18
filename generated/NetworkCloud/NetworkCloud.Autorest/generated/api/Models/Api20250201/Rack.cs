// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// Rack represents the hardware of the rack and is dependent upon the cluster for lifecycle.
    /// </summary>
    public partial class Rack :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRack,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.TrackedResource();

        /// <summary>
        /// The value that will be used for machines in this rack to represent the availability zones that can be referenced by Hybrid
        /// AKS Clusters for node arrangement.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).AvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).AvailabilityZone = value ; }

        /// <summary>
        /// The resource ID of the cluster the rack is created for. This value is set when the rack is created by the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ClusterId; }

        /// <summary>The more detailed status of the rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackDetailedStatus? DetailedStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatus; }

        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string DetailedStatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatusMessage; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>Resource ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Backing field for <see cref="ExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation _extendedLocation;

        /// <summary>The extended location of the cluster associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ExtendedLocation()); set => this._extendedLocation = value; }

        /// <summary>The resource ID of the extended location on which the resource will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocationInternal)ExtendedLocation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocationInternal)ExtendedLocation).Name = value ; }

        /// <summary>The extended location type, for example, CustomLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocationInternal)ExtendedLocation).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocationInternal)ExtendedLocation).Type = value ; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for ClusterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ClusterId = value; }

        /// <summary>Internal Acessors for DetailedStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackDetailedStatus? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.DetailedStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatus = value; }

        /// <summary>Internal Acessors for DetailedStatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.DetailedStatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatusMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).DetailedStatusMessage = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ExtendedLocation()); set { {_extendedLocation = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.RackProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackProperties _property;

        /// <summary>The list of the resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.RackProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the rack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// The free-form description of the rack location. (e.g. “DTN Datacenter, Floor 3, Isle 9, Rack 2B”)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string RackLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackLocation = value ; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial
        /// number may be provided if desired.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackSerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackSerialNumber = value ; }

        /// <summary>The SKU for the rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string SkuId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackSkuId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackPropertiesInternal)Property).RackSkuId = value ; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Rack" /> instance.</summary>
        public Rack()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Rack represents the hardware of the rack and is dependent upon the cluster for lifecycle.
    public partial interface IRack :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResource
    {
        /// <summary>
        /// The value that will be used for machines in this rack to represent the availability zones that can be referenced by Hybrid
        /// AKS Clusters for node arrangement.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The value that will be used for machines in this rack to represent the availability zones that can be referenced by Hybrid AKS Clusters for node arrangement.",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
        /// <summary>
        /// The resource ID of the cluster the rack is created for. This value is set when the rack is created by the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource ID of the cluster the rack is created for. This value is set when the rack is created by the cluster.",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterId { get;  }
        /// <summary>The more detailed status of the rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The more detailed status of the rack.",
        SerializedName = @"detailedStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackDetailedStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackDetailedStatus? DetailedStatus { get;  }
        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The descriptive message about the current detailed status.",
        SerializedName = @"detailedStatusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string DetailedStatusMessage { get;  }
        /// <summary>Resource ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource ETag.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>The resource ID of the extended location on which the resource will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID of the extended location on which the resource will be created.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type, for example, CustomLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The extended location type, for example, CustomLocation.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationType { get; set; }
        /// <summary>The provisioning state of the rack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the rack resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// The free-form description of the rack location. (e.g. “DTN Datacenter, Floor 3, Isle 9, Rack 2B”)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The free-form description of the rack location. (e.g. “DTN Datacenter, Floor 3, Isle 9, Rack 2B”)",
        SerializedName = @"rackLocation",
        PossibleTypes = new [] { typeof(string) })]
        string RackLocation { get; set; }
        /// <summary>
        /// The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial
        /// number may be provided if desired.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial number may be provided if desired.",
        SerializedName = @"rackSerialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>The SKU for the rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The SKU for the rack.",
        SerializedName = @"rackSkuId",
        PossibleTypes = new [] { typeof(string) })]
        string SkuId { get; set; }

    }
    /// Rack represents the hardware of the rack and is dependent upon the cluster for lifecycle.
    internal partial interface IRackInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal
    {
        /// <summary>
        /// The value that will be used for machines in this rack to represent the availability zones that can be referenced by Hybrid
        /// AKS Clusters for node arrangement.
        /// </summary>
        string AvailabilityZone { get; set; }
        /// <summary>
        /// The resource ID of the cluster the rack is created for. This value is set when the rack is created by the cluster.
        /// </summary>
        string ClusterId { get; set; }
        /// <summary>The more detailed status of the rack.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackDetailedStatus? DetailedStatus { get; set; }
        /// <summary>The descriptive message about the current detailed status.</summary>
        string DetailedStatusMessage { get; set; }
        /// <summary>Resource ETag.</summary>
        string Etag { get; set; }
        /// <summary>The extended location of the cluster associated with the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation ExtendedLocation { get; set; }
        /// <summary>The resource ID of the extended location on which the resource will be created.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type, for example, CustomLocation.</summary>
        string ExtendedLocationType { get; set; }
        /// <summary>The list of the resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackProperties Property { get; set; }
        /// <summary>The provisioning state of the rack resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.RackProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The free-form description of the rack location. (e.g. “DTN Datacenter, Floor 3, Isle 9, Rack 2B”)
        /// </summary>
        string RackLocation { get; set; }
        /// <summary>
        /// The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial
        /// number may be provided if desired.
        /// </summary>
        string SerialNumber { get; set; }
        /// <summary>The SKU for the rack.</summary>
        string SkuId { get; set; }

    }
}