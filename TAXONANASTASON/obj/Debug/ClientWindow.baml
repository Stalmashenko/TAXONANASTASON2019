   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TAXONANASTASONTAXONANASTASON  5   	   I)clr-namespace:TAXONANASTASON.userControlsTAXONANASTASON.userControls  5   	   !    TAXONANASTASON.ClientWindow   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   .localclr-namespace:TAXONANASTASON     5   	   ;users)clr-namespace:TAXONANASTASON.userControls     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��	ClientWin��5	        � Title$  	ClientWin��5
   	   $	��600��6   $
��1080��6(    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p   
�������$��Century Gothic)�6�    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63   6@     5      $ 0:0:0.5��6'   $	 200Q�69   6G   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63   6A     5      $ 0:0:0.5��6'   $ 60Q�69   6F   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   6G   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   6H   5       .��5#      � ���#f0bd48 � RowDefinitions 5$   
   �� 5%      $��70 �6   6*   �� 5&      $��* �6   6)    � ColumnDefinitions 5(   
   �� 5)      $	��200 �6   6-   �� 5*      $��* �6   6+   .+�5,   
   � $��0��6   $��0��6   $��2��6,   $��70��6@   ���#504d49$	��Top=�6a   .+�5-      �� -   5        $��
HeaderWork��5-      $%��ТАКСОН АНАСТАСОН��6+   $��Center=�6C   $��Center=�6`   $��24(�6{   6�   �� 5/      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�50      �� -   5        $��YourName��50      $
��lala��6,   $��Center=�68   $��18(�6S   6c   '  !MaterialDesignThemes.Wpf.PopupBox  51      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 52      �� $	��160��6!   .+�53      �� -   5        $��14(�53   !   $��Мой профиль��6/   6f   �� 54      -   5        $$��MyProfileButton_ChangePassword��54   !   $��14(�6G   $#��Изменить пароль��6U   6�   �� 55      �� 56      -   5         ��Name$ ButtonPopUpLogout��56   /   $��14(�6!   $��
Выход��6J   6|   57      58      59      5:      � 5;   
   -   5         �Name$ GridMenu��5;   =   $��0��6   $��0��6   $��2��6,   $��60��6O   $
��Left=�6Z   ���#504d49.+�5=      �� .+�5>      � $	��150��6   ���#e1d3c1.+�5?      �� -   5        $ ButtonCloseMenu��5?      $��60��66   $��60��6A   $	��top=�6{   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5@      '  !MaterialDesignThemes.Wpf.PackIcon  ���#186059�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6G   $��25��6X   $��25��6c   5A      �� 5B      -	   5        $ ButtonOpenMenu��5B      $��60��65   $��60��6@   $	��top=�6z   $��Right=�6�   ��6L   Z� ��6b   Z� .��5C        ���#186059$
 Menu=�6G   $��25��6S   $��25��6^   5D      5E      �� 5F      $ 
Horizontal=�6   .+�5G        $ Person=�6.   $��25��6<   $��25��6G   $��15q�6S   $��Center=�6_   6|   �� 5H      -
   5        $ MyProfileButton��5H      
�������$$��Мой профиль         ��6g   $��Century Gothic)�6�    $  MaterialDesignRaisedAccentButton#��[ 6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �#6795A0��6�   Z� ��6�   Z� 6;  5I      �� 5J      $ 
Horizontal=�6   .+�5K        $
 Taxi=�6.   $��25��6:   $��25��6E   $��15q�6R   $��Center=�6^   6{   �� 5L      -   5        $ MyTripButton��5L      $)��#Заказать такси        ��63   $��Century Gothic)�6o   
�������#��[ 6�    �#6795A0��6�   Z� ��6�   Z� 66  5M      �� 5N      $ 
Horizontal=�6   .+�5O        $ Information=�6.   $��25��6A   $��25��6L   $��15q�6Y   $��Center=�6e   6�   �� 5P      -   5        $ MyCurTripButton��5P      $+��%Текущая поездка        ��66   $��Century Gothic)�6v   
�������#��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6=  5Q      �� 5R      $ 
Horizontal=�6   .+�5S        $ Information=�6.   $��25��6A   $��25��6L   $��15q�6Y   $��Center=�6e   6�   �� 5T      -   5        $ MyLastTripButton��5T      $+��%Оценить поездку        ��67   $��Century Gothic)�6x   
�������#��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6?  5U      �� 5V      $ 
Horizontal=�6   .+�5W        $ History=�6.   $��25��6=   $��25��6H   $��15q�6T   $��Center=�6a   6~   �� 5X      -   5        $ MyHistoryButton��5X   ;   $&�� Моя история           ��6T   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6=  5Y      5Z      5[      &    TAXONANASTASON.userControls.Info  5]   
   -   5          Name$ ucMyProfile��5]      $��1��6*   $��1��67   $y�Hidden=�6G   6]   0   *TAXONANASTASON.userControls.ChangePassword  5^   
   -   5          Name$ ucChangePassword��5^      $��1��6:   $��1��6G   $y�Hidden=�6W   6m   ,   &TAXONANASTASON.userControls.CreateTrip  5_   
   -   5          Name$ ucTrip��5_      $��1��6-   $��1��6:   $y�Hidden=�6J   6`   )	   #TAXONANASTASON.userControls.History	  5`   
   -   5         	 Name$ 	ucHistory��5`      $��1��6,   $��1��69   $y�Hidden=�6I   6_   )
   #TAXONANASTASON.userControls.CurTrip
  5a   
   -   5         
 Name$ 	ucCurTrip��5a      $��1��6-   $��1��6:   $y�Hidden=�6J   6`   ,   &TAXONANASTASON.userControls.FinishTrip  5b   
   -   5          Name$ 
ucLastTrip��5b      $��1��61   $��1��6>   $y�Hidden=�6N   6d   5d      5e      