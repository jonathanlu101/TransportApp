/* 
 * PTV Timetable API - Version 3
 *
 * The PTV Timetable API provides direct access to Public Transport Victoria’s public transport timetable data.    The API returns scheduled timetable, route and stop data for all metropolitan and regional train, tram and bus services in Victoria, including Night Network(Night Train and Night Tram data are included in metropolitan train and tram services data, respectively, whereas Night Bus is a separate route type).    The API also returns real-time data for metropolitan train, tram and bus services (where this data is made available to PTV), as well as disruption information, stop facility information, and access to myki ticket outlet data.    This Swagger is for Version 3 of the PTV Timetable API. By using this documentation you agree to comply with the licence and terms of service.    Train timetable data is updated daily, while the remaining data is updated weekly, taking into account any planned timetable changes (for example, due to holidays or planned disruptions). The PTV timetable API is the same API used by PTV for its apps. To access the most up to date data PTV has (including real-time data) you must use the API dynamically.    You can access the PTV Timetable API through a HTTP or HTTPS interface, as follows:        base URL / version number / API name / query string  The base URL is either:    *  http://timetableapi.ptv.vic.gov.au  or    *  https://timetableapi.ptv.vic.gov.au    The Swagger JSON file is available at http://timetableapi.ptv.vic.gov.au/swagger/docs/v3    Frequently asked questions are available on the PTV website at http://ptv.vic.gov.au/apifaq    Links to the following information are also provided on the PTV website at http://ptv.vic.gov.au/ptv-timetable-api/  * How to register for an API key and calculate a signature  * PTV Timetable API V2 to V3 Migration Guide  * Documentation for Version 2 of the PTV Timetable API  * PTV Timetable API Data Quality Statement    All information about how to use the API is in this documentation. PTV cannot provide technical support for the API.  
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TransportApp.PTVApi.Model
{
    /// <summary>
    /// V3StopBase
    /// </summary>
    [DataContract]
    public partial class V3StopBase :  IEquatable<V3StopBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3StopBase" /> class.
        /// </summary>
        /// <param name="StopId">Stop identifier.</param>
        /// <param name="StopName">Name of stop.</param>
        public V3StopBase(int? StopId = null, string StopName = null)
        {
            this.StopId = StopId;
            this.StopName = StopName;
        }
        
        /// <summary>
        /// Stop identifier
        /// </summary>
        /// <value>Stop identifier</value>
        [DataMember(Name="stop_id", EmitDefaultValue=false)]
        public int? StopId { get; set; }
        /// <summary>
        /// Name of stop
        /// </summary>
        /// <value>Name of stop</value>
        [DataMember(Name="stop_name", EmitDefaultValue=false)]
        public string StopName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3StopBase {\n");
            sb.Append("  StopId: ").Append(StopId).Append("\n");
            sb.Append("  StopName: ").Append(StopName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V3StopBase);
        }

        /// <summary>
        /// Returns true if V3StopBase instances are equal
        /// </summary>
        /// <param name="other">Instance of V3StopBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3StopBase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StopId == other.StopId ||
                    this.StopId != null &&
                    this.StopId.Equals(other.StopId)
                ) && 
                (
                    this.StopName == other.StopName ||
                    this.StopName != null &&
                    this.StopName.Equals(other.StopName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StopId != null)
                    hash = hash * 59 + this.StopId.GetHashCode();
                if (this.StopName != null)
                    hash = hash * 59 + this.StopName.GetHashCode();
                return hash;
            }
        }
    }

}
