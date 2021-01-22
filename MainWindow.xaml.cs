using System;
using System.Collections;
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

namespace ImagesV0._2
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
      
        public void reg0123(int R0, int R1, int R2, int R3)
        {
            reg0.Content = R0;
            reg1.Content = R1;
            reg2.Content = R2;
            reg3.Content = R3;
        }
        private void Compilate_Click(object sender, RoutedEventArgs e)
        {
            
            if (mof1.Text.Equals("0"))
            {
                reg0.Content = mof2.Text;
            }       
            else
            if (mof1.Text.Equals("1"))
            {
                reg1.Content = mof2.Text;
            }
            else
            if (mof1.Text.Equals("2"))
            {
                reg2.Content = mof2.Text;
            }
            else
            if (mof1.Text.Equals("3"))
            {
                reg3.Content = mof2.Text;
            }
            else
            {
                MessageBox.Show("Error\nOnly 0-3 (R0, R1, R2, R3)");
            }

        }



        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            window.Show();
            Close();
        }

        private void Mof1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Mof2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Addb_Click(object sender, RoutedEventArgs e)
        {
            if (mof1.Text.Equals("0"))
            {
                reg0.Content = mof2.Text;
            }
            else
           if (mof1.Text.Equals("1"))
            {
                reg1.Content = mof2.Text;
            }
            else
           if (mof1.Text.Equals("2"))
            {
                reg2.Content = mof2.Text;
            }
            else
           if (mof1.Text.Equals("3"))
            {
                reg3.Content = mof2.Text;
            }
            else
            {
                MessageBox.Show("Only 0-3 (R0, R1, R2, R3)");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enter 1, 2 \n res=R1=2");
        }
    }
}
