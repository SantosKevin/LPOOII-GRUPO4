   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	       Vistas.WinPelis   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      
������   � Triggers  5
      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      t�  g� Duration$ 0:0:0.3D�6)    �� TargetProperty$ Margin�6<    t� From$ 0,-500,0,500X�6_   	 t� To$ 0X�6s    g� DecelerationRatio$ .9Q�6z   W� 5      $ 0:0:0.3D�6&   $ Opacity�69    W� From$ 0X�6]   	 W� To$ 1X�6f   5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $
��0.2* �6   6.   �� 5      $
��0.4* �6   6.   �� 5      $
��0.4* �6   6.   �� 5      $
��0.2* �6   6.   
 � RowDefinitions
 5   
   �� 5      $��0.15* �6   6-   �� 5      $��0.15* �6   6-   �� 5      $
��0.8* �6   6,   �� 5       $
��0.1* �6   6,   .+�5,   
   �� $
��auto��6   $��4��6    $��0��64   ._�5.      �� $��GESTION DE PELICULAS��6   $��Center=�64   $��Center=�6O   $��	0,10,0,10q�5/      $��Century Gothic)�50      $��22(�64   $
��Bold"�6B   $��	Underline{�51      
�������6I   52      ]� 54   
   ��. $��1��6)   $��1��69   $
��auto��6F   $��Center=�55      $��0,0,0,8q�6/   .+�58      "  FontAwesome.WPF.ImageAwesome     Icon$ Search=�6   $��Right=�6,   $��25��6C   $��10,0,0,5q�6N      
Foreground
 �����6u   �� 5:      -   5         ��Name$ btnBuscarPeli��5:      $��30��6-   $
��Left=�69   $��Buscar Pelicula...��5;      $��18(�61   $��5,0,0,0q�6?   $��0,10,0,5q�6Q   5=      �� 5?   
   $��2��6   $��1��6!   $��0,0,0,8q�6.   $��Center=�6?   ._�5@      �� $��Right=�6   $��Right=�61   $��Center=�6M   .+�5A      �� -   5        $��MyBorder��5A   W   ���	#FF47E000$��10,0,0,0q�61   $��3q�6C   $��42��5B      
������  �� CornerRadius$ 10��5E      ._�5F      �� -   5         ��Name$ btnAgregarPeli��5F      $��0q�65   
�������$
��auto��5G   4   
������ $��20(�5I   !   $��Century Gothic)�6/   $
��Bold"�5J       � Cursor$
 Hand��6/   .��5L      ��  �� Orientation$ 
Horizontal=�6%   .+�5M      �� $��Agregar Pelicula��6(   ���	#FF47E000$��10,0,0,0q�6W   $��18(�6i   6y     5N      $
 Film=�6.    �	#FF47E000$��	10,0,10,0q�6Q   $��25��6d   6q   5O      5Q      5R      5S      5T      �� 5V   
   $��1��6   $��2��6!   $��2��65   $��3q�6B   
�������$ 4��6j   ._�5W      ]� ��. .+�5Y      &   System.Windows.Controls.DataGrid  $
��auto��6   $
��auto��6-   5[      5]      5_      5a      5b      