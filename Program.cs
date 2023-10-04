using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace WebApplication1
{
    class apiConnectionTest
    {
        static void Main(string[] args)
        {
            //Creatin the new Http client
            using (var client = new HttpClient())
            {
                //Getting connection from api
                string url = "https://api.coinbase.com/v2/exchange-rates";
                //I use .Clear because this api does not need credential keys
                client.DefaultRequestHeaders.Clear();

                //Saving the response in var variable
                var response = client.GetAsync(url).Result;
                //Reading the response and saving it in var variable
                var res = response.Content.ReadAsStringAsync().Result;

                //Parsing the Json Object in c# object
                //dynamic is used to execute the variable during runtime process and not during compile
                dynamic r = JObject.Parse(res);
             
                //Display out the response
                Console.WriteLine(r);//para ver la respuesta 
                //Display the status
                Console.WriteLine("Status Connection: {0}", response.StatusCode.ToString());

               
            }
        }
    }
}
