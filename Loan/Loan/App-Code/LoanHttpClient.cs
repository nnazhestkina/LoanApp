using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Loan.App_Code
{
    public class LoanHttpClient
    {

        private const string _apiBaseUrl = "https://localhost:44330/api/";


        private HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(_apiBaseUrl) };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
           
            return httpClient;
        }

        public List<T> GetList<T>(string url) where T : class
        {
            List<T> modelList = new List<T>();
            using (var httpClient = CreateHttpClient())
            {
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress + url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    modelList = JsonConvert.DeserializeObject<List<T>>(data);
                }
            }

            return modelList;
        }

        public T Get<T>(string url) where T : class
        {
            T model =null;
            using (var httpClient = CreateHttpClient())
            {
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress + url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    model = JsonConvert.DeserializeObject<T>(data);
                }
            }

            return model;
        }

        public void Remove<T>(string url, out string errorMessage) where T : class
        {
            errorMessage = "";
            using (var httpClient = CreateHttpClient())
            {
                HttpResponseMessage response = httpClient.DeleteAsync(httpClient.BaseAddress + url).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorMessage = "Unable to remove the record.";
                }
            }

            
        }
        public T Post<T>(string url, T data) where T : class
        {
            return RunAsyncAsSync(() => PostAsync(url, data));
        }

        public async Task<T> PostAsync<T>(string url, T data) where T : class
        {
            T model = null;
            var jsonString = JsonConvert.SerializeObject(data);
            var postData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            using var httpClient = CreateHttpClient();            
            using var client = CreateHttpClient();
            using var response = await client.PostAsync(url, postData);
            if (response.IsSuccessStatusCode)
            {
                string d = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<T>(d);
            }
            return model;

        }

        private static T RunAsyncAsSync<T>(Func<Task<T>> function)
        {
            var task = function();
            task.ConfigureAwait(false);
            task.Wait();
            return task.Result;
        }

        public bool Delete<T>(string url, int id)
        {
            using (var client = CreateHttpClient())
            {
                using (var response =  client.DeleteAsync(url))
                {                   
                    return response.IsCompletedSuccessfully;
                }
            }
        }

        public bool Put<T>(string url, int id, T data) where T : class
        {
            return RunAsyncAsSync(() => PutAsync(url,id,  data));
        }

        public async Task<bool> PutAsync<T>(string url, int id, T data) where T : class
        {
            var jsonString = JsonConvert.SerializeObject(data);
            var postData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            using var httpClient = CreateHttpClient();
            using var client = CreateHttpClient();
            using var response = await client.PutAsync(url+""+id, postData);

            return response.IsSuccessStatusCode;

        }
    }
}
