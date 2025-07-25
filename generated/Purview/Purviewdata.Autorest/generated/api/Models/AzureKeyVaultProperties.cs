// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AzureKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGenerated __azureKeyVaultPropertiesAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureKeyVaultPropertiesAutoGenerated();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string BaseUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGeneratedInternal)__azureKeyVaultPropertiesAutoGenerated).BaseUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGeneratedInternal)__azureKeyVaultPropertiesAutoGenerated).BaseUrl = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGeneratedInternal)__azureKeyVaultPropertiesAutoGenerated).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGeneratedInternal)__azureKeyVaultPropertiesAutoGenerated).Description = value ?? null; }

        /// <summary>Creates an new <see cref="AzureKeyVaultProperties" /> instance.</summary>
        public AzureKeyVaultProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureKeyVaultPropertiesAutoGenerated), __azureKeyVaultPropertiesAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__azureKeyVaultPropertiesAutoGenerated), __azureKeyVaultPropertiesAutoGenerated);
        }
    }
    public partial interface IAzureKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGenerated
    {

    }
    internal partial interface IAzureKeyVaultPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureKeyVaultPropertiesAutoGeneratedInternal
    {

    }
}