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
using Tarea3Aplicada1WPF.UI;
using Tarea3Aplicada1WPF.Clases_de_Apoyo;

namespace Tarea3Aplicada1WPF
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EjerciciosCap6 ejerciciosCap6 = new EjerciciosCap6();
            ejerciciosCap6.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Ejercicio1cap7 ejercicio1Cap7 = new Ejercicio1cap7();
            ejercicio1Cap7.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Ejercicio2cap7 ejercicio2Cap7 = new Ejercicio2cap7();
            ejercicio2Cap7.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap7 ejercicio5Cap7 = new Ejercicio5cap7();
            ejercicio5Cap7.Show();
        }

    }
}
