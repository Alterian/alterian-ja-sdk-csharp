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
    /// FieldTransformationSampleSettings
    /// </summary>
    [DataContract(Name = "FieldTransformationSampleSettings")]
    public partial class FieldTransformationSampleSettings : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SampleType
        /// </summary>
        [DataMember(Name = "SampleType", EmitDefaultValue = false)]
        public FieldTransformationSampleType? SampleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTransformationSampleSettings" /> class.
        /// </summary>
        /// <param name="sampleType">sampleType.</param>
        /// <param name="sampleSize">sampleSize.</param>
        /// <param name="randomSeed">randomSeed.</param>
        public FieldTransformationSampleSettings(FieldTransformationSampleType? sampleType = default(FieldTransformationSampleType?), int sampleSize = default(int), int? randomSeed = default(int?))
        {
            this.SampleType = sampleType;
            this.SampleSize = sampleSize;
            this.RandomSeed = randomSeed;
        }

        /// <summary>
        /// Gets or Sets SampleSize
        /// </summary>
        [DataMember(Name = "SampleSize", EmitDefaultValue = false)]
        public int SampleSize { get; set; }

        /// <summary>
        /// Gets or Sets RandomSeed
        /// </summary>
        [DataMember(Name = "RandomSeed", EmitDefaultValue = true)]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldTransformationSampleSettings {\n");
            sb.Append("  SampleType: ").Append(SampleType).Append("\n");
            sb.Append("  SampleSize: ").Append(SampleSize).Append("\n");
            sb.Append("  RandomSeed: ").Append(RandomSeed).Append("\n");
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
