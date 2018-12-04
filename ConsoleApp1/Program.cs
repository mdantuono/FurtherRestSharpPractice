using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using RestSharp.Authenticators;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string status = "This tweet was posted using RestSharp.";
            var client = new RestClient("https://api.twitter.com/");
            var request = new RestRequest("1.1/statuses/update.json?", Method.POST);
            request.AddHeader("Authorization", "OAuth oauth_consumer_key");
            request.AddParameter("status", status);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.Write(content);
        }
    }
}
