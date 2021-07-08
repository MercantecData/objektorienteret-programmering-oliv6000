using System;
using System.IO;
using System.Net;

namespace FremlæggelseLibrary
{
    public class EndpointService
    {
        public static string get(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                var geekJoke = reader.ReadToEnd();

                reader.Close();
                response.Close();

                return geekJoke;
            }

            catch(Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}