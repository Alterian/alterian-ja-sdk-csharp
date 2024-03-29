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
    /// GetWebSpoonLoginUrlRequest
    /// </summary>
    [DataContract(Name = "GetWebSpoonLoginUrl_request")]
    public partial class GetWebSpoonLoginUrlRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebSpoonLoginUrlRequest" /> class.
        /// </summary>
        /// <param name="id">The Id of the Template Builder instance from @(ListWebSpoon) or @(CreateWebSpoon).</param>
        /// <param name="jOClient">The default JO client to assign.</param>
        /// <param name="jOToken">A valid JO token.</param>
        /// <param name="jOUser">The same user which was passed to @see(CreateWebSpoon).</param>
        public GetWebSpoonLoginUrlRequest(string id = default(string), string jOClient = default(string), Guid jOToken = default(Guid), string jOUser = default(string))
        {
            this.Id = id;
            this.JOClient = jOClient;
            this.JOToken = jOToken;
            this.JOUser = jOUser;
        }

        /// <summary>
        /// The Id of the Template Builder instance from @(ListWebSpoon) or @(CreateWebSpoon)
        /// </summary>
        /// <value>The Id of the Template Builder instance from @(ListWebSpoon) or @(CreateWebSpoon)</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The default JO client to assign
        /// </summary>
        /// <value>The default JO client to assign</value>
        [DataMember(Name = "JOClient", EmitDefaultValue = false)]
        public string JOClient { get; set; }

        /// <summary>
        /// A valid JO token
        /// </summary>
        /// <value>A valid JO token</value>
        [DataMember(Name = "JOToken", EmitDefaultValue = false)]
        public Guid JOToken { get; set; }

        /// <summary>
        /// The same user which was passed to @see(CreateWebSpoon)
        /// </summary>
        /// <value>The same user which was passed to @see(CreateWebSpoon)</value>
        [DataMember(Name = "JOUser", EmitDefaultValue = false)]
        public string JOUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWebSpoonLoginUrlRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JOClient: ").Append(JOClient).Append("\n");
            sb.Append("  JOToken: ").Append(JOToken).Append("\n");
            sb.Append("  JOUser: ").Append(JOUser).Append("\n");
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
