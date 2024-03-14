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
    /// EMPrimaryKeysRequest
    /// </summary>
    [DataContract(Name = "EM_PrimaryKeys_request")]
    public partial class EMPrimaryKeysRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "FieldType", EmitDefaultValue = false)]
        public DMFieldType? FieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EMPrimaryKeysRequest" /> class.
        /// </summary>
        /// <param name="clientId">EM Client Id obtained from @see(EM_GetClientSets).</param>
        /// <param name="eMMappingId">Mapping Id to use for auto-login mode.</param>
        /// <param name="eMSiteId">EM Site Id obtained from @see(GetEMMappings) or @see(GetEMMapping).</param>
        /// <param name="eMToken">A valid EM token obtained via @see(EM_Authenticate)..</param>
        /// <param name="fieldType">fieldType.</param>
        public EMPrimaryKeysRequest(int clientId = default(int), int? eMMappingId = default(int?), int eMSiteId = default(int), string eMToken = default(string), DMFieldType? fieldType = default(DMFieldType?))
        {
            this.ClientId = clientId;
            this.EMMappingId = eMMappingId;
            this.EMSiteId = eMSiteId;
            this.EMToken = eMToken;
            this.FieldType = fieldType;
        }

        /// <summary>
        /// EM Client Id obtained from @see(EM_GetClientSets)
        /// </summary>
        /// <value>EM Client Id obtained from @see(EM_GetClientSets)</value>
        [DataMember(Name = "ClientId", EmitDefaultValue = false)]
        public int ClientId { get; set; }

        /// <summary>
        /// Mapping Id to use for auto-login mode
        /// </summary>
        /// <value>Mapping Id to use for auto-login mode</value>
        [DataMember(Name = "EMMappingId", EmitDefaultValue = true)]
        public int? EMMappingId { get; set; }

        /// <summary>
        /// EM Site Id obtained from @see(GetEMMappings) or @see(GetEMMapping)
        /// </summary>
        /// <value>EM Site Id obtained from @see(GetEMMappings) or @see(GetEMMapping)</value>
        [DataMember(Name = "EMSiteId", EmitDefaultValue = false)]
        public int EMSiteId { get; set; }

        /// <summary>
        /// A valid EM token obtained via @see(EM_Authenticate).
        /// </summary>
        /// <value>A valid EM token obtained via @see(EM_Authenticate).</value>
        [DataMember(Name = "EMToken", EmitDefaultValue = false)]
        public string EMToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EMPrimaryKeysRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  EMMappingId: ").Append(EMMappingId).Append("\n");
            sb.Append("  EMSiteId: ").Append(EMSiteId).Append("\n");
            sb.Append("  EMToken: ").Append(EMToken).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
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
