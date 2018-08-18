using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkRides
{
    public class Rides
    {
        public string GetName { get; set; }
        public string GetMaterial { get; set; }


        public string GetNumRiders(string material)
        {
            if (material == "wood")
            {
                return "2";
            }

            if (material == "Steel")
            {
                return "5";
            }

            if (material == "alum")
            {
                return "4";
            }

            return "0";
            
        }

    }

   
}
