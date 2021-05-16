using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace SkyTestinAPI.Steps
{
    

    [Binding]
    public class SkyTestingAPISteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

            [Given(@"I have access to the endpoint")]
        public void GivenIHaveAccessToTheEndpoint()
        {
            //GET for list of Articles
            client = new RestClient("https://5f99522350d84900163b8737.mockapi.io/tech-test/articles");
            client.Timeout = -1;
            
        }

        //GET for Single Article
        [Given(@"I have access to the single endpoint")]
        public void GivenIHaveAccessToTheSingleEndpoint()
        {
            client = new RestClient("https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/2");
            client.Timeout = -1;

        }

        [When(@"I search for the endpoint")]
        public void WhenISearchForTheEndpoint()
        {
            
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        
        [Then(@"result is displayed")]
        public void ThenResultIsDisplayed()
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");
        }

       












    }
}
