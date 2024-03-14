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
    /// DeleteVisualisationFavouritesRequest
    /// </summary>
    [DataContract(Name = "DeleteVisualisationFavourites_request")]
    public partial class DeleteVisualisationFavouritesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVisualisationFavouritesRequest" /> class.
        /// </summary>
        /// <param name="visualisationFavouriteIds">Id&#39;s of the Visualisation favourite(s) to delete..</param>
        public DeleteVisualisationFavouritesRequest(List<int> visualisationFavouriteIds = default(List<int>))
        {
            this.VisualisationFavouriteIds = visualisationFavouriteIds;
        }

        /// <summary>
        /// Id&#39;s of the Visualisation favourite(s) to delete.
        /// </summary>
        /// <value>Id&#39;s of the Visualisation favourite(s) to delete.</value>
        [DataMember(Name = "VisualisationFavouriteIds", EmitDefaultValue = false)]
        public List<int> VisualisationFavouriteIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteVisualisationFavouritesRequest {\n");
            sb.Append("  VisualisationFavouriteIds: ").Append(VisualisationFavouriteIds).Append("\n");
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
