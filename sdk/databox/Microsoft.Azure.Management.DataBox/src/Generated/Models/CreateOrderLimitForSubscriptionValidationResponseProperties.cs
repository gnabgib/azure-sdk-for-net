// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of create order limit for subscription validation response.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidateCreateOrderLimit")]
    public partial class CreateOrderLimitForSubscriptionValidationResponseProperties : ValidationInputResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrderLimitForSubscriptionValidationResponseProperties class.
        /// </summary>
        public CreateOrderLimitForSubscriptionValidationResponseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrderLimitForSubscriptionValidationResponseProperties class.
        /// </summary>
        /// <param name="error">Error code and message of validation
        /// response.</param>
        /// <param name="status">Create order limit validation status. Possible
        /// values include: 'Valid', 'Invalid', 'Skipped'</param>
        public CreateOrderLimitForSubscriptionValidationResponseProperties(CloudError error = default(CloudError), ValidationStatus? status = default(ValidationStatus?))
            : base(error)
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets create order limit validation status. Possible values include:
        /// 'Valid', 'Invalid', 'Skipped'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ValidationStatus? Status { get; private set; }

    }
}
