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

namespace ListWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
           //xlaf giá trị muốn đưa vào danh sách
           int x = int.Parse(txtGiaTri.Text);
           // thêm x vào ds
           dsDuLieu.Add(x);
           HienThiDangSach();
           txtGiaTri.Text = "";
        }

        private void HienThiDangSach()
        {
            lisDuLieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x= dsDuLieu[i];
                lisDuLieu.Items.Add(x);
            }
        }

        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            //goi leenh sapws xeeps ds
            dsDuLieu.Sort();
            // hien thi laij ds
            HienThiDangSach();
        }

        private void BtnXoa1PhanTu(object sender, RoutedEventArgs e)
        {
            if (lisDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phai chon mot phan tu moi xoa duoc","Thong bao loi",MessageBoxButton.OK);
                return;
                // xoa ptu tai vi tri dg chon
                dsDuLieu.RemoveAt(lisDuLieu.SelectedIndex);
                HienThiDangSach();
            }
        }

        private void BtnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lisDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }

            while (lisDuLieu.SelectedItems.Count > 0)
            {
                int data = (int)lisDuLieu.SelectedItems[0];
                dsDuLieu.Remove(data);
                lisDuLieu.Items.Remove(data);
            }
        }

        private void BtnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDangSach();
        }

        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
           //x laf gias trij muoons chenf 
           int x = int.Parse(txtGiaTriChen.Text);
           // vt maf ta chenf x vaod
           int vt = int.Parse(txtViTriChen.Text);
            // chenf x vaof vi tri vt
            dsDuLieu.Insert(vt,x);
            // hien thi laij danh sach
            txtViTriChen.Text = "";
            txtGiaTriChen.Text = "";

        }

        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            //goi leenh sapws xeeps ds
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            // hien thi laij ds
            HienThiDangSach();
        }
    }
}