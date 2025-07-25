
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Update an identity in the specified subscription and resource group.
.Description
Update an identity in the specified subscription and resource group.
.Example
Update-AzUserAssignedIdentity -ResourceGroupName azure-rg-test -Name uai-pwsh01 -Tag @{'key01'='value01'; 'key02'='value02'}
.Example
Get-AzUserAssignedIdentity -ResourceGroupName azure-rg-test -Name uai-pwsh01 | Update-AzUserAssignedIdentity -Tag @{'key01'='value01'; 'key02'='value02'}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.IManagedServiceIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.IIdentity
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IManagedServiceIdentity>: Identity Parameter
  [FederatedIdentityCredentialResourceName <String>]: The name of the federated identity credential resource.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the Resource Group to which the identity belongs.
  [ResourceName <String>]: The name of the identity resource.
  [Scope <String>]: The resource provider scope of the resource. Parent resource being extended by Managed Identities.
  [SubscriptionId <String>]: The Id of the Subscription to which the identity belongs.
.Link
https://learn.microsoft.com/powershell/module/az.managedserviceidentity/update-azuserassignedidentity
#>
function Update-AzUserAssignedIdentity {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.IIdentity])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Path')]
    [System.String]
    # The name of the identity resource.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Path')]
    [System.String]
    # The name of the Resource Group to which the identity belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath')]
    [Parameter(ParameterSetName='UpdateViaJsonString')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Id of the Subscription to which the identity belongs.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.IManagedServiceIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.IIdentityUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Update operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Body')]
    [System.String]
    # Json string supplied to the Update operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $context = Get-AzContext
        if (-not $context -and -not $testPlayback) {
            Write-Error "No Azure login detected. Please run 'Connect-AzAccount' to log in."
            exit
        }

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.ManagedServiceIdentity.private\Update-AzUserAssignedIdentity_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.ManagedServiceIdentity.private\Update-AzUserAssignedIdentity_UpdateViaIdentityExpanded';
            UpdateViaJsonFilePath = 'Az.ManagedServiceIdentity.private\Update-AzUserAssignedIdentity_UpdateViaJsonFilePath';
            UpdateViaJsonString = 'Az.ManagedServiceIdentity.private\Update-AzUserAssignedIdentity_UpdateViaJsonString';
        }
        if (('UpdateExpanded', 'UpdateViaJsonFilePath', 'UpdateViaJsonString') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
