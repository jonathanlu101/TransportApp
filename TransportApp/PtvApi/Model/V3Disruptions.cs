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
    /// V3Disruptions
    /// </summary>
    [DataContract]
    public partial class V3Disruptions :  IEquatable<V3Disruptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3Disruptions" /> class.
        /// </summary>
        /// <param name="General">Subset of disruption information applicable to multiple route_types.</param>
        /// <param name="MetroTrain">Subset of disruption information applicable to metropolitan train.</param>
        /// <param name="MetroTram">Subset of disruption information applicable to metropolitan tram.</param>
        /// <param name="MetroBus">Subset of disruption information applicable to metropolitan bus.</param>
        /// <param name="RegionalTrain">Subset of disruption information applicable to V/Line train.</param>
        /// <param name="RegionalCoach">Subset of disruption information applicable to V/Line coach.</param>
        /// <param name="RegionalBus">Subset of disruption information applicable to regional bus.</param>
        public V3Disruptions(List<V3Disruption> General = null, List<V3Disruption> MetroTrain = null, List<V3Disruption> MetroTram = null, List<V3Disruption> MetroBus = null, List<V3Disruption> RegionalTrain = null, List<V3Disruption> RegionalCoach = null, List<V3Disruption> RegionalBus = null)
        {
            this.General = General;
            this.MetroTrain = MetroTrain;
            this.MetroTram = MetroTram;
            this.MetroBus = MetroBus;
            this.RegionalTrain = RegionalTrain;
            this.RegionalCoach = RegionalCoach;
            this.RegionalBus = RegionalBus;
        }
        
        /// <summary>
        /// Subset of disruption information applicable to multiple route_types
        /// </summary>
        /// <value>Subset of disruption information applicable to multiple route_types</value>
        [DataMember(Name="general", EmitDefaultValue=false)]
        public List<V3Disruption> General { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to metropolitan train
        /// </summary>
        /// <value>Subset of disruption information applicable to metropolitan train</value>
        [DataMember(Name="metro_train", EmitDefaultValue=false)]
        public List<V3Disruption> MetroTrain { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to metropolitan tram
        /// </summary>
        /// <value>Subset of disruption information applicable to metropolitan tram</value>
        [DataMember(Name="metro_tram", EmitDefaultValue=false)]
        public List<V3Disruption> MetroTram { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to metropolitan bus
        /// </summary>
        /// <value>Subset of disruption information applicable to metropolitan bus</value>
        [DataMember(Name="metro_bus", EmitDefaultValue=false)]
        public List<V3Disruption> MetroBus { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to V/Line train
        /// </summary>
        /// <value>Subset of disruption information applicable to V/Line train</value>
        [DataMember(Name="regional_train", EmitDefaultValue=false)]
        public List<V3Disruption> RegionalTrain { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to V/Line coach
        /// </summary>
        /// <value>Subset of disruption information applicable to V/Line coach</value>
        [DataMember(Name="regional_coach", EmitDefaultValue=false)]
        public List<V3Disruption> RegionalCoach { get; set; }
        /// <summary>
        /// Subset of disruption information applicable to regional bus
        /// </summary>
        /// <value>Subset of disruption information applicable to regional bus</value>
        [DataMember(Name="regional_bus", EmitDefaultValue=false)]
        public List<V3Disruption> RegionalBus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3Disruptions {\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  MetroTrain: ").Append(MetroTrain).Append("\n");
            sb.Append("  MetroTram: ").Append(MetroTram).Append("\n");
            sb.Append("  MetroBus: ").Append(MetroBus).Append("\n");
            sb.Append("  RegionalTrain: ").Append(RegionalTrain).Append("\n");
            sb.Append("  RegionalCoach: ").Append(RegionalCoach).Append("\n");
            sb.Append("  RegionalBus: ").Append(RegionalBus).Append("\n");
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
            return this.Equals(obj as V3Disruptions);
        }

        /// <summary>
        /// Returns true if V3Disruptions instances are equal
        /// </summary>
        /// <param name="other">Instance of V3Disruptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3Disruptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.General == other.General ||
                    this.General != null &&
                    this.General.SequenceEqual(other.General)
                ) && 
                (
                    this.MetroTrain == other.MetroTrain ||
                    this.MetroTrain != null &&
                    this.MetroTrain.SequenceEqual(other.MetroTrain)
                ) && 
                (
                    this.MetroTram == other.MetroTram ||
                    this.MetroTram != null &&
                    this.MetroTram.SequenceEqual(other.MetroTram)
                ) && 
                (
                    this.MetroBus == other.MetroBus ||
                    this.MetroBus != null &&
                    this.MetroBus.SequenceEqual(other.MetroBus)
                ) && 
                (
                    this.RegionalTrain == other.RegionalTrain ||
                    this.RegionalTrain != null &&
                    this.RegionalTrain.SequenceEqual(other.RegionalTrain)
                ) && 
                (
                    this.RegionalCoach == other.RegionalCoach ||
                    this.RegionalCoach != null &&
                    this.RegionalCoach.SequenceEqual(other.RegionalCoach)
                ) && 
                (
                    this.RegionalBus == other.RegionalBus ||
                    this.RegionalBus != null &&
                    this.RegionalBus.SequenceEqual(other.RegionalBus)
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
                if (this.General != null)
                    hash = hash * 59 + this.General.GetHashCode();
                if (this.MetroTrain != null)
                    hash = hash * 59 + this.MetroTrain.GetHashCode();
                if (this.MetroTram != null)
                    hash = hash * 59 + this.MetroTram.GetHashCode();
                if (this.MetroBus != null)
                    hash = hash * 59 + this.MetroBus.GetHashCode();
                if (this.RegionalTrain != null)
                    hash = hash * 59 + this.RegionalTrain.GetHashCode();
                if (this.RegionalCoach != null)
                    hash = hash * 59 + this.RegionalCoach.GetHashCode();
                if (this.RegionalBus != null)
                    hash = hash * 59 + this.RegionalBus.GetHashCode();
                return hash;
            }
        }
    }

}
