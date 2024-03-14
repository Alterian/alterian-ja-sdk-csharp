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
    /// RequestCancelPatternTasksRequest
    /// </summary>
    [DataContract(Name = "RequestCancelPatternTasks_request")]
    public partial class RequestCancelPatternTasksRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCancelPatternTasksRequest" /> class.
        /// </summary>
        /// <param name="patternId">Pattern Id.</param>
        /// <param name="taskTypes">Task types to cancel (defaults to all).</param>
        public RequestCancelPatternTasksRequest(int patternId = default(int), List<PatternTaskType> taskTypes = default(List<PatternTaskType>))
        {
            this.PatternId = patternId;
            this.TaskTypes = taskTypes;
        }

        /// <summary>
        /// Pattern Id
        /// </summary>
        /// <value>Pattern Id</value>
        [DataMember(Name = "PatternId", EmitDefaultValue = false)]
        public int PatternId { get; set; }

        /// <summary>
        /// Task types to cancel (defaults to all)
        /// </summary>
        /// <value>Task types to cancel (defaults to all)</value>
        [DataMember(Name = "TaskTypes", EmitDefaultValue = false)]
        public List<PatternTaskType> TaskTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestCancelPatternTasksRequest {\n");
            sb.Append("  PatternId: ").Append(PatternId).Append("\n");
            sb.Append("  TaskTypes: ").Append(TaskTypes).Append("\n");
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