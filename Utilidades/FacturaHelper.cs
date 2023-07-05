using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
   public static class FacturaHelper
   {
      public const string MASCARA = "500000000"; // 500.000.000 - 500 millones

      public static string AplicarMascara(string idFactura)
      {
         return MASCARA.Substring(0, MASCARA.Length - idFactura.Length) + idFactura;
      }
   }
}
