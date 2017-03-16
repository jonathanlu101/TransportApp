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
    /// V3ResultStop
    /// </summary>
    [DataContract]
    public partial class V3ResultStop :  IEquatable<V3ResultStop>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3ResultStop" /> class.
        /// </summary>
        /// <param name="StopDistance">Distance of stop from input location (in metres); returns 0 if no location is input.</param>
        /// <param name="StopName">Name of stop.</param>
        /// <param name="StopId">Stop identifier.</param>
        /// <param name="RouteType">Transport mode identifier.</param>
        /// <param name="StopLatitude">Geographic coordinate of latitude at stop.</param>
        /// <param name="StopLongitude">Geographic coordinate of longitude at stop.</param>
        public V3ResultStop(float? StopDistance = null, string StopName = null, int? StopId = null, int? RouteType = null, float? StopLatitude = null, float? StopLongitude = null)
        {
            this.StopDistance = StopDistance;
            this.StopName = StopName;
            this.StopId = StopId;
            this.RouteType = RouteType;
            this.StopLatitude = StopLatitude;
            this.StopLongitude = StopLongitude;
        }
        
        /// <summary>
        /// Distance of stop from input location (in metres); returns 0 if no location is input
        /// </summary>
        /// <value>Distance of stop from input location (in metres); returns 0 if no location is input</value>
        [DataMember(Name="stop_distance", EmitDefaultValue=false)]
        public float? StopDistance { get; set; }
        /// <summary>
        /// Name of stop
        /// </summary>
        /// <value>Name of stop</value>
        [DataMember(Name="stop_name", EmitDefaultValue=false)]
        public string StopName { get; set; }
        /// <summary>
        /// Stop identifier
        /// </summary>
        /// <value>Stop identifier</value>
        [DataMember(Name="stop_id", EmitDefaultValue=false)]
        public int? StopId { get; set; }
        /// <summary>
        /// Transport mode identifier
        /// </summary>
        /// <value>Transport mode identifier</value>
        [DataMember(Name="route_type", EmitDefaultValue=false)]
        public int? RouteType { get; set; }
        /// <summary>
        /// Geographic coordinate of latitude at stop
        /// </summary>
        /// <value>Geographic coordinate of latitude at stop</value>
        [DataMember(Name="stop_latitude", EmitDefaultValue=false)]
        public float? StopLatitude { get; set; }
        /// <summary>
        /// Geographic coordinate of longitude at stop
        /// </summary>
        /// <value>Geographic coordinate of longitude at stop</value>
        [DataMember(Name="stop_longitude", EmitDefaultValue=false)]
        public float? StopLongitude { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3ResultStop {\n");
            sb.Append("  StopDistance: ").Append(StopDistance).Append("\n");
            sb.Append("  StopName: ").Append(StopName).Append("\n");
            sb.Append("  StopId: ").Append(StopId).Append("\n");
            sb.Append("  RouteType: ").Append(RouteType).Append("\n");
            sb.Append("  StopLatitude: ").Append(StopLatitude).Append("\n");
            sb.Append("  StopLongitude: ").Append(StopLongitude).Append("\n");
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
            return this.Equals(obj as V3ResultStop);
        }

        /// <summary>
        /// Returns true if V3ResultStop instances are equal
        /// </summary>
        /// <param name="other">Instance of V3ResultStop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3ResultStop other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StopDistance == other.StopDistance ||
                    this.StopDistance != null &&
                    this.StopDistance.Equals(other.StopDistance)
                ) && 
                (
                    this.StopName == other.StopName ||
                    this.StopName != null &&
                    this.StopName.Equals(other.StopName)
                ) && 
                (
                    this.StopId == other.StopId ||
                    this.StopId != null &&
                    this.StopId.Equals(other.StopId)
                ) && 
                (
                    this.RouteType == other.RouteType ||
                    this.RouteType != null &&
                    this.RouteType.Equals(other.RouteType)
                ) && 
                (
                    this.StopLatitude == other.StopLatitude ||
                    this.StopLatitude != null &&
                    this.StopLatitude.Equals(other.StopLatitude)
                ) && 
                (
                    this.StopLongitude == other.StopLongitude ||
                    this.StopLongitude != null &&
                    this.StopLongitude.Equals(other.StopLongitude)
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
                if (this.StopDistance != null)
                    hash = hash * 59 + this.StopDistance.GetHashCode();
                if (this.StopName != null)
                    hash = hash * 59 + this.StopName.GetHashCode();
                if (this.StopId != null)
                    hash = hash * 59 + this.StopId.GetHashCode();
                if (this.RouteType != null)
                    hash = hash * 59 + this.RouteType.GetHashCode();
                if (this.StopLatitude != null)
                    hash = hash * 59 + this.StopLatitude.GetHashCode();
                if (this.StopLongitude != null)
                    hash = hash * 59 + this.StopLongitude.GetHashCode();
                return hash;
            }
        }
    }

}
