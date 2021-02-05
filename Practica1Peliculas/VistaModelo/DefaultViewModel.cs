using Practica1Peliculas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Practica1Peliculas.VistaModelo
{
    class DefaultViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private PeliculaCollection _peliculaList = new PeliculaCollection();

        public PeliculaCollection PeliculaList
        {
            get { return _peliculaList; }
            set { _peliculaList = value; raisePropertyChanged(); }
        }

        public DefaultViewModel()
        {
            PeliculaList.Add(new Pelicula()
            {
                Titulo = "Titulo1",
                Director = "Director1 ",
                Argumento="Argumento1",
                Genero ="Genero1",
                Ano = 2000
            });

            PeliculaList.Add(new Pelicula()
            {
                Titulo = "Titulo2",
                Director = "Director2 ",
                Argumento = "Argumento2",
                Genero = "Genero2",
                Ano = 2010
            });
        }

        private void raisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
