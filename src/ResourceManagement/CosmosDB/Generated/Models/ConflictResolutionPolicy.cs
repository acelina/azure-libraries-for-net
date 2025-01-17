// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The conflict resolution policy for the container.
    /// </summary>
    public partial class ConflictResolutionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ConflictResolutionPolicy class.
        /// </summary>
        public ConflictResolutionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConflictResolutionPolicy class.
        /// </summary>
        /// <param name="mode">Indicates the conflict resolution mode. Possible
        /// values include: 'LastWriterWins', 'Custom'</param>
        /// <param name="conflictResolutionPath">The conflict resolution path
        /// in the case of LastWriterWins mode.</param>
        /// <param name="conflictResolutionProcedure">The procedure to resolve
        /// conflicts in the case of custom mode.</param>
        public ConflictResolutionPolicy(string mode = default(string), string conflictResolutionPath = default(string), string conflictResolutionProcedure = default(string))
        {
            Mode = mode;
            ConflictResolutionPath = conflictResolutionPath;
            ConflictResolutionProcedure = conflictResolutionProcedure;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the conflict resolution mode. Possible
        /// values include: 'LastWriterWins', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the conflict resolution path in the case of
        /// LastWriterWins mode.
        /// </summary>
        [JsonProperty(PropertyName = "conflictResolutionPath")]
        public string ConflictResolutionPath { get; set; }

        /// <summary>
        /// Gets or sets the procedure to resolve conflicts in the case of
        /// custom mode.
        /// </summary>
        [JsonProperty(PropertyName = "conflictResolutionProcedure")]
        public string ConflictResolutionProcedure { get; set; }

    }
}
