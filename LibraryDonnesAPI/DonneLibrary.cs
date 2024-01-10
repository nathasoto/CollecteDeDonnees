using CollecteDeDonnees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.Runtime.CompilerServices;

namespace LibraryDonnesAPI
{
    public class DonneLibrary
    {
        private IRequest _request;
        

        //constructor class main production
        public DonneLibrary()
        {
            _request = new Request();
        }
        //constructor class fake test
        public DonneLibrary(IRequest request)
        {
            _request = request;
        }

        public List<LineDonne> GetWebDonne(String URL)
        {

            String json_string = _request.doRequest(URL);

            //List <LineDonne> data = JsonConvert.DeserializeObject<List<LineDonne>>(json_string);

            //return data;
            return json_string.ToLineDonneeList();


        }
        public List<LineDonne> FindLines(String lat, String lon, String radio)
        {

            
            String url = $"http://data.mobilites-m.fr/api/linesNear/json?x={lat}&y={lon}&dist={radio}&details={"true"}";
            return GetWebDonne(url);



        }

    }

    static class ResponseDeserialize
    {
        public static List<LineDonne> ToLineDonneeList(this string response)
        {
            return JsonConvert.DeserializeObject<List<LineDonne>>(response);
        }
    }
}
