   M S B A M L   `   `   `  ����I  ETAXONANASTASON, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TAXONANASTASONTAXONANASTASON  5   	   !    TAXONANASTASON.Autorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TAXONANASTASON     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Авторизация��5	   	   $	��450��6   $	��500��6*   $��Century Gothic)�67    � WindowStyle$
 None=�6S    � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�6|   ��5
      �� 5   
    �� ImageSource$ /pictures/background.jpg��6   6>   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   6.   �� 5      $
��0.8* �6   6.   �� 5      $
��0.1* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6-   �� 5      $
��0.8* �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   �� -   5         ��Name$
 exit��5      ���#504d49 � ToolTip$ Закрыть��6H   $��0��6Z   $��30��6g   $��30��6s   $��2��6~   
������ 
������  /  +MaterialDesignFloatingActionMiniLightButton#��[  6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]	   Kind$	 	ExitToApp=�6&   $��22��67   $��22��6C   5      �� 5   
   -   5        $
 back��5      ���#504d49$3 -Вернуться в главное меню��6H   $��0��6k   $��30��6x   $��30��6�   $��1��6�   $��Center=�6�   $��Right=�6�   
������ 
������ #��[  6	  .��5        $	 	ArrowBack=�6&   $��22��67   $��22��6C   5      � 5   
   $��1��6   $��1��6   .+�5       �� $
��0,20q�6   
 �� RadiusY$
 12��6'    �� RadiusX$ 12��64    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         Color$ DarkBlue��6'      	Direction$ 0Q�68      
BlurRadius$ 15Q�6F      RenderingBias$ Quality=�6V      ShadowDepth$ 1Q�6n   6�   5$      5%      � 5'   
   $��1��6   $��1��6   $
��0,50q�6,   .+�5(      �� $��ВХОД��6   $��1��6$   $��1��64   $��Center=�6A   $��33(�6^   ���#504d49$��	UltraBold"�6�   $��Italic$�6�   6�   �� 5)      $��1��6   $��1��6*   $��10,50,10,-30q�67   .+�5*      �� -   5        $��LoginBox��5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
ЛОГИН��6+   $��18(�6R    % !MaterialDesignFloatingHintTextBox#��[ 6`   $
��0,10q�6�   G� 5+      -   5        $��PassBox��5+      $ ПАРОЛЬ��6-   $��18(�6U    ) %MaterialDesignFloatingHintPasswordBox#��[ 6c   $
��0,10q�6�   5,      �� 5-      -   5        $ entryButton��5-      $��Center=�6D   $��Bottom=�6a   $��35��6|   $	��170��6�   $��50��6�   $	��300��6�   $��
ВОЙТИ��6�   ���#504d496�   5.      5/      51      