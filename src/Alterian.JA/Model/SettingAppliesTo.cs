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
    /// Defines SettingAppliesTo
    /// </summary>
    public enum SettingAppliesTo
    {
        /// <summary>
        /// Enum Site for value: 1
        /// </summary>
        Site = 1,

        /// <summary>
        /// Enum Login for value: 2
        /// </summary>
        Login = 2,

        /// <summary>
        /// Enum Issuer for value: 4
        /// </summary>
        Issuer = 4
    }

}
