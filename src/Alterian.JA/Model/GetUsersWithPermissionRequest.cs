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
    /// GetUsersWithPermissionRequest
    /// </summary>
    [DataContract(Name = "GetUsersWithPermission_request")]
    public partial class GetUsersWithPermissionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersWithPermissionRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="groupID">Optionally restrict the check to users that are members of the specified group (either directly or by inclusion in a member group - see IsMemberGroupRecursionAllowed).</param>
        /// <param name="isMemberGroupRecursionAllowed">Where restricting the check to users that are members of the specified group set to false to require direct membership or true to allow inclusion in one of its member groups.</param>
        /// <param name="permissionID">ID of the permission to check.</param>
        public GetUsersWithPermissionRequest(APICursor cursor = default(APICursor), int? groupID = default(int?), bool? isMemberGroupRecursionAllowed = default(bool?), int permissionID = default(int))
        {
            this.Cursor = cursor;
            this.GroupID = groupID;
            this.IsMemberGroupRecursionAllowed = isMemberGroupRecursionAllowed;
            this.PermissionID = permissionID;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Optionally restrict the check to users that are members of the specified group (either directly or by inclusion in a member group - see IsMemberGroupRecursionAllowed)
        /// </summary>
        /// <value>Optionally restrict the check to users that are members of the specified group (either directly or by inclusion in a member group - see IsMemberGroupRecursionAllowed)</value>
        [DataMember(Name = "GroupID", EmitDefaultValue = true)]
        public int? GroupID { get; set; }

        /// <summary>
        /// Where restricting the check to users that are members of the specified group set to false to require direct membership or true to allow inclusion in one of its member groups
        /// </summary>
        /// <value>Where restricting the check to users that are members of the specified group set to false to require direct membership or true to allow inclusion in one of its member groups</value>
        [DataMember(Name = "IsMemberGroupRecursionAllowed", EmitDefaultValue = true)]
        public bool? IsMemberGroupRecursionAllowed { get; set; }

        /// <summary>
        /// ID of the permission to check
        /// </summary>
        /// <value>ID of the permission to check</value>
        [DataMember(Name = "PermissionID", EmitDefaultValue = false)]
        public int PermissionID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUsersWithPermissionRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  GroupID: ").Append(GroupID).Append("\n");
            sb.Append("  IsMemberGroupRecursionAllowed: ").Append(IsMemberGroupRecursionAllowed).Append("\n");
            sb.Append("  PermissionID: ").Append(PermissionID).Append("\n");
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
