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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Network;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// networks your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157182.aspx for
    /// more information)
    /// </summary>
    public static partial class NetworkOperationsExtensions
    {
        /// <summary>
        /// The Set Network Configuration operation asynchronously configures
        /// the virtual network  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157181.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The updated network configuration.
        /// </param>
        /// <returns>
        /// A standard storage response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse BeginSettingConfiguration(this INetworkOperations operations, NetworkSetConfigurationParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).BeginSettingConfigurationAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Set Network Configuration operation asynchronously configures
        /// the virtual network  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157181.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The updated network configuration.
        /// </param>
        /// <returns>
        /// A standard storage response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> BeginSettingConfigurationAsync(this INetworkOperations operations, NetworkSetConfigurationParameters parameters)
        {
            return operations.BeginSettingConfigurationAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Network Configuration operation retrieves the network
        /// configuration file for the given subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157196.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <returns>
        /// The Get Network Configuration operation response.
        /// </returns>
        public static NetworkGetConfigurationResponse GetConfiguration(this INetworkOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).GetConfigurationAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Network Configuration operation retrieves the network
        /// configuration file for the given subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157196.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <returns>
        /// The Get Network Configuration operation response.
        /// </returns>
        public static Task<NetworkGetConfigurationResponse> GetConfigurationAsync(this INetworkOperations operations)
        {
            return operations.GetConfigurationAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The List Virtual network sites operation retrieves the virtual
        /// networks configured for the subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157185.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation.
        /// </returns>
        public static NetworkListResponse List(this INetworkOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Virtual network sites operation retrieves the virtual
        /// networks configured for the subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157185.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation.
        /// </returns>
        public static Task<NetworkListResponse> ListAsync(this INetworkOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The Set Network Configuration operation asynchronously configures
        /// the virtual network  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157181.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The updated network configuration.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static OperationStatusResponse SetConfiguration(this INetworkOperations operations, NetworkSetConfigurationParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).SetConfigurationAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Set Network Configuration operation asynchronously configures
        /// the virtual network  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157181.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.INetworkOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. The updated network configuration.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<OperationStatusResponse> SetConfigurationAsync(this INetworkOperations operations, NetworkSetConfigurationParameters parameters)
        {
            return operations.SetConfigurationAsync(parameters, CancellationToken.None);
        }
    }
}
