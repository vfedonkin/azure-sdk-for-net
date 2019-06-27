// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MSDeploy ARM response
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MSDeployStatus : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the MSDeployStatus class.
        /// </summary>
        public MSDeployStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MSDeployStatus class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="deployer">Username of deployer</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'accepted', 'running', 'succeeded', 'failed',
        /// 'canceled'</param>
        /// <param name="startTime">Start time of deploy operation</param>
        /// <param name="endTime">End time of deploy operation</param>
        /// <param name="complete">Whether the deployment operation has
        /// completed</param>
        public MSDeployStatus(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string deployer = default(string), MSDeployProvisioningState? provisioningState = default(MSDeployProvisioningState?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), bool? complete = default(bool?))
            : base(id, name, kind, type)
        {
            Deployer = deployer;
            ProvisioningState = provisioningState;
            StartTime = startTime;
            EndTime = endTime;
            Complete = complete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets username of deployer
        /// </summary>
        [JsonProperty(PropertyName = "properties.deployer")]
        public string Deployer { get; private set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'accepted',
        /// 'running', 'succeeded', 'failed', 'canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public MSDeployProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets start time of deploy operation
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end time of deploy operation
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets whether the deployment operation has completed
        /// </summary>
        [JsonProperty(PropertyName = "properties.complete")]
        public bool? Complete { get; private set; }

    }
}