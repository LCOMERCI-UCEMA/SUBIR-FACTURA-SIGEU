using Entidades;
using Oracle.ManagedDataAccess.Client;
using System.Data;

using SPParam = Entidades.StoredProcedureParam;

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

      public static Task<DataTable> CargarFacturaAsync(Factura factura)
      {
         Dictionary<string, SPParam> args = new Dictionary<string, SPParam>()
         {
            { "p_n_factura"       , SPParam.Create( OracleDbType.Int64   , factura.NumeroFactura    ) },
            { "p_n_id_empresa"    , SPParam.Create( OracleDbType.Int64   , factura.IdEmpresa        ) },
            { "p_fecha_vto"       , SPParam.Create( OracleDbType.Date    , factura.FechaVencimiento ) },
            { "p_razon_social"    , SPParam.Create( OracleDbType.Varchar2, factura.RazonSocial      ) },
            { "p_domicilio"       , SPParam.Create( OracleDbType.Varchar2, factura.Domicilio        ) },
            { "p_n_cuit"          , SPParam.Create( OracleDbType.Int64   , factura.Cuit             ) },
            { "p_n_importe_total" , SPParam.Create( OracleDbType.Int64   , factura.ImporteTotal     ) },
            { "p_n_importe1"      , SPParam.Create( OracleDbType.Int64   , factura.Importe1         ) },
            { "p_d_desc_concepto1", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion1     ) },
            { "p_n_importe2"      , SPParam.Create( OracleDbType.Int64   , factura.Importe2         ) },
            { "p_d_desc_concepto2", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion2     ) },
            { "p_n_importe3"      , SPParam.Create( OracleDbType.Int64   , factura.Importe3         ) },
            { "p_d_desc_concepto3", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion3     ) },
            { "p_n_importe4"      , SPParam.Create( OracleDbType.Int64   , factura.Importe4         ) },
            { "p_d_desc_concepto4", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion4     ) },
            { "p_n_importe5"      , SPParam.Create( OracleDbType.Int64   , factura.Importe5         ) },
            { "p_d_desc_concepto5", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion5     ) },
            { "p_n_importe6"      , SPParam.Create( OracleDbType.Int64   , factura.Importe6         ) },
            { "p_d_desc_concepto6", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion6     ) },
            { "p_n_importe7"      , SPParam.Create( OracleDbType.Int64   , factura.Importe7         ) },
            { "p_d_desc_concepto7", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion7     ) },
            { "p_n_importe8"      , SPParam.Create( OracleDbType.Int64   , factura.Importe8         ) },
            { "p_d_desc_concepto8", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion8     ) },
            { "p_n_importe9"      , SPParam.Create( OracleDbType.Int64   , factura.Importe9         ) },
            { "p_d_desc_concepto9", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion9     ) },
         };

         return Datos.Script.CargarFacturaAsync(args);
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

      public static async Task<bool> NotaCreditoExisteAsync(long idNotaCredito)
      {
         DataTable dtResultados = await Datos.Script.BuscarNotaCreditoAsync(idNotaCredito);

         return dtResultados.Rows.Count > 0;
      }
   }
}