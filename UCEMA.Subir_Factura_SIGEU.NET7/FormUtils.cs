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
   public class FormUtils
   {
      public static Action onLoadBegin = () => {};
      public static Action onLoadEnd = () => {};

      public static async Task<dynamic> RunAsync(Func<dynamic> action)
      {
         return await Task.Run(action);
      }

      public static void Numeric_KeyPress(ref object sender, ref KeyPressEventArgs e, bool isDecimal=false)
      {
         bool condition = isDecimal
            ? (    !char.IsControl(e.KeyChar) 
               && !(char.IsDigit(e.KeyChar) 
                  || e.KeyChar.ToString() == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            : (    !char.IsControl(e.KeyChar) 
               && !char.IsDigit(e.KeyChar));

         if (condition)
         {
            e.Handled = true;
         }
      }

      public static void LoadingON()
      {
         onLoadBegin.Invoke();
      }

      public static void LoadingOFF()
      {
         onLoadEnd.Invoke();
      }
   }
}
