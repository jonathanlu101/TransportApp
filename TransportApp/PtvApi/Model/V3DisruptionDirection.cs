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
    /// V3DisruptionDirection
    /// </summary>
    [DataContract]
    public partial class V3DisruptionDirection :  IEquatable<V3DisruptionDirection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3DisruptionDirection" /> class.
        /// </summary>
        /// <param name="RouteDirectionId">Route and direction of travel combination identifier.</param>
        /// <param name="DirectionId">Direction of travel identifier.</param>
        /// <param name="DirectionName">Name of direction of travel.</param>
        /// <param name="ServiceTime">Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if disruption applies to multiple (or no) services.</param>
        public V3DisruptionDirection(int? RouteDirectionId = null, int? DirectionId = null, string DirectionName = null, string ServiceTime = null)
        {
            this.RouteDirectionId = RouteDirectionId;
            this.DirectionId = DirectionId;
            this.DirectionName = DirectionName;
            this.ServiceTime = ServiceTime;
        }
        
        /// <summary>
        /// Route and direction of travel combination identifier
        /// </summary>
        /// <value>Route and direction of travel combination identifier</value>
        [DataMember(Name="route_direction_id", EmitDefaultValue=false)]
        public int? RouteDirectionId { get; set; }
        /// <summary>
        /// Direction of travel identifier
        /// </summary>
        /// <value>Direction of travel identifier</value>
        [DataMember(Name="direction_id", EmitDefaultValue=false)]
        public int? DirectionId { get; set; }
        /// <summary>
        /// Name of direction of travel
        /// </summary>
        /// <value>Name of direction of travel</value>
        [DataMember(Name="direction_name", EmitDefaultValue=false)]
        public string DirectionName { get; set; }
        /// <summary>
        /// Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if disruption applies to multiple (or no) services
        /// </summary>
        /// <value>Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if disruption applies to multiple (or no) services</value>
        [DataMember(Name="service_time", EmitDefaultValue=false)]
        public string ServiceTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3DisruptionDirection {\n");
            sb.Append("  RouteDirectionId: ").Append(RouteDirectionId).Append("\n");
            sb.Append("  DirectionId: ").Append(DirectionId).Append("\n");
            sb.Append("  DirectionName: ").Append(DirectionName).Append("\n");
            sb.Append("  ServiceTime: ").Append(ServiceTime).Append("\n");
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
            return this.Equals(obj as V3DisruptionDirection);
        }

        /// <summary>
        /// Returns true if V3DisruptionDirection instances are equal
        /// </summary>
        /// <param name="other">Instance of V3DisruptionDirection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3DisruptionDirection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RouteDirectionId == other.RouteDirectionId ||
                    this.RouteDirectionId != null &&
                    this.RouteDirectionId.Equals(other.RouteDirectionId)
                ) && 
                (
                    this.DirectionId == other.DirectionId ||
                    this.DirectionId != null &&
                    this.DirectionId.Equals(other.DirectionId)
                ) && 
                (
                    this.DirectionName == other.DirectionName ||
                    this.DirectionName != null &&
                    this.DirectionName.Equals(other.DirectionName)
                ) && 
                (
                    this.ServiceTime == other.ServiceTime ||
                    this.ServiceTime != null &&
                    this.ServiceTime.Equals(other.ServiceTime)
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
                if (this.RouteDirectionId != null)
                    hash = hash * 59 + this.RouteDirectionId.GetHashCode();
                if (this.DirectionId != null)
                    hash = hash * 59 + this.DirectionId.GetHashCode();
                if (this.DirectionName != null)
                    hash = hash * 59 + this.DirectionName.GetHashCode();
                if (this.ServiceTime != null)
                    hash = hash * 59 + this.ServiceTime.GetHashCode();
                return hash;
            }
        }
    }

}