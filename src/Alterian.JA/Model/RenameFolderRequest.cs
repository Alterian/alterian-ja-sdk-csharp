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
    /// RenameFolderRequest
    /// </summary>
    [DataContract(Name = "RenameFolder_request")]
    public partial class RenameFolderRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameFolderRequest" /> class.
        /// </summary>
        /// <param name="folderID">ID of the folder to rename.</param>
        /// <param name="newName">New name for the folder.</param>
        public RenameFolderRequest(int folderID = default(int), string newName = default(string))
        {
            this.FolderID = folderID;
            this.NewName = newName;
        }

        /// <summary>
        /// ID of the folder to rename
        /// </summary>
        /// <value>ID of the folder to rename</value>
        [DataMember(Name = "FolderID", EmitDefaultValue = false)]
        public int FolderID { get; set; }

        /// <summary>
        /// New name for the folder
        /// </summary>
        /// <value>New name for the folder</value>
        [DataMember(Name = "NewName", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenameFolderRequest {\n");
            sb.Append("  FolderID: ").Append(FolderID).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
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
