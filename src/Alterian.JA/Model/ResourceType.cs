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
    /// Types of resources that can have permissions applied to them.
    /// </summary>
    /// <value>Types of resources that can have permissions applied to them.</value>
    public enum ResourceType
    {
        /// <summary>
        /// Enum Document for value: 1
        /// </summary>
        Document = 1,

        /// <summary>
        /// Enum Campaign for value: 2
        /// </summary>
        Campaign = 2,

        /// <summary>
        /// Enum Module for value: 3
        /// </summary>
        Module = 3,

        /// <summary>
        /// Enum Folder for value: 4
        /// </summary>
        Folder = 4,

        /// <summary>
        /// Enum File for value: 5
        /// </summary>
        File = 5,

        /// <summary>
        /// Enum Node for value: 6
        /// </summary>
        Node = 6,

        /// <summary>
        /// Enum Datasource for value: 7
        /// </summary>
        Datasource = 7,

        /// <summary>
        /// Enum DatasourceDatabase for value: 8
        /// </summary>
        DatasourceDatabase = 8,

        /// <summary>
        /// Enum DatasourceTable for value: 9
        /// </summary>
        DatasourceTable = 9,

        /// <summary>
        /// Enum DatasourceColumn for value: 10
        /// </summary>
        DatasourceColumn = 10,

        /// <summary>
        /// Enum UserOrGroup for value: 11
        /// </summary>
        UserOrGroup = 11,

        /// <summary>
        /// Enum NodeFolder for value: 12
        /// </summary>
        NodeFolder = 12,

        /// <summary>
        /// Enum FTPSite for value: 13
        /// </summary>
        FTPSite = 13,

        /// <summary>
        /// Enum FTPSiteFolder for value: 14
        /// </summary>
        FTPSiteFolder = 14,

        /// <summary>
        /// Enum EMMappingFolder for value: 15
        /// </summary>
        EMMappingFolder = 15,

        /// <summary>
        /// Enum EMMapping for value: 16
        /// </summary>
        EMMapping = 16,

        /// <summary>
        /// Enum ExternalAgentFolder for value: 17
        /// </summary>
        ExternalAgentFolder = 17,

        /// <summary>
        /// Enum ExternalAgent for value: 18
        /// </summary>
        ExternalAgent = 18,

        /// <summary>
        /// Enum Metric for value: 19
        /// </summary>
        Metric = 19
    }

}
