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
    /// ALDatasourcePrimaryKey
    /// </summary>
    [DataContract(Name = "ALDatasourcePrimaryKey")]
    public partial class ALDatasourcePrimaryKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ALDatasourcePrimaryKey" /> class.
        /// </summary>
        /// <param name="iD">iD.</param>
        /// <param name="tableID">tableID.</param>
        /// <param name="columnIDs">columnIDs.</param>
        public ALDatasourcePrimaryKey(int iD = default(int), int tableID = default(int), List<int> columnIDs = default(List<int>))
        {
            this.ID = iD;
            this.TableID = tableID;
            this.ColumnIDs = columnIDs;
        }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or Sets TableID
        /// </summary>
        [DataMember(Name = "TableID", EmitDefaultValue = false)]
        public int TableID { get; set; }

        /// <summary>
        /// Gets or Sets ColumnIDs
        /// </summary>
        [DataMember(Name = "ColumnIDs", EmitDefaultValue = false)]
        public List<int> ColumnIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ALDatasourcePrimaryKey {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  TableID: ").Append(TableID).Append("\n");
            sb.Append("  ColumnIDs: ").Append(ColumnIDs).Append("\n");
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
