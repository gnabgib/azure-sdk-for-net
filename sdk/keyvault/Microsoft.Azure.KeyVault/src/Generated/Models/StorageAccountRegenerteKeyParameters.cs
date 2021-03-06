// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account key regenerate parameters.
    /// </summary>
    public partial class StorageAccountRegenerteKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerteKeyParameters class.
        /// </summary>
        public StorageAccountRegenerteKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerteKeyParameters class.
        /// </summary>
        /// <param name="keyName">The storage account key name.</param>
        public StorageAccountRegenerteKeyParameters(string keyName)
        {
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage account key name.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}
