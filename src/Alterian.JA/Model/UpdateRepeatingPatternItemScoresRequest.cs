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
    /// UpdateRepeatingPatternItemScoresRequest
    /// </summary>
    [DataContract(Name = "UpdateRepeatingPatternItemScores_request")]
    public partial class UpdateRepeatingPatternItemScoresRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRepeatingPatternItemScoresRequest" /> class.
        /// </summary>
        /// <param name="decodeId">Optional. Only required if the scores are to be recorded against a transform.</param>
        /// <param name="decodeVersion">Optional. Only required if the scores are to be recorded against a transform.</param>
        /// <param name="items">List of the sequence items to be re-scored.</param>
        /// <param name="patternId">Pattern Id.</param>
        /// <param name="replaceExistingScores">Defaults to False meaning that the update acts in a &#39;cursored&#39; mode - the UI can submit only the modified scores and any existing scores from the previous list version are preserved. When set to true then any existing scores are completely replaced.</param>
        /// <param name="scores">List of the scores (must have a 1:1 relationship with Items).</param>
        public UpdateRepeatingPatternItemScoresRequest(int? decodeId = default(int?), int? decodeVersion = default(int?), List<string> items = default(List<string>), int patternId = default(int), bool replaceExistingScores = default(bool), List<double> scores = default(List<double>))
        {
            this.DecodeId = decodeId;
            this.DecodeVersion = decodeVersion;
            this.Items = items;
            this.PatternId = patternId;
            this.ReplaceExistingScores = replaceExistingScores;
            this.Scores = scores;
        }

        /// <summary>
        /// Optional. Only required if the scores are to be recorded against a transform
        /// </summary>
        /// <value>Optional. Only required if the scores are to be recorded against a transform</value>
        [DataMember(Name = "DecodeId", EmitDefaultValue = true)]
        public int? DecodeId { get; set; }

        /// <summary>
        /// Optional. Only required if the scores are to be recorded against a transform
        /// </summary>
        /// <value>Optional. Only required if the scores are to be recorded against a transform</value>
        [DataMember(Name = "DecodeVersion", EmitDefaultValue = true)]
        public int? DecodeVersion { get; set; }

        /// <summary>
        /// List of the sequence items to be re-scored
        /// </summary>
        /// <value>List of the sequence items to be re-scored</value>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// Pattern Id
        /// </summary>
        /// <value>Pattern Id</value>
        [DataMember(Name = "PatternId", EmitDefaultValue = false)]
        public int PatternId { get; set; }

        /// <summary>
        /// Defaults to False meaning that the update acts in a &#39;cursored&#39; mode - the UI can submit only the modified scores and any existing scores from the previous list version are preserved. When set to true then any existing scores are completely replaced
        /// </summary>
        /// <value>Defaults to False meaning that the update acts in a &#39;cursored&#39; mode - the UI can submit only the modified scores and any existing scores from the previous list version are preserved. When set to true then any existing scores are completely replaced</value>
        [DataMember(Name = "ReplaceExistingScores", EmitDefaultValue = true)]
        public bool ReplaceExistingScores { get; set; }

        /// <summary>
        /// List of the scores (must have a 1:1 relationship with Items)
        /// </summary>
        /// <value>List of the scores (must have a 1:1 relationship with Items)</value>
        [DataMember(Name = "Scores", EmitDefaultValue = false)]
        public List<double> Scores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateRepeatingPatternItemScoresRequest {\n");
            sb.Append("  DecodeId: ").Append(DecodeId).Append("\n");
            sb.Append("  DecodeVersion: ").Append(DecodeVersion).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PatternId: ").Append(PatternId).Append("\n");
            sb.Append("  ReplaceExistingScores: ").Append(ReplaceExistingScores).Append("\n");
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