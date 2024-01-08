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

            List <LineDonne> data = JsonConvert.DeserializeObject<List<LineDonne>>(json_string);

            return data;


        }
        public List<LineDonne> FindLines(String lat, String lon, String radio)
        {
            String url = $"http://data.mobilites-m.fr/api/linesNear/json?x={lat}&y={lon}&dist={radio}&details={"true"}";

            return GetWebDonne(url);

            //foreach (LineDonne lineDonne in GetWebDonne(url))
            //{
            //    Console.WriteLine("Id: {0}", lineDonne.id);
            //    Console.WriteLine("Name: {0}", lineDonne.name);
            //    Console.WriteLine("Longitud: {0}", lineDonne.lon);
            //    Console.WriteLine("Latitude: {0}", lineDonne.lat);
            //    Console.WriteLine("Zone: {0}", lineDonne.zone);

            //    foreach (String lines in lineDonne.lines)
            //    {
            //        Console.WriteLine("Line: {0}", lines);
            //    }

            //    Console.WriteLine("\n");

            //}

        }

    }
}
