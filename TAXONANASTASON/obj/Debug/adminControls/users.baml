   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TAXONANASTASON.adminControlsTAXONANASTASON.adminControls  5      (    "TAXONANASTASON.adminControls.users   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:TAXONANASTASON.adminControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��AllUsers��5   *   $��Century Gothic)�6   .��5      � ���#f0bd48  � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      $
��0.1* �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��0.6* �6   �� 5      $��10 �6   .+�5   
   � $��1��6   $��1��6   �� 5   
   $��1��6   $��1��6"   $	��Top=�62   $
��Left=�6J    �� Orientation$ 
Horizontal=�6e   .+�5      �� -   5        $��
AllDrivers��5      $
��Left=�6@   $��Center=�6[   ���#504d49
����������#707870$��ВОДИТЕЛИ��6�   $	��195��6�   $��40��6�   $��2��6�   �� 5      -   5        $��
AllClients��5      $
��Left=�6@   $��Center=�6[   ���#504d49
����������#707870$��КЛИЕНТЫ��6�   $	��195��6�   $��40��6�   5      � 5"   
   $��2��6   $��1��6   $��2��6,   $��
0,20,90,50q�6@    5#      �� 5$      $	��16* �6#   �� 5%      $	��19* �6#   .+�5(      �� -   5        $��XMLParse��5(   2   $��Center=�6   $��Bottom=�6Y   $	��XML��6t   $��129,0,131,-53q�6�   6�   �� 5)      -   5        $��	XMLExport��5)   2   $��Center=�6   $��Bottom=�6[   $��EX��6v   $��231,0,29,-53q�6�   6�   &   System.Windows.Controls.DataGrid  5+      -   5        $��DataGridDrivers��5+   ,   ���#E1d3c1   AutoGenerateColumns .  $y�Hidden=�6b      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6w    J� Opacity$	 0.7Q�6�      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  	   
IsReadOnly	 . $��2��6�   
   Columns
 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Id+6D     5.      $ Фамилия��6I    6-   �� *	Surname+6I     5/      $ Имя��6K    6-   �� *	Firstname+6K     50      $ Отчество��6M    6-   �� *Fathersname+6M     51      $ Телефон��6G    6-   �� *Phone+6G     53      $ Машина��6O    6-   �� *Car.TypeModel+6O   55        57      -   5        $��DataGridClients��57   0   ���#E1d3c1 .  $y�Hidden=�6f   $
 auto 6{   $	 0.7Q�6�    .   .   .  	 . $��2��6�   
 58        59      $	 №��6D    6-   �� *Id+6D     5:      $ Фамилия��6I    6-   �� *	Surname+6I     5;      $ Имя��6K    6-   �� *	Firstname+6K     5<      $ Телефон��6G    6-   �� *Phone+6G     5=      $ 
Карта��6F    6-   �� *Card+6F   5?      5@      5A      5B      