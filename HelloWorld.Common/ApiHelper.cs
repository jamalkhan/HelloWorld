using System;
using System.IO;
using System.Net;

namespace HelloWorld.Common
{
    public static class ApiHelper
    {
        public static string CallApi_Hello(string baseUrl)
        {
            // 
            var req = HttpWebRequest.Create(baseUrl + "/api/hello");
            req.Method = "GET";
            using (var resp = (HttpWebResponse)req.GetResponse())
            {
                var message = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                return message;
            }
        }
    }
}
