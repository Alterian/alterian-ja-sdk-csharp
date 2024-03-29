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
    /// DMVMTA
    /// </summary>
    [DataContract(Name = "DMVMTA")]
    public partial class DMVMTA : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMVMTA" /> class.
        /// </summary>
        /// <param name="iD">iD.</param>
        /// <param name="name">name.</param>
        /// <param name="iP">iP.</param>
        /// <param name="mTAServerID">mTAServerID.</param>
        public DMVMTA(int iD = default(int), string name = default(string), string iP = default(string), int mTAServerID = default(int))
        {
            this.ID = iD;
            this.Name = name;
            this.IP = iP;
            this.MTAServerID = mTAServerID;
        }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IP
        /// </summary>
        [DataMember(Name = "IP", EmitDefaultValue = false)]
        public string IP { get; set; }

        /// <summary>
        /// Gets or Sets MTAServerID
        /// </summary>
        [DataMember(Name = "MTAServerID", EmitDefaultValue = false)]
        public int MTAServerID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DMVMTA {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IP: ").Append(IP).Append("\n");
            sb.Append("  MTAServerID: ").Append(MTAServerID).Append("\n");
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
