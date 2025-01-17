// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteCrossConnectionsOperations.
    /// </summary>
    public static partial class ExpressRouteCrossConnectionsOperationsExtensions
    {
            /// <summary>
            /// Retrieves all the ExpressRouteCrossConnections in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCrossConnectionInner>> ListAsync(this IExpressRouteCrossConnectionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves all the ExpressRouteCrossConnections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCrossConnectionInner>> ListByResourceGroupAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details about the specified ExpressRouteCrossConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group (peering location of the circuit).
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection (service key of the circuit).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionInner> GetAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, crossConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the specified ExpressRouteCrossConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update express route crossConnection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionInner> CreateOrUpdateAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, ExpressRouteCrossConnectionInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, crossConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an express route cross connection tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the cross connection.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionInner> UpdateTagsAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, crossConnectionName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// cross connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsArpTableListResultInner> ListArpTableAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListArpTableWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the route table summary associated with the express route cross
            /// connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionsRoutesTableSummaryListResultInner> ListRoutesTableSummaryAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRoutesTableSummaryWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route cross connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResultInner> ListRoutesTableAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRoutesTableWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the specified ExpressRouteCrossConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update express route crossConnection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionInner> BeginCreateOrUpdateAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, ExpressRouteCrossConnectionInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, crossConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an express route cross connection tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the cross connection.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionInner> BeginUpdateTagsAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, crossConnectionName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// cross connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsArpTableListResultInner> BeginListArpTableAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListArpTableWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the route table summary associated with the express route cross
            /// connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCrossConnectionsRoutesTableSummaryListResultInner> BeginListRoutesTableSummaryAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListRoutesTableSummaryWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route cross connection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResultInner> BeginListRoutesTableAsync(this IExpressRouteCrossConnectionsOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListRoutesTableWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves all the ExpressRouteCrossConnections in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCrossConnectionInner>> ListNextAsync(this IExpressRouteCrossConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves all the ExpressRouteCrossConnections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCrossConnectionInner>> ListByResourceGroupNextAsync(this IExpressRouteCrossConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
