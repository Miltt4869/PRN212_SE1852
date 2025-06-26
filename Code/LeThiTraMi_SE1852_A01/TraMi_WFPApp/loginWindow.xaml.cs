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
using System.Windows.Shapes;
using BusinessObjects;
using Services; 

namespace TraMi_WFPApp
{
    public partial class LoginWindow : Window
    {

        private readonly IEmployeeServices iEmployeeServices;
        private readonly ICustomerServices iCustomerServices;


        public LoginWindow()
        {
            InitializeComponent();

            iEmployeeServices = new EmployeeServices();
            iCustomerServices = new CustomerServices();


            lblUser.Text = rdoAdmin.IsChecked == true ? "Username:" : "Phone:";
        }

        private void Role_Checked(object sender, RoutedEventArgs e)
        {
            
            if (lblUser == null || txtUsername == null)
                return;

            if (rdoCustomer.IsChecked == true)
            {
                lblUser.Text = "Số điện thoại:";
                lblPassword.Visibility = Visibility.Collapsed;
                txtPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                lblUser.Text = "Username:";
                lblPassword.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Visible;
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (rdoAdmin.IsChecked == true)
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Password; 

                // ---phần chỉnh sửa ---

             
                Employee? emp = iEmployeeServices.Login(username, password);

                // --- -- ---

                if (emp != null)
                {
                    MainWindow main = new MainWindow(emp);
                    main.Show();
                  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu (Admin)!");
                }
            }
            else
            {
                // Customer login
                string phone = txtUsername.Text.Trim();


                Customer? cus = iCustomerServices.Login(phone);


                if (cus != null)
                {
                    MainWindow main = new MainWindow(cus);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai số điện thoại hoặc mật khẩu (Customer)!");
                }
            }
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {
           
            Close();
        }
    }
}
