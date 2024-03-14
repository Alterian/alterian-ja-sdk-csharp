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
    /// GetUserRequest
    /// </summary>
    [DataContract(Name = "GetUser_request")]
    public partial class GetUserRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserRequest" /> class.
        /// </summary>
        /// <param name="includeGroups">Include group membership.</param>
        /// <param name="includePermissions">Include user level permissions.</param>
        /// <param name="includeSettings">Include user settings.</param>
        /// <param name="includeTools">Include tools to which the user has access.</param>
        /// <param name="userID">ID of the @see(ALUser) to read.</param>
        public GetUserRequest(bool includeGroups = default(bool), bool includePermissions = default(bool), bool includeSettings = default(bool), bool includeTools = default(bool), int userID = default(int))
        {
            this.IncludeGroups = includeGroups;
            this.IncludePermissions = includePermissions;
            this.IncludeSettings = includeSettings;
            this.IncludeTools = includeTools;
            this.UserID = userID;
        }

        /// <summary>
        /// Include group membership
        /// </summary>
        /// <value>Include group membership</value>
        [DataMember(Name = "IncludeGroups", EmitDefaultValue = true)]
        public bool IncludeGroups { get; set; }

        /// <summary>
        /// Include user level permissions
        /// </summary>
        /// <value>Include user level permissions</value>
        [DataMember(Name = "IncludePermissions", EmitDefaultValue = true)]
        public bool IncludePermissions { get; set; }

        /// <summary>
        /// Include user settings
        /// </summary>
        /// <value>Include user settings</value>
        [DataMember(Name = "IncludeSettings", EmitDefaultValue = true)]
        public bool IncludeSettings { get; set; }

        /// <summary>
        /// Include tools to which the user has access
        /// </summary>
        /// <value>Include tools to which the user has access</value>
        [DataMember(Name = "IncludeTools", EmitDefaultValue = true)]
        public bool IncludeTools { get; set; }

        /// <summary>
        /// ID of the @see(ALUser) to read
        /// </summary>
        /// <value>ID of the @see(ALUser) to read</value>
        [DataMember(Name = "UserID", EmitDefaultValue = false)]
        public int UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUserRequest {\n");
            sb.Append("  IncludeGroups: ").Append(IncludeGroups).Append("\n");
            sb.Append("  IncludePermissions: ").Append(IncludePermissions).Append("\n");
            sb.Append("  IncludeSettings: ").Append(IncludeSettings).Append("\n");
            sb.Append("  IncludeTools: ").Append(IncludeTools).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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