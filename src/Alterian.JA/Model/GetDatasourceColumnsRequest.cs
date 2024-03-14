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
    /// GetDatasourceColumnsRequest
    /// </summary>
    [DataContract(Name = "GetDatasourceColumns_request")]
    public partial class GetDatasourceColumnsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasourceColumnsRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="includeDisabled">Should disabled columns be included in the output?Default false.</param>
        /// <param name="includeInvisible">Should invisible columns be included in the output? Default false.</param>
        /// <param name="minimalResults">Exclude attributes, etc. from the results.</param>
        /// <param name="nameFilter">Optionally filter on the name.</param>
        /// <param name="tableID">Supply a table ID to filter the result to just the columns within this table. Ignore this parameter to fetch all columns, which can be very slow..</param>
        public GetDatasourceColumnsRequest(APICursor cursor = default(APICursor), bool includeDisabled = default(bool), bool includeInvisible = default(bool), bool minimalResults = default(bool), string nameFilter = default(string), int? tableID = default(int?))
        {
            this.Cursor = cursor;
            this.IncludeDisabled = includeDisabled;
            this.IncludeInvisible = includeInvisible;
            this.MinimalResults = minimalResults;
            this.NameFilter = nameFilter;
            this.TableID = tableID;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Should disabled columns be included in the output?Default false
        /// </summary>
        /// <value>Should disabled columns be included in the output?Default false</value>
        [DataMember(Name = "IncludeDisabled", EmitDefaultValue = true)]
        public bool IncludeDisabled { get; set; }

        /// <summary>
        /// Should invisible columns be included in the output? Default false
        /// </summary>
        /// <value>Should invisible columns be included in the output? Default false</value>
        [DataMember(Name = "IncludeInvisible", EmitDefaultValue = true)]
        public bool IncludeInvisible { get; set; }

        /// <summary>
        /// Exclude attributes, etc. from the results
        /// </summary>
        /// <value>Exclude attributes, etc. from the results</value>
        [DataMember(Name = "MinimalResults", EmitDefaultValue = true)]
        public bool MinimalResults { get; set; }

        /// <summary>
        /// Optionally filter on the name
        /// </summary>
        /// <value>Optionally filter on the name</value>
        [DataMember(Name = "NameFilter", EmitDefaultValue = false)]
        public string NameFilter { get; set; }

        /// <summary>
        /// Supply a table ID to filter the result to just the columns within this table. Ignore this parameter to fetch all columns, which can be very slow.
        /// </summary>
        /// <value>Supply a table ID to filter the result to just the columns within this table. Ignore this parameter to fetch all columns, which can be very slow.</value>
        [DataMember(Name = "TableID", EmitDefaultValue = true)]
        public int? TableID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDatasourceColumnsRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  IncludeDisabled: ").Append(IncludeDisabled).Append("\n");
            sb.Append("  IncludeInvisible: ").Append(IncludeInvisible).Append("\n");
            sb.Append("  MinimalResults: ").Append(MinimalResults).Append("\n");
            sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
            sb.Append("  TableID: ").Append(TableID).Append("\n");
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