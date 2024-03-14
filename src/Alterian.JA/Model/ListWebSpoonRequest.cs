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
    /// ListWebSpoonRequest
    /// </summary>
    [DataContract(Name = "ListWebSpoon_request")]
    public partial class ListWebSpoonRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebSpoonRequest" /> class.
        /// </summary>
        /// <param name="id">If you want a specific instance, provide the id here.</param>
        /// <param name="includeOperationalStatus">If you want to call out to the instance to see if it is reachable, specify yes.  For each instance, this will increase the time that this method takes to return.</param>
        public ListWebSpoonRequest(string id = default(string), bool includeOperationalStatus = default(bool))
        {
            this.Id = id;
            this.IncludeOperationalStatus = includeOperationalStatus;
        }

        /// <summary>
        /// If you want a specific instance, provide the id here
        /// </summary>
        /// <value>If you want a specific instance, provide the id here</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// If you want to call out to the instance to see if it is reachable, specify yes.  For each instance, this will increase the time that this method takes to return
        /// </summary>
        /// <value>If you want to call out to the instance to see if it is reachable, specify yes.  For each instance, this will increase the time that this method takes to return</value>
        [DataMember(Name = "IncludeOperationalStatus", EmitDefaultValue = true)]
        public bool IncludeOperationalStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListWebSpoonRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncludeOperationalStatus: ").Append(IncludeOperationalStatus).Append("\n");
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