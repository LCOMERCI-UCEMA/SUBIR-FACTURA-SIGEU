using Entidades;
using System.Data;

namespace Logica
{
   public static class Script
   {
      public static Task<DataTable> BuscarEmpresaAsync(string cuitEmpresa)
      {
         return Datos.Script.BuscarEmpresaAsync(cuitEmpresa);
      }

      public static Task<DataTable> BuscarEmpresaDomicilioAsync(int idEmpresa)
      {
         return Datos.Script.BuscarEmpresaDomicilioAsync(idEmpresa);
      }

      public static bool CargarFactura(Factura factura)
      {
         return Datos.Script.CargarFactura(factura);
      }

      public static Task<bool> CargarFacturaAsync(Factura factura)
      {
         return Datos.Script.CargarFacturaAsync(factura);
      }

      public static bool FacturaExiste(int idFactura)
      {
         DataTable dtResultados = Datos.Script.BuscarFactura(idFactura);

         return dtResultados.Rows.Count > 0;
      }

      public static async Task<bool> FacturaExisteAsync(long idFactura)
      {
         DataTable dtResultados = await Datos.Script.BuscarFacturaAsync(idFactura);

         return dtResultados.Rows.Count > 0;
      }

      public static async Task<DataTable> GetAllCUITsAsync()
      {
         return await Datos.Script.GetAllCUITsAsync();
      }
   }
}