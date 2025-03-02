// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Get Storage Account ManagementPolicies operation response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagementPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicy class.
        /// </summary>
        public ManagementPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicy class.
        /// </summary>
        /// <param name="policy">The Storage Account ManagementPolicy, in JSON
        /// format. See more details in:
        /// https://learn.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="lastModifiedTime">Returns the date and time the
        /// ManagementPolicies was last modified.</param>
        public ManagementPolicy(ManagementPolicySchema policy, string id = default(string), string name = default(string), string type = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?))
            : base(id, name, type)
        {
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the date and time the ManagementPolicies was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the Storage Account ManagementPolicy, in JSON format.
        /// See more details in:
        /// https://learn.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policy")]
        public ManagementPolicySchema Policy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Policy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Policy");
            }
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}
