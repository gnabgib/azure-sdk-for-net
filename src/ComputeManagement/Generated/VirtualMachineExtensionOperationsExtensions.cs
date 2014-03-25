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
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class VirtualMachineExtensionOperationsExtensions
    {
        /// <summary>
        /// The List Resource Extensions operation lists the resource
        /// extensions that are available to add to a Virtual Machine. In
        /// Windows Azure, a process can run as a resource extension of a
        /// Virtual Machine. For example, Remote Desktop Access or the Windows
        /// Azure Diagnostics Agent can run as resource extensions to the
        /// Virtual Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495441.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineExtensionOperations.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public static VirtualMachineExtensionListResponse List(this IVirtualMachineExtensionOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineExtensionOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Resource Extensions operation lists the resource
        /// extensions that are available to add to a Virtual Machine. In
        /// Windows Azure, a process can run as a resource extension of a
        /// Virtual Machine. For example, Remote Desktop Access or the Windows
        /// Azure Diagnostics Agent can run as resource extensions to the
        /// Virtual Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495441.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineExtensionOperations.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public static Task<VirtualMachineExtensionListResponse> ListAsync(this IVirtualMachineExtensionOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The List Resource Extension Versions operation lists the versions
        /// of a resource extension that are available to add to a Virtual
        /// Machine. In Windows Azure, a process can run as a resource
        /// extension of a Virtual Machine. For example, Remote Desktop Access
        /// or the Windows Azure Diagnostics Agent can run as resource
        /// extensions to the Virtual Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495440.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineExtensionOperations.
        /// </param>
        /// <param name='publisherName'>
        /// Required. The name of the publisher.
        /// </param>
        /// <param name='extensionName'>
        /// Required. The name of the extension.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public static VirtualMachineExtensionListResponse ListVersions(this IVirtualMachineExtensionOperations operations, string publisherName, string extensionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineExtensionOperations)s).ListVersionsAsync(publisherName, extensionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Resource Extension Versions operation lists the versions
        /// of a resource extension that are available to add to a Virtual
        /// Machine. In Windows Azure, a process can run as a resource
        /// extension of a Virtual Machine. For example, Remote Desktop Access
        /// or the Windows Azure Diagnostics Agent can run as resource
        /// extensions to the Virtual Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495440.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineExtensionOperations.
        /// </param>
        /// <param name='publisherName'>
        /// Required. The name of the publisher.
        /// </param>
        /// <param name='extensionName'>
        /// Required. The name of the extension.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public static Task<VirtualMachineExtensionListResponse> ListVersionsAsync(this IVirtualMachineExtensionOperations operations, string publisherName, string extensionName)
        {
            return operations.ListVersionsAsync(publisherName, extensionName, CancellationToken.None);
        }
    }
}
