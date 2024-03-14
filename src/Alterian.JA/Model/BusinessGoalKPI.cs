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
    /// The KPI to measure the sucess of the goal
    /// </summary>
    [DataContract(Name = "BusinessGoalKPI")]
    public partial class BusinessGoalKPI : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Polarity
        /// </summary>
        [DataMember(Name = "Polarity", EmitDefaultValue = false)]
        public MetricPolarity? Polarity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessGoalKPI" /> class.
        /// </summary>
        /// <param name="metricID">The ID of the metric used to measure success for this goal.</param>
        /// <param name="polarity">polarity.</param>
        /// <param name="target">The target for the metric for this business goal.</param>
        /// <param name="duration">The number of days over which the metric should be evaluated.</param>
        public BusinessGoalKPI(int metricID = default(int), MetricPolarity? polarity = default(MetricPolarity?), double? target = default(double?), int duration = default(int))
        {
            this.MetricID = metricID;
            this.Polarity = polarity;
            this.Target = target;
            this.Duration = duration;
        }

        /// <summary>
        /// The ID of the metric used to measure success for this goal
        /// </summary>
        /// <value>The ID of the metric used to measure success for this goal</value>
        [DataMember(Name = "MetricID", EmitDefaultValue = false)]
        public int MetricID { get; set; }

        /// <summary>
        /// The target for the metric for this business goal
        /// </summary>
        /// <value>The target for the metric for this business goal</value>
        [DataMember(Name = "Target", EmitDefaultValue = true)]
        public double? Target { get; set; }

        /// <summary>
        /// The number of days over which the metric should be evaluated
        /// </summary>
        /// <value>The number of days over which the metric should be evaluated</value>
        [DataMember(Name = "Duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessGoalKPI {\n");
            sb.Append("  MetricID: ").Append(MetricID).Append("\n");
            sb.Append("  Polarity: ").Append(Polarity).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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