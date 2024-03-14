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
    /// UpdateSystemSettingRequest
    /// </summary>
    [DataContract(Name = "UpdateSystemSetting_request")]
    public partial class UpdateSystemSettingRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSystemSettingRequest" /> class.
        /// </summary>
        /// <param name="key">Setting to update e.g. \&quot;SMTPHost\&quot;.</param>
        /// <param name="value">New value e.g.\&quot;mysmtpserver.com\&quot;.</param>
        public UpdateSystemSettingRequest(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Setting to update e.g. \&quot;SMTPHost\&quot;
        /// </summary>
        /// <value>Setting to update e.g. \&quot;SMTPHost\&quot;</value>
        [DataMember(Name = "Key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// New value e.g.\&quot;mysmtpserver.com\&quot;
        /// </summary>
        /// <value>New value e.g.\&quot;mysmtpserver.com\&quot;</value>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSystemSettingRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
