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
    /// Definition of a business goal
    /// </summary>
    [DataContract(Name = "BusinessGoal")]
    public partial class BusinessGoal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessGoal" /> class.
        /// </summary>
        /// <param name="iD">Goal ID.</param>
        /// <param name="name">Name of the business goal.</param>
        /// <param name="description">A longer description of what the objective of the goal is.</param>
        /// <param name="position">position.</param>
        /// <param name="kPI">kPI.</param>
        public BusinessGoal(int iD = default(int), string name = default(string), string description = default(string), int position = default(int), BusinessGoalKPI kPI = default(BusinessGoalKPI))
        {
            this.ID = iD;
            this.Name = name;
            this.Description = description;
            this.Position = position;
            this.KPI = kPI;
        }

        /// <summary>
        /// Goal ID
        /// </summary>
        /// <value>Goal ID</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Name of the business goal
        /// </summary>
        /// <value>Name of the business goal</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A longer description of what the objective of the goal is
        /// </summary>
        /// <value>A longer description of what the objective of the goal is</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "Position", EmitDefaultValue = false)]
        public int Position { get; set; }

        /// <summary>
        /// Gets or Sets KPI
        /// </summary>
        [DataMember(Name = "KPI", EmitDefaultValue = false)]
        public BusinessGoalKPI KPI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessGoal {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  KPI: ").Append(KPI).Append("\n");
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