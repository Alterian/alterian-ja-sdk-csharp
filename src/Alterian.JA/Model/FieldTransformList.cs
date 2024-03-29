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
    /// FieldTransformList
    /// </summary>
    [DataContract(Name = "FieldTransformList")]
    public partial class FieldTransformList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTransformList" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="jSONTransforms">jSONTransforms.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="publishedVersions">publishedVersions.</param>
        public FieldTransformList(string name = default(string), int id = default(int), int varVersion = default(int), string jSONTransforms = default(string), string metadata = default(string), List<ColumnPublishedTransform> publishedVersions = default(List<ColumnPublishedTransform>))
        {
            this.Name = name;
            this.Id = id;
            this.VarVersion = varVersion;
            this.JSONTransforms = jSONTransforms;
            this.Metadata = metadata;
            this.PublishedVersions = publishedVersions;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
        /// Gets or Sets JSONTransforms
        /// </summary>
        [DataMember(Name = "JSONTransforms", EmitDefaultValue = false)]
        public string JSONTransforms { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "Metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets PublishedVersions
        /// </summary>
        [DataMember(Name = "PublishedVersions", EmitDefaultValue = false)]
        public List<ColumnPublishedTransform> PublishedVersions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldTransformList {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  JSONTransforms: ").Append(JSONTransforms).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PublishedVersions: ").Append(PublishedVersions).Append("\n");
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
