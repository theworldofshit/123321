using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ImagesV0._2
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register window = new Register();
            window.Show();
            Close();
        }
        /*
             *  private void CheckBox_Checked(object sender,EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                MessageBox.Show("" + checkBox.Text + "  ");
            }
            else
            {
                MessageBox.Show(" " + checkBox.Text + "  ");
            }
        }
             */
        private void Button1_Click23(object sender, RoutedEventArgs e)
        {
            Accounts window = new Accounts
                                             ();
            window.Show
                                             ();
            Close
                                             ();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Accounts.mdf';Integrated Security=True");
            string query = "Select * from Tables where login = '" + loginenter.Text.Trim() + "' and password = '" + passwordBox.Password.Trim() + "'";
            SqlDataAdapter Queue = new SqlDataAdapter(query, connect);
            DataTable zapros = new DataTable
                                            ();
            

            Queue.Fill(zapros);
            if (zapros.Rows.Count == 1)
            {
                MessageBox.Show("Succsess");
                MainWindow window = new MainWindow
                                            ();               
                window.Show
                                            ();
                Close
                                            ();
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }
        
        private void Button1_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow
                                             ();
            window.Show
                                             ();
            Close
                                             ();
        }

          
        int k = 0;
        private void Buttcount(object sender, EventArgs e)//dobavit morkov zaicy
        {
         
            if (k >= 9)
            {
                count.Content = "";
                bunnyc.Content = "(u) (u)\n  (*.*) Hi! \n ('').('')";
            }
            else
            {
                k++;
                count.Content = k;
            }
          
        }

        private void Loginenter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /*




private void RadioButton_Checked(object sender, RoutedEventArgs e)
{
   RadioButton radioButton = (RadioButton)sender;
   if (radioButton.Checked)
   {
       MessageBox.Show("Вы выбрали " + radioButton.Text);
   }
}
*/
    }
    }

