   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TAXONANASTASONTAXONANASTASON  5   	   K*clr-namespace:TAXONANASTASON.adminControlsTAXONANASTASON.adminControls  5   	        TAXONANASTASON.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TAXONANASTASON     5   	   <users*clr-namespace:TAXONANASTASON.adminControls     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��AdminWin��5	        � Title$  AdminWin��5
   	   $	��600��6   $
��1080��6A    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d    � WindowStyle$
 None=�6�   
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
HeaderWork��5-      $ ��АДМИНИСТРАТОР��6+   $��Center=�6@   $��Center=�6]   $��24(�6x   6�   �� 5/      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�50      �� -   5        $��YourName��50      $
��lala��6,   $��Center=�68   $��18(�6S   6c   '  !MaterialDesignThemes.Wpf.PopupBox  51      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 52      �� $	��160��6!   .+�53      �� -   5        $��14(�53   !   $��Мой профиль��6/   6g   �� 54      -   5        $��ChangePassword��54   !   $��14(�67   $#��Изменить пароль��6E   6   �� 55      -   5        $	��XML��55   !   $��14(�6?   $	��XML��6M   6^   �� 56      �� 57      -   5         ��Name$ ButtonPopUpLogout��57   /   $��14(�6!   $��
Выход��6J   6|   58      59      5:      5;      � 5<   
   -   5         �Name$ GridMenu��5<   =   $��0��6   $��0��6   $��2��6,   $��60��6O   $
��Left=�6Z   ���#504d49.+�5>      �� .+�5?      � $	��150��6   ���#e1d3c1.+�5@      �� -	   5        $ ButtonCloseMenu��5@      $��60��66   $��60��6A   $	��top=�6{   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5A      '  !MaterialDesignThemes.Wpf.PackIcon  ���#186059�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6G   $��25��6X   $��25��6c   5B      �� 5C      -
   5        $ ButtonOpenMenu��5C      $��60��65   $��60��6@   $	��top=�6z   $��Right=�6�   ��6L   Z� ��6b   Z� .��5D        ���#186059$
 Menu=�6G   $��25��6S   $��25��6^   5E      5F      �� 5G      $ 
Horizontal=�6   .+�5H        $ 	FaceAgent=�6.   $��25��6?   $��25��6J   $��15q�6V   $��Center=�6b   6   �� 5I      -   5        $ MyProfileButton��5I      
�������$$��Мой профиль         ��6h   $��Century Gothic)�6�    $  MaterialDesignRaisedAccentButton#��[ 6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �#6795A0��6�   Z� ��6�   Z� 6<  5J      �� 5K      $ 
Horizontal=�6   .+�5L        $	 Add=�6.   $��25��69   $��25��6D   $��15q�6Q   $��Center=�6]   6z   �� 5M      -   5        $ CreateAdmin��5M      $)��#Создать админа        ��6L   $��Century Gothic)�6n   
�������#��[ 6�    �#6795A0��6�   Z� ��6�   Z� 65  5N      �� 5O      $ 
Horizontal=�6   .+�5P        $ AccountsAdd=�6.   $��25��6A   $��25��6L   $��15q�6X   $��Center=�6e   6�   �� 5Q      -   5        $ CreateDriver��5Q      $0��*Создать водителя           ��6N   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6<  5R      �� 5S      $ 
Horizontal=�6   .+�5T        $ Users=�6.   $��25��6;   $��25��6F   $��15q�6R   $��Center=�6_   6|   �� 5U      -   5        $ Trips��5U      $(��"Пользователи          ��6@   
�������$��Century Gothic)�6u   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6)  5V      �� 5W      $ 
Horizontal=�6   .+�5X        $ Information=�6.   $��25��6A   $��25��6L   $��15q�6X   $��Center=�6e   6�   �� 5Y      -   5        $
 Info��5Y      $��Поездки           ��6>   
�������$��Century Gothic)�6o   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6#  5Z      5[      5\      ,   &TAXONANASTASON.adminControls.MyProfile  5]   
   -   5          Name$ ucMyProfile��5]      $��1��6/   $��1��6<   $y�Hidden=�6L   6b   1   +TAXONANASTASON.adminControls.ChangePassword  5^   
   -   5          Name$ ucMyPassword��5^      $��1��65   $��1��6B   $y�Hidden=�6R   6h   /   )TAXONANASTASON.adminControls.CreateDriver  5_   
   -   5          Name$ ucAddDriver��5_      $��1��62   $��1��6?   $y�Hidden=�6O   6f   .	   (TAXONANASTASON.adminControls.CreateAdmin	  5`   
   -   5         	 Name$ 
ucAddAdmin��5`      $��1��60   $��1��6=   $y�Hidden=�6M   6d   ,
   &TAXONANASTASON.adminControls.CheckInfo
  5a   
   -   5         
 Name$ ucInfo��5a      $��1��6+   $��1��68   $y�Hidden=�6H   6^   &    TAXONANASTASON.adminControls.XML  5b   
   -   5          Name$ ucXML��5b      $��1��6$   $��1��61   $y�Hidden=�6A   6W   (   "TAXONANASTASON.adminControls.users  5c   
   -   5          Name$ ucUSERS��5c      $��1��6'   $��1��64   $y�Hidden=�6D   6[   5d      5e      