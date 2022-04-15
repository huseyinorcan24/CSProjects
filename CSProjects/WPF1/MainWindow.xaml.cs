using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
   /// <summary>
   /// MainWindow.xaml etkileşim mantığı
   /// </summary>
   public partial class MainWindow : Window
   {
      public Hesap AktifHesap { get; set; }
      public ObservableCollection<Hesap> Hesaplar { get; set; }
      public MainWindow()
      {
         InitializeComponent();
      }

      private void Window_Loaded(object sender, RoutedEventArgs e)
      {
         this.DataContext = this;

         Hesaplar = new ObservableCollection<Hesap>();
         Hesap h;
         Random rnd = new Random();
         for(int i=0; i < 10; i++)
         {
            h = new Hesap();
            h.ParaEkle(rnd.Next(100, 1000));
            Hesaplar.Add(h);
         }

         for (int i = 0; i < 10; i++)
         {
            h = new Hesap();
            h.ParaEkle(rnd.Next(100, 1000));
            Hesaplar.Add(h);
         }
      }

      private void btnParaEkle_Click(object sender, RoutedEventArgs e)
      {
         Button btn = sender as Button;
         decimal tutar = Convert.ToDecimal(btn.Tag);
         AktifHesap.ParaEkle(tutar);
      }

      private void hesapTablo_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         
      }
   }
}
