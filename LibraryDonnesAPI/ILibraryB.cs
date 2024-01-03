using CollecteDeDonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDonnesAPI
{
    internal interface ILibraryB
    {
        List<LineDonne> GetWebDonne();
    }
}
