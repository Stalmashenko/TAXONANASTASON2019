   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TAXONANASTASONTAXONANASTASON  5   	   !    TAXONANASTASON.registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TAXONANASTASON     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   
���   �  � Title$  Регистрация��5
   	   $	��800��6   $	��800��6*   $��Century Gothic)�67   $y�Visible=�6S    � WindowStyle$
 None=�6h    � 
ResizeMode$ NoResize=�6{    � WindowStartupLocation$ CenterScreen=�6�   ��5      �� 5   
    �� ImageSource$ /pictures/background.jpg��6   6>   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   6.   �� 5      $��* �6   6+   �� 5      $
��0.1* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $��* �6   6)   �� 5      $��0 �6   6)   .+�5   
   �� -   5         ��Name$
 exit��5      ���#504d49 � ToolTip$ Закрыть��6H   $��0��6Z   $��30��6g   $��30��6s   $��2��6~   
������ 
������  /  +MaterialDesignFloatingActionMiniLightButton#��[  6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]	   Kind$	 	ExitToApp=�6&   $��22��67   $��22��6C   5      �� 5   
   -   5        $
 back��5      ���#504d49$3 -Вернуться в главное меню��6H   $��0��6k   $��30��6x   $��30��6�   $��1��6�   $��Center=�6�   $��Right=�6�   
������ 
������ #��[  6	  .��5        $	 	ArrowBack=�6&   $��22��67   $��22��6C   5      �� 5   
   $��1��6   $��0��6$   $��РЕГИСТРАЦИЯ��61   $��Center=�6D   ���#504d49$��33(�6t   $��	UltraBold"�6�   $��Italic$�6�   $��Center=�6�   � 5    
   $��1��6   $��1��6   .+�5!      #  MaterialDesignThemes.Wpf.Card    MaterialDesignBackground#���  6"   .��5"      �� .+�5#      9� -   5        $��first��5#   4   ���#E1D3C1$��Stretch=�6A   $8��2Информация для авторизации��6_   .��5$      �� 
 �� Orientation$
 Vertical=�6%     MaterialDesignBody#���  6<   $��24,-15,24,10q�6y   .+�5%      �� -   5        $��myLogin��5%   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
ЛОГИН��66   $��16(�6]    % !MaterialDesignFloatingHintTextBox#��[ 6k   G� 5&      -   5        $��
myPassword��5&   *   $ ПАРОЛЬ��6=   $��16(�6e    ) %MaterialDesignFloatingHintPasswordBox#��[ 6s   5'      5(      �� 5)        MaterialDesignDivider#���  6   $��1��6R   $��Stretch=�6]    J� SnapsToDevicePixels . 6{   9� 5*      -   5        $��second��5*   4   ���#E1D3C1$��Stretch=�6B   $&�� Информация о себе��6`   |�.  .��5+      �� $
 Vertical=�6%   #���  6<   $��24,-15,24,10q�6x   .+�5,      �� -   5        $��	mySurname��5,   '   $ ФАМИЛИЯ��68   $��16(�6a   #��[ 6o   �� 5-      -   5        $��myFirstname��5-   '   $ ИМЯ��6:   $��16(�6_   #��[ 6m   �� 5.      -	   5        $��myCardID��5.   &   $! НОМЕР КАРТОЧКИ��66   $��16(�6f   #��[ 6t   �� 5/      -
   5        $��myPhone��5/   '   $# Формат: +375ХХ1234567��66   $' !МОБИЛЬНЫЙ ТЕЛЕФОН��6V   $��16(�6�   #��[ 6�   �� 50      -   5        $ Create��50   %   $��СОЗДАТЬ��65   $��Right=�6G    $  MaterialDesignRaisedAccentButton#��[ 6c   $	��150��6�   ���#504d49
����������#707870$��0,5,5,0q�6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback
 �����6'  51      52      53      54      55      56      57      