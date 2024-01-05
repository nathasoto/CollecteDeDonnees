using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoUI.Models
{
    internal class LignesTransport
    {
        private double latitude;
        public double Latitude{
            get { return latitude;}
            set { latitude = value;}
        }

        private double longitude;
        public double Longitude
        {
            get { return longitude;}
            set { longitude = value;}
        }
        private double rayon;
        public double Rayon { 
            get { return rayon;} 
            set {  rayon = value;} 
        }

        private List<string> lines;
        public List<string> Lines
        {
            get { return lines;}
            set { lines = value;}
        }


    }
}
