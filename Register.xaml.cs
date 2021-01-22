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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login
                ();
            window.Show
                ();
            Close
                ();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Accounts.mdf';Integrated Security=True"))
            {
                try
                {
                    connect.Open();
                    SqlCommand Save = new SqlCommand("UserAdd", connect);
                    //new Exception(ex);
              /*   ex1: */  Save.CommandType = CommandType.StoredProcedure;
                   /*   ex2: */  Save.Parameters.AddWithValue("@login", login1.Text.Trim());
                        /*   ex3: */ Save.Parameters.AddWithValue("@password", pbox.Password.Trim());//pomenat znaki hide
                    Save.ExecuteNonQuery();
                    MessageBox.Show("Succsess");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);            
                }

                finally
                {   
                    
                }

            }
        }
    }
}
