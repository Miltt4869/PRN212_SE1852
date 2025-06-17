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

namespace RadioButtonControl
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

        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (radRatTot.IsChecked == true)
            {
                binhChon = radRatTot.Content + "";
            }
            else if(radTot.IsChecked == true)
            {
                binhChon = radTot.Content + "";
            }
            else if(radTamDuoc.IsChecked == true)
            {
                binhChon = radTamDuoc.Content + "";
            }
            else if(radKhongTot.IsChecked == true)
            {
                binhChon = radTamDuoc.Content + "";
            }

            string gioitinh = "";
            if (radNam.IsChecked == true)
            {
                gioitinh = radNam.Content + "";
            }
            else if(radNu.IsChecked == true)
            {
                gioitinh = radNam.Content + "";
            }

            string infor = "Bạn bình chọn hệ thống= " + binhChon + Environment.NewLine;
            infor += "Giói tính của bạn = " + gioitinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.Yes)
            {
                // xử lý xác nhận
            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            // or close();
        }
    }
}