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
    /// Contains information about a database table.
    /// </summary>
    [DataContract(Name = "ALDataSourceTable")]
    public partial class ALDataSourceTable : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ALDataSourceTable" /> class.
        /// </summary>
        /// <param name="iD">Unique ID of the datasource.</param>
        /// <param name="name">Name of the datasource [must be unique].</param>
        /// <param name="nameEx">Full name of this table, which includes in the datasource and the native name for the table in the pattern (datasource).[database].[table].</param>
        /// <param name="enabled">Whether or not this datasource is enabled.</param>
        /// <param name="visible">Whether or not this datasource is visible.</param>
        /// <param name="accessView">Can the user view this datasource.</param>
        /// <param name="accessModify">Not currently used.</param>
        /// <param name="attributes">Attributes for this datasource.  @see(DatasourceAttribute).</param>
        /// <param name="databaseID">The ID of the database that this table belongs to..</param>
        /// <param name="nativeName">The fully qualified name as used by the underlying datasource type..</param>
        /// <param name="columns">columns.</param>
        /// <param name="datasourceTypeID">What kind of datasource is this a table from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types..</param>
        /// <param name="primaryKey">primaryKey.</param>
        /// <param name="resolverTableID">resolverTableID.</param>
        /// <param name="joins">List which columns are part of any defined join between this table and linked tables..</param>
        /// <param name="links">What other tables can this table be linked to?.</param>
        /// <param name="fullNativeName">The entire native name of this item - - usually includes database and table.</param>
        /// <param name="datasourceId">ID of the Datasource.</param>
        public ALDataSourceTable(int iD = default(int), string name = default(string), string nameEx = default(string), bool enabled = default(bool), bool visible = default(bool), bool accessView = default(bool), bool accessModify = default(bool), List<DatasourceAttribute> attributes = default(List<DatasourceAttribute>), int databaseID = default(int), string nativeName = default(string), List<ALDataSourceColumn> columns = default(List<ALDataSourceColumn>), int datasourceTypeID = default(int), ALDatasourcePrimaryKey primaryKey = default(ALDatasourcePrimaryKey), int? resolverTableID = default(int?), List<ALDatasourceJoin> joins = default(List<ALDatasourceJoin>), List<ALDatasourceLink> links = default(List<ALDatasourceLink>), string fullNativeName = default(string), int datasourceId = default(int))
        {
            this.ID = iD;
            this.Name = name;
            this.NameEx = nameEx;
            this.Enabled = enabled;
            this.Visible = visible;
            this.AccessView = accessView;
            this.AccessModify = accessModify;
            this.Attributes = attributes;
            this.DatabaseID = databaseID;
            this.NativeName = nativeName;
            this.Columns = columns;
            this.DatasourceTypeID = datasourceTypeID;
            this.PrimaryKey = primaryKey;
            this.ResolverTableID = resolverTableID;
            this.Joins = joins;
            this.Links = links;
            this.FullNativeName = fullNativeName;
            this.DatasourceId = datasourceId;
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
        /// Full name of this table, which includes in the datasource and the native name for the table in the pattern (datasource).[database].[table]
        /// </summary>
        /// <value>Full name of this table, which includes in the datasource and the native name for the table in the pattern (datasource).[database].[table]</value>
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
        /// The ID of the database that this table belongs to.
        /// </summary>
        /// <value>The ID of the database that this table belongs to.</value>
        [DataMember(Name = "DatabaseID", EmitDefaultValue = false)]
        public int DatabaseID { get; set; }

        /// <summary>
        /// The fully qualified name as used by the underlying datasource type.
        /// </summary>
        /// <value>The fully qualified name as used by the underlying datasource type.</value>
        [DataMember(Name = "NativeName", EmitDefaultValue = false)]
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "Columns", EmitDefaultValue = false)]
        public List<ALDataSourceColumn> Columns { get; set; }

        /// <summary>
        /// What kind of datasource is this a table from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types.
        /// </summary>
        /// <value>What kind of datasource is this a table from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types.</value>
        [DataMember(Name = "DatasourceTypeID", EmitDefaultValue = false)]
        public int DatasourceTypeID { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryKey
        /// </summary>
        [DataMember(Name = "PrimaryKey", EmitDefaultValue = false)]
        public ALDatasourcePrimaryKey PrimaryKey { get; set; }

        /// <summary>
        /// Gets or Sets ResolverTableID
        /// </summary>
        [DataMember(Name = "ResolverTableID", EmitDefaultValue = true)]
        public int? ResolverTableID { get; set; }

        /// <summary>
        /// List which columns are part of any defined join between this table and linked tables.
        /// </summary>
        /// <value>List which columns are part of any defined join between this table and linked tables.</value>
        [DataMember(Name = "Joins", EmitDefaultValue = false)]
        public List<ALDatasourceJoin> Joins { get; set; }

        /// <summary>
        /// What other tables can this table be linked to?
        /// </summary>
        /// <value>What other tables can this table be linked to?</value>
        [DataMember(Name = "Links", EmitDefaultValue = false)]
        public List<ALDatasourceLink> Links { get; set; }

        /// <summary>
        /// The entire native name of this item - - usually includes database and table
        /// </summary>
        /// <value>The entire native name of this item - - usually includes database and table</value>
        [DataMember(Name = "FullNativeName", EmitDefaultValue = false)]
        public string FullNativeName { get; set; }

        /// <summary>
        /// ID of the Datasource
        /// </summary>
        /// <value>ID of the Datasource</value>
        [DataMember(Name = "DatasourceId", EmitDefaultValue = false)]
        public int DatasourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ALDataSourceTable {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameEx: ").Append(NameEx).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  AccessView: ").Append(AccessView).Append("\n");
            sb.Append("  AccessModify: ").Append(AccessModify).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  DatabaseID: ").Append(DatabaseID).Append("\n");
            sb.Append("  NativeName: ").Append(NativeName).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  DatasourceTypeID: ").Append(DatasourceTypeID).Append("\n");
            sb.Append("  PrimaryKey: ").Append(PrimaryKey).Append("\n");
            sb.Append("  ResolverTableID: ").Append(ResolverTableID).Append("\n");
            sb.Append("  Joins: ").Append(Joins).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  FullNativeName: ").Append(FullNativeName).Append("\n");
            sb.Append("  DatasourceId: ").Append(DatasourceId).Append("\n");
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