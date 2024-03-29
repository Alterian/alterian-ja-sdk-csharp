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
    ///  Class for testing PermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PermissionsApiTests : IDisposable
    {
        private PermissionsApi instance;

        public PermissionsApiTests()
        {
            instance = new PermissionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermissionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PermissionsApi
            //Assert.IsType<PermissionsApi>(instance);
        }

        /// <summary>
        /// Test ClearPermissions
        /// </summary>
        [Fact]
        public void ClearPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClearPermissionsRequest clearPermissionsRequest = null;
            //var response = instance.ClearPermissions(clearPermissionsRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetAvailablePermissions
        /// </summary>
        [Fact]
        public void GetAvailablePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAvailablePermissions();
            //Assert.IsType<GetAvailablePermissionsDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetGroupsWithPermission
        /// </summary>
        [Fact]
        public void GetGroupsWithPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetGroupsWithPermissionRequest getGroupsWithPermissionRequest = null;
            //var response = instance.GetGroupsWithPermission(getGroupsWithPermissionRequest);
            //Assert.IsType<GetGroupsWithPermissionDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Fact]
        public void GetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetPermissionsRequest getPermissionsRequest = null;
            //var response = instance.GetPermissions(getPermissionsRequest);
            //Assert.IsType<GetPermissionsDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetPermittedUsersAndGroups
        /// </summary>
        [Fact]
        public void GetPermittedUsersAndGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetPermittedUsersAndGroupsRequest getPermittedUsersAndGroupsRequest = null;
            //var response = instance.GetPermittedUsersAndGroups(getPermittedUsersAndGroupsRequest);
            //Assert.IsType<GetGroupsWithPermissionDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetResources
        /// </summary>
        [Fact]
        public void GetResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetResources();
            //Assert.IsType<GetResourcesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetUsersWithPermission
        /// </summary>
        [Fact]
        public void GetUsersWithPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetUsersWithPermissionRequest getUsersWithPermissionRequest = null;
            //var response = instance.GetUsersWithPermission(getUsersWithPermissionRequest);
            //Assert.IsType<GetGroupsWithPermissionDefaultResponse>(response);
        }

        /// <summary>
        /// Test SetPermissions
        /// </summary>
        [Fact]
        public void SetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPermissionsRequest setPermissionsRequest = null;
            //var response = instance.SetPermissions(setPermissionsRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test TakeOwnershipPermission
        /// </summary>
        [Fact]
        public void TakeOwnershipPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TakeOwnershipPermissionRequest takeOwnershipPermissionRequest = null;
            //var response = instance.TakeOwnershipPermission(takeOwnershipPermissionRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}
