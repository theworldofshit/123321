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
    /// Логика взаимодействия для Accounts.xaml
    /// </summary>
    public partial class Accounts : Window
    {
        public Accounts()
        {
            InitializeComponent();
        }
        //nepravilnaya sortirovka
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = "SELECT * FROM tblEmployee";
            var c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Accounts.mdf';Integrated Security=True"); // m1
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGrid.IsReadOnly = true;
        }

        private void ComeBack_Click(object sender, RoutedEventArgs e)
        {
            Login away = new Login
                ();
            away.Show
                ();
            Close
                ();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // dataGrid.Update();
          //  dataGrid.Refresh();
        }
    }
}
