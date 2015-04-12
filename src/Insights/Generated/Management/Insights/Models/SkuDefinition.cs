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
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents a sku definition.
    /// </summary>
    public partial class SkuDefinition
    {
        private Capacity _capacity;

        /// <summary>
        /// Optional. The capacity of the sku.
        /// </summary>
        public Capacity Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        private Display _display;

        /// <summary>
        /// Optional. The capacity of the sku.
        /// </summary>
        public Display Display
        {
            get { return this._display; }
            set { this._display = value; }
        }

        private Sku _sku;

        /// <summary>
        /// Optional. The sku.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }

        /// <summary>
        /// Initializes a new instance of the SkuDefinition class.
        /// </summary>
        public SkuDefinition()
        {
        }
    }
}
