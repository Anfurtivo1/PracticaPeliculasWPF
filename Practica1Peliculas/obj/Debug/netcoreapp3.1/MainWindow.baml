   M S B A M L   `   `   `  ����M  IPractica1Peliculas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Practica1PeliculasPractica1Peliculas  5   	   O,clr-namespace:Practica1Peliculas.VistaModeloPractica1Peliculas.VistaModelo  5   	   #    Practica1Peliculas.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Practica1Peliculas     5   	   ;vm,clr-namespace:Practica1Peliculas.VistaModelo     5   	     � Title$  Alquiler peliculas��5	   	   $	��450��6$   $	��800��61    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ vm:Comandos.Anadir��5      6S     5   
   -   5        $ vm:Comandos.Modificar��5      6Y     5   
   -   5        $ vm:Comandos.Eliminar��5      6W    � 	Resources 5         img �� 
TargetType �� Property �� Value5  /Practica1Peliculas.VistaModelo.DefaultViewModel  PeliculasColeccion��%�   &	        &	 �     �� 5   
   " ��6   .�5      ��  � ��$	 130��6&   �� 5       � ��$	 130��6'   �� 5       � ��$ 3q�6'   �� 5       � ��$ UniformToFill=�6(   5        5   
   6:   5       � DataContext 5        5   
   .��5      �  � ColumnDefinitions 5    
   �� 5!      $
��395* �6   �� 5"      $
��406* �6   .+�5$   
   �� -   5        $��	btnAnadir��5$      $��vm:Comandos.Anadir��6"   $��Añadir��6?   $��1��6P   $
��Left=�6`   $��
190,70,0,0q�6{   $	��Top=�6�   6�   �� 5%   
   -   5        $��btnModificar��5%      $��vm:Comandos.Modificar��6%   $��	Modificar��6E   $��1��6Y   $
��Left=�6i   $��182,110,0,0q�6�   $	��Top=�6�   6�   �� 5&   
   -   5        $��btnEliminar��5&      $��vm:Comandos.Eliminar��6$   $��Eliminar��6C   $��1��6V   $
��Left=�6f   $��186,150,0,0q�6�   $	��Top=�6�   6�   �� 5'   
   -   5        $��btnGuardarBD��5'      $��Guardar en BD��6%   $��1��6=   $
��Left=�6M   $��168,190,0,0q�6h   $	��Top=�6}   6�   �� 5)   
   -   5        	 ��Name$	 Lista��5)      ��6"   �� 
 �� Source#
 [  �� Path$ PeliculaList���5*      �� 5,      .R�5-      � $	��269��6    5.      �� 5/      $
��146* �6/   �� 50      $
��123* �6/   .+�52      �� $��1��6%   .+�53      ��  �� Orientation$ 
Horizontal=�6)   $	��168��6B   .+�54   "   �� $��Titulo:��6,   �� 55   "   ��6,   �� *Titulo+56      �� 57      $ 
Horizontal=�6)   $	��168��6B   .+�58   "   �� $��Director/a:��6,   �� 59   "   ��6,   �� *
Director+5:      �� 5;      $ 
Horizontal=�6)   $	��168��6B   .+�5<   "   �� $��
Argumento:��6,   �� 5=   "   ��6,   �� *	Argumento+5>      5?      �� 5@      $ Vertical=�6%   .+�5A      �� $
��Left=�6$   #��[  6?   $��/Imagenes/Imagen1.png��6\   �� 5B      $ 
Horizontal=�6)   .+�5C   "   �� $ 
Horizontal=�6-   .+�5D   &   �� $��Genero:��60   �� 5E   &   ��60   �� *Genero+5F   #   �� 5G   "   $��4q�6,   �� 5H   "   $ 
Horizontal=�6-   .+�5I   &   �� $��Año:��60   �� 5J   &   ��60   �� *Ano+5K   #   5L      5M      5N      5O      5Q      5R      5S      