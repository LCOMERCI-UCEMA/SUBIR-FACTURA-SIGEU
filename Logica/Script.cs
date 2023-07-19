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

      // CARGAR FACTURA
      public static Task<DataTable> CargarFacturaAsync(Factura factura)
      {
         Dictionary<string, SPParam> args = new Dictionary<string, SPParam>()
         {
            { "p_n_factura"       , SPParam.Create( OracleDbType.Int64   , factura.NumeroFactura    )},
            { "p_n_id_empresa"    , SPParam.Create( OracleDbType.Int64   , factura.IdEmpresa        )},
            { "p_fecha_vto"       , SPParam.Create( OracleDbType.Date    , factura.FechaVencimiento )},
            { "p_razon_social"    , SPParam.Create( OracleDbType.Varchar2, factura.RazonSocial      )},
            { "p_domicilio"       , SPParam.Create( OracleDbType.Varchar2, factura.Domicilio        )},
            { "p_n_cuit"          , SPParam.Create( OracleDbType.Int64   , factura.Cuit             )},
            { "p_n_importe_total" , SPParam.Create( OracleDbType.Decimal , factura.ImporteTotal     )},
            { "p_n_importe1"      , SPParam.Create( OracleDbType.Decimal , factura.Importe01        )},
            { "p_d_desc_concepto1", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion01    )},
            { "p_n_importe2"      , SPParam.Create( OracleDbType.Decimal , factura.Importe02        )},
            { "p_d_desc_concepto2", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion02    )},
            { "p_n_importe3"      , SPParam.Create( OracleDbType.Decimal , factura.Importe03        )},
            { "p_d_desc_concepto3", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion03    )},
            { "p_n_importe4"      , SPParam.Create( OracleDbType.Decimal , factura.Importe04        )},
            { "p_d_desc_concepto4", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion04    )},
            { "p_n_importe5"      , SPParam.Create( OracleDbType.Decimal , factura.Importe05        )},
            { "p_d_desc_concepto5", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion05    )},
            { "p_n_importe6"      , SPParam.Create( OracleDbType.Decimal , factura.Importe06        )},
            { "p_d_desc_concepto6", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion06    )},
            { "p_n_importe7"      , SPParam.Create( OracleDbType.Decimal , factura.Importe07        )},
            { "p_d_desc_concepto7", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion07    )},
            { "p_n_importe8"      , SPParam.Create( OracleDbType.Decimal , factura.Importe08        )},
            { "p_d_desc_concepto8", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion08    )},
            { "p_n_importe9"      , SPParam.Create( OracleDbType.Decimal , factura.Importe09        )},
            { "p_d_desc_concepto9", SPParam.Create( OracleDbType.Varchar2, factura.Descripcion09    )},
         };

         return Datos.Script.CargarFacturaAsync(args);
      }

      // CARGAR NOTA CREDITO
      public static Task<DataTable> CargarNotaCreditoAsync(NotaCredito notaCredito)
      {
         Dictionary<string, SPParam> args = new Dictionary<string, SPParam>()
         {
            { "p_n_factura"       , SPParam.Create( OracleDbType.Int64   , notaCredito.NumeroNota    )},
            { "p_n_nota_credito"  , SPParam.Create( OracleDbType.Int64   , notaCredito.NumeroFactura )},
            { "p_fecha_desde"     , SPParam.Create( OracleDbType.Date    , notaCredito.FechaDesde    )},
            { "p_n_importe_total" , SPParam.Create( OracleDbType.Decimal , notaCredito.ImporteTotal  )},
            { "p_n_importe1"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe1      )},
            { "p_d_desc_concepto1", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion1  )},
            { "p_n_importe2"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe2      )},
            { "p_d_desc_concepto2", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion2  )},
            { "p_n_importe3"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe3      )},
            { "p_d_desc_concepto3", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion3  )},
            { "p_n_importe4"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe4      )},
            { "p_d_desc_concepto4", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion4  )},
            { "p_n_importe5"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe5      )},
            { "p_d_desc_concepto5", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion5  )},
            { "p_n_importe6"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe6      )},
            { "p_d_desc_concepto6", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion6  )},
            { "p_n_importe7"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe7      )},
            { "p_d_desc_concepto7", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion7  )},
            { "p_n_importe8"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe8      )},
            { "p_d_desc_concepto8", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion8  )},
            { "p_n_importe9"      , SPParam.Create( OracleDbType.Decimal , notaCredito.Importe9      )},
            { "p_d_desc_concepto9", SPParam.Create( OracleDbType.Varchar2, notaCredito.Descripcion9  )},
         };

         return Datos.Script.CargarFacturaAsync(args);
      }

      public static Task<DataTable> AnularFacturaAsync(int idFactura) 
      {
         return Datos.Script.AnularFactura(idFactura);
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