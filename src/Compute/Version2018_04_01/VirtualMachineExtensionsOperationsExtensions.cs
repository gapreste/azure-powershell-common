// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineExtensionsOperations.
    /// </summary>
    public static partial class VirtualMachineExtensionsOperationsExtensions
    {
            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be created or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension CreateOrUpdate(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be created or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> CreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension Update(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters)
            {
                return operations.UpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> UpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static OperationStatusResponse Delete(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName)
            {
                return operations.DeleteAsync(resourceGroupName, vmName, vmExtensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> DeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to get the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the extension.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static VirtualMachineExtension Get(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, vmName, vmExtensionName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the extension.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> GetAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be created or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension BeginCreateOrUpdate(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be created or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> BeginCreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension BeginUpdate(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Update Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtension> BeginUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static OperationStatusResponse BeginDelete(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, vmName, vmExtensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> BeginDeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
