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
    /// Container network interface child resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContainerNetworkInterfaceInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerNetworkInterfaceInner
        /// class.
        /// </summary>
        public ContainerNetworkInterfaceInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerNetworkInterfaceInner
        /// class.
        /// </summary>
        /// <param name="containerNetworkInterfaceConfiguration">Container
        /// network interface configuration from which this container network
        /// interface is created.</param>
        /// <param name="container">Reference to the container to which this
        /// container network interface is attached.</param>
        /// <param name="ipConfigurations">Reference to the ip configuration on
        /// this container nic.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource.</param>
        /// <param name="name">The name of the resource. This name can be used
        /// to access the resource.</param>
        /// <param name="type">Sub Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ContainerNetworkInterfaceInner(string id = default(string), Management.ResourceManager.Fluent.SubResource containerNetworkInterfaceConfiguration = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource container = default(Management.ResourceManager.Fluent.SubResource), IList<ContainerNetworkInterfaceIpConfiguration> ipConfigurations = default(IList<ContainerNetworkInterfaceIpConfiguration>), string provisioningState = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id)
        {
            ContainerNetworkInterfaceConfiguration = containerNetworkInterfaceConfiguration;
            Container = container;
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
            Name = name;
            Type = type;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container network interface configuration from which
        /// this container network interface is created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerNetworkInterfaceConfiguration")]
        public Management.ResourceManager.Fluent.SubResource ContainerNetworkInterfaceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets reference to the container to which this container
        /// network interface is attached.
        /// </summary>
        [JsonProperty(PropertyName = "properties.container")]
        public Management.ResourceManager.Fluent.SubResource Container { get; set; }

        /// <summary>
        /// Gets or sets reference to the ip configuration on this container
        /// nic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<ContainerNetworkInterfaceIpConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource. This name can be used to
        /// access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets sub Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
