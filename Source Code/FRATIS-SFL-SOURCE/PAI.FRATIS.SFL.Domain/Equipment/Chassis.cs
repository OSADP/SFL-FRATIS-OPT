//    Copyright 2014 Productivity Apex Inc.
//        http://www.productivityapex.com/
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Collections.Generic;

namespace PAI.FRATIS.SFL.Domain.Equipment
{
    /// <summary>
    /// Represents a chassis
    /// </summary>
    public class Chassis : EntitySubscriberBase
    {
        /// <summary>
        /// Gets or sets wheter is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Represents whether this container is used for 
        /// Domestic purposes, as opposed to International
        /// A null value represents inapplicable, and the Chassis
        /// should be used for both Domestic and International
        /// </summary>
        public bool? IsDomestic { get; set; }

        public virtual ICollection<Container> Containers { get; set; } 

        public Chassis()
        {
            IsDomestic = null;
        }
    }
}