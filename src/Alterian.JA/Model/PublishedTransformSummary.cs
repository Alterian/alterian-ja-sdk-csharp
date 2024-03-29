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
    /// PublishedTransformSummary
    /// </summary>
    [DataContract(Name = "PublishedTransformSummary")]
    public partial class PublishedTransformSummary : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransformType
        /// </summary>
        [DataMember(Name = "TransformType", EmitDefaultValue = false)]
        public TransformType? TransformType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedTransformSummary" /> class.
        /// </summary>
        /// <param name="alias">Alias that applies when the transform is applied to a column.</param>
        /// <param name="name">name.</param>
        /// <param name="transformName">transformName.</param>
        /// <param name="transformType">transformType.</param>
        /// <param name="id">Id of the Transform.</param>
        /// <param name="transformId">transformId.</param>
        /// <param name="varVersion">Version of the Transform.</param>
        public PublishedTransformSummary(string alias = default(string), string name = default(string), string transformName = default(string), TransformType? transformType = default(TransformType?), int id = default(int), int transformId = default(int), int varVersion = default(int))
        {
            this.Alias = alias;
            this.Name = name;
            this.TransformName = transformName;
            this.TransformType = transformType;
            this.Id = id;
            this.TransformId = transformId;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Alias that applies when the transform is applied to a column
        /// </summary>
        /// <value>Alias that applies when the transform is applied to a column</value>
        [DataMember(Name = "Alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TransformName
        /// </summary>
        [DataMember(Name = "TransformName", EmitDefaultValue = false)]
        public string TransformName { get; set; }

        /// <summary>
        /// Id of the Transform
        /// </summary>
        /// <value>Id of the Transform</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets TransformId
        /// </summary>
        [DataMember(Name = "TransformId", EmitDefaultValue = false)]
        public int TransformId { get; set; }

        /// <summary>
        /// Version of the Transform
        /// </summary>
        /// <value>Version of the Transform</value>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishedTransformSummary {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TransformName: ").Append(TransformName).Append("\n");
            sb.Append("  TransformType: ").Append(TransformType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransformId: ").Append(TransformId).Append("\n");
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
