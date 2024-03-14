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
    /// CreateClientRequest
    /// </summary>
    [DataContract(Name = "CreateClient_request")]
    public partial class CreateClientRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientRequest" /> class.
        /// </summary>
        /// <param name="clientName">The name of the new client. Method will fail if this client name already exists within the specified @see(ALClientSet).</param>
        /// <param name="clientSetID">The identifier of the @see(ALClientSet) that this client will be created within. Method will fail if this clientset cannot be found.</param>
        /// <param name="databaseName">The name of the SQLServer database that this client will create. Method will fail if this database already exists on the specified database server ID.  May only be 50 characters long and must not start with a number nor have special characters.</param>
        /// <param name="databaseServerID">The identifier of the database server that the database will be created within. Method will fail if this database server cannot be found.</param>
        /// <param name="sourceClientID">sourceClientID.</param>
        public CreateClientRequest(string clientName = default(string), int clientSetID = default(int), string databaseName = default(string), int databaseServerID = default(int), int sourceClientID = default(int))
        {
            this.ClientName = clientName;
            this.ClientSetID = clientSetID;
            this.DatabaseName = databaseName;
            this.DatabaseServerID = databaseServerID;
            this.SourceClientID = sourceClientID;
        }

        /// <summary>
        /// The name of the new client. Method will fail if this client name already exists within the specified @see(ALClientSet)
        /// </summary>
        /// <value>The name of the new client. Method will fail if this client name already exists within the specified @see(ALClientSet)</value>
        [DataMember(Name = "ClientName", EmitDefaultValue = false)]
        public string ClientName { get; set; }

        /// <summary>
        /// The identifier of the @see(ALClientSet) that this client will be created within. Method will fail if this clientset cannot be found
        /// </summary>
        /// <value>The identifier of the @see(ALClientSet) that this client will be created within. Method will fail if this clientset cannot be found</value>
        [DataMember(Name = "ClientSetID", EmitDefaultValue = false)]
        public int ClientSetID { get; set; }

        /// <summary>
        /// The name of the SQLServer database that this client will create. Method will fail if this database already exists on the specified database server ID.  May only be 50 characters long and must not start with a number nor have special characters
        /// </summary>
        /// <value>The name of the SQLServer database that this client will create. Method will fail if this database already exists on the specified database server ID.  May only be 50 characters long and must not start with a number nor have special characters</value>
        [DataMember(Name = "DatabaseName", EmitDefaultValue = false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The identifier of the database server that the database will be created within. Method will fail if this database server cannot be found
        /// </summary>
        /// <value>The identifier of the database server that the database will be created within. Method will fail if this database server cannot be found</value>
        [DataMember(Name = "DatabaseServerID", EmitDefaultValue = false)]
        public int DatabaseServerID { get; set; }

        /// <summary>
        /// Gets or Sets SourceClientID
        /// </summary>
        [DataMember(Name = "SourceClientID", EmitDefaultValue = false)]
        public int SourceClientID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateClientRequest {\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  ClientSetID: ").Append(ClientSetID).Append("\n");
            sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  DatabaseServerID: ").Append(DatabaseServerID).Append("\n");
            sb.Append("  SourceClientID: ").Append(SourceClientID).Append("\n");
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
