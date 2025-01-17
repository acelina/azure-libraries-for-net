// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a dedicated host.
    /// </summary>
    public partial class DedicatedHostInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedHostInstanceView class.
        /// </summary>
        public DedicatedHostInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedHostInstanceView class.
        /// </summary>
        /// <param name="assetId">Specifies the unique of the dedicated
        /// physical machine on which the dedicated host resides.</param>
        /// <param name="capacity">The total capacity of the dedicated
        /// host.</param>
        /// <param name="availableCapacity">Unutilized capacity of the
        /// dedicated host.</param>
        /// <param name="statuses">The resource status information.</param>
        public DedicatedHostInstanceView(string assetId = default(string), DedicatedHostCapacity capacity = default(DedicatedHostCapacity), DedicatedHostAvailableCapacity availableCapacity = default(DedicatedHostAvailableCapacity), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            AssetId = assetId;
            Capacity = capacity;
            AvailableCapacity = availableCapacity;
            Statuses = statuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the unique of the dedicated physical machine on
        /// which the dedicated host resides.
        /// </summary>
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; private set; }

        /// <summary>
        /// Gets or sets the total capacity of the dedicated host.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public DedicatedHostCapacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets unutilized capacity of the dedicated host.
        /// </summary>
        [JsonProperty(PropertyName = "availableCapacity")]
        public DedicatedHostAvailableCapacity AvailableCapacity { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
