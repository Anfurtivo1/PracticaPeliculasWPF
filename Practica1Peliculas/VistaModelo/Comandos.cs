using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Practica1Peliculas.VistaModelo
{
    class Comandos
    {
        public static readonly RoutedUICommand Anadir = new RoutedUICommand(
               "Accion que añade una pelicula a la lista",
               "Anadir",
               typeof(Comandos),
               new InputGestureCollection()
               {
                    new KeyGesture(Key.P,ModifierKeys.Control)
               }
           );


        public static readonly RoutedUICommand Modificar = new RoutedUICommand(
               "Accion que modifica una pelicula de la lista",
               "Modificar",
               typeof(Comandos),
               new InputGestureCollection()
               {
                    new KeyGesture(Key.M,ModifierKeys.Control)
               }
           );


        public static readonly RoutedUICommand Eliminar = new RoutedUICommand(
               "Accion que elimina una pelicula de la lista",
               "Eliminar",
               typeof(Comandos),
               new InputGestureCollection()
               {
                    new KeyGesture(Key.E,ModifierKeys.Control)
               }
           );



    }
}
