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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
             
            foreach(string element in Window2.booklst)
            {
                booklist.Items.Add(element.ToString());
            }
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 addbook = new Window2();
            addbook.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You succesfully deleted"+" "+ booklist.SelectedItem.ToString()+" "+"from your list!");
            Window2.booklst.Remove(booklist.SelectedItem.ToString());
            booklist.Items.Remove(booklist.SelectedItem);
            
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
