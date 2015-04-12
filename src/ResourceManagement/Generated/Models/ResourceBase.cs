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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Resource information.
    /// </summary>
    public partial class ResourceBase
    {
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets the location of the resource.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets the tags attached to the resource.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceBase class.
        /// </summary>
        public ResourceBase()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceBase class with required
        /// arguments.
        /// </summary>
        public ResourceBase(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
