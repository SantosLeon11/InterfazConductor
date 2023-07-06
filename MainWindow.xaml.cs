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

namespace AppPrueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGenR_Click(object sender, RoutedEventArgs e)
        {
            VentanaGenReserva interfaz = new();
            interfaz.Show();
           this.Close();
        }

        private void BtnConR_Click(object sender, RoutedEventArgs e)
        {
            VentanaConReserva interfaz = new ();
            interfaz.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            VentanaLogin interfaz1 = new();
            interfaz1.Show();
            this.Close();
        }
    }
}
