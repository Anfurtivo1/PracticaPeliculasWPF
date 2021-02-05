using Practica1Peliculas.Modelo;
using Practica1Peliculas.VistaModelo;
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

namespace Practica1Peliculas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i=2;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnGuardarBD_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CompruebaAnadir(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void EjecutaAnadir(Object sender, ExecutedRoutedEventArgs e)
        {
            i++;
            Pelicula p = new Pelicula("Titulo " + i, "Director " + i, "Argumento " + i, "Genero " + i, 2015);
            var variable = (DefaultViewModel)this.FindResource("PeliculasColeccion");
            variable.PeliculaList.Add(p);
        }

        private void CompruebaModificar(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (Lista!= null)
            {
                e.CanExecute = Lista.SelectedIndex != -1;
            }
            
        }

        private void EjecutaModificar(Object sender, ExecutedRoutedEventArgs e)
        {

            var variable = (DefaultViewModel)this.FindResource("PeliculasColeccion");

            //MessageBox.Show("El elemento seleccionado era " + Lista.SelectedIndex, "");
            Pelicula p = variable.PeliculaList[Lista.SelectedIndex];
            EditarPelicula ep = new EditarPelicula(p);
            ep.ShowDialog();

        }


        private void CompruebaEliminar(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (Lista != null)
            {
                e.CanExecute = Lista.SelectedIndex != -1;
            }

        }

        private void EjecutaEliminar(Object sender, ExecutedRoutedEventArgs e)
        {
            var variable = (DefaultViewModel)this.FindResource("PeliculasColeccion");
            variable.PeliculaList.RemoveAt(Lista.SelectedIndex);
        }



    }
}
