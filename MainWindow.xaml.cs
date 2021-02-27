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

namespace MT_W2021_991555817
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
        /// <summary>
        /// Will validate the login components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            String user = "sinrisha";
            String password = "123456";
            String uname = txt_uname.Text;
            String pass = pbox_pass.Password;
            if (uname=="" || pass=="")
            {
                MessageBox.Show("One or more fields missing.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(!(uname.Contains(user))||!(pass.Contains(password)))
            {
                MessageBox.Show("One or more incorrect fields.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Welcome " + user, "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
                PackInfo pac = new PackInfo();
                pac.ShowDialog();
                
            }
        }
    }
}
