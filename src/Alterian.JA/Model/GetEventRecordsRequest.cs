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
    /// GetEventRecordsRequest
    /// </summary>
    [DataContract(Name = "GetEventRecords_request")]
    public partial class GetEventRecordsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventRecordsRequest" /> class.
        /// </summary>
        /// <param name="columnTransforms">Applies the specified transforms to base the result on the transformed discrete values.</param>
        /// <param name="cursor">cursor.</param>
        /// <param name="dataSourceId">Id of the datasource to which table belongs..</param>
        /// <param name="eventDateTimeLower">Optionally filter by EventDateTime.</param>
        /// <param name="eventDateTimeUpper">Optionally filter by EventDateTime.</param>
        /// <param name="eventTypes">List of event types to include (default to all).</param>
        /// <param name="filters">Additional columns to filter on.</param>
        /// <param name="initiatives">List of initiatives to include (default to all).</param>
        /// <param name="key">Optional Key value (the integer re-keyed value).</param>
        /// <param name="tableNameEx">Event Stream table (standard two part name ex).</param>
        public GetEventRecordsRequest(List<EventStreamColumnTransform> columnTransforms = default(List<EventStreamColumnTransform>), APILastModifiedCursor cursor = default(APILastModifiedCursor), int dataSourceId = default(int), DateTime? eventDateTimeLower = default(DateTime?), DateTime? eventDateTimeUpper = default(DateTime?), List<string> eventTypes = default(List<string>), List<ColumnMatchList> filters = default(List<ColumnMatchList>), List<string> initiatives = default(List<string>), int? key = default(int?), string tableNameEx = default(string))
        {
            this.ColumnTransforms = columnTransforms;
            this.Cursor = cursor;
            this.DataSourceId = dataSourceId;
            this.EventDateTimeLower = eventDateTimeLower;
            this.EventDateTimeUpper = eventDateTimeUpper;
            this.EventTypes = eventTypes;
            this.Filters = filters;
            this.Initiatives = initiatives;
            this.Key = key;
            this.TableNameEx = tableNameEx;
        }

        /// <summary>
        /// Applies the specified transforms to base the result on the transformed discrete values
        /// </summary>
        /// <value>Applies the specified transforms to base the result on the transformed discrete values</value>
        [DataMember(Name = "ColumnTransforms", EmitDefaultValue = false)]
        public List<EventStreamColumnTransform> ColumnTransforms { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APILastModifiedCursor Cursor { get; set; }

        /// <summary>
        /// Id of the datasource to which table belongs.
        /// </summary>
        /// <value>Id of the datasource to which table belongs.</value>
        [DataMember(Name = "DataSourceId", EmitDefaultValue = false)]
        public int DataSourceId { get; set; }

        /// <summary>
        /// Optionally filter by EventDateTime
        /// </summary>
        /// <value>Optionally filter by EventDateTime</value>
        [DataMember(Name = "EventDateTimeLower", EmitDefaultValue = true)]
        public DateTime? EventDateTimeLower { get; set; }

        /// <summary>
        /// Optionally filter by EventDateTime
        /// </summary>
        /// <value>Optionally filter by EventDateTime</value>
        [DataMember(Name = "EventDateTimeUpper", EmitDefaultValue = true)]
        public DateTime? EventDateTimeUpper { get; set; }

        /// <summary>
        /// List of event types to include (default to all)
        /// </summary>
        /// <value>List of event types to include (default to all)</value>
        [DataMember(Name = "EventTypes", EmitDefaultValue = false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// Additional columns to filter on
        /// </summary>
        /// <value>Additional columns to filter on</value>
        [DataMember(Name = "Filters", EmitDefaultValue = false)]
        public List<ColumnMatchList> Filters { get; set; }

        /// <summary>
        /// List of initiatives to include (default to all)
        /// </summary>
        /// <value>List of initiatives to include (default to all)</value>
        [DataMember(Name = "Initiatives", EmitDefaultValue = false)]
        public List<string> Initiatives { get; set; }

        /// <summary>
        /// Optional Key value (the integer re-keyed value)
        /// </summary>
        /// <value>Optional Key value (the integer re-keyed value)</value>
        [DataMember(Name = "Key", EmitDefaultValue = true)]
        public int? Key { get; set; }

        /// <summary>
        /// Event Stream table (standard two part name ex)
        /// </summary>
        /// <value>Event Stream table (standard two part name ex)</value>
        [DataMember(Name = "TableNameEx", EmitDefaultValue = false)]
        public string TableNameEx { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEventRecordsRequest {\n");
            sb.Append("  ColumnTransforms: ").Append(ColumnTransforms).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  EventDateTimeLower: ").Append(EventDateTimeLower).Append("\n");
            sb.Append("  EventDateTimeUpper: ").Append(EventDateTimeUpper).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Initiatives: ").Append(Initiatives).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  TableNameEx: ").Append(TableNameEx).Append("\n");
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
