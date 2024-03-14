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
    /// EventStreamColumnTransform
    /// </summary>
    [DataContract(Name = "EventStreamColumnTransform")]
    public partial class EventStreamColumnTransform : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransformType
        /// </summary>
        [DataMember(Name = "TransformType", EmitDefaultValue = false)]
        public TransformType? TransformType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventStreamColumnTransform" /> class.
        /// </summary>
        /// <param name="transformType">transformType.</param>
        /// <param name="columnName">This can be determined from the ColumnName property of EventStreamField.</param>
        /// <param name="alias">This will be the column name of the transformation result. If blank then the original column will be swapped out.</param>
        /// <param name="id">id.</param>
        /// <param name="varVersion">varVersion.</param>
        public EventStreamColumnTransform(TransformType? transformType = default(TransformType?), string columnName = default(string), string alias = default(string), int id = default(int), int varVersion = default(int))
        {
            this.TransformType = transformType;
            this.ColumnName = columnName;
            this.Alias = alias;
            this.Id = id;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// This can be determined from the ColumnName property of EventStreamField
        /// </summary>
        /// <value>This can be determined from the ColumnName property of EventStreamField</value>
        [DataMember(Name = "ColumnName", EmitDefaultValue = false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// This will be the column name of the transformation result. If blank then the original column will be swapped out
        /// </summary>
        /// <value>This will be the column name of the transformation result. If blank then the original column will be swapped out</value>
        [DataMember(Name = "Alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventStreamColumnTransform {\n");
            sb.Append("  TransformType: ").Append(TransformType).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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