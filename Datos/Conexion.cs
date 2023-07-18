using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class Conexion
   {
      //DESA
      //public static string strConexion = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=pluton.ucema.edu.ar)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=pdbpluton.ucema.edu.ar)));User Id=;Password=;";
      //PRODUCCION
      private const string DATASOURCE_PLUTON = @"(
         DESCRIPTION=(
            ADDRESS=
               (PROTOCOL=TCP)
               (HOST=pluton.ucema.edu.ar)
               (PORT=1521)
            )(
            CONNECT_DATA=
               (SERVICE_NAME=pdbpluton.ucema.edu.ar)
         )
      )";
      
      private const string DATASOURCE_NEPTUNO = @"(
         DESCRIPTION=(
            ADDRESS=
               (PROTOCOL=TCP)
               (HOST=neptuno.ucema.edu.ar)
               (PORT=1521)
            )(
            CONNECT_DATA=
               (SERVICE_NAME=cema.ucema.edu.ar)
         )
      )";

      // En lo que respecta a las cadenas de conexión, a Oracle NO le gusta que haya espacios en blanco
      // entre cada ";" y el nombre del siguiente parámetro.

      //private const string strConexion = @$"Data Source={DATASOURCE_NEPTUNO};User Id=UCEMADEV;Password=ucema49585!;"; // PROD
      private const string strConexion = @$"Data Source={DATASOURCE_PLUTON};User Id={Constantes.DB_USERNAME};Password={Constantes.DB_PASSWORD};"; // TEST

      public static string StrConexion()
      {
         return strConexion;
      }
   }

}