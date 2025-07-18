<!-- region Generated -->
# Az.LabServices
This directory contains the PowerShell module for the LabServices service.

---
## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.7.5 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.LabServices`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@autorest`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest-beta`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.azure.noprofile.md
# lock the commit
commit: 6d7653ffd37cdc781e16202306567e355b45ebf8
input-file:
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/Images.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/LabPlans.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/LabServices.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/Labs.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/OperationResults.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/Schedules.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/Users.json
  - $(repo)/specification/labservices/resource-manager/Microsoft.LabServices/preview/2021-10-01-preview/VirtualMachines.json
module-version: 0.1.0
title: LabServices
subject-prefix: $(service-name)

inlining-threshold: 50

directive:

  - where:
      verb: (.*)
    set:
      breaking-change:
        deprecated-by-version: '-'
        deprecated-by-azversion: 18.2.0
        change-effective-date: 2027/06/28
        change-description: Azure Lab Services will be retired on June 28, 2027, please see details on https://azure.microsoft.com/en-us/updates?id=azure-lab-services-is-being-retired.

  # reset vm password / New Lab / Update lab to set securestring passwords
  - from: swagger-document
    where: $.definitions.ResetPasswordBody.properties.password
    transform: >-
      return {
          "description": "The password",
          "type": "string",
          "x-ms-secret": true,
          "x-ms-mutability": [
            "create"
          ],
          "format": "password"
        }
  - from: swagger-document
    where: $.definitions.Credentials.properties.password
    transform: >-
      return {
          "description": "The password for the user. This is required for the TemplateVM createOption.",
          "type": "string",
          "x-ms-secret": true,
          "x-ms-mutability": [
            "create",
            "update"
          ],
          "format": "password"
        }
  # Fix update
  - from: swagger-document
    where: $.definitions.Credentials.properties.username
    transform: $['x-ms-mutability'] = ["read", "update", "create"]
  - from: swagger-document
    where: $.definitions.VirtualMachineAdditionalCapabilities.properties.installGpuDrivers
    transform: $['x-ms-mutability'] = ["read", "update", "create"]
  - from: swagger-document
    where: $.definitions.VirtualMachineProfile.properties.imageReference
    transform: $['x-ms-mutability'] = ["read", "update", "create"]
  # Fix bug that the words of create or update will be replaced
  - from: source-file-csharp
    where: $
    transform: $ = $.replace(/"Publish or re-publish a lab. This will publish all lab resources, such as virtual machines."/g, '"Publish or re-publish a lab. This will create or update all lab resources, such as virtual machines."');
  # change VirtualMachine to VM
  - where:
      subject: ^(.*)(VirtualMachine)(.*)$
    set:
      subject: $1VM$3
  # change Invoke to Send for InviteUser
  - where:
      verb: Invoke
      subject: ^(.*)(InviteUser)(.*)$
    set:
      verb: Send
      subject: $1UserInvite$3
  # change Invoke to Redeploy-AzLabVM
  - where:
      verb: Invoke
      subject: ^(.*)(RedeployVM)(.*)$
    set:
      verb: Start
      subject: $1VMRedeployment$3
  # Change the sync group to users
  - where:
      verb: Sync
      subject: ^(.*)(Group)(.*)$
    set:
      subject: $1User$3
  # Change Update-xxxVM to Update-AzLabVMReimage
  - where:
      verb: Update
      subject: ^(.*)(VM)
    set:
      subject: $1VMReimage
  # Remove operation cmdlets
  - where:
      subject: Operation
    remove: true
  # Remove OperationResult to Operation
  - where:
      subject: OperationResult
    remove: true
  # remove the New cmdlets and alias the Set ones - aliasing doesn't work with regex-replacement so we have to explicitly identify all of them
  - where:
      verb: Set
      subject: Lab
    set:
      alias: New-AzLab
  - where:
      verb: Set
      subject: LabImage
    set:
      alias: New-AzLabImage
  - where:
      verb: Set
      subject: LabPlan
    set:
      alias: New-AzLabPlan
  - where:
      verb: Set
      subject: Schedule
    set:
      alias: New-AzLabSchedule
  - where:
      verb: Set
      subject: User
    set:
      alias: New-AzLabUser
  - where:
      verb: Set
    remove: true
  # Change LabImage to LabPlanImage
  - where:
      verb: Get
      subject: ^(.*)(Image)(.*)$
    set:
      subject: $1PlanImage$3
  - where:
      verb: Get
      subject: AzLabImage
    remove: true
  - where:
      verb: New
      subject: ^(.*)(Image)(.*)$
    remove: true  
  - where:
      verb: Update
      subject: ^(.*)(Image)(.*)$
    set:
      subject: $1PlanImage$3
  - where:
      verb: Update
      subject: AzLabImage
    remove: true
  - where:
      verb: Update
      subject: ^(.*)VMRePlanImage
    set:
      verb: Update
      subject: $1VMReimage
  - where:
      variant: ^(Create|Update|Reset|Save|Invite)(?!.*?(Expanded|JsonFilePath|JsonString)) 
    remove: true
  - where:
      variant: ^CreateViaIdentityExpanded$
    remove: true
  # Custom new variant (rename parameter)
  - where:
      verb: Get
      subject: Lab
    hide: true
```
