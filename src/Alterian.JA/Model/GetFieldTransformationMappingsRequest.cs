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
    /// GetFieldTransformationMappingsRequest
    /// </summary>
    [DataContract(Name = "GetFieldTransformationMappings_request")]
    public partial class GetFieldTransformationMappingsRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SourcePostMatch
        /// </summary>
        [DataMember(Name = "SourcePostMatch", EmitDefaultValue = false)]
        public MatchOptions? SourcePostMatch { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldTransformationMappingsRequest" /> class.
        /// </summary>
        /// <param name="columnNameEx">Source column to which transforms should be applied.</param>
        /// <param name="cursor">cursor.</param>
        /// <param name="dataSourceId">Id of the datasource to which column belongs..</param>
        /// <param name="isDataRefreshRequired">Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false).</param>
        /// <param name="jSONCompareTransforms">Optional JSON array of transforms to produce a revised starting set of values from the column.</param>
        /// <param name="jSONTransforms">JSON array of transform to be applied e.g. [{{\\\&quot;FrequencyReplace\\\&quot;:{{\\\&quot;@minimum\\\&quot;:8035,\\\&quot;@replacement\\\&quot;:\\\&quot;My Replacement\\\&quot;}}}}]. Note that attributes must be prefixed with @.</param>
        /// <param name="postFilter">Optional string to filter the post transform values by.</param>
        /// <param name="sampleSettings">sampleSettings.</param>
        /// <param name="sourceFilter">Optional string to filter the source values by.</param>
        /// <param name="sourcePostMatch">sourcePostMatch.</param>
        public GetFieldTransformationMappingsRequest(string columnNameEx = default(string), APICursor cursor = default(APICursor), int dataSourceId = default(int), bool isDataRefreshRequired = default(bool), string jSONCompareTransforms = default(string), string jSONTransforms = default(string), string postFilter = default(string), FieldTransformationSampleSettings sampleSettings = default(FieldTransformationSampleSettings), string sourceFilter = default(string), MatchOptions? sourcePostMatch = default(MatchOptions?))
        {
            this.ColumnNameEx = columnNameEx;
            this.Cursor = cursor;
            this.DataSourceId = dataSourceId;
            this.IsDataRefreshRequired = isDataRefreshRequired;
            this.JSONCompareTransforms = jSONCompareTransforms;
            this.JSONTransforms = jSONTransforms;
            this.PostFilter = postFilter;
            this.SampleSettings = sampleSettings;
            this.SourceFilter = sourceFilter;
            this.SourcePostMatch = sourcePostMatch;
        }

        /// <summary>
        /// Source column to which transforms should be applied
        /// </summary>
        /// <value>Source column to which transforms should be applied</value>
        [DataMember(Name = "ColumnNameEx", EmitDefaultValue = false)]
        public string ColumnNameEx { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Id of the datasource to which column belongs.
        /// </summary>
        /// <value>Id of the datasource to which column belongs.</value>
        [DataMember(Name = "DataSourceId", EmitDefaultValue = false)]
        public int DataSourceId { get; set; }

        /// <summary>
        /// Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false)
        /// </summary>
        /// <value>Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false)</value>
        [DataMember(Name = "IsDataRefreshRequired", EmitDefaultValue = true)]
        public bool IsDataRefreshRequired { get; set; }

        /// <summary>
        /// Optional JSON array of transforms to produce a revised starting set of values from the column
        /// </summary>
        /// <value>Optional JSON array of transforms to produce a revised starting set of values from the column</value>
        [DataMember(Name = "JSONCompareTransforms", EmitDefaultValue = false)]
        public string JSONCompareTransforms { get; set; }

        /// <summary>
        /// JSON array of transform to be applied e.g. [{{\\\&quot;FrequencyReplace\\\&quot;:{{\\\&quot;@minimum\\\&quot;:8035,\\\&quot;@replacement\\\&quot;:\\\&quot;My Replacement\\\&quot;}}}}]. Note that attributes must be prefixed with @
        /// </summary>
        /// <value>JSON array of transform to be applied e.g. [{{\\\&quot;FrequencyReplace\\\&quot;:{{\\\&quot;@minimum\\\&quot;:8035,\\\&quot;@replacement\\\&quot;:\\\&quot;My Replacement\\\&quot;}}}}]. Note that attributes must be prefixed with @</value>
        [DataMember(Name = "JSONTransforms", EmitDefaultValue = false)]
        public string JSONTransforms { get; set; }

        /// <summary>
        /// Optional string to filter the post transform values by
        /// </summary>
        /// <value>Optional string to filter the post transform values by</value>
        [DataMember(Name = "PostFilter", EmitDefaultValue = false)]
        public string PostFilter { get; set; }

        /// <summary>
        /// Gets or Sets SampleSettings
        /// </summary>
        [DataMember(Name = "SampleSettings", EmitDefaultValue = false)]
        public FieldTransformationSampleSettings SampleSettings { get; set; }

        /// <summary>
        /// Optional string to filter the source values by
        /// </summary>
        /// <value>Optional string to filter the source values by</value>
        [DataMember(Name = "SourceFilter", EmitDefaultValue = false)]
        public string SourceFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetFieldTransformationMappingsRequest {\n");
            sb.Append("  ColumnNameEx: ").Append(ColumnNameEx).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  IsDataRefreshRequired: ").Append(IsDataRefreshRequired).Append("\n");
            sb.Append("  JSONCompareTransforms: ").Append(JSONCompareTransforms).Append("\n");
            sb.Append("  JSONTransforms: ").Append(JSONTransforms).Append("\n");
            sb.Append("  PostFilter: ").Append(PostFilter).Append("\n");
            sb.Append("  SampleSettings: ").Append(SampleSettings).Append("\n");
            sb.Append("  SourceFilter: ").Append(SourceFilter).Append("\n");
            sb.Append("  SourcePostMatch: ").Append(SourcePostMatch).Append("\n");
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