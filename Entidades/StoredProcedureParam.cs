using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Entidades
{
   public struct StoredProcedureParam
   {
      private OracleDbType tipo;
      private dynamic? valor;

      public OracleDbType Tipo { get => tipo; set => tipo = value; }
      public dynamic? Valor { get => valor; set => valor = value; }

      // constructor protegido
      private StoredProcedureParam(OracleDbType tipo, dynamic? valor)
      {
         this.tipo = tipo;
         this.valor = valor;
      }

      // function generadora de StoredProcedureParams
      public static StoredProcedureParam Create(OracleDbType tipo, dynamic? valor)
      {
         return new StoredProcedureParam(tipo, valor);
      }
   }
}
