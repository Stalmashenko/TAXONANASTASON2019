   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:TAXONANASTASON.userControlsTAXONANASTASON.userControls  5      )    #TAXONANASTASON.userControls.History   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:TAXONANASTASON.userControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��userTrip��5   *   $��Century Gothic)�6   .��5      � ���#f0bd48  � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      $
��0.1* �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��0.6* �6   �� 5      $��10 �6   .+�5   
   � $��1��6   $��1��6   �� 5   
   -   5        $��MyHistoryButton��5      $��Center=�6F   $��Center=�6c   ���#504d49
����������#707870$4��.ПОКАЗАТЬ ИСТОРИЮ ПОЕЗДОК��6�   $��1��6�   $��1��6�   $	��300��6�   $��40��6	  $��0, 0, 200, 0q�6  � 5   
   $��2��6   $��1��6   $��2��6,   $��	0,20,10,0q�6@   .+�5      �� -   5        $��Scroll��5   c   $
��Auto=�6   $
��Auto=�6>   $y�Hidden=�6q   .��5      &   System.Windows.Controls.DataGrid  -   5        $��DataGridTrip��5   0   ���#E1d3c1$y�Hidden=�6E      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6Z    J� Opacity$	 0.7Q�6m      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     
IsReadOnly .    AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Начало поездки��6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	StartDate+6K     5!      $
 Конец поездки��6L    6-   �� *
FinishDate+6L     5"      $
 Kуда��6Y    6-   �� *ToAddress.Street.Street+6Y     5#      $
 Откуда��6[    6-   �� *FromAddress.Street.Street+6[     5$      $
 
Тариф��6G    6-   �� *Tarif+6G     5%      $
 
Сумма��6G    6-   �� *Summa+6G     5&      $
 Расстояние��6J    6-   �� *
Distance+6J     5'      $
 Оценка��6H    6-   �� *Rating+6H   5)      5*      5+      5,      5-      