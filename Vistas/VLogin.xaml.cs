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

namespace AppPrueba.Vistas
{
    /// <summary>
    /// Lógica de interacción para VLogin.xaml
    /// </summary>
    public partial class VLogin : Window
    {
        public VLogin()
        {
            InitializeComponent();
        }

        private void txtMatricula_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            MConductor interfaz1 = new();
            interfaz1.Show();
            Close();
        }
    }
}
