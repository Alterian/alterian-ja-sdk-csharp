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
    /// PatternScoreList
    /// </summary>
    [DataContract(Name = "PatternScoreList")]
    public partial class PatternScoreList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternScoreList" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="scores">scores.</param>
        public PatternScoreList(List<string> items = default(List<string>), List<double> scores = default(List<double>))
        {
            this.Items = items;
            this.Scores = scores;
        }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// Gets or Sets Scores
        /// </summary>
        [DataMember(Name = "Scores", EmitDefaultValue = false)]
        public List<double> Scores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatternScoreList {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
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
