param (
    [string]$RepoRoot
)

$utilFilePath = Join-Path $RepoRoot '.azure-pipelines' 'PipelineSteps' 'BatchGeneration' 'util.psm1'
Import-Module $utilFilePath -Force

$pipelineName = $env:BUILD_DEFINITIONNAME
$pipelineUrl = "$($env:SYSTEM_TEAMFOUNDATIONCOLLECTIONURI)$($env:SYSTEM_TEAMPROJECT)/_build?definitionId=$($env:SYSTEM_DEFINITIONID)"
$runUrl = "$($env:SYSTEM_TEAMFOUNDATIONCOLLECTIONURI)$($env:SYSTEM_TEAMPROJECT)/_build/results?buildId=$($env:BUILD_BUILDID)"

$templateFilePath = Join-Path $RepoRoot '.azure-pipelines' 'PipelineSteps' 'BatchGeneration' 'FailedJobTeamsTemplate.html'
$notificationTemplate = Get-Content -Path $templateFilePath -Raw
$notificationContent = $notificationTemplate -replace "{{ pipelineName }}", $pipelineName `
                                            -replace "{{ pipelineUrl }}", $pipelineUrl `
                                            -replace "{{ runUrl }}", $runUrl

$notificationReceivers = if ($env:NotificationReceiversOverride -and $env:NotificationReceiversOverride -ne 'none') { $env:NotificationReceiversOverride } else { $env:FailedJobNotificationReceivers }
Write-Host "Notification receivers: $notificationReceivers"

Send-Teams `
    -to $notificationReceivers `
    -title "Batch Generation Job Failed" `
    -content $notificationContent
