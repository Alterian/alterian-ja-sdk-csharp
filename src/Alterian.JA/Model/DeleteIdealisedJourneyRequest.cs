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
    /// DeleteIdealisedJourneyRequest
    /// </summary>
    [DataContract(Name = "DeleteIdealisedJourney_request")]
    public partial class DeleteIdealisedJourneyRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteIdealisedJourneyRequest" /> class.
        /// </summary>
        /// <param name="idealisedJourneyIds">Id&#39;s of the idealised journey to delete..</param>
        public DeleteIdealisedJourneyRequest(List<int> idealisedJourneyIds = default(List<int>))
        {
            this.IdealisedJourneyIds = idealisedJourneyIds;
        }

        /// <summary>
        /// Id&#39;s of the idealised journey to delete.
        /// </summary>
        /// <value>Id&#39;s of the idealised journey to delete.</value>
        [DataMember(Name = "IdealisedJourneyIds", EmitDefaultValue = false)]
        public List<int> IdealisedJourneyIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteIdealisedJourneyRequest {\n");
            sb.Append("  IdealisedJourneyIds: ").Append(IdealisedJourneyIds).Append("\n");
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
