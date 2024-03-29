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
    /// IDatasourceObject
    /// </summary>
    [DataContract(Name = "IDatasourceObject")]
    public partial class IDatasourceObject : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IDatasourceObject" /> class.
        /// </summary>
        /// <param name="iD">Unique ID of the datasource.</param>
        /// <param name="name">Name of the datasource [must be unique].</param>
        /// <param name="nameEx">NameEX.</param>
        /// <param name="enabled">Whether or not this datasource is enabled.</param>
        /// <param name="visible">Whether or not this datasource is visible.</param>
        /// <param name="accessView">Can the user view this datasource.</param>
        /// <param name="accessModify">Not currently used.</param>
        /// <param name="attributes">Attributes for this datasource.  @see(DatasourceAttribute).</param>
        /// <param name="fullNativeName">The entire native name of this item - - usually includes database and table.</param>
        public IDatasourceObject(int iD = default(int), string name = default(string), string nameEx = default(string), bool enabled = default(bool), bool visible = default(bool), bool accessView = default(bool), bool accessModify = default(bool), List<DatasourceAttribute> attributes = default(List<DatasourceAttribute>), string fullNativeName = default(string))
        {
            this.ID = iD;
            this.Name = name;
            this.NameEx = nameEx;
            this.Enabled = enabled;
            this.Visible = visible;
            this.AccessView = accessView;
            this.AccessModify = accessModify;
            this.Attributes = attributes;
            this.FullNativeName = fullNativeName;
        }

        /// <summary>
        /// Unique ID of the datasource
        /// </summary>
        /// <value>Unique ID of the datasource</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Name of the datasource [must be unique]
        /// </summary>
        /// <value>Name of the datasource [must be unique]</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// NameEX
        /// </summary>
        /// <value>NameEX</value>
        [DataMember(Name = "NameEx", EmitDefaultValue = false)]
        public string NameEx { get; set; }

        /// <summary>
        /// Whether or not this datasource is enabled
        /// </summary>
        /// <value>Whether or not this datasource is enabled</value>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether or not this datasource is visible
        /// </summary>
        /// <value>Whether or not this datasource is visible</value>
        [DataMember(Name = "Visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// Can the user view this datasource
        /// </summary>
        /// <value>Can the user view this datasource</value>
        [DataMember(Name = "AccessView", EmitDefaultValue = true)]
        public bool AccessView { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        /// <value>Not currently used</value>
        [DataMember(Name = "AccessModify", EmitDefaultValue = true)]
        public bool AccessModify { get; set; }

        /// <summary>
        /// Attributes for this datasource.  @see(DatasourceAttribute)
        /// </summary>
        /// <value>Attributes for this datasource.  @see(DatasourceAttribute)</value>
        [DataMember(Name = "Attributes", EmitDefaultValue = false)]
        public List<DatasourceAttribute> Attributes { get; set; }

        /// <summary>
        /// The entire native name of this item - - usually includes database and table
        /// </summary>
        /// <value>The entire native name of this item - - usually includes database and table</value>
        [DataMember(Name = "FullNativeName", EmitDefaultValue = false)]
        public string FullNativeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IDatasourceObject {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameEx: ").Append(NameEx).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  AccessView: ").Append(AccessView).Append("\n");
            sb.Append("  AccessModify: ").Append(AccessModify).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  FullNativeName: ").Append(FullNativeName).Append("\n");
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
