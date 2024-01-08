using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPositionGPS.Models
{
    sealed class PositionGPS 
    {
        public double Latitude{ get; set; }

        public double Longitud { get; set; }

        public int Rayon { get; set; }

    }
}
