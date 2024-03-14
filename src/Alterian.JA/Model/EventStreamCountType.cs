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
    /// Certain counts are available &#39;out of the box&#39; and can be retrieved using the following enumeration
    /// </summary>
    /// <value>Certain counts are available &#39;out of the box&#39; and can be retrieved using the following enumeration</value>
    public enum EventStreamCountType
    {
        /// <summary>
        /// Enum UnknownVisitorsNew for value: 1
        /// </summary>
        UnknownVisitorsNew = 1,

        /// <summary>
        /// Enum UnknownVisitorsNewAndReturned for value: 2
        /// </summary>
        UnknownVisitorsNewAndReturned = 2,

        /// <summary>
        /// Enum UnknownVisitorsReturned for value: 3
        /// </summary>
        UnknownVisitorsReturned = 3,

        /// <summary>
        /// Enum KnownVisitorsNew for value: 4
        /// </summary>
        KnownVisitorsNew = 4,

        /// <summary>
        /// Enum KnownVisitorsNewAndReturned for value: 5
        /// </summary>
        KnownVisitorsNewAndReturned = 5,

        /// <summary>
        /// Enum KnownVisitorsReturned for value: 6
        /// </summary>
        KnownVisitorsReturned = 6,

        /// <summary>
        /// Enum TotalConversations for value: 7
        /// </summary>
        TotalConversations = 7
    }

}