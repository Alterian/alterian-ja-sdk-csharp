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
    /// DDE Rule
    /// </summary>
    [DataContract(Name = "Rule")]
    public partial class Rule : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="name">Name of the DDE Rule.</param>
        /// <param name="target">Target of the DDE Rule.</param>
        /// <param name="varClient">Client of the DDE Rule.</param>
        /// <param name="conversion">A conversion rule can be associated with many intiaitives.</param>
        public Rule(string name = default(string), string target = default(string), string varClient = default(string), bool conversion = default(bool))
        {
            this.Name = name;
            this.Target = target;
            this.VarClient = varClient;
            this.Conversion = conversion;
        }

        /// <summary>
        /// Name of the DDE Rule
        /// </summary>
        /// <value>Name of the DDE Rule</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Target of the DDE Rule
        /// </summary>
        /// <value>Target of the DDE Rule</value>
        [DataMember(Name = "Target", EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// Client of the DDE Rule
        /// </summary>
        /// <value>Client of the DDE Rule</value>
        [DataMember(Name = "Client", EmitDefaultValue = false)]
        public string VarClient { get; set; }

        /// <summary>
        /// A conversion rule can be associated with many intiaitives
        /// </summary>
        /// <value>A conversion rule can be associated with many intiaitives</value>
        [DataMember(Name = "Conversion", EmitDefaultValue = true)]
        public bool Conversion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  Conversion: ").Append(Conversion).Append("\n");
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
