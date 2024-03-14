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
    /// DMField
    /// </summary>
    [DataContract(Name = "DMField")]
    public partial class DMField : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "FieldType", EmitDefaultValue = false)]
        public DMFieldType? FieldType { get; set; }

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "StorageType", EmitDefaultValue = false)]
        public DMFieldStorageType? StorageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DMField" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="fieldType">fieldType.</param>
        /// <param name="iD">iD.</param>
        /// <param name="isSeed">isSeed.</param>
        /// <param name="listField">listField.</param>
        /// <param name="modified">modified.</param>
        /// <param name="name">name.</param>
        /// <param name="primaryKey">primaryKey.</param>
        /// <param name="sourceColumn">sourceColumn.</param>
        /// <param name="storageType">storageType.</param>
        /// <param name="userAccess">userAccess.</param>
        /// <param name="userOptOut">userOptOut.</param>
        public DMField(DateTime created = default(DateTime), DMFieldType? fieldType = default(DMFieldType?), int iD = default(int), bool isSeed = default(bool), bool listField = default(bool), DateTime modified = default(DateTime), string name = default(string), bool primaryKey = default(bool), string sourceColumn = default(string), DMFieldStorageType? storageType = default(DMFieldStorageType?), bool userAccess = default(bool), bool userOptOut = default(bool))
        {
            this.Created = created;
            this.FieldType = fieldType;
            this.ID = iD;
            this.IsSeed = isSeed;
            this.ListField = listField;
            this.Modified = modified;
            this.Name = name;
            this.PrimaryKey = primaryKey;
            this.SourceColumn = sourceColumn;
            this.StorageType = storageType;
            this.UserAccess = userAccess;
            this.UserOptOut = userOptOut;
        }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "Created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or Sets IsSeed
        /// </summary>
        [DataMember(Name = "IsSeed", EmitDefaultValue = true)]
        public bool IsSeed { get; set; }

        /// <summary>
        /// Gets or Sets ListField
        /// </summary>
        [DataMember(Name = "ListField", EmitDefaultValue = true)]
        public bool ListField { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "Modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryKey
        /// </summary>
        [DataMember(Name = "PrimaryKey", EmitDefaultValue = true)]
        public bool PrimaryKey { get; set; }

        /// <summary>
        /// Gets or Sets SourceColumn
        /// </summary>
        [DataMember(Name = "SourceColumn", EmitDefaultValue = false)]
        public string SourceColumn { get; set; }

        /// <summary>
        /// Gets or Sets UserAccess
        /// </summary>
        [DataMember(Name = "UserAccess", EmitDefaultValue = true)]
        public bool UserAccess { get; set; }

        /// <summary>
        /// Gets or Sets UserOptOut
        /// </summary>
        [DataMember(Name = "UserOptOut", EmitDefaultValue = true)]
        public bool UserOptOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DMField {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IsSeed: ").Append(IsSeed).Append("\n");
            sb.Append("  ListField: ").Append(ListField).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryKey: ").Append(PrimaryKey).Append("\n");
            sb.Append("  SourceColumn: ").Append(SourceColumn).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  UserAccess: ").Append(UserAccess).Append("\n");
            sb.Append("  UserOptOut: ").Append(UserOptOut).Append("\n");
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