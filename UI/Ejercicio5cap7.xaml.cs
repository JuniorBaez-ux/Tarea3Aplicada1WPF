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
using Tarea3Aplicada1WPF.Clases_de_Apoyo;
using System.Collections;

namespace Tarea3Aplicada1WPF.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio5cap7.xaml
    /// </summary>
    public partial class Ejercicio5cap7 : Window
    {
        public AgendaTelefonica agenda = new AgendaTelefonica();
        public Hashtable hagenda = new Hashtable();
        public Ejercicio5cap7()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            agenda.nombre = PalabraTextBox.Text;
            agenda.NumeroTelefono = DefinicionTextBox.Text;
            MessageBox.Show("Guardado con exito!");

            hagenda.Add(agenda.nombre, agenda.NumeroTelefono);
            LlenarDataGrid();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void LlenarDataGrid()
        {
            DiccionarioDataGrid.ItemsSource = null;
            if (hagenda.Count > 0)
            {
                DiccionarioDataGrid.ItemsSource = hagenda;
            }
        }
    }
}
