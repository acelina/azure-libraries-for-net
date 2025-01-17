// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// P2SVpnGateway Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class P2SVpnGatewayInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the P2SVpnGatewayInner class.
        /// </summary>
        public P2SVpnGatewayInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SVpnGatewayInner class.
        /// </summary>
        /// <param name="virtualHub">The VirtualHub to which the gateway
        /// belongs.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="vpnGatewayScaleUnit">The scale unit for this p2s vpn
        /// gateway.</param>
        /// <param name="p2SVpnServerConfiguration">The
        /// P2SVpnServerConfiguration to which the p2sVpnGateway is attached
        /// to.</param>
        /// <param name="vpnClientAddressPool">The reference of the address
        /// space resource which represents Address space for P2S
        /// VpnClient.</param>
        /// <param name="customRoutes">The reference of the address space
        /// resource which represents the custom routes specified by the
        /// customer for P2SVpnGateway and P2S VpnClient.</param>
        /// <param name="vpnClientConnectionHealth">All P2S VPN clients'
        /// connection health status.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public P2SVpnGatewayInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Management.ResourceManager.Fluent.SubResource virtualHub = default(Management.ResourceManager.Fluent.SubResource), ProvisioningState provisioningState = default(ProvisioningState), int? vpnGatewayScaleUnit = default(int?), Management.ResourceManager.Fluent.SubResource p2SVpnServerConfiguration = default(Management.ResourceManager.Fluent.SubResource), AddressSpace vpnClientAddressPool = default(AddressSpace), AddressSpace customRoutes = default(AddressSpace), VpnClientConnectionHealth vpnClientConnectionHealth = default(VpnClientConnectionHealth), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            VirtualHub = virtualHub;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            P2SVpnServerConfiguration = p2SVpnServerConfiguration;
            VpnClientAddressPool = vpnClientAddressPool;
            CustomRoutes = customRoutes;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public Management.ResourceManager.Fluent.SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the scale unit for this p2s vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayScaleUnit")]
        public int? VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets the P2SVpnServerConfiguration to which the
        /// p2sVpnGateway is attached to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2SVpnServerConfiguration")]
        public Management.ResourceManager.Fluent.SubResource P2SVpnServerConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents Address space for P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents the custom routes specified by the customer for
        /// P2SVpnGateway and P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customRoutes")]
        public AddressSpace CustomRoutes { get; set; }

        /// <summary>
        /// Gets all P2S VPN clients' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConnectionHealth")]
        public VpnClientConnectionHealth VpnClientConnectionHealth { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
