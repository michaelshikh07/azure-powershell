// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisCache.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters for Redis export operation.
    /// </summary>
    public partial class ExportRDBParameters
    {
        /// <summary>
        /// Initializes a new instance of the ExportRDBParameters class.
        /// </summary>
        public ExportRDBParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportRDBParameters class.
        /// </summary>
        /// <param name="prefix">Prefix to use for exported files.</param>
        /// <param name="container">Container name to export to.</param>
        /// <param name="format">File format.</param>
        /// <param name="preferredDataArchiveAuthMethod">Preferred auth method
        /// to communicate to storage account used for data archive, specify
        /// SAS or ManagedIdentity, default value is SAS</param>
        /// <param name="storageSubscriptionId">Subscription id of the storage
        /// container for data to be exported using ManagedIdentity.</param>
        public ExportRDBParameters(string prefix, string container, string format = default(string), string preferredDataArchiveAuthMethod = default(string), string storageSubscriptionId = default(string))
        {
            Format = format;
            Prefix = prefix;
            Container = container;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            StorageSubscriptionId = storageSubscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file format.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets prefix to use for exported files.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets container name to export to.
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets preferred auth method to communicate to storage
        /// account used for data archive, specify SAS or ManagedIdentity,
        /// default value is SAS
        /// </summary>
        [JsonProperty(PropertyName = "preferred-data-archive-auth-method")]
        public string PreferredDataArchiveAuthMethod { get; set; }

        /// <summary>
        /// Gets or sets subscription id of the storage container for data to
        /// be exported using ManagedIdentity.
        /// </summary>
        [JsonProperty(PropertyName = "storage-subscription-id")]
        public string StorageSubscriptionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Prefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Prefix");
            }
            if (Container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Container");
            }
        }
    }
}
