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
    /// The information of a security entity [either an @see(ALUser) or @see(ALUserGroup)] which has some form of permission applied to it.
    /// </summary>
    [DataContract(Name = "PermissionUserGroup")]
    public partial class PermissionUserGroup : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "Source", EmitDefaultValue = false)]
        public UserGroupSource? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionUserGroup" /> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="iD">ID for this item.</param>
        /// <param name="isGroup">Does this item represent a group?  If false, it represents a user.</param>
        /// <param name="name">Name of the user/group.</param>
        /// <param name="emailAddress">Email Address for a user.</param>
        /// <param name="culture">Culture for a user.</param>
        public PermissionUserGroup(UserGroupSource? source = default(UserGroupSource?), int iD = default(int), bool isGroup = default(bool), string name = default(string), string emailAddress = default(string), string culture = default(string))
        {
            this.Source = source;
            this.ID = iD;
            this.IsGroup = isGroup;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.Culture = culture;
        }

        /// <summary>
        /// ID for this item
        /// </summary>
        /// <value>ID for this item</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Does this item represent a group?  If false, it represents a user
        /// </summary>
        /// <value>Does this item represent a group?  If false, it represents a user</value>
        [DataMember(Name = "IsGroup", EmitDefaultValue = true)]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Name of the user/group
        /// </summary>
        /// <value>Name of the user/group</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Email Address for a user
        /// </summary>
        /// <value>Email Address for a user</value>
        [DataMember(Name = "EmailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Culture for a user
        /// </summary>
        /// <value>Culture for a user</value>
        [DataMember(Name = "Culture", EmitDefaultValue = false)]
        public string Culture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermissionUserGroup {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
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
