using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    internal class cs_PlakaKontrolu
    {
        public static bool PlakaKontrol(string plaka)
        {
            string plakaUyum = @"^\d{2}[A-Z]{2,3}\d{2,3}$";
            return Regex.IsMatch(plaka, plakaUyum);
        }
    }
}
