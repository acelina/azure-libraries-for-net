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
    /// ExpressRoutePorts Peering Location
    /// </summary>
    /// <remarks>
    /// Definition of the ExpressRoutePorts peering location resource.
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRoutePortsLocationInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRoutePortsLocationInner
        /// class.
        /// </summary>
        public ExpressRoutePortsLocationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRoutePortsLocationInner
        /// class.
        /// </summary>
        /// <param name="address">Address of peering location.</param>
        /// <param name="contact">Contact details of peering locations.</param>
        /// <param name="availableBandwidths">The inventory of available
        /// ExpressRoutePort bandwidths.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// ExpressRoutePortLocation resource. Possible values are:
        /// 'Succeeded', 'Updating', 'Deleting', and 'Failed'.</param>
        public ExpressRoutePortsLocationInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string address = default(string), string contact = default(string), IList<ExpressRoutePortsLocationBandwidths> availableBandwidths = default(IList<ExpressRoutePortsLocationBandwidths>), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Address = address;
            Contact = contact;
            AvailableBandwidths = availableBandwidths;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets address of peering location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.address")]
        public string Address { get; private set; }

        /// <summary>
        /// Gets contact details of peering locations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contact")]
        public string Contact { get; private set; }

        /// <summary>
        /// Gets or sets the inventory of available ExpressRoutePort
        /// bandwidths.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availableBandwidths")]
        public IList<ExpressRoutePortsLocationBandwidths> AvailableBandwidths { get; set; }

        /// <summary>
        /// Gets the provisioning state of the ExpressRoutePortLocation
        /// resource. Possible values are: 'Succeeded', 'Updating', 'Deleting',
        /// and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

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
