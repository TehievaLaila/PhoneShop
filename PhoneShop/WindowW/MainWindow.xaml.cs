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
using PhoneShop.BD;
using PhoneShop.WindowW;

namespace PhoneShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static prog13Entities dba = new prog13Entities();
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            foreach(var user in dba.User )
            {
                if(user.ID_Role == '2')
                {
                    if (Log.Text == "" || Pass.Password == "")
                    {
                        MessageBox.Show("Введите данные");
                    }
                    if (Log.Text.Trim() == user.login)
                    {
                        if (Pass.Password.Trim() == user.Password)
                        {
                            App.us = user;
                            MessageBox.Show($"Здравствуйте");
                            GlavWindow glav = new GlavWindow();
                            glav.Show();
                            this.Close();

                        }
                    }
                }
                else
                {
                    if (user.ID_Role == '1')
                    {
                        if (Log.Text == "" || Pass.Password == "")
                        {
                            MessageBox.Show("Введите данные");
                        }
                        if (Log.Text.Trim() == user.login)
                        {
                            if (Pass.Password.Trim() == user.Password)
                            {
                                App.us = user;
                                MessageBox.Show($"Здравствуйте");
                                AdminWindow ad = new AdminWindow();
                                ad.Show();
                                this.Close();

                            }
                        }
                    }
                }
            }
        }
    }
}
