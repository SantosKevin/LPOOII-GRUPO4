   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	       Vistas.WinClientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   
   
������   � Triggers  5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      t�  g� Duration$ 0:0:0.3D�6)    �� TargetProperty$ Margin�6<    t� From$ 0,-500,0,500X�6_   	 t� To$ 0X�6s    g� DecelerationRatio$ .9Q�6z   W� 5      $ 0:0:0.3D�6&   $ Opacity�69    W� From$ 0X�6]   	 W� To$ 1X�6f   5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $
��0.2* �6   6.   �� 5      $
��0.4* �6   6.   �� 5      $
��0.4* �6   6.   �� 5      $
��0.2* �6   6.   
 � RowDefinitions
 5   
   �� 5      $��0.15* �6   6-   �� 5       $��0.15* �6   6-   �� 5!      $
��0.8* �6   6,   �� 5"      $
��0.1* �6   6,   .+�5.   
   �� $
��auto��6   $��4��6    $��0��64   ._�50      �� $��GESTION DE CLIENTES��6   $��Center=�63   $��Center=�6N   $��	0,10,0,10q�51      $��Century Gothic)�52      $��22(�64   $
��Bold"�6B   $��	Underline{�53      
�������6I   54      ]� 56   
   ��. $��1��6)   $��1��69   $��0,0,0,8q�6F   $
��auto��6W   .+�59      "  FontAwesome.WPF.ImageAwesome     Icon$ Search=�6   $��Right=�6,   $��25��6C   $��10,0,0,6q�6N      
Foreground
 �����6u   �� 5;      -   5         ��Name$ btnBuscarPeli��5;      $��30��6-   $
��Left=�69   $��Buscar Cliente...��5<      $��18(�60   $��5,0,0,0q�6>   $��0,10,0,5q�6P   5>      �� 5@   
   $��2��6   $��1��6!   $��0,0,0,8q�6.   ._�5A      �� $��Right=�6   $��Right=�61   $��Center=�6M   .+�5B      �� -   5        $��MyBorder��5B   W   ���	#FF47E000$��10,0,0,0q�61   $��3q�6C   $��42��5C      
������  �� CornerRadius$ 10��5F      ._�5G      �� -   5         ��Name$ btnAgregarCliente��5G      $��0q�68   
�������$
��auto��5H   4   
������ $��20(�5J   !   $��Century Gothic)�6/   $
��Bold"�5K       � Cursor$
 Hand��6/   .��5M      ��  �� Orientation$ 
Horizontal=�6%   .+�5N      �� $��Agregar Cliente��6(   ���	#FF47E000$��10,0,0,0q�6V   $��18(�6h   6x     5O      $ UserPlus=�6.    �	#FF47E000$��	10,0,10,0q�6U   $��25��6h   6u   5P      5R      5S      5T      5U      �� 5W   
   $��1��6   $��2��6!   $��2��65   $��3q�6B   
�������$ 4��6j   ._�5X      ]� ��. .+�5Z      &   System.Windows.Controls.DataGrid  $
��auto��6   $
��auto��6)   5\      5^      5`      5b      5c      