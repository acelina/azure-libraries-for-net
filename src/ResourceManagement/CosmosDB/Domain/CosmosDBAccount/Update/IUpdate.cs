// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update
{
    using Microsoft.Azure.Management.CosmosDB.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Update;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Collections.Generic;

    /// <summary>
    /// The stage of the cosmos db update allowing to set the consistency policy.
    /// </summary>
    public interface IWithConsistencyPolicy
    {
        /// <summary>
        /// The consistency policy for the CosmosDB account.
        /// </summary>
        /// <param name="maxStalenessPrefix">The max staleness prefix.</param>
        /// <param name="maxIntervalInSeconds">The max interval in seconds.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithBoundedStalenessConsistency(int maxStalenessPrefix, int maxIntervalInSeconds);

        /// <summary>
        /// The consistency policy for the CosmosDB account.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithStrongConsistency();

        /// <summary>
        /// The consistency policy for the CosmosDB account.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithEventualConsistency();

        /// <summary>
        /// The consistency policy for the CosmosDB account.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithSessionConsistency();
    }

    /// <summary>
    /// The stage of the Cosmos DB update definition allowing the definition of a Virtual Network ACL Rule.
    /// </summary>
    public interface IWithVirtualNetworkRule  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {

        /// <summary>
        /// Removes a Virtual Network ACL Rule for the CosmosDB account.
        /// </summary>
        /// <param name="virtualNetworkId">The ID of a virtual network.</param>
        /// <param name="subnetName">
        /// The name of the subnet within the virtual network; the subnet must have the service
        /// endpoints enabled for 'Microsoft.AzureCosmosDB'.
        /// </param>
        /// <return>The next stage of the update definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithoutVirtualNetwork(string virtualNetworkId, string subnetName);

        /// <summary>
        /// Specifies a new Virtual Network ACL Rule for the CosmosDB account.
        /// </summary>
        /// <param name="virtualNetworkId">The ID of a virtual network.</param>
        /// <param name="subnetName">
        /// The name of the subnet within the virtual network; the subnet must have the service
        /// endpoints enabled for 'Microsoft.AzureCosmosDB'.
        /// </param>
        /// <return>The next stage of the update definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithVirtualNetwork(string virtualNetworkId, string subnetName);

        /// <summary>
        /// A Virtual Network ACL Rule for the CosmosDB account.
        /// </summary>
        /// <param name="virtualNetworkRules">
        /// The list of Virtual Network ACL Rules (an empty list value
        /// will remove all the rules).
        /// </param>
        /// <return>The next stage of the update definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithVirtualNetworkRules(IList<Microsoft.Azure.Management.CosmosDB.Fluent.Models.VirtualNetworkRule> virtualNetworkRules);
    }

    /// <summary>
    /// The stage of the cosmos db update definition allowing to set the IP range filter.
    /// </summary>
    public interface IWithIpRangeFilter
    {
        /// <summary>
        /// CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR
        /// form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges
        /// must be comma separated and must not contain any spaces.
        /// </summary>
        /// <param name="ipRangeFilter">Specifies the set of IP addresses or IP address ranges.</param>
        /// <return>The next stage of the update definition.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithIpRangeFilter(string ipRangeFilter);
    }

    /// <summary>
    /// The stage of the cosmos db update definition allowing to specify whether multiple write locations are enabled or not.
    /// </summary>
    public interface IWithMultipleLocations
    {
        /// <summary>
        /// Specifies whether multiple write locations are enabled or not for this cosmos db account.
        /// </summary>
        /// <param name="enabled">Whether multiple write locations are enabled or not for this cosmos db account.</param>
        /// <returns>The next stage of the update definition.</returns>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals WithMultipleWriteLocationsEnabled(bool enabled);
    }

    /// <summary>
    /// Grouping of cosmos db update stages.
    /// </summary>
    public interface IWithOptionals :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Update.IUpdateWithTags<Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IAppliable<Microsoft.Azure.Management.CosmosDB.Fluent.ICosmosDBAccount>,
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithConsistencyPolicy,
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithVirtualNetworkRule,
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithIpRangeFilter,
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithMultipleLocations
    {
    }

    /// <summary>
    /// Grouping of cosmos db update stages.
    /// </summary>
    public interface IUpdate :
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithReadLocations,
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithOptionals
    {
    }

    /// <summary>
    /// The stage of the cosmos db definition allowing the definition of a write location.
    /// </summary>
    public interface IWithReadLocations :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IAppliable<Microsoft.Azure.Management.CosmosDB.Fluent.ICosmosDBAccount>
    {
        /// <summary>
        /// A georeplication location for the CosmosDB account.
        /// </summary>
        /// <param name="region">The region for the location.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithReadLocations WithReadReplication(Region region);

        /// <summary>
        /// A georeplication location for the CosmosDB account.
        /// </summary>
        /// <param name="region">The region for the location.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.CosmosDB.Fluent.CosmosDBAccount.Update.IWithReadLocations WithoutReadReplication(Region region);
    }
}