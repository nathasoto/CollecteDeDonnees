using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDonnesAPI
{
    public class Request:IRequest
    {
        public String doRequest(String URL)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;

            // Initialize the WebRequest.
            WebRequest myRequest = WebRequest.Create(URL);


            //Return the response.
            Stream myResponse = myRequest.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(myResponse);

            String json_string = objReader.ReadToEnd();

            return json_string;
        }

           
    }
}
