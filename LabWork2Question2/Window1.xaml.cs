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

namespace LabWork2Question2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window bookswindow = new Window2();
            if (txtuser.Text.ToString().Equals("tohan") && txtpass.Password.Equals("tohan"))
            {
                MessageBox.Show("Welcome Mr.Tohan");
                bookswindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password. Check again");
            }
        }
    }
}
