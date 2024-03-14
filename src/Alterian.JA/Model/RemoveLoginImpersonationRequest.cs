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
    /// RemoveLoginImpersonationRequest
    /// </summary>
    [DataContract(Name = "RemoveLoginImpersonation_request")]
    public partial class RemoveLoginImpersonationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveLoginImpersonationRequest" /> class.
        /// </summary>
        /// <param name="loginId">The login to remove impersonation from.</param>
        public RemoveLoginImpersonationRequest(Guid loginId = default(Guid))
        {
            this.LoginId = loginId;
        }

        /// <summary>
        /// The login to remove impersonation from
        /// </summary>
        /// <value>The login to remove impersonation from</value>
        [DataMember(Name = "LoginId", EmitDefaultValue = false)]
        public Guid LoginId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemoveLoginImpersonationRequest {\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
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
