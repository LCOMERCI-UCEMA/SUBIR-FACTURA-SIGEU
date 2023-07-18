using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Console = System.Diagnostics.Debug;

namespace UCEMA.Subir_Factura_SIGEU.NET7
{
   public static class FormUtils
   {
      // Fields
      private static Action onLoadBegin = () => { };
      private static Action onLoadEnd = () => { };
      private static Control? statusbar;

      // Properties
      public static Action OnLoadBegin { get => onLoadBegin; set => onLoadBegin = value; }
      public static Action OnLoadEnd { get => onLoadEnd; set => onLoadEnd = value; }
      public static Control? Statusbar { get => statusbar; set => statusbar = value; }

      public static async Task<dynamic> RunAsync(Func<dynamic> action)
      {
         return await Task.Run(action);
      }

      public static void Numeric_KeyPress(ref object sender, ref KeyPressEventArgs e, bool isDecimal = false)
      {
         // Obtener el separador decimal del sistema operativo
         char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

         // Permitir solo números y teclas de movimiento
         bool isControl = char.IsControl(e.KeyChar);
         bool isDigit = char.IsDigit(e.KeyChar);
         bool isDecimalSeparator = e.KeyChar == decimalSeparator;
         bool canHandle = isControl || isDigit || (isDecimal && isDecimalSeparator);

         // Verificar si ya se ingresó un separador decimal
         if (isDecimal && isDecimalSeparator && ((TextBox) sender).Text.Contains(decimalSeparator))
         {
            canHandle = false;
         }

         e.Handled = !canHandle;
      }

      public static void LoadingON()
      {
         OnLoadBegin.Invoke();
      }

      public static void LoadingOFF()
      {
         OnLoadEnd.Invoke();
      }

      public static GroupBox? GetParentGroupBox(Control control)
      {
         Control? parent = control.Parent;

         while (parent != null)
         {
            if (parent is GroupBox groupBox)
               return groupBox;
            parent = parent.Parent;
         }

         return null;
      }

      public static void StatusMessage(string message)
      {
         
      }
   }
}
