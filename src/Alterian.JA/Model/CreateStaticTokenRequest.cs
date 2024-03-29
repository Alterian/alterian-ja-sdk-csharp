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
    /// CreateStaticTokenRequest
    /// </summary>
    [DataContract(Name = "CreateStaticToken_request")]
    public partial class CreateStaticTokenRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStaticTokenRequest" /> class.
        /// </summary>
        /// <param name="clientID">ClientID to which the new static token should be associated.  If you have an SA token, you must provide this parameter.  If you have a regular token, this parameter is ignored and the clientID of your token is used instead.</param>
        /// <param name="userID">UserID to which the new static token should be associated.</param>
        public CreateStaticTokenRequest(int? clientID = default(int?), int userID = default(int))
        {
            this.ClientID = clientID;
            this.UserID = userID;
        }

        /// <summary>
        /// ClientID to which the new static token should be associated.  If you have an SA token, you must provide this parameter.  If you have a regular token, this parameter is ignored and the clientID of your token is used instead
        /// </summary>
        /// <value>ClientID to which the new static token should be associated.  If you have an SA token, you must provide this parameter.  If you have a regular token, this parameter is ignored and the clientID of your token is used instead</value>
        [DataMember(Name = "ClientID", EmitDefaultValue = true)]
        public int? ClientID { get; set; }

        /// <summary>
        /// UserID to which the new static token should be associated
        /// </summary>
        /// <value>UserID to which the new static token should be associated</value>
        [DataMember(Name = "UserID", EmitDefaultValue = false)]
        public int UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateStaticTokenRequest {\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
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
