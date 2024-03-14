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
    /// A user is a unique profile of permissions and linked to a set of user login credentials. When a user logs in using those credentials, the permissions in the user profile are applied.
    /// </summary>
    [DataContract(Name = "ALUserGroup")]
    public partial class ALUserGroup : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ALUserGroup" /> class.
        /// </summary>
        /// <param name="iD">iD.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="folderID">folderID.</param>
        /// <param name="members">A list that can contain the groups or users that are immediate children of this group. I contain them..</param>
        /// <param name="groups">The groups that are immediate parents of this group. They contain me..</param>
        /// <param name="folderName">folderName.</param>
        public ALUserGroup(int iD = default(int), string name = default(string), string description = default(string), bool enabled = default(bool), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), int folderID = default(int), List<Object> members = default(List<Object>), List<ALUserGroup> groups = default(List<ALUserGroup>), string folderName = default(string))
        {
            this.ID = iD;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Created = created;
            this.Modified = modified;
            this.FolderID = folderID;
            this.Members = members;
            this.Groups = groups;
            this.FolderName = folderName;
        }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "Created", EmitDefaultValue = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "Modified", EmitDefaultValue = true)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or Sets FolderID
        /// </summary>
        [DataMember(Name = "FolderID", EmitDefaultValue = false)]
        public int FolderID { get; set; }

        /// <summary>
        /// A list that can contain the groups or users that are immediate children of this group. I contain them.
        /// </summary>
        /// <value>A list that can contain the groups or users that are immediate children of this group. I contain them.</value>
        [DataMember(Name = "Members", EmitDefaultValue = false)]
        public List<Object> Members { get; set; }

        /// <summary>
        /// The groups that are immediate parents of this group. They contain me.
        /// </summary>
        /// <value>The groups that are immediate parents of this group. They contain me.</value>
        [DataMember(Name = "Groups", EmitDefaultValue = false)]
        public List<ALUserGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets FolderName
        /// </summary>
        [DataMember(Name = "FolderName", EmitDefaultValue = false)]
        public string FolderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ALUserGroup {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  FolderID: ").Append(FolderID).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
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
