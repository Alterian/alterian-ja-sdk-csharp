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
    /// QueryEventStreamResult
    /// </summary>
    [DataContract(Name = "QueryEventStreamResult")]
    public partial class QueryEventStreamResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEventStreamResult" /> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="secondaryEvents">secondaryEvents.</param>
        /// <param name="transitions">transitions.</param>
        /// <param name="transforms">Indicates the transforms that were used in the Sankey.</param>
        public QueryEventStreamResult(List<string> events = default(List<string>), List<string> secondaryEvents = default(List<string>), List<EventStreamTransition> transitions = default(List<EventStreamTransition>), List<ColumnPublishedTransformSummary> transforms = default(List<ColumnPublishedTransformSummary>))
        {
            this.Events = events;
            this.SecondaryEvents = secondaryEvents;
            this.Transitions = transitions;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "Events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryEvents
        /// </summary>
        [DataMember(Name = "SecondaryEvents", EmitDefaultValue = false)]
        public List<string> SecondaryEvents { get; set; }

        /// <summary>
        /// Gets or Sets Transitions
        /// </summary>
        [DataMember(Name = "Transitions", EmitDefaultValue = false)]
        public List<EventStreamTransition> Transitions { get; set; }

        /// <summary>
        /// Indicates the transforms that were used in the Sankey
        /// </summary>
        /// <value>Indicates the transforms that were used in the Sankey</value>
        [DataMember(Name = "Transforms", EmitDefaultValue = false)]
        public List<ColumnPublishedTransformSummary> Transforms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryEventStreamResult {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  SecondaryEvents: ").Append(SecondaryEvents).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
            sb.Append("  Transforms: ").Append(Transforms).Append("\n");
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
