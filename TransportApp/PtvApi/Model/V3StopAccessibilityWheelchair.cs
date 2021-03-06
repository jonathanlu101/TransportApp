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
    /// V3StopAccessibilityWheelchair
    /// </summary>
    [DataContract]
    public partial class V3StopAccessibilityWheelchair :  IEquatable<V3StopAccessibilityWheelchair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3StopAccessibilityWheelchair" /> class.
        /// </summary>
        /// <param name="AccessibleRamp">Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992).</param>
        /// <param name="AccessibleParking">Indicates if there is at least one accessible parking spot at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992).</param>
        /// <param name="AccessiblePhone">Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992).</param>
        /// <param name="AccessibleToilet">Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992).</param>
        public V3StopAccessibilityWheelchair(bool? AccessibleRamp = null, bool? AccessibleParking = null, bool? AccessiblePhone = null, bool? AccessibleToilet = null)
        {
            this.AccessibleRamp = AccessibleRamp;
            this.AccessibleParking = AccessibleParking;
            this.AccessiblePhone = AccessiblePhone;
            this.AccessibleToilet = AccessibleToilet;
        }
        
        /// <summary>
        /// Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        /// <value>Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</value>
        [DataMember(Name="accessible_ramp", EmitDefaultValue=false)]
        public bool? AccessibleRamp { get; set; }
        /// <summary>
        /// Indicates if there is at least one accessible parking spot at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        /// <value>Indicates if there is at least one accessible parking spot at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</value>
        [DataMember(Name="accessible_parking", EmitDefaultValue=false)]
        public bool? AccessibleParking { get; set; }
        /// <summary>
        /// Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        /// <value>Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</value>
        [DataMember(Name="accessible_phone", EmitDefaultValue=false)]
        public bool? AccessiblePhone { get; set; }
        /// <summary>
        /// Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        /// <value>Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</value>
        [DataMember(Name="accessible_toilet", EmitDefaultValue=false)]
        public bool? AccessibleToilet { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3StopAccessibilityWheelchair {\n");
            sb.Append("  AccessibleRamp: ").Append(AccessibleRamp).Append("\n");
            sb.Append("  AccessibleParking: ").Append(AccessibleParking).Append("\n");
            sb.Append("  AccessiblePhone: ").Append(AccessiblePhone).Append("\n");
            sb.Append("  AccessibleToilet: ").Append(AccessibleToilet).Append("\n");
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
            return this.Equals(obj as V3StopAccessibilityWheelchair);
        }

        /// <summary>
        /// Returns true if V3StopAccessibilityWheelchair instances are equal
        /// </summary>
        /// <param name="other">Instance of V3StopAccessibilityWheelchair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3StopAccessibilityWheelchair other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessibleRamp == other.AccessibleRamp ||
                    this.AccessibleRamp != null &&
                    this.AccessibleRamp.Equals(other.AccessibleRamp)
                ) && 
                (
                    this.AccessibleParking == other.AccessibleParking ||
                    this.AccessibleParking != null &&
                    this.AccessibleParking.Equals(other.AccessibleParking)
                ) && 
                (
                    this.AccessiblePhone == other.AccessiblePhone ||
                    this.AccessiblePhone != null &&
                    this.AccessiblePhone.Equals(other.AccessiblePhone)
                ) && 
                (
                    this.AccessibleToilet == other.AccessibleToilet ||
                    this.AccessibleToilet != null &&
                    this.AccessibleToilet.Equals(other.AccessibleToilet)
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
                if (this.AccessibleRamp != null)
                    hash = hash * 59 + this.AccessibleRamp.GetHashCode();
                if (this.AccessibleParking != null)
                    hash = hash * 59 + this.AccessibleParking.GetHashCode();
                if (this.AccessiblePhone != null)
                    hash = hash * 59 + this.AccessiblePhone.GetHashCode();
                if (this.AccessibleToilet != null)
                    hash = hash * 59 + this.AccessibleToilet.GetHashCode();
                return hash;
            }
        }
    }

}
