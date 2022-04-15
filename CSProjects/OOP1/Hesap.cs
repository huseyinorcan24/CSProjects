using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
   class Hesap
   {
      protected decimal hesapBakiye;

      public decimal Bakiye
      {
         get { return hesapBakiye; }
      }

      public virtual bool BakiyeYeterli(decimal tutar)
      {
         if (tutar <= hesapBakiye)
         { return true; }
         else { return false; }
      }

      public void ParaEkle(decimal tutar)
      {
         if (tutar > 0)
         {
            hesapBakiye += tutar;
         }
      }

      public void ParaCek(decimal tutar)
      {
         if (tutar > 0 && BakiyeYeterli(tutar))
         {
            hesapBakiye = hesapBakiye - tutar;
         }
      }
   }
}
