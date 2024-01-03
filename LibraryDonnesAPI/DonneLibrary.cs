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
        private String URL = "http://data.mobilites-m.fr/api/linesNear/json?x=5.731358767949209&y=45.18457681950622&dist=400&details=true";

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

        public List<LineDonne> GetWebDonne()
        {

            String json_string = _request.doRequest(URL);

            List <LineDonne> data = JsonConvert.DeserializeObject<List<LineDonne>>(json_string);

            return data;


        }

    }
}
