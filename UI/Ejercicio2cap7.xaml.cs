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
using System.Collections;
using Tarea3Aplicada1WPF.Clases_de_Apoyo;

namespace Tarea3Aplicada1WPF.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio2cap7.xaml
    /// </summary>
    public partial class Ejercicio2cap7 : Window
    {
        public Diccionario diccionario = new Diccionario();
        public Hashtable hdiccionario = new Hashtable();
        public Ejercicio2cap7()
        {
            InitializeComponent();
        }
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            //hdiccionario.Remove();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Diccionario diccionario = new Diccionario();

            diccionario.palabra = PalabraTextBox.Text;
            diccionario.definicion = DefinicionTextBox.Text;
            MessageBox.Show("Guardado con exito!");

            hdiccionario.Add(diccionario.palabra, diccionario.definicion);
            LlenarDataGrid();
        }

        private  void Limpiar()
        {
            hdiccionario.Clear();
        }

        public void LlenarDataGrid()
        {
            DiccionarioDataGrid.ItemsSource = null;
            if (hdiccionario.Count > 0)
            {
                DiccionarioDataGrid.ItemsSource = hdiccionario;
            }
        }


    }
}
