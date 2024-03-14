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
    /// UpdateIdealisedJourneyRequest
    /// </summary>
    [DataContract(Name = "UpdateIdealisedJourney_request")]
    public partial class UpdateIdealisedJourneyRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIdealisedJourneyRequest" /> class.
        /// </summary>
        /// <param name="idealisedJourneyId">A valid Sankey ID.</param>
        /// <param name="json">json.</param>
        /// <param name="name">name.</param>
        public UpdateIdealisedJourneyRequest(int idealisedJourneyId = default(int), string json = default(string), string name = default(string))
        {
            this.IdealisedJourneyId = idealisedJourneyId;
            this.Json = json;
            this.Name = name;
        }

        /// <summary>
        /// A valid Sankey ID
        /// </summary>
        /// <value>A valid Sankey ID</value>
        [DataMember(Name = "IdealisedJourneyId", EmitDefaultValue = false)]
        public int IdealisedJourneyId { get; set; }

        /// <summary>
        /// Gets or Sets Json
        /// </summary>
        [DataMember(Name = "Json", EmitDefaultValue = false)]
        public string Json { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateIdealisedJourneyRequest {\n");
            sb.Append("  IdealisedJourneyId: ").Append(IdealisedJourneyId).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
