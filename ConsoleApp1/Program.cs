﻿using System;
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
            var client = new RestClient("https://twitter.com");
            var request = new RestRequest("/statuses/update", Method.POST);
            request.AddParameter("name", "Mike_DAntuono");
            request.AddParameter("status", status);


            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.Write(content);
        }
    }
}
