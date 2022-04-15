using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
   class KrediliHesap : Hesap
   {
      private static decimal LIMIT = 1000;

      public override bool BakiyeYeterli(decimal tutar)
      {
         if (tutar <= hesapBakiye + LIMIT)
         { return true; }
         else { return false; }
      }
   }
}
