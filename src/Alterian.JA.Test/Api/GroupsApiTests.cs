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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsApiTests : IDisposable
    {
        private GroupsApi instance;

        public GroupsApiTests()
        {
            instance = new GroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupsApi
            //Assert.IsType<GroupsApi>(instance);
        }

        /// <summary>
        /// Test CopyGroup
        /// </summary>
        [Fact]
        public void CopyGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CopyGroupRequest copyGroupRequest = null;
            //var response = instance.CopyGroup(copyGroupRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Fact]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateGroupRequest createGroupRequest = null;
            //var response = instance.CreateGroup(createGroupRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Fact]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteGroupRequest deleteGroupRequest = null;
            //var response = instance.DeleteGroup(deleteGroupRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Fact]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetGroupRequest getGroupRequest = null;
            //var response = instance.GetGroup(getGroupRequest);
            //Assert.IsType<GetGroupDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetGroupMembers
        /// </summary>
        [Fact]
        public void GetGroupMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetGroupMembersRequest getGroupMembersRequest = null;
            //var response = instance.GetGroupMembers(getGroupMembersRequest);
            //Assert.IsType<GetGroupMembersDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Fact]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetGroupsRequest getGroupsRequest = null;
            //var response = instance.GetGroups(getGroupsRequest);
            //Assert.IsType<GetGroupsDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Fact]
        public void UpdateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateGroupRequest createGroupRequest = null;
            //var response = instance.UpdateGroup(createGroupRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}
