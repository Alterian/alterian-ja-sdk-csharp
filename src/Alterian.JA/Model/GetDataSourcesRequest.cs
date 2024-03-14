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
    /// GetDataSourcesRequest
    /// </summary>
    [DataContract(Name = "GetDataSources_request")]
    public partial class GetDataSourcesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDataSourcesRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="datasourceTypeID">Include only datasources of this type.</param>
        /// <param name="fullyPopulate">Fully populate the datasource structure - - including databases, tables and columns.  For complicated structures, this might take a while to invoke..</param>
        /// <param name="includeDisabled">Include disabled datasources in the list [default is to not include].</param>
        /// <param name="includeInvisible">Include invisible datasources in the list [default is to not include].</param>
        /// <param name="minimalResults">Exclude attributes, etc. from the results.</param>
        /// <param name="nameFilter">Optionally filter on the name.</param>
        public GetDataSourcesRequest(APICursor cursor = default(APICursor), int? datasourceTypeID = default(int?), bool fullyPopulate = default(bool), bool includeDisabled = default(bool), bool includeInvisible = default(bool), bool minimalResults = default(bool), string nameFilter = default(string))
        {
            this.Cursor = cursor;
            this.DatasourceTypeID = datasourceTypeID;
            this.FullyPopulate = fullyPopulate;
            this.IncludeDisabled = includeDisabled;
            this.IncludeInvisible = includeInvisible;
            this.MinimalResults = minimalResults;
            this.NameFilter = nameFilter;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Include only datasources of this type
        /// </summary>
        /// <value>Include only datasources of this type</value>
        [DataMember(Name = "DatasourceTypeID", EmitDefaultValue = true)]
        public int? DatasourceTypeID { get; set; }

        /// <summary>
        /// Fully populate the datasource structure - - including databases, tables and columns.  For complicated structures, this might take a while to invoke.
        /// </summary>
        /// <value>Fully populate the datasource structure - - including databases, tables and columns.  For complicated structures, this might take a while to invoke.</value>
        [DataMember(Name = "FullyPopulate", EmitDefaultValue = true)]
        public bool FullyPopulate { get; set; }

        /// <summary>
        /// Include disabled datasources in the list [default is to not include]
        /// </summary>
        /// <value>Include disabled datasources in the list [default is to not include]</value>
        [DataMember(Name = "IncludeDisabled", EmitDefaultValue = true)]
        public bool IncludeDisabled { get; set; }

        /// <summary>
        /// Include invisible datasources in the list [default is to not include]
        /// </summary>
        /// <value>Include invisible datasources in the list [default is to not include]</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDataSourcesRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  DatasourceTypeID: ").Append(DatasourceTypeID).Append("\n");
            sb.Append("  FullyPopulate: ").Append(FullyPopulate).Append("\n");
            sb.Append("  IncludeDisabled: ").Append(IncludeDisabled).Append("\n");
            sb.Append("  IncludeInvisible: ").Append(IncludeInvisible).Append("\n");
            sb.Append("  MinimalResults: ").Append(MinimalResults).Append("\n");
            sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
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