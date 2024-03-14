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
    /// GetOpportunitiesDefaultResponse
    /// </summary>
    [DataContract(Name = "GetOpportunities_default_response")]
    public partial class GetOpportunitiesDefaultResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunitiesDefaultResponse" /> class.
        /// </summary>
        /// <param name="statusCode">A string constant representing the success or failure of the method call. See the status codes table below..</param>
        /// <param name="debugMessage">By default, an empty array []. Internal debug messages can be exposed by changing a configuration setting on the server, but be aware that this can leak internal implementation details such as stack calls or method names to the caller..</param>
        /// <param name="detail">Optionally return additional information about this API call             This will typically contain the reason WHY a method failed (if it fails), warnings if success, and other bits of data that             are NOT part of the main result..</param>
        /// <param name="cursor">cursor.</param>
        /// <param name="result">result.</param>
        public GetOpportunitiesDefaultResponse(string statusCode = default(string), string debugMessage = default(string), List<List<string>> detail = default(List<List<string>>), APICursor cursor = default(APICursor), List<Opportunity> result = default(List<Opportunity>))
        {
            this.StatusCode = statusCode;
            this.DebugMessage = debugMessage;
            this.Detail = detail;
            this.Cursor = cursor;
            this.Result = result;
        }

        /// <summary>
        /// A string constant representing the success or failure of the method call. See the status codes table below.
        /// </summary>
        /// <value>A string constant representing the success or failure of the method call. See the status codes table below.</value>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// By default, an empty array []. Internal debug messages can be exposed by changing a configuration setting on the server, but be aware that this can leak internal implementation details such as stack calls or method names to the caller.
        /// </summary>
        /// <value>By default, an empty array []. Internal debug messages can be exposed by changing a configuration setting on the server, but be aware that this can leak internal implementation details such as stack calls or method names to the caller.</value>
        [DataMember(Name = "DebugMessage", EmitDefaultValue = false)]
        public string DebugMessage { get; set; }

        /// <summary>
        /// Optionally return additional information about this API call             This will typically contain the reason WHY a method failed (if it fails), warnings if success, and other bits of data that             are NOT part of the main result.
        /// </summary>
        /// <value>Optionally return additional information about this API call             This will typically contain the reason WHY a method failed (if it fails), warnings if success, and other bits of data that             are NOT part of the main result.</value>
        [DataMember(Name = "Detail", EmitDefaultValue = false)]
        public List<List<string>> Detail { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "Result", EmitDefaultValue = false)]
        public List<Opportunity> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetOpportunitiesDefaultResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  DebugMessage: ").Append(DebugMessage).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
