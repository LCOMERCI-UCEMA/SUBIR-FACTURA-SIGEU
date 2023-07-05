using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class NotaCredito
   {
      #region Atributos de la Nota de Crédito
      public long NumeroFactura { get; set; }
      public long NumeroNota { get; set; }
      public DateTime FechaDesde { get; set; }
      public decimal ImporteTotal { get; set; }

      #endregion

      #region Items de la Nota de Crédito
      public string Descripcion1 { get; set; } = string.Empty;
      public decimal Importe1 { get; set; }
      public string Descripcion2 { get; set; } = string.Empty;
      public decimal Importe2 { get; set; }
      public string Descripcion3 { get; set; } = string.Empty;
      public decimal Importe3 { get; set; }
      public string Descripcion4 { get; set; } = string.Empty;
      public decimal Importe4 { get; set; }
      public string Descripcion5 { get; set; } = string.Empty;
      public decimal Importe5 { get; set; }
      public string Descripcion6 { get; set; } = string.Empty;
      public decimal Importe6 { get; set; }
      public string Descripcion7 { get; set; } = string.Empty;
      public decimal Importe7 { get; set; }
      public string Descripcion8 { get; set; } = string.Empty;
      public decimal Importe8 { get; set; }
      public string Descripcion9 { get; set; } = string.Empty;
      public decimal Importe9 { get; set; }

      #endregion
   }
}
