using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP1
{
   class Program
   {
      static void Main(string[] args)
      {
         Hesap hesap1 = new Hesap();

         hesap1.ParaEkle(100);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap1.Bakiye);

         hesap1.ParaCek(50);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap1.Bakiye);

         hesap1.ParaCek(100);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap1.Bakiye);

         Console.WriteLine();

         KrediliHesap hesap2 = new KrediliHesap();

         hesap2.ParaEkle(100);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap2.Bakiye);

         hesap2.ParaCek(50);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap2.Bakiye);

         hesap2.ParaCek(100);
         Console.WriteLine("Hesap bakiyesi: {0}", hesap2.Bakiye);
      }
   }
}
