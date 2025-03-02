// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of the load balancer backend addresses.</summary>
    public partial class LoadBalancerBackendAddressPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="AdminState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? _adminState;

        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get => this._adminState; set => this._adminState = value; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="InboundNatRulesPortMapping" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] _inboundNatRulesPortMapping;

        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get => this._inboundNatRulesPortMapping; }

        /// <summary>Backing field for <see cref="LoadBalancerFrontendIPConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated _loadBalancerFrontendIPConfiguration;

        /// <summary>
        /// Reference to the frontend ip address configuration defined in regional loadbalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated LoadBalancerFrontendIPConfiguration { get => (this._loadBalancerFrontendIPConfiguration = this._loadBalancerFrontendIPConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set => this._loadBalancerFrontendIPConfiguration = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string LoadBalancerFrontendIPConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)LoadBalancerFrontendIPConfiguration).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)LoadBalancerFrontendIPConfiguration).Id = value ?? null; }

        /// <summary>Internal Acessors for InboundNatRulesPortMapping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal.InboundNatRulesPortMapping { get => this._inboundNatRulesPortMapping; set { {_inboundNatRulesPortMapping = value;} } }

        /// <summary>Internal Acessors for LoadBalancerFrontendIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal.LoadBalancerFrontendIPConfiguration { get => (this._loadBalancerFrontendIPConfiguration = this._loadBalancerFrontendIPConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set { {_loadBalancerFrontendIPConfiguration = value;} } }

        /// <summary>Internal Acessors for NetworkInterfaceIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal.NetworkInterfaceIPConfiguration { get => (this._networkInterfaceIPConfiguration = this._networkInterfaceIPConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set { {_networkInterfaceIPConfiguration = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal.Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set { {_subnet = value;} } }

        /// <summary>Internal Acessors for VirtualNetwork</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal.VirtualNetwork { get => (this._virtualNetwork = this._virtualNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set { {_virtualNetwork = value;} } }

        /// <summary>Backing field for <see cref="NetworkInterfaceIPConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated _networkInterfaceIPConfiguration;

        /// <summary>Reference to IP address defined in network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated NetworkInterfaceIPConfiguration { get => (this._networkInterfaceIPConfiguration = this._networkInterfaceIPConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string NetworkInterfaceIPConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)NetworkInterfaceIPConfiguration).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)NetworkInterfaceIPConfiguration).Id = value ?? null; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated _subnet;

        /// <summary>Reference to an existing subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set => this._subnet = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)Subnet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)Subnet).Id = value ?? null; }

        /// <summary>Backing field for <see cref="VirtualNetwork" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated _virtualNetwork;

        /// <summary>Reference to an existing virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated VirtualNetwork { get => (this._virtualNetwork = this._virtualNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set => this._virtualNetwork = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string VirtualNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)VirtualNetwork).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)VirtualNetwork).Id = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="LoadBalancerBackendAddressPropertiesFormat" /> instance.
        /// </summary>
        public LoadBalancerBackendAddressPropertiesFormat()
        {

        }
    }
    /// Properties of the load balancer backend addresses.
    public partial interface ILoadBalancerBackendAddressPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of administrative states which once set can override health probe so that Load Balancer will always forward new connections to backend, or deny new connections and reset existing connections.",
        SerializedName = @"adminState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get; set; }
        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP Address belonging to the referenced virtual network.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Collection of inbound NAT rule port mappings.",
        SerializedName = @"inboundNatRulesPortMapping",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerFrontendIPConfigurationId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceIPConfigurationId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkId { get; set; }

    }
    /// Properties of the load balancer backend addresses.
    internal partial interface ILoadBalancerBackendAddressPropertiesFormatInternal

    {
        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get; set; }
        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        string IPAddress { get; set; }
        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get; set; }
        /// <summary>
        /// Reference to the frontend ip address configuration defined in regional loadbalancer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated LoadBalancerFrontendIPConfiguration { get; set; }
        /// <summary>Resource ID.</summary>
        string LoadBalancerFrontendIPConfigurationId { get; set; }
        /// <summary>Reference to IP address defined in network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated NetworkInterfaceIPConfiguration { get; set; }
        /// <summary>Resource ID.</summary>
        string NetworkInterfaceIPConfigurationId { get; set; }
        /// <summary>Reference to an existing subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Subnet { get; set; }
        /// <summary>Resource ID.</summary>
        string SubnetId { get; set; }
        /// <summary>Reference to an existing virtual network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated VirtualNetwork { get; set; }
        /// <summary>Resource ID.</summary>
        string VirtualNetworkId { get; set; }

    }
}