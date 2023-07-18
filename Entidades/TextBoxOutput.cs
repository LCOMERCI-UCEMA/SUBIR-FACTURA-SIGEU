using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class TextBoxOutput : TextWriter
   {
      public override Encoding Encoding
      {
         get { return System.Text.Encoding.UTF8; }
      }
   }
}
