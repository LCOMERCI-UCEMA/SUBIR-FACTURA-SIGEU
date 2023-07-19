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
      public string Descripcion01 { get; set; } = string.Empty;
      public decimal Importe01 { get; set; } = 0m;
      public string Descripcion02 { get; set; } = string.Empty;
      public decimal Importe02 { get; set; } = 0m;
      public string Descripcion03 { get; set; } = string.Empty;
      public decimal Importe03 { get; set; } = 0m;
      public string Descripcion04 { get; set; } = string.Empty;
      public decimal Importe04 { get; set; } = 0m;
      public string Descripcion05 { get; set; } = string.Empty;
      public decimal Importe05 { get; set; } = 0m;
      public string Descripcion06 { get; set; } = string.Empty;
      public decimal Importe06 { get; set; } = 0m;
      public string Descripcion07 { get; set; } = string.Empty;
      public decimal Importe07 { get; set; } = 0m;
      public string Descripcion08 { get; set; } = string.Empty;
      public decimal Importe08 { get; set; } = 0m;
      public string Descripcion09 { get; set; } = string.Empty;
      public decimal Importe09 { get; set; } = 0m;

      #endregion
   }
}
