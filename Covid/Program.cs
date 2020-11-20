using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.covid19api.com/summary";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Console.WriteLine(httpWebResponse.StatusCode);
            Console.WriteLine(httpWebResponse.Server);
            string jsonString;
            using (Stream stream = httpWebResponse.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            Item data = JsonConvert.DeserializeObject<Item>(jsonString);
            foreach (var item in data.Countries)
            {
                if (item.Country == "Turkey")
                {
                    Console.WriteLine($"Country: {item.Country}\nCountry Code: {item.CountryCode}\nDate:{item.date.Substring(0,10)}\n" +
                        $"New Confirmed : {item.NewConfirmed}\nNew Deaths: {item.NewDeaths}\nNew Recovered : {item.NewRecovered}\nTotal Confirmed : {item.TotalConfirmed}" +
                        $"\nTotal Deaths : {item.TotalDeaths}\nTotal Recovered : {item.TotalRecovered}");
                }
            }


            Console.ReadLine();
        }
    }

   
   
    
}
