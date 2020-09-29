using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RequestApi
    {
        public async Task reqPost(string url, object json,string authorization)
        {
            string Url = "https://192.168.1.46/eepwebservice/BaseHandler.svc/GetBaseInfoByMang";
            var JsonObject = new
            {
                EmpID = "632303",
                EffectDate = "2020/09/25"
            };
            string postData = await PostAsyncJson(url, json, authorization);
            //List<Dictionary<string, string>> dataList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(postData);
            //Dictionary<string, string> dataKeyValue = dataList[0];
            //Dictionary<string, string>.KeyCollection keyColl = dataKeyValue.Keys;

            //foreach (string s in keyColl)
            //{
            //    Console.WriteLine($"Key = {s}\nValue = {dataKeyValue[s]}");
            //}
        }


        public void getApi()
        {
            string Url = "https://jsonplaceholder.typicode.com/posts";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(Url);
            req.Method = "GET";

            using (WebResponse response = req.GetResponse())
            {
                //在這裡對接收到的頁面內容進行處理
                string result = null;
                StreamReader sr = new StreamReader(response.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(result.ToString());

            }
        }

        public  async Task<string> PostAsyncJson(string url, object json,string authorization)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            HttpClient client = new HttpClient();
            if (authorization.Length > 0)
            {
                client.DefaultRequestHeaders.Add("authorization", "Basic NjQ2MjQ1OjY0NjI0NQ==");
            }
            HttpContent content = new StringContent(JsonConvert.SerializeObject(json));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
