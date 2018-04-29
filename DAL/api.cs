using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class Api
    {
        private string url = "http://masglobaltestapi.azurewebsites.net/api/";

        public JArray Get(string rute, string urlParameters = "")
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                var response = httpClient.GetStringAsync(new Uri(url+rute+urlParameters)).Result;
                var releases = JArray.Parse(response);
                return releases;
            }
        }
    }
}
