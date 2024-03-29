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
    /// AUTHCreateLoginRequest
    /// </summary>
    [DataContract(Name = "AUTH_CreateLogin_request")]
    public partial class AUTHCreateLoginRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AUTHCreateLoginRequest" /> class.
        /// </summary>
        /// <param name="login">Login to create.</param>
        /// <param name="sHA1Password">Password of the new login.  Pass null for external authentication.</param>
        /// <param name="siteId">Id of the CM Site (typically 1).</param>
        /// <param name="userId">Optional userid to which this login is going to be associated..</param>
        public AUTHCreateLoginRequest(string login = default(string), string sHA1Password = default(string), int siteId = default(int), int? userId = default(int?))
        {
            this.Login = login;
            this.SHA1Password = sHA1Password;
            this.SiteId = siteId;
            this.UserId = userId;
        }

        /// <summary>
        /// Login to create
        /// </summary>
        /// <value>Login to create</value>
        [DataMember(Name = "Login", EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// Password of the new login.  Pass null for external authentication
        /// </summary>
        /// <value>Password of the new login.  Pass null for external authentication</value>
        [DataMember(Name = "SHA1Password", EmitDefaultValue = false)]
        public string SHA1Password { get; set; }

        /// <summary>
        /// Id of the CM Site (typically 1)
        /// </summary>
        /// <value>Id of the CM Site (typically 1)</value>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// Optional userid to which this login is going to be associated.
        /// </summary>
        /// <value>Optional userid to which this login is going to be associated.</value>
        [DataMember(Name = "UserId", EmitDefaultValue = true)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AUTHCreateLoginRequest {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  SHA1Password: ").Append(SHA1Password).Append("\n");
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
