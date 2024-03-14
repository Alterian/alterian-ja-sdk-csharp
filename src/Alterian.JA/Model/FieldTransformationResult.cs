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
    /// FieldTransformationResult
    /// </summary>
    [DataContract(Name = "FieldTransformationResult")]
    public partial class FieldTransformationResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTransformationResult" /> class.
        /// </summary>
        /// <param name="transformationCounts">transformationCounts.</param>
        /// <param name="sourceValues">sourceValues.</param>
        /// <param name="transformedValues">transformedValues.</param>
        public FieldTransformationResult(List<long> transformationCounts = default(List<long>), DiscreteValueData sourceValues = default(DiscreteValueData), DiscreteValueData transformedValues = default(DiscreteValueData))
        {
            this.TransformationCounts = transformationCounts;
            this.SourceValues = sourceValues;
            this.TransformedValues = transformedValues;
        }

        /// <summary>
        /// Gets or Sets TransformationCounts
        /// </summary>
        [DataMember(Name = "TransformationCounts", EmitDefaultValue = false)]
        public List<long> TransformationCounts { get; set; }

        /// <summary>
        /// Gets or Sets SourceValues
        /// </summary>
        [DataMember(Name = "SourceValues", EmitDefaultValue = false)]
        public DiscreteValueData SourceValues { get; set; }

        /// <summary>
        /// Gets or Sets TransformedValues
        /// </summary>
        [DataMember(Name = "TransformedValues", EmitDefaultValue = false)]
        public DiscreteValueData TransformedValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldTransformationResult {\n");
            sb.Append("  TransformationCounts: ").Append(TransformationCounts).Append("\n");
            sb.Append("  SourceValues: ").Append(SourceValues).Append("\n");
            sb.Append("  TransformedValues: ").Append(TransformedValues).Append("\n");
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