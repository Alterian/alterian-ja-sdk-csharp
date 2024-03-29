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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test CopyUser
        /// </summary>
        [Fact]
        public void CopyUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CopyUserRequest copyUserRequest = null;
            //var response = instance.CopyUser(copyUserRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest createUserRequest = null;
            //var response = instance.CreateUser(createUserRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Fact]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteUserRequest deleteUserRequest = null;
            //var response = instance.DeleteUser(deleteUserRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteUserReassignAssets
        /// </summary>
        [Fact]
        public void DeleteUserReassignAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteUserReassignAssetsRequest deleteUserReassignAssetsRequest = null;
            //var response = instance.DeleteUserReassignAssets(deleteUserReassignAssetsRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetCultures
        /// </summary>
        [Fact]
        public void GetCulturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetClientSetsRequest getClientSetsRequest = null;
            //var response = instance.GetCultures(getClientSetsRequest);
            //Assert.IsType<GetCulturesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetCurrentUser
        /// </summary>
        [Fact]
        public void GetCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetCurrentUserRequest getCurrentUserRequest = null;
            //var response = instance.GetCurrentUser(getCurrentUserRequest);
            //Assert.IsType<GetCurrentUserDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetTimeZones
        /// </summary>
        [Fact]
        public void GetTimeZonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetClientSetsRequest getClientSetsRequest = null;
            //var response = instance.GetTimeZones(getClientSetsRequest);
            //Assert.IsType<GetTimeZonesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetUser
        /// </summary>
        [Fact]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetUserRequest getUserRequest = null;
            //var response = instance.GetUser(getUserRequest);
            //Assert.IsType<GetCurrentUserDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Fact]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetUsersRequest getUsersRequest = null;
            //var response = instance.GetUsers(getUsersRequest);
            //Assert.IsType<GetUsersDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetUsersForClient
        /// </summary>
        [Fact]
        public void GetUsersForClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetUsersForClientRequest getUsersForClientRequest = null;
            //var response = instance.GetUsersForClient(getUsersForClientRequest);
            //Assert.IsType<GetUsersDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest createUserRequest = null;
            //var response = instance.UpdateUser(createUserRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}
