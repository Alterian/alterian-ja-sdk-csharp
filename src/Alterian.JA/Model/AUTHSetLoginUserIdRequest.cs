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
    /// AUTHSetLoginUserIdRequest
    /// </summary>
    [DataContract(Name = "AUTH_SetLoginUserId_request")]
    public partial class AUTHSetLoginUserIdRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AUTHSetLoginUserIdRequest" /> class.
        /// </summary>
        /// <param name="loginId">Id of the login.</param>
        /// <param name="siteId">Id of the CM Site (typically 1).</param>
        /// <param name="userId">User Id to associate with the login.  Pass NULL to disassociate the login with a user..</param>
        public AUTHSetLoginUserIdRequest(Guid loginId = default(Guid), int siteId = default(int), int? userId = default(int?))
        {
            this.LoginId = loginId;
            this.SiteId = siteId;
            this.UserId = userId;
        }

        /// <summary>
        /// Id of the login
        /// </summary>
        /// <value>Id of the login</value>
        [DataMember(Name = "LoginId", EmitDefaultValue = false)]
        public Guid LoginId { get; set; }

        /// <summary>
        /// Id of the CM Site (typically 1)
        /// </summary>
        /// <value>Id of the CM Site (typically 1)</value>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// User Id to associate with the login.  Pass NULL to disassociate the login with a user.
        /// </summary>
        /// <value>User Id to associate with the login.  Pass NULL to disassociate the login with a user.</value>
        [DataMember(Name = "UserId", EmitDefaultValue = true)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AUTHSetLoginUserIdRequest {\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
