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
    /// GetFoldersRequest
    /// </summary>
    [DataContract(Name = "GetFolders_request")]
    public partial class GetFoldersRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FolderType
        /// </summary>
        [DataMember(Name = "FolderType", EmitDefaultValue = false)]
        public FolderTypes? FolderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFoldersRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="folderType">folderType.</param>
        /// <param name="getChildFolders">Return back the children of the folders [recursively].</param>
        /// <param name="includeChildCount">If GetChildFolders is set to false then this option can be user to get a count of the immediate children of each returned folder..</param>
        /// <param name="includeHidden">Include hidden folders in your result.</param>
        /// <param name="parentFolder">Parent folder to start looking for folders.</param>
        public GetFoldersRequest(APICursor cursor = default(APICursor), FolderTypes? folderType = default(FolderTypes?), bool getChildFolders = default(bool), bool includeChildCount = default(bool), bool includeHidden = default(bool), int? parentFolder = default(int?))
        {
            this.Cursor = cursor;
            this.FolderType = folderType;
            this.GetChildFolders = getChildFolders;
            this.IncludeChildCount = includeChildCount;
            this.IncludeHidden = includeHidden;
            this.ParentFolder = parentFolder;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Return back the children of the folders [recursively]
        /// </summary>
        /// <value>Return back the children of the folders [recursively]</value>
        [DataMember(Name = "GetChildFolders", EmitDefaultValue = true)]
        public bool GetChildFolders { get; set; }

        /// <summary>
        /// If GetChildFolders is set to false then this option can be user to get a count of the immediate children of each returned folder.
        /// </summary>
        /// <value>If GetChildFolders is set to false then this option can be user to get a count of the immediate children of each returned folder.</value>
        [DataMember(Name = "IncludeChildCount", EmitDefaultValue = true)]
        public bool IncludeChildCount { get; set; }

        /// <summary>
        /// Include hidden folders in your result
        /// </summary>
        /// <value>Include hidden folders in your result</value>
        [DataMember(Name = "IncludeHidden", EmitDefaultValue = true)]
        public bool IncludeHidden { get; set; }

        /// <summary>
        /// Parent folder to start looking for folders
        /// </summary>
        /// <value>Parent folder to start looking for folders</value>
        [DataMember(Name = "ParentFolder", EmitDefaultValue = true)]
        public int? ParentFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetFoldersRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
            sb.Append("  GetChildFolders: ").Append(GetChildFolders).Append("\n");
            sb.Append("  IncludeChildCount: ").Append(IncludeChildCount).Append("\n");
            sb.Append("  IncludeHidden: ").Append(IncludeHidden).Append("\n");
            sb.Append("  ParentFolder: ").Append(ParentFolder).Append("\n");
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
