using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using LibraryDonnesAPI;



namespace CollecteDeDonnees
{

    internal class Program
    {

        static void Main(string[] args)
        {

            String X = "5.731358767949209";
            String Y = "45.18457681950622";
            String D = "300";
            String B = "true";

            String url = $"http://data.mobilites-m.fr/api/linesNear/json?x={X}&y={Y}&dist={D}&details={B}";

            DonneLibrary webData = new DonneLibrary();
            

            foreach (LineDonne lineDonne in webData.GetWebDonne(url))
            {
                Console.WriteLine("Id: {0}", lineDonne.id);
                Console.WriteLine("Name: {0}", lineDonne.name);
                Console.WriteLine("Longitud: {0}", lineDonne.lon);
                Console.WriteLine("Latitude: {0}", lineDonne.lat);
                Console.WriteLine("Zone: {0}", lineDonne.zone);

                foreach (String lines in lineDonne.lines)
                {
                    Console.WriteLine("Line: {0}", lines);
                }

                Console.WriteLine("\n");

            }

        }

    }
}
