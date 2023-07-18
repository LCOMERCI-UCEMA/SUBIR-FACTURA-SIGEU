using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Factura
   {
      #region Atributos de la Factura
      public long NumeroFactura { get; set; } = 0;
      public int IdEmpresa { get; set; } = 0;
      public DateTime? FechaAlta { get; set; } = null;
      public DateTime? FechaVencimiento { get; set; } = null;
      public string RazonSocial { get; set; } = string.Empty;
      public string Domicilio { get; set; } = string.Empty;
      public long? Cuit { get; set; } = null;
      public decimal ImporteTotal { get; set; } = 0m;
      public string Estado { get; set; } = string.Empty;

      #endregion

      #region Items de la Factura
      public string Descripcion1 { get; set; } = string.Empty;
      public string Importe1 { get; set; } = string.Empty;
      public string Descripcion2 { get; set; } = string.Empty;
      public string Importe2 { get; set; } = string. Empty;
      public string Descripcion3 { get; set; } = string.Empty;
      public string Importe3 { get; set; } = string. Empty;
      public string Descripcion4 { get; set; } = string.Empty;
      public string Importe4 { get; set; } = string. Empty;
      public string Descripcion5 { get; set; } = string.Empty;
      public string Importe5 { get; set; } = string. Empty;
      public string Descripcion6 { get; set; } = string.Empty;
      public string Importe6 { get; set; } = string. Empty;
      public string Descripcion7 { get; set; } = string.Empty;
      public string Importe7 { get; set; } = string. Empty;
      public string Descripcion8 { get; set; } = string.Empty;
      public string Importe8 { get; set; } = string. Empty;
      public string Descripcion9 { get; set; } = string.Empty;
      public string Importe9 { get; set; } = string. Empty;

      #endregion
   }
}
