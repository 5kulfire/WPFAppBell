using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MT_W2021_991555817
{
    /// <summary>
    /// Interaction logic for PackInfo.xaml
    /// </summary>
    public partial class PackInfo : Window
    {
        public PackInfo()
        {
            InitializeComponent();
        }
        List<string> checkbox = new List<string>();
        

        abstract class InternetPack
        {
            String pack="";


        }
        class OneGig : InternetPack
        {
            String pack = "1 Gb";
        }
        class Fivehundred : InternetPack
        {
            String pack = "500Mbps";
        }
        class Onefifty : InternetPack
        {
            String pack = "150Mbps";
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_offer.Clear();
            if (radio150mbps.IsChecked== true)
            {
                radio150mbps.IsChecked=false;
            }
            else if(radio500mbps.IsChecked== true)
            {
                radio500mbps.IsChecked = false;
            }
            else if(radio_onegig.IsChecked== true)
            {
                radio_onegig.IsChecked = false;
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            
            if(MessageBox.Show("Do you want to exit the program?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning)== MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            
        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            if(radio150mbps.IsChecked!= true && radio500mbps.IsChecked!= true && radio_onegig.IsChecked!=true)
            {
                MessageBox.Show("Please choose a plan.", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_offer.Text == "")
            {
                MessageBox.Show("Offer name cannot be empty.", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                cmb_choices.ItemsSource = txt_offer.Text;
                if(radio150mbps.IsChecked== true)
                {
                    txt_install.Text = "49.99";
                    txt_monthly.Text = "104.99";
                    txt_rental.Text = "10";
                    txt_speed.Text = "150Mbps";
                    double total = 49.99 + 104.99 + 10;
                    txt_monthly_readonly.Text = "104.99";
                    txt_speed_readonly.Text = "150Mbps";
                    txt_total_readonly_.Text = total.ToString();
                }
                else if (radio500mbps.IsChecked== true)
                {
                    txt_install.Text = "49.99";
                    txt_monthly.Text = "104.99";
                    txt_rental.Text = "10";
                    txt_speed.Text = "500Mbps";
                    double total = 49.99 + 104.99 + 10;
                    txt_monthly_readonly.Text = "104.99";
                    txt_speed_readonly.Text = "500Mbps";
                    txt_total_readonly_.Text = total.ToString();
                }
                else if (radio_onegig.IsChecked == true)
                {
                    txt_install.Text = "0";
                    txt_monthly.Text = "104.99";
                    txt_rental.Text = "10";
                    txt_speed.Text = "1 Gb";
                    double total = 104.99 + 10;
                    txt_monthly_readonly.Text = "104.99";
                    txt_speed_readonly.Text = "150Mbps";
                    txt_total_readonly_.Text = total.ToString();
                }
                MessageBox.Show("Successfully created.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
