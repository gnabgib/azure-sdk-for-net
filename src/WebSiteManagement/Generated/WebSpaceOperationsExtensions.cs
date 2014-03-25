// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Windows Azure Web Sites management API provides a RESTful set of
    /// web services that interact with Windows Azure Web Sites service to
    /// manage your web sites. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Web Sites
    /// service.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public static partial class WebSpaceOperationsExtensions
    {
        /// <summary>
        /// Creates a source control user allowed to publish to this web space.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='username'>
        /// Required. The user name.
        /// </param>
        /// <param name='password'>
        /// Required. The user password.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Parameters supplied to the Create Publishing User
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Publishing User operation response.
        /// </returns>
        public static WebSpacesCreatePublishingUserResponse CreatePublishingUser(this IWebSpaceOperations operations, string username, string password, WebSpacesCreatePublishingUserParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).CreatePublishingUserAsync(username, password, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a source control user allowed to publish to this web space.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='username'>
        /// Required. The user name.
        /// </param>
        /// <param name='password'>
        /// Required. The user password.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Parameters supplied to the Create Publishing User
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Publishing User operation response.
        /// </returns>
        public static Task<WebSpacesCreatePublishingUserResponse> CreatePublishingUserAsync(this IWebSpaceOperations operations, string username, string password, WebSpacesCreatePublishingUserParameters parameters)
        {
            return operations.CreatePublishingUserAsync(username, password, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// You can retrieve details for a specified webspace name by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167017.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// The Get Web Space Details operation response.
        /// </returns>
        public static WebSpacesGetResponse Get(this IWebSpaceOperations operations, string webSpaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).GetAsync(webSpaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can retrieve details for a specified webspace name by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167017.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// The Get Web Space Details operation response.
        /// </returns>
        public static Task<WebSpacesGetResponse> GetAsync(this IWebSpaceOperations operations, string webSpaceName)
        {
            return operations.GetAsync(webSpaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the dns suffix for this subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        public static WebSpacesGetDnsSuffixResponse GetDnsSuffix(this IWebSpaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).GetDnsSuffixAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the dns suffix for this subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        public static Task<WebSpacesGetDnsSuffixResponse> GetDnsSuffixAsync(this IWebSpaceOperations operations)
        {
            return operations.GetDnsSuffixAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// You can list the webspaces under the current subscription by
        /// issuing a GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166961.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The List Web Spaces operation response.
        /// </returns>
        public static WebSpacesListResponse List(this IWebSpaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can list the webspaces under the current subscription by
        /// issuing a GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166961.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The List Web Spaces operation response.
        /// </returns>
        public static Task<WebSpacesListResponse> ListAsync(this IWebSpaceOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Get the available geo regions for this webspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        public static WebSpacesListGeoRegionsResponse ListGeoRegions(this IWebSpaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).ListGeoRegionsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the available geo regions for this webspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        public static Task<WebSpacesListGeoRegionsResponse> ListGeoRegionsAsync(this IWebSpaceOperations operations)
        {
            return operations.ListGeoRegionsAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Get the source control users allowed to publish to this web space.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The List Publishing Users operation response.
        /// </returns>
        public static WebSpacesListPublishingUsersResponse ListPublishingUsers(this IWebSpaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).ListPublishingUsersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the source control users allowed to publish to this web space.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <returns>
        /// The List Publishing Users operation response.
        /// </returns>
        public static Task<WebSpacesListPublishingUsersResponse> ListPublishingUsersAsync(this IWebSpaceOperations operations)
        {
            return operations.ListPublishingUsersAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// You can retrieve a list of all web sites in a web space by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236429.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The List Web Sites operation response.
        /// </returns>
        public static WebSpacesListWebSitesResponse ListWebSites(this IWebSpaceOperations operations, string webSpaceName, WebSiteListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWebSpaceOperations)s).ListWebSitesAsync(webSpaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can retrieve a list of all web sites in a web space by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236429.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IWebSpaceOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The List Web Sites operation response.
        /// </returns>
        public static Task<WebSpacesListWebSitesResponse> ListWebSitesAsync(this IWebSpaceOperations operations, string webSpaceName, WebSiteListParameters parameters)
        {
            return operations.ListWebSitesAsync(webSpaceName, parameters, CancellationToken.None);
        }
    }
}
