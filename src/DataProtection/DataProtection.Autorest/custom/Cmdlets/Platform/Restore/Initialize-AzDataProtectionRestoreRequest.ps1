﻿function Initialize-AzDataProtectionRestoreRequest
{
	[OutputType('Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest')]
    [CmdletBinding(PositionalBinding=$false, DefaultParameterSetName='AlternateLocationFullRecovery')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Description('Initializes Restore Request object for triggering restore on a protected backup instance.')]

    param(
        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory, HelpMessage='Datasource Type')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory, HelpMessage='Datasource Type')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='Datasource Type')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory, HelpMessage='Datasource Type')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='Datasource Type')]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DatasourceTypes]
        ${DatasourceType},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory, HelpMessage='DataStore Type of the Recovery point')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory, HelpMessage='DataStore Type of the Recovery point')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='DataStore Type of the Recovery point')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory, HelpMessage='DataStore Type of the Recovery point')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='DataStore Type of the Recovery point')]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreType]
        ${SourceDataStore},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Id of the recovery point to be restored.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Id of the recovery point to be restored.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Id of the recovery point to be restored.')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Id of the recovery point to be restored.')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Id of the recovery point to be restored.')]
        [System.String]
        ${RecoveryPoint},
        
        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Point In Time for restore.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Point In Time for restore.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Point In Time for restore.')]
        # [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Point In Time for restore.')]
        [System.DateTime]
        ${PointInTime},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Rehydration duration for the archived recovery point to stay rehydrated, default value for rehydration duration is 15.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Rehydration duration for the archived recovery point to stay rehydrated, default value for rehydration duration is 15.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Rehydration duration for the archived recovery point to stay rehydrated, default value for rehydration duration is 15.')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Rehydration duration for the archived recovery point to stay rehydrated, default value for rehydration duration is 15.')]
        # [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Rehydration duration for the archived recovery point to stay rehydrated, default value for rehydration duration is 15.')]
        [System.String]
        ${RehydrationDuration},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Rehydration priority for archived recovery point. This parameter is mandatory for rehydrate restore of archived points.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Rehydration priority for archived recovery point. This parameter is mandatory for rehydrate restore of archived points.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Rehydration priority for archived recovery point. This parameter is mandatory for rehydrate restore of archived points.')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Rehydration priority for archived recovery point. This parameter is mandatory for rehydrate restore of archived points.')]
        # [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Rehydration priority for archived recovery point. This parameter is mandatory for rehydrate restore of archived points.')]
        [ValidateSet("Standard")]
        [System.String]
        ${RehydrationPriority},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory, HelpMessage='Target Restore Location')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory, HelpMessage='Target Restore Location')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='Target Restore Location')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory, HelpMessage='Target Restore Location')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='Target Restore Location')]
        [System.String]
        ${RestoreLocation},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory, HelpMessage='Restore Target Type')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory, HelpMessage='Restore Target Type')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='Restore Target Type')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory, HelpMessage='Restore Target Type')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='Restore Target Type')]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreTargetType]
        ${RestoreType},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory, HelpMessage='Backup Instance object to trigger original location restore.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='Backup Instance object to trigger original location restore.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.BackupInstanceResource]
        ${BackupInstance},

        # this is applicable to all workloads wherever ALR supported.
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory, HelpMessage='Specify the target resource ID for restoring backup data in an alternate location. For instance, provide the target database ARM ID that you want to restore to, for workloadType AzureDatabaseForPostgreSQL.')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='Specify the target resource ID for restoring backup data in an alternate location. For instance, provide the target database ARM ID that you want to restore to, for workloadType AzureDatabaseForPostgreSQL.')]
        [System.String]
        ${TargetResourceId},

        # this parameter is being used in OSS cross subscription restore as files
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Target storage account container ARM Id to which backup data will be restored as files. This parameter is required for restoring as files when cross subscription restore is disabled on the backup vault.')]
        [System.String]
        ${TargetResourceIdForRestoreAsFile},

        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory, HelpMessage='Target storage account container Id to which backup data will be restored as files.')]
        [System.String]
        ${TargetContainerURI},

        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='File name to be prefixed to the restored backup data.')]
        [System.String]
        ${FileNamePrefix},

        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory, HelpMessage='Switch parameter to enable item level recovery.')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory, HelpMessage='Switch parameter to enable item level recovery.')]
        [Switch]
        ${ItemLevelRecovery},
                
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Container names for Item Level Recovery.')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Container names for Item Level Recovery.')]
        [System.String[]]
        ${ContainersList},
                
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Use this parameter to filter block blobs by prefix in a container for alternate location ILR. When you specify a prefix, only blobs matching that prefix in the container will be restored. Input for this parameter is a hashtable where each key is a container name and each value is an array of string prefixes for that container.')]
        [Hashtable]
        ${PrefixMatch},

        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Specify the blob restore start range for PITR. You can use this option to specify the starting range for a subset of blobs in each container to restore. use a forward slash (/) to separate the container name from the blob prefix pattern.')]
        # [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Minimum matching value for Item Level Recovery.')]
        [System.String[]]
        ${FromPrefixPattern},

        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Specify the blob restore end range for PITR. You can use this option to specify the ending range for a subset of blobs in each container to restore. use a forward slash (/) to separate the container name from the blob prefix pattern.')]
        # [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Maximum matching value for Item Level Recovery.')]
        [System.String[]]
        ${ToPrefixPattern},

        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Restore configuration for restore. Use this parameter to restore with AzureKubernetesService.')]
        [Parameter(ParameterSetName="AlternateLocationILR", Mandatory=$false, HelpMessage='Restore configuration for restore. Use this parameter to restore with AzureKubernetesService.')]
        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Restore configuration for restore. Use this parameter to restore with AzureKubernetesService.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Restore configuration for restore. Use this parameter to restore with AzureKubernetesService.')]
        [PSObject]
        ${RestoreConfiguration},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Secret uri for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Secret uri for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Secret uri for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Secret uri for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [System.String]
        ${SecretStoreURI},

        [Parameter(ParameterSetName="OriginalLocationFullRecovery", Mandatory=$false, HelpMessage='Secret store type for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="AlternateLocationFullRecovery", Mandatory=$false, HelpMessage='Secret store type for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="OriginalLocationILR", Mandatory=$false, HelpMessage='Secret store type for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [Parameter(ParameterSetName="RestoreAsFiles", Mandatory=$false, HelpMessage='Secret store type for secret store authentication of data source. This parameter is only supported for AzureDatabaseForPostgreSQL currently.')]
        [ValidateSet("AzureKeyVault")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreTypes]
        ${SecretStoreType},

        [Parameter(Mandatory=$false, ParameterSetName="OriginalLocationFullRecovery", HelpMessage='Use system assigned identity')]
        [Parameter(Mandatory=$false, ParameterSetName="AlternateLocationFullRecovery", HelpMessage='Use system assigned identity')]
        [Parameter(Mandatory=$false, ParameterSetName="OriginalLocationILR", HelpMessage='Use system assigned identity')]
        [Parameter(Mandatory=$false, ParameterSetName="RestoreAsFiles", HelpMessage='Use system assigned identity')]
        [Parameter(Mandatory=$false, ParameterSetName="AlternateLocationILR", HelpMessage='Use system assigned identity')]
        [System.Nullable[System.Boolean]]
        ${UseSystemAssignedIdentity},

        [Parameter(Mandatory=$false, ParameterSetName="OriginalLocationFullRecovery", HelpMessage='User assigned identity ARM Id')]
        [Parameter(Mandatory=$false, ParameterSetName="AlternateLocationFullRecovery", HelpMessage='User assigned identity ARM Id')]
        [Parameter(Mandatory=$false, ParameterSetName="OriginalLocationILR", HelpMessage='User assigned identity ARM Id')]
        [Parameter(Mandatory=$false, ParameterSetName="RestoreAsFiles", HelpMessage='User assigned identity ARM Id')]
        [Parameter(Mandatory=$false, ParameterSetName="AlternateLocationILR", HelpMessage='User assigned identity ARM Id')]
        [Alias('AssignUserIdentity')]
        [System.String]
        ${UserAssignedIdentityArmId}    
    )

    process
    {         
        # Validations
        $parameterSetName = $PsCmdlet.ParameterSetName

        $restoreRequest = $null
        $restoreMode = $null
        $manifest = LoadManifest -DatasourceType $DatasourceType.ToString()

        # Choose Restore Request Type Based on Recovery Point ID/ Time
        if(($RecoveryPoint -ne $null) -and ($RecoveryPoint -ne ""))
        {               
            Write-Debug -Message $RecoveryPoint
            
            if($PSBoundParameters.ContainsKey("RehydrationPriority")){
                $restoreRequest = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AzureBackupRestoreWithRehydrationRequest]::new()
                $restoreRequest.ObjectType = "AzureBackupRestoreWithRehydrationRequest"   
                $restoreRequest.RehydrationPriority = $RehydrationPriority
                if($PSBoundParameters.ContainsKey("RehydrationDuration")){
                    $restoreRequest.RehydrationRetentionDuration = "P" + $RehydrationDuration + "D"
                }
                else{
                    $restoreRequest.RehydrationRetentionDuration = "P15D"
                }                
            }
            else{
                $restoreRequest = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AzureBackupRecoveryPointBasedRestoreRequest]::new()
                $restoreRequest.ObjectType = "AzureBackupRecoveryPointBasedRestoreRequest"            
            }            
            $restoreRequest.RecoveryPointId = $RecoveryPoint
            $restoreMode = "RecoveryPointBased"
        }
        elseif(($PointInTime -ne $null)  -and ($PointInTime -ne "")) # RecoveryPointInTimeBasedRestore
        {
            $utcTime = $PointInTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.0000000Z")
            Write-Debug -Message $utcTime
            $restoreRequest = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AzureBackupRecoveryTimeBasedRestoreRequest]::new()
            $restoreRequest.ObjectType = "AzureBackupRecoveryTimeBasedRestoreRequest"
            $restoreRequest.RecoveryPointTime = $utcTime
            $restoreMode = "PointInTimeBased"
        }
        else{
            $errormsg = "Please input either RecoveryPoint or PointInTime parameter"
    		throw $errormsg
        }
        
        #Validate Restore Options = recoverypoint, ALR, OLR, ILR
        ValidateRestoreOptions -DatasourceType $DatasourceType -RestoreMode $restoreMode -RestoreTargetType $RestoreType -ItemLevelRecovery $ItemLevelRecovery -SecretStoreURI $SecretStoreURI

        # UAMI for restore
        $hasUseSystemAssignedIdentity = $PSBoundParameters.Remove("UseSystemAssignedIdentity")
        $hasUserAssignedIdentityArmId = $PSBoundParameters.Remove("UserAssignedIdentityArmId")
        if ($hasUseSystemAssignedIdentity -or $hasUserAssignedIdentityArmId) {

            if ($hasUserAssignedIdentityArmId -and (!$hasUseSystemAssignedIdentity -or $UseSystemAssignedIdentity)) {
                throw "UserAssignedIdentityArmId cannot be provided without UseSystemAssignedIdentity and UseSystemAssignedIdentity must be false when UserAssignedIdentityArmId is provided."
            }

            $restoreRequest.IdentityDetail = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20240401.IdentityDetails]::new()
            $restoreRequest.IdentityDetail.UseSystemAssignedIdentity = $UseSystemAssignedIdentity            

            if ($hasUserAssignedIdentityArmId) {
                $restoreRequest.IdentityDetail.UserAssignedIdentityArmUrl = $UserAssignedIdentityArmId
            }
        }

        # Initialize Restore Target Info based on Type provided

        if($RestoreType -eq "RestoreAsFiles") 
        {
           $restoreRequest.RestoreTargetInfo = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RestoreFilesTargetInfo]::new()
           $restoreRequest.RestoreTargetInfo.ObjectType = "RestoreFilesTargetInfo"

           if($manifest.fileNamePrefixDisabled -and $PSBoundParameters.ContainsKey("FileNamePrefix")){
               $errormsg = "FileNamePrefix can't be set for given DatasourceType. Please try again after removing FileNamePrefix parameter"
    		   throw $errormsg
           }
           elseif($manifest.fileNamePrefixDisabled -and !($PSBoundParameters.ContainsKey("TargetContainerURI"))){
               $errormsg = "TargetContainerURI parameter is required for RestoreAsFiles for given DatasourceType"
    		   throw $errormsg
           }
           elseif( !$manifest.fileNamePrefixDisabled -and (!($PSBoundParameters.ContainsKey("FileNamePrefix")) -or !($PSBoundParameters.ContainsKey("TargetContainerURI"))) ){
                $errormsg = "FileNamePrefix and TargetContainerURI parameters are required for RestoreAsFiles for given DatasourceType"
    		    throw $errormsg
           }

           if($manifest.fileNamePrefixDisabled){
               $restoreRequest.RestoreTargetInfo.TargetDetail.FilePrefix = "dummyprefix"
           }
           else{
               $restoreRequest.RestoreTargetInfo.TargetDetail.FilePrefix = $FileNamePrefix
           }
           
           $restoreRequest.RestoreTargetInfo.TargetDetail.RestoreTargetLocationType = "AzureBlobs"
           $restoreRequest.RestoreTargetInfo.TargetDetail.Url = $TargetContainerURI

           # mandatory for Cross Subscription restore scenario for OSS
           if(($PSBoundParameters.ContainsKey("TargetResourceIdForRestoreAsFile"))){
               $restoreRequest.RestoreTargetInfo.TargetDetail.TargetResourceArmId = $TargetResourceIdForRestoreAsFile                
           }
        }
        elseif(!($ItemLevelRecovery))
        {   
            # RestoreTargetInfo for OLR ALR Full recovery
            if($DatasourceType -ne "AzureKubernetesService"){
                $restoreRequest.RestoreTargetInfo = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RestoreTargetInfo]::new()
                $restoreRequest.RestoreTargetInfo.ObjectType = "restoreTargetInfo"
            }
            else{
                $restoreRequest.RestoreTargetInfo = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ItemLevelRestoreTargetInfo]::new()
                $restoreRequest.RestoreTargetInfo.ObjectType = "itemLevelRestoreTargetInfo"
                $restoreCriteriaList = @()

                # ItemLevelRecovery for AzureKubernetesService
                if($RestoreConfiguration -ne $null){
                    $restoreCriteria = $RestoreConfiguration
                }
                else{
                    $errormsg = "Please input parameter RestoreConfiguration for AKS cluster restore. Use command New-AzDataProtectionRestoreConfigurationClientObject for creating the RestoreConfiguration"
    		        throw $errormsg
                }                
                
                $restoreCriteriaList += ($restoreCriteria)
                $restoreRequest.RestoreTargetInfo.RestoreCriterion = $restoreCriteriaList
            }
        }        
        else 
        {
            # ILR: ItemLevelRestoreTargetInfo
            $restoreRequest.RestoreTargetInfo = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ItemLevelRestoreTargetInfo]::new()
            $restoreRequest.RestoreTargetInfo.ObjectType = "itemLevelRestoreTargetInfo"

            $restoreCriteriaList = @()
            
            # can generalise this condition to manifest level if needed
            if($DatasourceType -ne "AzureKubernetesService"){ # TODO: remove Datasource dependency
                
                if(($RecoveryPoint -ne $null) -and ($RecoveryPoint -ne "") -and $ContainersList.length -gt 0){
                    $hasPrefixMatch = $PSBoundParameters.Remove("PrefixMatch")
                    for($i = 0; $i -lt $ContainersList.length; $i++){
                                
                        $restoreCriteria = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ItemPathBasedRestoreCriteria]::new()

                        $restoreCriteria.ObjectType = "ItemPathBasedRestoreCriteria"
                        $restoreCriteria.ItemPath = $ContainersList[$i]
                        $restoreCriteria.IsPathRelativeToBackupItem = $true

                        if($hasPrefixMatch){
                            $pathPrefix = $PrefixMatch[$ContainersList[$i]]
                            if($pathPrefix -ne $null -and !($pathPrefix -is [Array])){
                                throw "values for PrefixMatch must be string array for each container"
                            }
                            $restoreCriteria.SubItemPathPrefix = $pathPrefix
                        }

                        # adding a criteria for each container given
                        $restoreCriteriaList += ($restoreCriteria)
                    }
                }
                elseif($ContainersList.length -gt 0){
                    for($i = 0; $i -lt $ContainersList.length; $i++){
                                
                        $restoreCriteria = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RangeBasedItemLevelRestoreCriteria]::new()

                        $restoreCriteria.ObjectType = "RangeBasedItemLevelRestoreCriteria"
                        $restoreCriteria.MinMatchingValue = $ContainersList[$i]
                        $restoreCriteria.MaxMatchingValue = $ContainersList[$i] + "-0"

                        # adding a criteria for each container given
                        $restoreCriteriaList += ($restoreCriteria)
                    }
                }
                elseif($FromPrefixPattern.length -gt 0){
                
                    if(($FromPrefixPattern.length -ne $ToPrefixPattern.length) -or ($FromPrefixPattern.length -gt 10) -or ($ToPrefixPattern.length -gt 10)){
                        $errormsg = "FromPrefixPattern and ToPrefixPattern parameters maximum length can be 10 and must be equal "
    			        throw $errormsg
                    }
                
                    for($i = 0; $i -lt $FromPrefixPattern.length; $i++){
                                
                        $restoreCriteria =  [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RangeBasedItemLevelRestoreCriteria]::new()

                        $restoreCriteria.ObjectType = "RangeBasedItemLevelRestoreCriteria"
                        $restoreCriteria.MinMatchingValue = $FromPrefixPattern[$i]
                        $restoreCriteria.MaxMatchingValue = $ToPrefixPattern[$i]

                        # adding a criteria for each container given
                        $restoreCriteriaList += ($restoreCriteria)
                    }                
                }    
                else{
                     $errormsg = "Provide ContainersList or Prefixes for Item Level Recovery"
    			     throw $errormsg            
                }
            }
            else{
                # ItemLevelRecovery for AzureKubernetesService
                if($RestoreConfiguration -ne $null){
                    $restoreCriteria = $RestoreConfiguration
                }
                else{
                    $errormsg = "Please input parameter RestoreConfiguration for AKS cluster restore. Use command New-AzDataProtectionRestoreConfigurationClientObject for creating the RestoreConfiguration"
    		        throw $errormsg
                }
                
                $restoreCriteriaList += ($restoreCriteria)
            }

            $restoreRequest.RestoreTargetInfo.RestoreCriterion = $restoreCriteriaList
        }

        # Fill other fields of Restore Object based on inputs given        
        $restoreRequest.SourceDataStoreType = $SourceDataStore
        $restoreRequest.RestoreTargetInfo.RestoreLocation = $RestoreLocation

        
        if($RestoreType -eq "AlternateLocation"){

            if(($TargetResourceId -eq $null) -or ($TargetResourceId -eq ""))
            {
                $errormsg = "Please input TargetResourceId for alternate location recovery"
    		    throw $errormsg
            }
            $resourceId = $TargetResourceId
        }
        elseif($RestoreType -eq "OriginalLocation"){

            if(($BackupInstance -eq $null) -or ($BackupInstance -eq ""))
            {                
                $errormsg = "Please input BackupInstance for original location recovery"
    		    throw $errormsg
            }
            $resourceId = $BackupInstance.Property.DataSourceInfo.ResourceId
        }

        if( ($resourceId -ne $null) -and ($resourceId -ne "") )
        {            
            # set DatasourceInfo for OLR, ALR, OriginalLocationILR
            $restoreRequest.RestoreTargetInfo.DatasourceInfo = GetDatasourceInfo -ResourceId $resourceId -ResourceLocation $RestoreLocation -DatasourceType $DatasourceType
            
            if($manifest.isProxyResource -eq $true)  
            {
                $restoreRequest.RestoreTargetInfo.DatasourceSetInfo = GetDatasourceSetInfo -DatasourceInfo $restoreRequest.RestoreTargetInfo.DatasourceInfo -DatasourceType $DatasourceType
            }
        } 
        
        # secret store authentication
        if($PSBoundParameters.ContainsKey("SecretStoreURI"))
        {
            if($manifest.supportSecretStoreAuthentication -eq $true){
                if(!($PSBoundParameters.ContainsKey("SecretStoreType")))
                {        
                    $errormsg = "Please input SecretStoreType"
        		    throw $errormsg                    
                }
                $restoreRequest.RestoreTargetInfo.DatasourceAuthCredentials = [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SecretStoreBasedAuthCredentials]::new()
                $restoreRequest.RestoreTargetInfo.DatasourceAuthCredentials.ObjectType = "SecretStoreBasedAuthCredentials"
                $restoreRequest.RestoreTargetInfo.DatasourceAuthCredentials.SecretStoreResource =  [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SecretStoreResource]::new()
                $restoreRequest.RestoreTargetInfo.DatasourceAuthCredentials.SecretStoreResource.SecretStoreType = $SecretStoreType
                $restoreRequest.RestoreTargetInfo.DatasourceAuthCredentials.SecretStoreResource.Uri = $SecretStoreURI
            }
            else{
                $errormsg = "Please ensure that secret store based authentication is supported for given data source"
        		throw $errormsg
            }            
        }

        return $restoreRequest
    }
}