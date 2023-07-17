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
    /// Lógica de interacción para MConductor.xaml
    /// </summary>
    public partial class MConductor : Window
    {
        public MConductor()
        {
            InitializeComponent();
        }

        private void BtnDisponible_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BtnDisponible.Background = Brushes.Green;
                BtnDisponible.Content = "Disponible";
                BtnNoDisponible.Background = Brushes.Gray;
                BtnNoDisponible.Content = "";
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.Message);
            }
        }

        private void BtnNoDisponible_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BtnNoDisponible.Background = Brushes.Red;
                BtnNoDisponible.Content = "NoDisponible";
                BtnDisponible.Background = Brushes.Gray;
                BtnDisponible.Content = "";

            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.Message);
            }
        }

        
    }
}
