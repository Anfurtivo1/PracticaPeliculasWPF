using Practica1Peliculas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Practica1Peliculas
{
    /// <summary>
    /// Lógica de interacción para EditarPelicula.xaml
    /// </summary>
    public partial class EditarPelicula : Window
    {
        Pelicula p = new Pelicula();
        public EditarPelicula(Pelicula _p)
        {
            p = _p;
            InitializeComponent();
            rellenarCampos();

        }

        public void rellenarCampos()
        {
            txtTitulo.Text = p.Titulo;
            txtDirector.Text = p.Director;
            txtArgumento.Text = p.Argumento;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg";

            if (ofd.ShowDialog() == true)
            {
                Uri fileUri = new Uri(ofd.FileName);
                imgCaratula.Source = new BitmapImage(fileUri);
            }

            
            
        }
    }
}
