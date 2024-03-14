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
    /// Pattern
    /// </summary>
    [DataContract(Name = "Pattern")]
    public partial class Pattern : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public PatternState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventStreamId">eventStreamId.</param>
        /// <param name="snapshotStart">snapshotStart.</param>
        /// <param name="snapshotEnd">snapshotEnd.</param>
        /// <param name="settings">settings.</param>
        /// <param name="state">state.</param>
        /// <param name="dataSourceId">dataSourceId.</param>
        /// <param name="transforms">transforms.</param>
        public Pattern(int id = default(int), int eventStreamId = default(int), DateTime snapshotStart = default(DateTime), DateTime snapshotEnd = default(DateTime), string settings = default(string), PatternState? state = default(PatternState?), int dataSourceId = default(int), List<ColumnPublishedTransformSummary> transforms = default(List<ColumnPublishedTransformSummary>))
        {
            this.Id = id;
            this.EventStreamId = eventStreamId;
            this.SnapshotStart = snapshotStart;
            this.SnapshotEnd = snapshotEnd;
            this.Settings = settings;
            this.State = state;
            this.DataSourceId = dataSourceId;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets EventStreamId
        /// </summary>
        [DataMember(Name = "EventStreamId", EmitDefaultValue = false)]
        public int EventStreamId { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotStart
        /// </summary>
        [DataMember(Name = "SnapshotStart", EmitDefaultValue = false)]
        public DateTime SnapshotStart { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotEnd
        /// </summary>
        [DataMember(Name = "SnapshotEnd", EmitDefaultValue = false)]
        public DateTime SnapshotEnd { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
        public string Settings { get; set; }

        /// <summary>
        /// Gets or Sets DataSourceId
        /// </summary>
        [DataMember(Name = "DataSourceId", EmitDefaultValue = false)]
        public int DataSourceId { get; set; }

        /// <summary>
        /// Gets or Sets Transforms
        /// </summary>
        [DataMember(Name = "Transforms", EmitDefaultValue = false)]
        public List<ColumnPublishedTransformSummary> Transforms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Pattern {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventStreamId: ").Append(EventStreamId).Append("\n");
            sb.Append("  SnapshotStart: ").Append(SnapshotStart).Append("\n");
            sb.Append("  SnapshotEnd: ").Append(SnapshotEnd).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  Transforms: ").Append(Transforms).Append("\n");
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