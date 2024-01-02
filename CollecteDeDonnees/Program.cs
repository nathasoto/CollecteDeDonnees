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
            Donnes webData = new Donnes();

            foreach (LineDonne lineDonne in webData.GetWebDonne())
            {
                Console.WriteLine("Id: {0}",lineDonne.id);
                Console.WriteLine("Name: {0}", lineDonne.name);
                Console.WriteLine("Longitud: {0}", lineDonne.lon);
                Console.WriteLine("Latitude: {0}", lineDonne.lat);
                Console.WriteLine("Zone: {0}", lineDonne.zone);

                foreach (String lines  in lineDonne.lines)
                {
                    Console.WriteLine("Line: {0}", lines);
                }  
                
                Console.WriteLine("\n");

            }

        }

    }
}
