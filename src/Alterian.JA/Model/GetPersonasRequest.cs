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
    /// GetPersonasRequest
    /// </summary>
    [DataContract(Name = "GetPersonas_request")]
    public partial class GetPersonasRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPersonasRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="includeHidden">Do you want to return hidden personas as well?.</param>
        public GetPersonasRequest(APICursor cursor = default(APICursor), bool includeHidden = default(bool))
        {
            this.Cursor = cursor;
            this.IncludeHidden = includeHidden;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Do you want to return hidden personas as well?
        /// </summary>
        /// <value>Do you want to return hidden personas as well?</value>
        [DataMember(Name = "IncludeHidden", EmitDefaultValue = true)]
        public bool IncludeHidden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPersonasRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  IncludeHidden: ").Append(IncludeHidden).Append("\n");
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
