   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TAXONANASTASONTAXONANASTASON  5   	       TAXONANASTASON.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TAXONANASTASON     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��MainWin��5
   3   $	��450��5	   	   $	��700��6   $	��300��6'   $	��500��67     � Title$  Банк SAP��5
   	   $	��450��6   $	��500��6'   $��Century Gothic)�5   	    � WindowStyle$
 None=�6%    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   ��5      �� 5   
    �� ImageSource$ /pictures/background.jpg��6   6>   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��	MainLabel��5      $��10(�6!   ���#504d49$��Italic$�6D   $��	UltraBold"�6W   .��6n   !ТАКСОН АНАСТАСОН6�   �� 5   
   -   5         ��Name$
 exit��5      ���#504d49 � ToolTip$ Закрыть��6H   $��0��6Z   $��22��6g   $��30��6s   $��1��6~   $��Right=�6�   $	��Top=�6�   
������ 
������  /  +MaterialDesignFloatingActionMiniLightButton#��[  6�   $��	0,10,10,0q�6;  .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]	   Kind$	 	ExitToApp=�6&   $��22��67   $��22��6C   5      �� 5   
   $��0��6   $��1��6%   $��	UltraBold"�63   $��Center=�6J   $��Center=�6f   $��25(�6�   $��Italic$�6�   ���#504d49$��ВХОД��6�   z�5      T� 5      
 T� X$
 3Q�6%    T� Y$ 1Q�6+   5       �� 5!   
   $��1��6   $��1��6%   $��	UltraBold"�63   $��Center=�6J   $��Center=�6f   $��25(�6�   $��Italic$�6�   ���#504d49$��РЕГИСТРАЦИЯ��6�   z�5"      T� 5#      $
 3Q�6%   $ 1Q�6+   5%      �� 5&   
   -   5        $ EntryButton��5&   ;   $��	UltraBold"�6   $��Italic$�6(   $��ВХОД��6P   $��25(�6`   ���#E1d3c1
������ 
������ $��0��6�   $��1��6�   $
��auto��6�    # MaterialDesignRaisedLightButton#��[ 6�   �� 5'   
   -   5        $ RegistrationButton��5'   ;   $��	UltraBold"�6   $��Italic$�6(   $��РЕГИСТРАЦИЯ��6W   $��25(�6n   ���#E1d3c1
������ 
������ $��1��6�   $��1��6�   $
��auto��6�   #��[ 6  5(      5)      