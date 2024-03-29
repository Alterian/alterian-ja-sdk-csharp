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
    /// Defines DMFieldStorageType
    /// </summary>
    public enum DMFieldStorageType
    {
        /// <summary>
        /// Enum DMFS_NA for value: 0
        /// </summary>
        DMFS_NA = 0,

        /// <summary>
        /// Enum DMFS_LIST for value: 1
        /// </summary>
        DMFS_LIST = 1,

        /// <summary>
        /// Enum DMFS_RECIPIENT for value: 2
        /// </summary>
        DMFS_RECIPIENT = 2,

        /// <summary>
        /// Enum DMFS_RECIPIENTLIST for value: 3
        /// </summary>
        DMFS_RECIPIENTLIST = 3
    }

}
