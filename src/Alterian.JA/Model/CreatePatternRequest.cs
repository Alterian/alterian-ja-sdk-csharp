/*
 * Journey Analytics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 6.35.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Alterian.JA.Client.OpenAPIDateConverter;

namespace Alterian.JA.Model
{
    /// <summary>
    /// CreatePatternRequest
    /// </summary>
    [DataContract(Name = "CreatePattern_request")]
    public partial class CreatePatternRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePatternRequest" /> class.
        /// </summary>
        /// <param name="eventStreamId">Event stream to create pattern definition against.</param>
        /// <param name="settings">JSON describing the pattern e.g. {\&quot;sequence\&quot;:{\&quot;dedup:null\&quot;}, \&quot;detect\&quot;:{\&quot;minrep\&quot;:100}}.</param>
        /// <param name="snapshotEnd">snapshotEnd.</param>
        /// <param name="snapshotStart">snapshotStart.</param>
        public CreatePatternRequest(int eventStreamId = default(int), string settings = default(string), DateTime snapshotEnd = default(DateTime), DateTime snapshotStart = default(DateTime))
        {
            this.EventStreamId = eventStreamId;
            this.Settings = settings;
            this.SnapshotEnd = snapshotEnd;
            this.SnapshotStart = snapshotStart;
        }

        /// <summary>
        /// Event stream to create pattern definition against
        /// </summary>
        /// <value>Event stream to create pattern definition against</value>
        [DataMember(Name = "EventStreamId", EmitDefaultValue = false)]
        public int EventStreamId { get; set; }

        /// <summary>
        /// JSON describing the pattern e.g. {\&quot;sequence\&quot;:{\&quot;dedup:null\&quot;}, \&quot;detect\&quot;:{\&quot;minrep\&quot;:100}}
        /// </summary>
        /// <value>JSON describing the pattern e.g. {\&quot;sequence\&quot;:{\&quot;dedup:null\&quot;}, \&quot;detect\&quot;:{\&quot;minrep\&quot;:100}}</value>
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
        public string Settings { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotEnd
        /// </summary>
        [DataMember(Name = "SnapshotEnd", EmitDefaultValue = false)]
        public DateTime SnapshotEnd { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotStart
        /// </summary>
        [DataMember(Name = "SnapshotStart", EmitDefaultValue = false)]
        public DateTime SnapshotStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePatternRequest {\n");
            sb.Append("  EventStreamId: ").Append(EventStreamId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  SnapshotEnd: ").Append(SnapshotEnd).Append("\n");
            sb.Append("  SnapshotStart: ").Append(SnapshotStart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
