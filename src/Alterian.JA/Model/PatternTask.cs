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
    /// PatternTask
    /// </summary>
    [DataContract(Name = "PatternTask")]
    public partial class PatternTask : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TaskType
        /// </summary>
        [DataMember(Name = "TaskType", EmitDefaultValue = false)]
        public PatternTaskType? TaskType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public PatternTaskState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternTask" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="created">created.</param>
        /// <param name="started">started.</param>
        /// <param name="finished">finished.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="state">state.</param>
        /// <param name="logText">logText.</param>
        /// <param name="patternId">patternId.</param>
        public PatternTask(int id = default(int), DateTime created = default(DateTime), DateTime? started = default(DateTime?), DateTime? finished = default(DateTime?), PatternTaskType? taskType = default(PatternTaskType?), PatternTaskState? state = default(PatternTaskState?), string logText = default(string), int patternId = default(int))
        {
            this.Id = id;
            this.Created = created;
            this.Started = started;
            this.Finished = finished;
            this.TaskType = taskType;
            this.State = state;
            this.LogText = logText;
            this.PatternId = patternId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "Created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "Started", EmitDefaultValue = true)]
        public DateTime? Started { get; set; }

        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name = "Finished", EmitDefaultValue = true)]
        public DateTime? Finished { get; set; }

        /// <summary>
        /// Gets or Sets LogText
        /// </summary>
        [DataMember(Name = "LogText", EmitDefaultValue = false)]
        public string LogText { get; set; }

        /// <summary>
        /// Gets or Sets PatternId
        /// </summary>
        [DataMember(Name = "PatternId", EmitDefaultValue = false)]
        public int PatternId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatternTask {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LogText: ").Append(LogText).Append("\n");
            sb.Append("  PatternId: ").Append(PatternId).Append("\n");
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
