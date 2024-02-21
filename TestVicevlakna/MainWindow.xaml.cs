using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestVicevlakna
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private BackgroundWorker backgroundWorker1;
    private BackgroundWorker backgroundWorker2;
    private int x = 0;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      backgroundWorker1 = new BackgroundWorker();
      backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
      ba
      backgroundWorker2 = new BackgroundWorker();
      backgroundWorker2.DoWork += BackgroundWorker2_DoWork;
      backgroundWorker1.RunWorkerAsync();
      backgroundWorker2.RunWorkerAsync();
    }

    private void BackgroundWorker2_DoWork(object? sender, DoWorkEventArgs e)
    {
      while(x < 100)
      {
        x++;
        Thread.Sleep(750);
        labelX.Content = $"X = {x}";
      }
    }

    private void BackgroundWorker1_DoWork(object? sender, DoWorkEventArgs e)
    {
      while (x > -100)
      {
        x--;
        Thread.Sleep(500);
        labelX.Content = $"X = {x}";
      }
    }
  }
}
