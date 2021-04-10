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
using System.Collections.ObjectModel;

namespace LabWork2Question2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent(); 
            txtcategory.Items.Add("Adventure");
            txtcategory.Items.Add("Classics");
            txtcategory.Items.Add("Science");
            txtcategory.Items.Add("Fiction");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 list = new Window3();
            list.Show();
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                if (checkbox1.IsChecked == true)
                {
                    nextbtn.IsEnabled = true;
                }
                else
                {
                    nextbtn.IsEnabled = false;
                }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtcategory.SelectedItem.ToString() == "Adventure")
            {
                txtbook.Items.Clear();
                txtbook.Items.Add("The Odyssey");
                txtbook.Items.Add("Gulliver's Travels");
                txtbook.Items.Add("Moby-Dick");
                txtbook.Items.Add("Treasure Island");
                txtbook.Items.Add("King Solomon's Mines");
                txtbook.Items.Add("The Adventures of Huckleberry Finn");
                txtbook.Items.Add("Heart of Darkness");
                txtbook.Items.Add("The Call of the Wild");
                txtbook.Items.Add("The Sheltering Sky");
                txtbook.Items.Add("The Road");
            }
            if (txtcategory.SelectedItem.ToString() == "Classics")
            {
                txtbook.Items.Clear();
                txtbook.Items.Add("Pride and Prejudice");
                txtbook.Items.Add("To Kill a Mockingbird ");
                txtbook.Items.Add("The Great Gatsby");
                txtbook.Items.Add("One Hundred Years of Solitude");
                txtbook.Items.Add("In Cold Blood");
                txtbook.Items.Add("Wide Sargasso Sea");
                txtbook.Items.Add("Brave New World ");
                txtbook.Items.Add("I Capture The Castle");
                txtbook.Items.Add("Jane Eyre");
                txtbook.Items.Add("Crime and Punishment ");

            }
            if (txtcategory.SelectedItem.ToString() == "Science")
            {
                txtbook.Items.Clear();
                txtbook.Items.Add("The Feynman Lectures on Physics");
                txtbook.Items.Add("Cosmos");
                txtbook.Items.Add("Pale Blue Dot: A Vision of the Human Future in Space");
                txtbook.Items.Add("Gödel, Escher, Bach: An Eternal Golden Braid ");
                txtbook.Items.Add("A Short History of Nearly Everything");
                txtbook.Items.Add("The Greatest Show on Earth: The Evidence for Evolution");
                txtbook.Items.Add("The Universe in a Nutshell ");
                txtbook.Items.Add("A Brief History of Time");
                txtbook.Items.Add("The Selfish Gene");
                txtbook.Items.Add("Thinking, Fast and Slow");
            }
            if (txtcategory.SelectedItem.ToString() == "Fiction")
            {
                txtbook.Items.Clear();
                txtbook.Items.Add("Fahrenheit 451");
                txtbook.Items.Add("The Paying Guests");
                txtbook.Items.Add("Jane Eyre");
                txtbook.Items.Add("The Vegetarian");
                txtbook.Items.Add("Lord of the Flies");
                txtbook.Items.Add("Frankenstein");
                txtbook.Items.Add("Harry Potter and the Sorcerer's Stone");
                txtbook.Items.Add("Fahrenheit 451");
                txtbook.Items.Add("The Hobbit");
                txtbook.Items.Add("The Hunger Games");
                txtbook.Items.Add("Invisible Man");
                txtbook.Items.Add("The Shining");
                txtbook.Items.Add("Midnight's Children");
                txtbook.Items.Add("Lolita");

            }
        }

        private void txtbook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public static ObservableCollection<String> booklst = new ObservableCollection<string>();
        Window3 window3 = new Window3();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            booklst.Add(txtbook.Text.ToString());
            MessageBox.Show(txtbook.SelectedItem.ToString()+" "+"added to your list!");
            
        }

       
    }
}
