using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using Entidades;

namespace Datos
{
   public static class Script
   {
      public static DataTable TraerEntidades(string tabla, string campos = "*", string orden = "")
      {
         DataTable dt = new DataTable();

         using (OracleConnection con = new OracleConnection(Conexion.StrConexion()))
         {
            con.Open();
            using (OracleCommand cmd = con.CreateCommand())
            {
               cmd.CommandText = $"SELECT {campos} FROM {tabla} ";
               if (orden.Length > 0)
               {
                  cmd.CommandText += ($"ORDER BY {orden}");
               }
               cmd.CommandType = CommandType.Text;

               using (OracleDataAdapter adp = new OracleDataAdapter(cmd))
               {
                  adp.Fill(dt);
               }
            }

            con.Close();
         }

         return dt;
      }
      
      public static DataTable BuscarFactura(int idFactura)
      {
         return Consultar(@$"SELECT * FROM CEMAP.FACTURAS WHERE N_FACTURA = '{idFactura}'");
      }
      
      public static async Task<DataTable> BuscarFacturaAsync(long idFactura)
      {
         return await ConsultarAsync(@$"SELECT * FROM CEMAP.FACTURAS WHERE N_FACTURA = '{idFactura}'");
      }

      /// <summary>
      ///    Ejecuta una consulta sincrónica.
      /// </summary>
      /// <param name="consulta">
      ///    Consulta a ejecutar.
      /// </param>
      /// <returns>
      ///    Devuelve un DataTable con los resultados de la consulta.
      /// </returns>
      public static DataTable Consultar(string consulta)
      {
         DataTable dt = new DataTable();

         using (OracleConnection con = new OracleConnection(Conexion.StrConexion()))
         {
            con.Open();
            using (OracleCommand cmd = con.CreateCommand())
            {
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = consulta;

               using (OracleDataAdapter adp = new OracleDataAdapter(cmd))
               {
                  adp.Fill(dt);
               }
            }
            con.Close();
         }

         return dt;
      }

      /// <summary>
      ///    Ejecuta una consulta asincrónica.
      /// </summary>
      /// <param name="consulta">
      ///    Consulta a ejecutar.
      /// </param>
      /// <returns>
      ///    Devuelve un DataTable con los resultados de la consulta.
      /// </returns>
      public static async Task<DataTable> ConsultarAsync(string consulta)
      {
         DataTable dt = new DataTable();

         using (OracleConnection con = new OracleConnection(Conexion.StrConexion()))
         {
            await con.OpenAsync();

            using (OracleCommand cmd = con.CreateCommand())
            {
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = consulta;

               using (OracleDataAdapter adp = new OracleDataAdapter(cmd))
               {
                  await Task.Run(() => { 
                     adp.Fill(dt); 
                  });
               }
            }
            con.Close();
         }

         return dt;
      }

      public static async Task<DataTable> BuscarEmpresaAsync(string cuitEmpresa)
      {
         List<string> campos = new List<string>() {
             "EMPRESAS.N_ID_EMPRESA", "D_EMPRESA", "N_CUIT",
            @$"CASE WHEN D_DIRECCION IS NULL THEN '{Constantes.SIN_DOMICILIO}'
                   ELSE D_DIRECCION||' '||N_DOMICILIO END AS DOMICILIO",
            @"CASE WHEN C_PROVINCIA = 'C' THEN 'CABA' 
                   ELSE D_LOCALIDAD END AS LOCALIDAD",
             "C_RUBRO", "C_COND_IVA", "C_DOMICILIO"
         };
         string sql = @$"SELECT {string.Join(", ", campos.ToArray())} 
                           FROM CEMAP.EMPRESAS 
                           LEFT JOIN CEMAP.EMPRESAS_DOMICILIOS
                              ON EMPRESAS.N_ID_EMPRESA = EMPRESAS_DOMICILIOS.N_ID_EMPRESA
                           WHERE N_CUIT = '{cuitEmpresa}'";
         return await ConsultarAsync(sql);
      }

      public static async Task<DataTable> BuscarEmpresaDomicilioAsync(int idEmpresa)
      {
         return await ConsultarAsync(@$"SELECT * FROM CEMAP.EMPRESAS_DOMICILIOS WHERE N_ID_EMPRESA = '{idEmpresa}'");
      }

      public static bool CargarFactura(Factura factura)
      {
         DataTable dtResultado = Consultar(@$"SELECT CEMAP.CARGAR_FACTURA() FROM DUAL");

         return dtResultado.Rows.Count > 0;
      }

      public static async Task<bool> CargarFacturaAsync(Factura factura)
      {
         // TODO: Desempaquetar los params segun como haya que llamarla...
         DataTable dtResultado = await ConsultarAsync("SELECT CEMAP.CARGAR_FACTURA(...) FROM DUAL");

         return dtResultado.Rows.Count > 0;
      }

      public static async Task<DataTable> GetAllCUITsAsync()
      {
         return await ConsultarAsync("SELECT N_CUIT FROM CEMAP.EMPRESAS");
      }
   }
}
