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
    /// SequencePredictorPredictionOptions
    /// </summary>
    [DataContract(Name = "SequencePredictorPredictionOptions")]
    public partial class SequencePredictorPredictionOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SequencePredictorPredictionOptions" /> class.
        /// </summary>
        /// <param name="predictionName">Name for the generated prediction.</param>
        /// <param name="predictionSeedOutputOption">Indicates what proportion of the prediction seed to include in the prediction that is output             0 - None 1- All.</param>
        /// <param name="predictionSelectionMode">Whether to always select the most probable next step or to select randomised distribution around the most probable step             0&#x3D;Maximum probability , 1&#x3D;Randomized maximum probability (&#39;Fuzzy&#39; predictions - yields a more realistic looking range of outputs).</param>
        /// <param name="numberOfPredictions">Number of events to predict.</param>
        /// <param name="isDataDebugRequired">Turn this on to leave intermediate tables in place for the purposes of debugging a model                          For &#39;fuzzy mode&#39; predictons this will also cause some extra columns for &#39;Most Likely Event&#39; and &#39;Most Likely Event Probability&#39; to be added to the output for comparison.</param>
        public SequencePredictorPredictionOptions(string predictionName = default(string), int? predictionSeedOutputOption = default(int?), int? predictionSelectionMode = default(int?), int? numberOfPredictions = default(int?), bool isDataDebugRequired = default(bool))
        {
            this.PredictionName = predictionName;
            this.PredictionSeedOutputOption = predictionSeedOutputOption;
            this.PredictionSelectionMode = predictionSelectionMode;
            this.NumberOfPredictions = numberOfPredictions;
            this.IsDataDebugRequired = isDataDebugRequired;
        }

        /// <summary>
        /// Name for the generated prediction
        /// </summary>
        /// <value>Name for the generated prediction</value>
        [DataMember(Name = "PredictionName", EmitDefaultValue = false)]
        public string PredictionName { get; set; }

        /// <summary>
        /// Indicates what proportion of the prediction seed to include in the prediction that is output             0 - None 1- All
        /// </summary>
        /// <value>Indicates what proportion of the prediction seed to include in the prediction that is output             0 - None 1- All</value>
        [DataMember(Name = "PredictionSeedOutputOption", EmitDefaultValue = true)]
        public int? PredictionSeedOutputOption { get; set; }

        /// <summary>
        /// Whether to always select the most probable next step or to select randomised distribution around the most probable step             0&#x3D;Maximum probability , 1&#x3D;Randomized maximum probability (&#39;Fuzzy&#39; predictions - yields a more realistic looking range of outputs)
        /// </summary>
        /// <value>Whether to always select the most probable next step or to select randomised distribution around the most probable step             0&#x3D;Maximum probability , 1&#x3D;Randomized maximum probability (&#39;Fuzzy&#39; predictions - yields a more realistic looking range of outputs)</value>
        [DataMember(Name = "PredictionSelectionMode", EmitDefaultValue = true)]
        public int? PredictionSelectionMode { get; set; }

        /// <summary>
        /// Number of events to predict
        /// </summary>
        /// <value>Number of events to predict</value>
        [DataMember(Name = "NumberOfPredictions", EmitDefaultValue = true)]
        public int? NumberOfPredictions { get; set; }

        /// <summary>
        /// Turn this on to leave intermediate tables in place for the purposes of debugging a model                          For &#39;fuzzy mode&#39; predictons this will also cause some extra columns for &#39;Most Likely Event&#39; and &#39;Most Likely Event Probability&#39; to be added to the output for comparison
        /// </summary>
        /// <value>Turn this on to leave intermediate tables in place for the purposes of debugging a model                          For &#39;fuzzy mode&#39; predictons this will also cause some extra columns for &#39;Most Likely Event&#39; and &#39;Most Likely Event Probability&#39; to be added to the output for comparison</value>
        [DataMember(Name = "IsDataDebugRequired", EmitDefaultValue = true)]
        public bool IsDataDebugRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SequencePredictorPredictionOptions {\n");
            sb.Append("  PredictionName: ").Append(PredictionName).Append("\n");
            sb.Append("  PredictionSeedOutputOption: ").Append(PredictionSeedOutputOption).Append("\n");
            sb.Append("  PredictionSelectionMode: ").Append(PredictionSelectionMode).Append("\n");
            sb.Append("  NumberOfPredictions: ").Append(NumberOfPredictions).Append("\n");
            sb.Append("  IsDataDebugRequired: ").Append(IsDataDebugRequired).Append("\n");
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
