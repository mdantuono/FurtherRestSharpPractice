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
            request.AddHeader("Authorization", "OAuth oauth_consumer_key='2WNGB1TGcoZtMgIe7A5aFloHV',oauth_token='239156828 - hRlujnJQLZMbX3zTDRuRUP0ItXKUrzqCMC8UhhZw',oauth_signature_method='HMAC - SHA1'");
            request.AddParameter("status", status);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.Write(content);
        }
    }
}
