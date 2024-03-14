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
    /// GetEventStreamDecodeTargetDiscretesRequest
    /// </summary>
    [DataContract(Name = "GetEventStreamDecodeTargetDiscretes_request")]
    public partial class GetEventStreamDecodeTargetDiscretesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventStreamDecodeTargetDiscretesRequest" /> class.
        /// </summary>
        /// <param name="baseListId">Optionally base the decodes on a specified decode list subject to any explicitly specified overrides.</param>
        /// <param name="baseListVersion">Optional list version (defaults to latest).</param>
        /// <param name="columnName">Column from the event stream to be decoded (defaults to Location).</param>
        /// <param name="defaultLabel">In conjunction with IsDefaultLabelConfigured this allows the API to override the default label from any specified base decode list. Pass NULL to remove an underlying list default and an empty string or space to override it to NULL.</param>
        /// <param name="eventDateTimeLower">Start of the date window for column values to be displayed and decoded.</param>
        /// <param name="eventDateTimeUpper">End of the date window for column values to be displayed and decoded.</param>
        /// <param name="eventStreamId">Event Stream Id.</param>
        /// <param name="isDataRefreshRequired">Force the source labels to be refreshed from the event stream data.</param>
        /// <param name="isDefaultLabelConfigured">Set this to true if DefaultLabel is being used. If set to false then the default label will be determined by any specified base decode list.</param>
        /// <param name="sourceLabels">Specify any source labels that should be overriden on the specified base decode list.</param>
        /// <param name="targetLabels">Specify the target labels that should override the specified base decode list. Pass NULL to remove an underlying list decode or an empty string to override it to NULL. Pass a NULL list to remove mappings for all the specified source labels.</param>
        public GetEventStreamDecodeTargetDiscretesRequest(int? baseListId = default(int?), int? baseListVersion = default(int?), string columnName = default(string), string defaultLabel = default(string), DateTime? eventDateTimeLower = default(DateTime?), DateTime? eventDateTimeUpper = default(DateTime?), int eventStreamId = default(int), bool isDataRefreshRequired = default(bool), bool? isDefaultLabelConfigured = default(bool?), List<string> sourceLabels = default(List<string>), List<string> targetLabels = default(List<string>))
        {
            this.BaseListId = baseListId;
            this.BaseListVersion = baseListVersion;
            this.ColumnName = columnName;
            this.DefaultLabel = defaultLabel;
            this.EventDateTimeLower = eventDateTimeLower;
            this.EventDateTimeUpper = eventDateTimeUpper;
            this.EventStreamId = eventStreamId;
            this.IsDataRefreshRequired = isDataRefreshRequired;
            this.IsDefaultLabelConfigured = isDefaultLabelConfigured;
            this.SourceLabels = sourceLabels;
            this.TargetLabels = targetLabels;
        }

        /// <summary>
        /// Optionally base the decodes on a specified decode list subject to any explicitly specified overrides
        /// </summary>
        /// <value>Optionally base the decodes on a specified decode list subject to any explicitly specified overrides</value>
        [DataMember(Name = "BaseListId", EmitDefaultValue = true)]
        public int? BaseListId { get; set; }

        /// <summary>
        /// Optional list version (defaults to latest)
        /// </summary>
        /// <value>Optional list version (defaults to latest)</value>
        [DataMember(Name = "BaseListVersion", EmitDefaultValue = true)]
        public int? BaseListVersion { get; set; }

        /// <summary>
        /// Column from the event stream to be decoded (defaults to Location)
        /// </summary>
        /// <value>Column from the event stream to be decoded (defaults to Location)</value>
        [DataMember(Name = "ColumnName", EmitDefaultValue = false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// In conjunction with IsDefaultLabelConfigured this allows the API to override the default label from any specified base decode list. Pass NULL to remove an underlying list default and an empty string or space to override it to NULL
        /// </summary>
        /// <value>In conjunction with IsDefaultLabelConfigured this allows the API to override the default label from any specified base decode list. Pass NULL to remove an underlying list default and an empty string or space to override it to NULL</value>
        [DataMember(Name = "DefaultLabel", EmitDefaultValue = false)]
        public string DefaultLabel { get; set; }

        /// <summary>
        /// Start of the date window for column values to be displayed and decoded
        /// </summary>
        /// <value>Start of the date window for column values to be displayed and decoded</value>
        [DataMember(Name = "EventDateTimeLower", EmitDefaultValue = true)]
        public DateTime? EventDateTimeLower { get; set; }

        /// <summary>
        /// End of the date window for column values to be displayed and decoded
        /// </summary>
        /// <value>End of the date window for column values to be displayed and decoded</value>
        [DataMember(Name = "EventDateTimeUpper", EmitDefaultValue = true)]
        public DateTime? EventDateTimeUpper { get; set; }

        /// <summary>
        /// Event Stream Id
        /// </summary>
        /// <value>Event Stream Id</value>
        [DataMember(Name = "EventStreamId", EmitDefaultValue = false)]
        public int EventStreamId { get; set; }

        /// <summary>
        /// Force the source labels to be refreshed from the event stream data
        /// </summary>
        /// <value>Force the source labels to be refreshed from the event stream data</value>
        [DataMember(Name = "IsDataRefreshRequired", EmitDefaultValue = true)]
        public bool IsDataRefreshRequired { get; set; }

        /// <summary>
        /// Set this to true if DefaultLabel is being used. If set to false then the default label will be determined by any specified base decode list
        /// </summary>
        /// <value>Set this to true if DefaultLabel is being used. If set to false then the default label will be determined by any specified base decode list</value>
        [DataMember(Name = "IsDefaultLabelConfigured", EmitDefaultValue = true)]
        public bool? IsDefaultLabelConfigured { get; set; }

        /// <summary>
        /// Specify any source labels that should be overriden on the specified base decode list
        /// </summary>
        /// <value>Specify any source labels that should be overriden on the specified base decode list</value>
        [DataMember(Name = "SourceLabels", EmitDefaultValue = false)]
        public List<string> SourceLabels { get; set; }

        /// <summary>
        /// Specify the target labels that should override the specified base decode list. Pass NULL to remove an underlying list decode or an empty string to override it to NULL. Pass a NULL list to remove mappings for all the specified source labels
        /// </summary>
        /// <value>Specify the target labels that should override the specified base decode list. Pass NULL to remove an underlying list decode or an empty string to override it to NULL. Pass a NULL list to remove mappings for all the specified source labels</value>
        [DataMember(Name = "TargetLabels", EmitDefaultValue = false)]
        public List<string> TargetLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEventStreamDecodeTargetDiscretesRequest {\n");
            sb.Append("  BaseListId: ").Append(BaseListId).Append("\n");
            sb.Append("  BaseListVersion: ").Append(BaseListVersion).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  DefaultLabel: ").Append(DefaultLabel).Append("\n");
            sb.Append("  EventDateTimeLower: ").Append(EventDateTimeLower).Append("\n");
            sb.Append("  EventDateTimeUpper: ").Append(EventDateTimeUpper).Append("\n");
            sb.Append("  EventStreamId: ").Append(EventStreamId).Append("\n");
            sb.Append("  IsDataRefreshRequired: ").Append(IsDataRefreshRequired).Append("\n");
            sb.Append("  IsDefaultLabelConfigured: ").Append(IsDefaultLabelConfigured).Append("\n");
            sb.Append("  SourceLabels: ").Append(SourceLabels).Append("\n");
            sb.Append("  TargetLabels: ").Append(TargetLabels).Append("\n");
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