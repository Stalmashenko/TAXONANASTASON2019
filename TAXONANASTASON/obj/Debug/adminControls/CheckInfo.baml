   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TAXONANASTASON.adminControlsTAXONANASTASON.adminControls  5      ,    &TAXONANASTASON.adminControls.CheckInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:TAXONANASTASON.adminControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��Information��5   *   $��Century Gothic)�6   .��5      � ���#f0bd48  � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      $
��0.1* �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��0.6* �6   �� 5      $��10 �6   .+�5   
   � $��1��6   $��1��6   �� 5   
   $��1��6   $��1��6"   $	��Top=�62   $
��Left=�6J    �� Orientation$ 
Horizontal=�6e   .+�5      �� -   5        $��AllTrip��5      $��Right=�6:   $��Center=�6V   ���#504d49
����������#707870$��ВСЕ ПОЕЗДКИ��6�   $	��195��6�   $��40��6�   �� 5      -   5        $��CurrentTrip��5      $��Right=�6B   $��Center=�6^   ���#504d49
����������#707870$#��ТЕКУЩИЕ ПОЕЗДКИ��6�   $	��195��6�   $��40��6�   $��2��6�   5      � 5!   
   $��2��6   $��1��6   $��2��6,   $��
0,20,90,50q�6@    5"      �� 5#      �� 5$      $��0* �6#   .+�5&      �� -   5        $��	AllScroll��5&   d   $
��Auto=�6   $
��Auto=�6A   $y�Hidden=�6u   .��5'      &   System.Windows.Controls.DataGrid  -   5        $��DataGridAllTrip��5'   0   ���#E1d3c1   AutoGenerateColumns .  $y�Hidden=�6f      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6{    J� Opacity$	 0.7Q�6�      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  	   
IsReadOnly	 . $��2��6�   
   Columns
 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Id+6D     5*      $! Начало поездки��6K    6-   �� *	StartDate+6K     5+      $ Откуда��6Y    6-   �� *ToAddress.Street.Street+6Y     5,      $ Куда��6[    6-   �� *FromAddress.Street.Street+6[     5-      $ Водитель��6P    6-   �� *Driver.Surname+6P     5.      $ Клиент��6P    6-   �� *Client.Surname+6P     5/      $ Конец поездки��6L    6-   �� *
FinishDate+6L     50      $ 
Тариф��6G    6-   �� *Tarif+6G     51      $ 
Сумма��6G    6-   �� *Summa+6G     52      $ Расстояние��6J    6-   �� *
Distance+6J     53      $ Оценка��6H    6-   �� *Rating+6H   55      56        58      -   5        $��DataGridCurrentTrip��58   ,   ���#E1d3c1 .  $y�Hidden=�6f   $
 auto 6{   $	 0.7Q�6�    .   .   .  	 . 
 59        5:      $	 №��6@    6)   �� *Id+6@     5;      $! Начало поездки��6G    6)   �� *	StartDate+6G     5<      $ 
Тариф��6C    6)   �� *Tarif+6C     5=      $ Откуда��6U    6)   �� *ToAddress.Street.Street+6U     5>      $ Куда��6W    6)   �� *FromAddress.Street.Street+6W     5?      $ Водитель��6L    6)   �� *Driver.Surname+6L     5@      $ Клиент��6L    6)   �� *Client.Surname+6L   5B      5C      5D      5E      