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
    /// EMGetInboundAddressesRequest
    /// </summary>
    [DataContract(Name = "EM_GetInboundAddresses_request")]
    public partial class EMGetInboundAddressesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMGetInboundAddressesRequest" /> class.
        /// </summary>
        /// <param name="eMMappingId">Mapping Id to use for EM connection.</param>
        public EMGetInboundAddressesRequest(int eMMappingId = default(int))
        {
            this.EMMappingId = eMMappingId;
        }

        /// <summary>
        /// Mapping Id to use for EM connection
        /// </summary>
        /// <value>Mapping Id to use for EM connection</value>
        [DataMember(Name = "EMMappingId", EmitDefaultValue = false)]
        public int EMMappingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EMGetInboundAddressesRequest {\n");
            sb.Append("  EMMappingId: ").Append(EMMappingId).Append("\n");
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
