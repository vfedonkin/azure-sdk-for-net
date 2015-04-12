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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for managing Azure SQL Database secure
    /// connection.  Contains operations to: Create, Retrieve and Update
    /// secure connection policy .
    /// </summary>
    public partial interface ISecureConnectionPolicyOperations
    {
        /// <summary>
        /// Creates or updates an Azure SQL Database Server Firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database for which the policy applies.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for createing or updating a secure
        /// connection policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateOrUpdateDatabasePolicyAsync(string resourceGroupName, string serverName, string databaseName, DatabaseSecureConnectionPolicyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL Database secure connection policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database for which the secure connection
        /// policy applies.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get database secure connection request.
        /// </returns>
        Task<DatabaseSecureConnectionPolicyGetResponse> GetDatabasePolicyAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
    }
}
