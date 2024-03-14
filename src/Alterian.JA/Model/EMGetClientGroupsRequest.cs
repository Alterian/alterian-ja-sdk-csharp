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
    /// EMGetClientGroupsRequest
    /// </summary>
    [DataContract(Name = "EM_GetClientGroups_request")]
    public partial class EMGetClientGroupsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMGetClientGroupsRequest" /> class.
        /// </summary>
        /// <param name="clientId">EM Client ID obtained from @see(EM_GetClientSets).</param>
        /// <param name="eMSiteId">EM Site ID obtained from @see(GetEMMappings) or @see(GetEMMapping).</param>
        /// <param name="eMToken">A valid EM token obtained via @see(EM_Authenticate).  Token MUST be an SA token..</param>
        public EMGetClientGroupsRequest(int clientId = default(int), int eMSiteId = default(int), string eMToken = default(string))
        {
            this.ClientId = clientId;
            this.EMSiteId = eMSiteId;
            this.EMToken = eMToken;
        }

        /// <summary>
        /// EM Client ID obtained from @see(EM_GetClientSets)
        /// </summary>
        /// <value>EM Client ID obtained from @see(EM_GetClientSets)</value>
        [DataMember(Name = "ClientId", EmitDefaultValue = false)]
        public int ClientId { get; set; }

        /// <summary>
        /// EM Site ID obtained from @see(GetEMMappings) or @see(GetEMMapping)
        /// </summary>
        /// <value>EM Site ID obtained from @see(GetEMMappings) or @see(GetEMMapping)</value>
        [DataMember(Name = "EMSiteId", EmitDefaultValue = false)]
        public int EMSiteId { get; set; }

        /// <summary>
        /// A valid EM token obtained via @see(EM_Authenticate).  Token MUST be an SA token.
        /// </summary>
        /// <value>A valid EM token obtained via @see(EM_Authenticate).  Token MUST be an SA token.</value>
        [DataMember(Name = "EMToken", EmitDefaultValue = false)]
        public string EMToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EMGetClientGroupsRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  EMSiteId: ").Append(EMSiteId).Append("\n");
            sb.Append("  EMToken: ").Append(EMToken).Append("\n");
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
