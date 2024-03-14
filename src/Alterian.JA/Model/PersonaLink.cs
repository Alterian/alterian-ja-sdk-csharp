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
    /// Provides an easy way to represent a link from a persona to another object type.
    /// </summary>
    [DataContract(Name = "PersonaLink")]
    public partial class PersonaLink : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaLink" /> class.
        /// </summary>
        /// <param name="personaId">The Persona to which this is linked..</param>
        /// <param name="linkType">What type of object is this?.</param>
        /// <param name="id">The Id for the link; note, this might be an integer but we store it as a string as we might be storing other link types which are not integers.</param>
        public PersonaLink(int personaId = default(int), string linkType = default(string), string id = default(string))
        {
            this.PersonaId = personaId;
            this.LinkType = linkType;
            this.Id = id;
        }

        /// <summary>
        /// The Persona to which this is linked.
        /// </summary>
        /// <value>The Persona to which this is linked.</value>
        [DataMember(Name = "PersonaId", EmitDefaultValue = false)]
        public int PersonaId { get; set; }

        /// <summary>
        /// What type of object is this?
        /// </summary>
        /// <value>What type of object is this?</value>
        [DataMember(Name = "LinkType", EmitDefaultValue = false)]
        public string LinkType { get; set; }

        /// <summary>
        /// The Id for the link; note, this might be an integer but we store it as a string as we might be storing other link types which are not integers
        /// </summary>
        /// <value>The Id for the link; note, this might be an integer but we store it as a string as we might be storing other link types which are not integers</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonaLink {\n");
            sb.Append("  PersonaId: ").Append(PersonaId).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
