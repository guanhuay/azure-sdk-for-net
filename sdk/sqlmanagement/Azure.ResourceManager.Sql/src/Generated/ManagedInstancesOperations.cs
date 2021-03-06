// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ManagedInstances service client. </summary>
    public partial class ManagedInstancesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedInstancesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ManagedInstancesOperations for mocking. </summary>
        protected ManagedInstancesOperations()
        {
        }
        /// <summary> Initializes a new instance of ManagedInstancesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedInstancesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedInstancesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstance>> GetAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstance> Get(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of managed instances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<ManagedInstance> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ManagedInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of managed instances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<ManagedInstance> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ManagedInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all managed instances in an instance pool. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="instancePoolName"> The instance pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="instancePoolName"/> is null. </exception>
        public virtual AsyncPageable<ManagedInstance> ListByInstancePoolAsync(string resourceGroupName, string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            async Task<Page<ManagedInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByInstancePool");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstancePoolAsync(resourceGroupName, instancePoolName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByInstancePool");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByInstancePoolNextPageAsync(nextLink, resourceGroupName, instancePoolName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all managed instances in an instance pool. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="instancePoolName"> The instance pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="instancePoolName"/> is null. </exception>
        public virtual Pageable<ManagedInstance> ListByInstancePool(string resourceGroupName, string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            Page<ManagedInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByInstancePool");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstancePool(resourceGroupName, instancePoolName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.ListByInstancePool");
                scope.Start();
                try
                {
                    var response = RestClient.ListByInstancePoolNextPage(nextLink, resourceGroupName, instancePoolName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all managed instances in the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ManagedInstance> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all managed instances in the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ManagedInstance> List(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Failovers a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="replicaType"> The type of replica to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<ManagedInstancesFailoverOperation> StartFailoverAsync(string resourceGroupName, string managedInstanceName, ReplicaType? replicaType = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.FailoverAsync(resourceGroupName, managedInstanceName, replicaType, cancellationToken).ConfigureAwait(false);
                return new ManagedInstancesFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, managedInstanceName, replicaType).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Failovers a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="replicaType"> The type of replica to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual ManagedInstancesFailoverOperation StartFailover(string resourceGroupName, string managedInstanceName, ReplicaType? replicaType = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Failover(resourceGroupName, managedInstanceName, replicaType, cancellationToken);
                return new ManagedInstancesFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, managedInstanceName, replicaType).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ManagedInstancesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string managedInstanceName, ManagedInstance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters, cancellationToken).ConfigureAwait(false);
                return new ManagedInstancesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstancesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string managedInstanceName, ManagedInstance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, managedInstanceName, parameters, cancellationToken);
                return new ManagedInstancesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual async Task<ManagedInstancesDeleteOperation> StartDeleteAsync(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, managedInstanceName, cancellationToken).ConfigureAwait(false);
                return new ManagedInstancesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="managedInstanceName"/> is null. </exception>
        public virtual ManagedInstancesDeleteOperation StartDelete(string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, managedInstanceName, cancellationToken);
                return new ManagedInstancesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, managedInstanceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ManagedInstancesUpdateOperation> StartUpdateAsync(string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, managedInstanceName, parameters, cancellationToken).ConfigureAwait(false);
                return new ManagedInstancesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="parameters"> The requested managed instance resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstancesUpdateOperation StartUpdate(string resourceGroupName, string managedInstanceName, ManagedInstanceUpdate parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancesOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, managedInstanceName, parameters, cancellationToken);
                return new ManagedInstancesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, managedInstanceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
