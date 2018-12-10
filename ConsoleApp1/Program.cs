using System;
using System.Collections.Generic;
using System.Globalization;
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
            request.AddHeader("Authentication", "OAuth oauth_consumer_key=" + Keys.consumerKey + ",oauth_token=" + Keys.accessToken + ",oauth_signature_method=\"HMAC - SHA1\"");

            request.AddParameter("status", status);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.Write(content);
        }
    }
}
