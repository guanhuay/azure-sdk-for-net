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
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    public partial class OAuth2PermissionGrantClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OAuth2PermissionGrantRestClient RestClient { get; }
        /// <summary> Initializes a new instance of OAuth2PermissionGrantClient for mocking. </summary>
        protected OAuth2PermissionGrantClient()
        {
        }

        /// <summary> Initializes a new instance of OAuth2PermissionGrantClient. </summary>
        public OAuth2PermissionGrantClient(string tenantID, TokenCredential tokenCredential, RbacManagementClientOptions options = null)
        {
            options = options ?? new RbacManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new OAuth2PermissionGrantRestClient(_clientDiagnostics, _pipeline, tenantID, apiVersion: options.Version);
        }

        /// <summary> Grants OAuth2 permissions for the relevant resource Ids of an app. </summary>
        /// <param name="body"> The relevant app Service Principal Object Id and the Service Principal Object Id you want to grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OAuth2PermissionGrant>> CreateAsync(OAuth2PermissionGrant body = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Grants OAuth2 permissions for the relevant resource Ids of an app. </summary>
        /// <param name="body"> The relevant app Service Principal Object Id and the Service Principal Object Id you want to grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OAuth2PermissionGrant> Create(OAuth2PermissionGrant body = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(body, cancellationToken);
        }

        /// <summary> Delete a OAuth2 permission grant for the relevant resource Ids of an app. </summary>
        /// <param name="objectId"> The object ID of a permission grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string objectId, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(objectId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Delete a OAuth2 permission grant for the relevant resource Ids of an app. </summary>
        /// <param name="objectId"> The object ID of a permission grant. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string objectId, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(objectId, cancellationToken);
        }

        /// <summary> Queries OAuth2 permissions grants for the relevant SP ObjectId of an app. </summary>
        /// <param name="filter"> This is the Service Principal ObjectId associated with the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<OAuth2PermissionGrant> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OAuth2PermissionGrant>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<OAuth2PermissionGrant>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Queries OAuth2 permissions grants for the relevant SP ObjectId of an app. </summary>
        /// <param name="filter"> This is the Service Principal ObjectId associated with the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<OAuth2PermissionGrant> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<OAuth2PermissionGrant> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(filter, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<OAuth2PermissionGrant> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNext(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the next page of OAuth2 permission grants. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<OAuth2PermissionGrant> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<OAuth2PermissionGrant>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<OAuth2PermissionGrant>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the next page of OAuth2 permission grants. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<OAuth2PermissionGrant> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<OAuth2PermissionGrant> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListNext(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<OAuth2PermissionGrant> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}