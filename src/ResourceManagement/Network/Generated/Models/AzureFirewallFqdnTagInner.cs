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
    /// Azure Firewall FQDN Tag Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureFirewallFqdnTagInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallFqdnTagInner class.
        /// </summary>
        public AzureFirewallFqdnTagInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallFqdnTagInner class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state of the
        /// resource.</param>
        /// <param name="fqdnTagName">The name of this FQDN Tag.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public AzureFirewallFqdnTagInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string fqdnTagName = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            FqdnTagName = fqdnTagName;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the name of this FQDN Tag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdnTagName")]
        public string FqdnTagName { get; private set; }

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
            //Nothing to validate
        }
    }
}
