// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Add", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ExpressRouteCircuitPeeringConfig", DefaultParameterSetName = "SetByResource"), OutputType(typeof(PSExpressRouteCircuit))]
    public class AddAzureExpressRouteCircuitPeeringConfigCommand : AzureExpressRouteCircuitPeeringConfigBase
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the Peering")]
        [ValidateNotNullOrEmpty]
        public override string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The ExpressRouteCircuit")]
        public PSExpressRouteCircuit ExpressRouteCircuit { get; set; }

        public override void Execute()
        {
            base.Execute();
            // Verify if the subnet exists in the VirtualNetwork
            var peering = this.ExpressRouteCircuit.Peerings.SingleOrDefault(resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

            if (peering != null)
            {
                throw new ArgumentException("Peering with the specified name already exists");
            }


            if (string.Equals(ParameterSetName, ParamSetByRouteFilter))
            {
                if (this.RouteFilter != null)
                {
                    this.RouteFilterId = this.RouteFilter.Id;
                }
            }

            peering = new PSPeering();

            peering.Name = this.Name;
            peering.PeeringType = this.PeeringType;
            peering.PeerASN = this.PeerASN;
            peering.VlanId = this.VlanId;


            if (!string.IsNullOrEmpty(this.SharedKey))
            {
                peering.SharedKey = this.SharedKey;
            }

            if (AddressTypeUtils.IsIpv6(this.PeerAddressType))
            {
                this.SetIpv6PeeringParameters(peering);
            }
            else
            {
                // Set IPv4 config even if no PeerAddressType has been specified for backward compatibility
                this.SetIpv4PeeringParameters(peering);
            }

            this.ConstructMicrosoftConfig(peering);

            this.ExpressRouteCircuit.Peerings.Add(peering);

            WriteObject(this.ExpressRouteCircuit);
        }
    }
}
