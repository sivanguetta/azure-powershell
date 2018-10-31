//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ContainerServiceConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSContainerService))]
    public partial class NewAzureRmContainerServiceConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.ContainerService/containerServices")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public ContainerServiceOrchestratorTypes? OrchestratorType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public int MasterCount { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string MasterDnsPrefix { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public ContainerServiceAgentPoolProfile[] AgentPoolProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public string WindowsProfileAdminUsername { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public string WindowsProfileAdminPassword { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public string AdminUsername { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public string[] SshPublicKey { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public bool VmDiagnosticsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string CustomProfileOrchestrator { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ServicePrincipalProfileClientId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ServicePrincipalProfileSecret { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("ContainerService", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // OrchestratorProfile
            ContainerServiceOrchestratorProfile vOrchestratorProfile = null;

            // CustomProfile
            ContainerServiceCustomProfile vCustomProfile = null;

            // ServicePrincipalProfile
            ContainerServiceServicePrincipalProfile vServicePrincipalProfile = null;

            // MasterProfile
            ContainerServiceMasterProfile vMasterProfile = null;

            // WindowsProfile
            ContainerServiceWindowsProfile vWindowsProfile = null;

            // LinuxProfile
            ContainerServiceLinuxProfile vLinuxProfile = null;

            // DiagnosticsProfile
            ContainerServiceDiagnosticsProfile vDiagnosticsProfile = null;

            if (this.MyInvocation.BoundParameters.ContainsKey("OrchestratorType"))
            {
                if (vOrchestratorProfile == null)
                {
                    vOrchestratorProfile = new ContainerServiceOrchestratorProfile();
                }
                vOrchestratorProfile.OrchestratorType = this.OrchestratorType.Value;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("CustomProfileOrchestrator"))
            {
                if (vCustomProfile == null)
                {
                    vCustomProfile = new ContainerServiceCustomProfile();
                }
                vCustomProfile.Orchestrator = this.CustomProfileOrchestrator;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ServicePrincipalProfileClientId"))
            {
                if (vServicePrincipalProfile == null)
                {
                    vServicePrincipalProfile = new ContainerServiceServicePrincipalProfile();
                }
                vServicePrincipalProfile.ClientId = this.ServicePrincipalProfileClientId;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ServicePrincipalProfileSecret"))
            {
                if (vServicePrincipalProfile == null)
                {
                    vServicePrincipalProfile = new ContainerServiceServicePrincipalProfile();
                }
                vServicePrincipalProfile.Secret = this.ServicePrincipalProfileSecret;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("MasterCount"))
            {
                if (vMasterProfile == null)
                {
                    vMasterProfile = new ContainerServiceMasterProfile();
                }
                vMasterProfile.Count = this.MasterCount;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("MasterDnsPrefix"))
            {
                if (vMasterProfile == null)
                {
                    vMasterProfile = new ContainerServiceMasterProfile();
                }
                vMasterProfile.DnsPrefix = this.MasterDnsPrefix;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("WindowsProfileAdminUsername"))
            {
                if (vWindowsProfile == null)
                {
                    vWindowsProfile = new ContainerServiceWindowsProfile();
                }
                vWindowsProfile.AdminUsername = this.WindowsProfileAdminUsername;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("WindowsProfileAdminPassword"))
            {
                if (vWindowsProfile == null)
                {
                    vWindowsProfile = new ContainerServiceWindowsProfile();
                }
                vWindowsProfile.AdminPassword = this.WindowsProfileAdminPassword;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("AdminUsername"))
            {
                if (vLinuxProfile == null)
                {
                    vLinuxProfile = new ContainerServiceLinuxProfile();
                }
                vLinuxProfile.AdminUsername = this.AdminUsername;
            }


            if (this.MyInvocation.BoundParameters.ContainsKey("SshPublicKey"))
            {
                if (vLinuxProfile == null)
                {
                    vLinuxProfile = new ContainerServiceLinuxProfile();
                }
                if (vLinuxProfile.Ssh == null)
                {
                    vLinuxProfile.Ssh = new ContainerServiceSshConfiguration();
                }
                if (vLinuxProfile.Ssh.PublicKeys == null)
                {
                    vLinuxProfile.Ssh.PublicKeys = new List<ContainerServiceSshPublicKey>();
                }
                foreach (var element in this.SshPublicKey)
                {
                    var vPublicKeys = new ContainerServiceSshPublicKey();
                    vPublicKeys.KeyData = element;
                    vLinuxProfile.Ssh.PublicKeys.Add(vPublicKeys);
                }
            }

            if (vDiagnosticsProfile == null)
            {
                vDiagnosticsProfile = new ContainerServiceDiagnosticsProfile();
            }
            if (vDiagnosticsProfile.VmDiagnostics == null)
            {
                vDiagnosticsProfile.VmDiagnostics = new ContainerServiceVMDiagnostics();
            }

            vDiagnosticsProfile.VmDiagnostics.Enabled = this.VmDiagnosticsEnabled;

            var vContainerService = new PSContainerService
            {
                Location = this.MyInvocation.BoundParameters.ContainsKey("Location") ? this.Location : null,
                Tags = this.MyInvocation.BoundParameters.ContainsKey("Tag") ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                AgentPoolProfiles = this.MyInvocation.BoundParameters.ContainsKey("AgentPoolProfile") ? this.AgentPoolProfile : null,
                OrchestratorProfile = vOrchestratorProfile,
                CustomProfile = vCustomProfile,
                ServicePrincipalProfile = vServicePrincipalProfile,
                MasterProfile = vMasterProfile,
                WindowsProfile = vWindowsProfile,
                LinuxProfile = vLinuxProfile,
                DiagnosticsProfile = vDiagnosticsProfile,
            };

            WriteObject(vContainerService);
        }
    }
}
