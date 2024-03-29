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
    /// DiscreteValueData
    /// </summary>
    [DataContract(Name = "DiscreteValueData")]
    public partial class DiscreteValueData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscreteValueData" /> class.
        /// </summary>
        /// <param name="labels">labels.</param>
        /// <param name="frequencies">frequencies.</param>
        public DiscreteValueData(List<string> labels = default(List<string>), List<long> frequencies = default(List<long>))
        {
            this.Labels = labels;
            this.Frequencies = frequencies;
        }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Frequencies
        /// </summary>
        [DataMember(Name = "Frequencies", EmitDefaultValue = false)]
        public List<long> Frequencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscreteValueData {\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Frequencies: ").Append(Frequencies).Append("\n");
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
