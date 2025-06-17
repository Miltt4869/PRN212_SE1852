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

namespace BTcoban2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChKToanBo_Checked(object sender, RoutedEventArgs e)
        {
            ChkCongNghe.IsChecked = true;
            chkDuLich.IsChecked = true;
            chkDaBong.IsChecked = true;
            chkCemPhim.IsChecked = true;
        }

        private void ChKToanBo_Unchecked(object sender, RoutedEventArgs e)
        {
            ChkCongNghe.IsChecked = false;
            chkDuLich.IsChecked = false;
            chkDaBong.IsChecked = false;
            chkCemPhim.IsChecked = true;
        }

        private void chkSub_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (ChkCongNghe.IsChecked == true && chkDuLich.IsChecked == true &&
                chkDaBong.IsChecked == true && chkCemPhim.IsChecked == true)
            {
                ChKToanBo.IsChecked = true;//checked toàn bộ
            }
            else if (ChkCongNghe.IsChecked == false && chkDuLich.IsChecked == false &&
                 chkDaBong.IsChecked == false && chkCemPhim.IsChecked == false)

            {
                ChKToanBo.IsChecked = false;//unchecked toàn bộ
            }
            
        }

     
    }
}