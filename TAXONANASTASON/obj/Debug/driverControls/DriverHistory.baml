   M S B A M L   `   `   `  ����  TAXONANASTASON1    +TAXONANASTASON.driverControls.DriverHistory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��
DriverTrip��5   *   $��Century Gothic)�6   .��5
      � ���#f0bd48  � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      $
��0.1* �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��0.6* �6   �� 5      $��10 �6   .+�5   
   � $��1��6   $��1��6   �� 5   
   -   5        $��DriverHistoryButton��5      $��Center=�6O   $��Center=�6l   ���#504d49
����������#707870$4��.ПОКАЗАТЬ ИСТОРИЮ ПОЕЗДОК��6�   $��1��6�   $��1��6�   $	��300��6  $��40��6  $��0, 0, 200, 0q�6  � 5   
   $��2��6   $��1��6   $��2��6,   $��	0,20,10,0q�6@   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��DataGridTrip��5   ,   ���#E1d3c1$y�Hidden=�6A      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6V    J� Opacity$	 0.7Q�6i      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     
IsReadOnly .    AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Начало поездки��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *	StartDate+6G     5      $
 Конец поездки��6H    6)   �� *
FinishDate+6H     5       $
 Откуда��6W    6)   �� *FromAddress.Street.Street+6W     5!      $
 Куда��6V    6)   �� *ToAddress.Street.Street+6V     5"      $
 Клиент��6L    6)   �� *Client.Surname+6L     5#      $
 
Тариф��6C    6)   �� *Tarif+6C     5$      $
 
Сумма��6C    6)   �� *Summa+6C     5%      $
 Расстояние��6F    6)   �� *
Distance+6F     5&      $
 Оценка��6D    6)   �� *Rating+6D   5(      5)      5*      5+      