using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Practica1Peliculas.Modelo
{
    public class Pelicula : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _titulo;
        private string _director;
        private string _argumento;
        private string _genero;
        private int _ano;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; raisePropertyChanged(); }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; raisePropertyChanged(); }
        }

        public string Argumento
        {
            get { return _argumento; }
            set { _argumento = value; raisePropertyChanged(); }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; raisePropertyChanged(); }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; raisePropertyChanged(); }
        }

        public Pelicula(string titulo, string director, string argumento, string genero, int ano)
        {
            Titulo = titulo;
            Director = director;
            Argumento = argumento;
            Genero = genero;
            Ano = ano;
        }

        public Pelicula() { }

        private void raisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
