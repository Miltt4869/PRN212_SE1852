using System.Windows;
using BusinessObjects;

namespace TraMi_WFPApp
{
    /// <summary>
    /// Interaction logic for CustomerDialog.xaml
    /// </summary>
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; private set; }
        private bool isEdit = false;

        public CustomerDialog()
        {
            InitializeComponent();
            Customer = new Customer();
        }

        public CustomerDialog(Customer customer) : this()
        {
            if (customer != null)
            {
                Customer = new Customer
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    Phone = customer.Phone,
                };
                isEdit = true;
                txtCompanyName.Text = Customer.CompanyName;
                txtContactName.Text = Customer.ContactName;
                txtPhone.Text = Customer.Phone;
            }
        }

        // Nút Lưu
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtContactName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Customer.CompanyName = txtCompanyName.Text.Trim();
            Customer.ContactName = txtContactName.Text.Trim();
            Customer.Phone = txtPhone.Text.Trim();

            DialogResult = true;
        }

        // Nút Hủy
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}