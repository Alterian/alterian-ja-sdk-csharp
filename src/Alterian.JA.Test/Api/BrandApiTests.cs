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
    ///  Class for testing BrandApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BrandApiTests : IDisposable
    {
        private BrandApi instance;

        public BrandApiTests()
        {
            instance = new BrandApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BrandApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BrandApi
            //Assert.IsType<BrandApi>(instance);
        }

        /// <summary>
        /// Test AddLoginImpersonation
        /// </summary>
        [Fact]
        public void AddLoginImpersonationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddLoginImpersonationRequest addLoginImpersonationRequest = null;
            //var response = instance.AddLoginImpersonation(addLoginImpersonationRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test AddUserToBrands
        /// </summary>
        [Fact]
        public void AddUserToBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddUserToBrandsRequest addUserToBrandsRequest = null;
            //var response = instance.AddUserToBrands(addUserToBrandsRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetBrandToken
        /// </summary>
        [Fact]
        public void GetBrandTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetBrandTokenRequest getBrandTokenRequest = null;
            //var response = instance.GetBrandToken(getBrandTokenRequest);
            //Assert.IsType<AUTHCreateLoginDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetBrands
        /// </summary>
        [Fact]
        public void GetBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetBrandsRequest getBrandsRequest = null;
            //var response = instance.GetBrands(getBrandsRequest);
            //Assert.IsType<GetBrandsDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetLoginBrandDefault
        /// </summary>
        [Fact]
        public void GetLoginBrandDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetLoginBrandDefaultRequest getLoginBrandDefaultRequest = null;
            //var response = instance.GetLoginBrandDefault(getLoginBrandDefaultRequest);
            //Assert.IsType<GetLoginBrandDefaultDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetLoginUserMapping
        /// </summary>
        [Fact]
        public void GetLoginUserMappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetLoginUserMappingRequest getLoginUserMappingRequest = null;
            //var response = instance.GetLoginUserMapping(getLoginUserMappingRequest);
            //Assert.IsType<GetLoginUserMappingDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetTokenDetails
        /// </summary>
        [Fact]
        public void GetTokenDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTokenDetails();
            //Assert.IsType<GetTokenDetailsDefaultResponse>(response);
        }

        /// <summary>
        /// Test RemoveLoginBrandDefault
        /// </summary>
        [Fact]
        public void RemoveLoginBrandDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveLoginBrandDefaultRequest removeLoginBrandDefaultRequest = null;
            //var response = instance.RemoveLoginBrandDefault(removeLoginBrandDefaultRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test RemoveLoginImpersonation
        /// </summary>
        [Fact]
        public void RemoveLoginImpersonationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveLoginImpersonationRequest removeLoginImpersonationRequest = null;
            //var response = instance.RemoveLoginImpersonation(removeLoginImpersonationRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test RemoveLoginUserMapping
        /// </summary>
        [Fact]
        public void RemoveLoginUserMappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveLoginUserMappingRequest removeLoginUserMappingRequest = null;
            //var response = instance.RemoveLoginUserMapping(removeLoginUserMappingRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test SetLoginBrandDefault
        /// </summary>
        [Fact]
        public void SetLoginBrandDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetLoginBrandDefaultRequest setLoginBrandDefaultRequest = null;
            //var response = instance.SetLoginBrandDefault(setLoginBrandDefaultRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test SetLoginUserMapping
        /// </summary>
        [Fact]
        public void SetLoginUserMappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetLoginUserMappingRequest setLoginUserMappingRequest = null;
            //var response = instance.SetLoginUserMapping(setLoginUserMappingRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}
