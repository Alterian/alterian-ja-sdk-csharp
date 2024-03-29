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
    ///  Class for testing OpportunityMatricesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OpportunityMatricesApiTests : IDisposable
    {
        private OpportunityMatricesApi instance;

        public OpportunityMatricesApiTests()
        {
            instance = new OpportunityMatricesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OpportunityMatricesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OpportunityMatricesApi
            //Assert.IsType<OpportunityMatricesApi>(instance);
        }

        /// <summary>
        /// Test CreateBusinessGoal
        /// </summary>
        [Fact]
        public void CreateBusinessGoalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBusinessGoalRequest createBusinessGoalRequest = null;
            //var response = instance.CreateBusinessGoal(createBusinessGoalRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test CreateInitiative
        /// </summary>
        [Fact]
        public void CreateInitiativeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateInitiativeRequest createInitiativeRequest = null;
            //var response = instance.CreateInitiative(createInitiativeRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test CreateOpportunity
        /// </summary>
        [Fact]
        public void CreateOpportunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOpportunityRequest createOpportunityRequest = null;
            //var response = instance.CreateOpportunity(createOpportunityRequest);
            //Assert.IsType<CreateClientDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteBusinessGoal
        /// </summary>
        [Fact]
        public void DeleteBusinessGoalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteBusinessGoalRequest deleteBusinessGoalRequest = null;
            //var response = instance.DeleteBusinessGoal(deleteBusinessGoalRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteInitiative
        /// </summary>
        [Fact]
        public void DeleteInitiativeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteInitiativeRequest deleteInitiativeRequest = null;
            //var response = instance.DeleteInitiative(deleteInitiativeRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test DeleteOpportunity
        /// </summary>
        [Fact]
        public void DeleteOpportunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteOpportunityRequest deleteOpportunityRequest = null;
            //var response = instance.DeleteOpportunity(deleteOpportunityRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetBusinessGoals
        /// </summary>
        [Fact]
        public void GetBusinessGoalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBusinessGoals();
            //Assert.IsType<GetBusinessGoalsDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetEventStreamInitiatives
        /// </summary>
        [Fact]
        public void GetEventStreamInitiativesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetEventStreamInitiativesRequest getEventStreamInitiativesRequest = null;
            //var response = instance.GetEventStreamInitiatives(getEventStreamInitiativesRequest);
            //Assert.IsType<GetEventStreamInitiativesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetInitiatives
        /// </summary>
        [Fact]
        public void GetInitiativesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInitiatives();
            //Assert.IsType<GetEventStreamInitiativesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetOpportunities
        /// </summary>
        [Fact]
        public void GetOpportunitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOpportunities();
            //Assert.IsType<GetOpportunitiesDefaultResponse>(response);
        }

        /// <summary>
        /// Test GetOpportunityMatrix
        /// </summary>
        [Fact]
        public void GetOpportunityMatrixTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOpportunityMatrix();
            //Assert.IsType<GetOpportunityMatrixDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateBusinessGoal
        /// </summary>
        [Fact]
        public void UpdateBusinessGoalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBusinessGoalRequest createBusinessGoalRequest = null;
            //var response = instance.UpdateBusinessGoal(createBusinessGoalRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateInitiative
        /// </summary>
        [Fact]
        public void UpdateInitiativeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateInitiativeRequest createInitiativeRequest = null;
            //var response = instance.UpdateInitiative(createInitiativeRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateOpportunity
        /// </summary>
        [Fact]
        public void UpdateOpportunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOpportunityRequest createOpportunityRequest = null;
            //var response = instance.UpdateOpportunity(createOpportunityRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }

        /// <summary>
        /// Test UpdateOpportunityMatrix
        /// </summary>
        [Fact]
        public void UpdateOpportunityMatrixTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateOpportunityMatrixRequest updateOpportunityMatrixRequest = null;
            //var response = instance.UpdateOpportunityMatrix(updateOpportunityMatrixRequest);
            //Assert.IsType<AUTHChangePasswordDefaultResponse>(response);
        }
    }
}
