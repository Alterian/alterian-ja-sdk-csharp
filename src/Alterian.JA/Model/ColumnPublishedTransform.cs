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
    /// ColumnPublishedTransform
    /// </summary>
    [DataContract(Name = "ColumnPublishedTransform")]
    public partial class ColumnPublishedTransform : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnPublishedTransform" /> class.
        /// </summary>
        /// <param name="id">Id of the column to which the transform has been published.</param>
        /// <param name="eventStreamName">Name of the event stream (client-target-queuename) to which the column belongs.</param>
        /// <param name="name">Name of the column to which the transform has been published.</param>
        /// <param name="isSystem">Flag indicating whether the column represents a system column or a custom column (e.g. a customer attribute).</param>
        /// <param name="varVersion">Version of the transform that was published against the column.</param>
        /// <param name="alias">Alias associated with the transform when it was published.</param>
        public ColumnPublishedTransform(int id = default(int), string eventStreamName = default(string), string name = default(string), bool isSystem = default(bool), int varVersion = default(int), string alias = default(string))
        {
            this.Id = id;
            this.EventStreamName = eventStreamName;
            this.Name = name;
            this.IsSystem = isSystem;
            this.VarVersion = varVersion;
            this.Alias = alias;
        }

        /// <summary>
        /// Id of the column to which the transform has been published
        /// </summary>
        /// <value>Id of the column to which the transform has been published</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Name of the event stream (client-target-queuename) to which the column belongs
        /// </summary>
        /// <value>Name of the event stream (client-target-queuename) to which the column belongs</value>
        [DataMember(Name = "EventStreamName", EmitDefaultValue = false)]
        public string EventStreamName { get; set; }

        /// <summary>
        /// Name of the column to which the transform has been published
        /// </summary>
        /// <value>Name of the column to which the transform has been published</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Flag indicating whether the column represents a system column or a custom column (e.g. a customer attribute)
        /// </summary>
        /// <value>Flag indicating whether the column represents a system column or a custom column (e.g. a customer attribute)</value>
        [DataMember(Name = "IsSystem", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Version of the transform that was published against the column
        /// </summary>
        /// <value>Version of the transform that was published against the column</value>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Alias associated with the transform when it was published
        /// </summary>
        /// <value>Alias associated with the transform when it was published</value>
        [DataMember(Name = "Alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ColumnPublishedTransform {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventStreamName: ").Append(EventStreamName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
