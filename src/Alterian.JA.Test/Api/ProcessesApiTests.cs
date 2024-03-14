/*
 * Journey Analytics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 6.35.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Alterian.JA.Client;
using Alterian.JA.Api;
// uncomment below to import models
//using Alterian.JA.Model;

namespace Alterian.JA.Test.Api
{
    /// <summary>
    ///  Class for testing ProcessesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProcessesApiTests : IDisposable
    {
        private ProcessesApi instance;

        public ProcessesApiTests()
        {
            instance = new ProcessesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProcessesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProcessesApi
            //Assert.IsType<ProcessesApi>(instance);
        }

        /// <summary>
        /// Test GetProcessApplications
        /// </summary>
        [Fact]
        public void GetProcessApplicationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetClientSetsRequest getClientSetsRequest = null;
            //var response = instance.GetProcessApplications(getClientSetsRequest);
            //Assert.IsType<GetProcessApplicationsDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetProcessEntries
        /// </summary>
        [Fact]
        public void GetProcessEntriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetProcessEntriesRequest getProcessEntriesRequest = null;
            //var response = instance.GetProcessEntries(getProcessEntriesRequest);
            //Assert.IsType<GetProcessEntriesDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateProcessEntry
        /// </summary>
        [Fact]
        public void UpdateProcessEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateProcessEntryRequest updateProcessEntryRequest = null;
            //var response = instance.UpdateProcessEntry(updateProcessEntryRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}