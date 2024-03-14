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
    /// A client represents a distinct set of users, documents and other data within a system.              Users and documents are unique within a client, and are isolated from other clients, so they cannot be shared between clients (except manually by export and import)             Note that multiple clients can use the same customer data by each creating a @see(ALDataSource) to the same customer database.             Each customer will typically have one client, but some large customers may have multiple clients             Each client has it&#39;s own SQLServer database to store information in.                The data is returned as a @see(ALClient) object
    /// </summary>
    [DataContract(Name = "ALClient")]
    public partial class ALClient : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ALClient" /> class.
        /// </summary>
        /// <param name="iD">The ID of the client..</param>
        /// <param name="name">The name of the client..</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="settings">settings.</param>
        /// <param name="packages">packages.</param>
        /// <param name="clientSetID">clientSetID.</param>
        /// <param name="siteId">siteId.</param>
        public ALClient(int iD = default(int), string name = default(string), bool enabled = default(bool), Dictionary<string, string> settings = default(Dictionary<string, string>), List<Package> packages = default(List<Package>), int clientSetID = default(int), Guid siteId = default(Guid))
        {
            this.ID = iD;
            this.Name = name;
            this.Enabled = enabled;
            this.Settings = settings;
            this.Packages = packages;
            this.ClientSetID = clientSetID;
            this.SiteId = siteId;
        }

        /// <summary>
        /// The ID of the client.
        /// </summary>
        /// <value>The ID of the client.</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// The name of the client.
        /// </summary>
        /// <value>The name of the client.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Gets or Sets Packages
        /// </summary>
        [DataMember(Name = "Packages", EmitDefaultValue = false)]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Gets or Sets ClientSetID
        /// </summary>
        [DataMember(Name = "ClientSetID", EmitDefaultValue = false)]
        public int ClientSetID { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ALClient {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
            sb.Append("  ClientSetID: ").Append(ClientSetID).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
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
