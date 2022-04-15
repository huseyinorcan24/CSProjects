using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF1
{
   public class Hesap : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;
      private void OzellikDegisti(string ozellik_adi)
      {
         if (PropertyChanged != null)
         {
            PropertyChanged(this, new
             PropertyChangedEventArgs(ozellik_adi));
         }
      }

      private static int hesapSayisi = 0;
      private int hesapNo;
      private decimal hesapBakiyesi;

      public Hesap()
      {
         hesapSayisi++;
         hesapNo = hesapSayisi;
      }

      public int No
      {
         get { return hesapNo; }
      }

      public decimal Bakiye
      {
         get { return hesapBakiyesi; }
      }

      public void ParaEkle(decimal tutar)
      {
         if(tutar > 0)
         {
            hesapBakiyesi += tutar;
            OzellikDegisti("Bakiye");
         }
      }

      public void ParaCek(decimal tutar)
      {
         if(tutar <= hesapBakiyesi)
         {
            hesapBakiyesi -= tutar;
            OzellikDegisti("Bakiye");
         }
      }
   }
}
