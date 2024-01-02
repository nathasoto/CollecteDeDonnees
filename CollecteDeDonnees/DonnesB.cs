using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CollecteDeDonnees
{
    internal class DonnesB : IDonnesB
    {
         public Stream GetWebDonne()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;

            // Initialize the WebRequest.
            WebRequest myRequest = WebRequest.Create("http://data.mobilites-m.fr/api/linesNear/json?x=5.731358767949209&y=45.18457681950622&dist=400&details=true");

            // Return the response.
            Stream myResponse = myRequest.GetResponse().GetResponseStream();

            // Close the response to free resources.
            //myResponse.Close();

            return myResponse;

        }
        public void ShowReponse(Stream myResponse)
        {

        }
    }
}
