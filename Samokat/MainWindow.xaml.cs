using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Samokat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frames.FrameMain = FrmMain;
            Frames.FrameMain.Navigate(new Goods());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
