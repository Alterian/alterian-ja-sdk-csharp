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
    /// GetEventStreamInitiativesRequest
    /// </summary>
    [DataContract(Name = "GetEventStreamInitiatives_request")]
    public partial class GetEventStreamInitiativesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventStreamInitiativesRequest" /> class.
        /// </summary>
        /// <param name="dataSourceId">Id of the datasource to which table belongs..</param>
        /// <param name="tableNameEx">Event Stream table (standard two part name ex).</param>
        public GetEventStreamInitiativesRequest(int? dataSourceId = default(int?), string tableNameEx = default(string))
        {
            this.DataSourceId = dataSourceId;
            this.TableNameEx = tableNameEx;
        }

        /// <summary>
        /// Id of the datasource to which table belongs.
        /// </summary>
        /// <value>Id of the datasource to which table belongs.</value>
        [DataMember(Name = "DataSourceId", EmitDefaultValue = true)]
        public int? DataSourceId { get; set; }

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
            sb.Append("class GetEventStreamInitiativesRequest {\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
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
