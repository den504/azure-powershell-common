// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment operation parameters.
    /// </summary>
    public partial class Deployment
    {
        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        public Deployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        /// <param name="properties">The deployment properties.</param>
        /// <param name="location">The location to store the deployment
        /// data.</param>
        public Deployment(DeploymentProperties properties, string location = default(string))
        {
            Location = location;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location to store the deployment data.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}