   M S B A M L   `   `   `  ����O  KLeagueOfLegendsLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:LeagueOfLegendsLogin.WindowsLeagueOfLegendsLogin.Windows  5   	   K*clr-namespace:LeagueOfLegendsLogin.WindowsLeagueOfLegendsLogin.Windows  5   	   1    +LeagueOfLegendsLogin.Windows.WindowSummoner   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:LeagueOfLegendsLogin.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.2.0.1494, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   3uc*clr-namespace:LeagueOfLegendsLogin.Windows  5   	   $��David)�5	   	   $��15(�5
   	   $	��600��5   	   $
��1000��6     � WindowStartupLocation$  CenterScreen=�6#    � 
ResizeMode$ NoResize=�6H    � WindowStyle$
 None=�6^   ���	#FF410A66.��5   
   � -   5        .+�5   
   ]� $��RightToLeft=�6   $
��1000��60   $��30��6=   $	��Top=�6I   .+�5      �� -   5         ��Name$ btn_Exit��5   9   $��2,0,2,0q�6   
�������$��25��6a   $��25��6l    &  "MaterialDesignFloatingActionButton#��[  6x   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ power=�6*   69   5      �� 5      -   5        $ btn_Minimize��5   &   $��2,0,2,0q�6   
�������$
��Left=�6j   $��25��6�   $��25��6�   #��[  6�   .��5        $ WindowMinimize=�6*   6B   5      �� 5      -   5        $ btn_Website��5   &   $��2,0,0,0q�6   
�������$
��Left=�6h   $��25��6�   $��25��6�   #��[  6�   .��5        $	 Web=�6*   67   5      5      � 5   
   $	��400��6   $
��Left=�6   .+�5      �� $��	20,10,0,0q�6   $
��Left=�6,   .+�5      �� $��/Images/logo.png��6   $	��130��62   $��80��6>    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 5Q�6+   5       5!      �� 5#      
�������$��20 100 20 20q�6-    �� CornerRadius$ 15��6C   ._�5$      �� $��Stretch=�6   $	��Top=�6;   .+�5%      �� $	��100��6   $	��100��6)   $��
20 20 0 10q�66   
�������$
��Left=�6a   $��1q�6|   $ 15��6�   ��5&      �� 5'       �� ImageSource 6)   �� 	 �� Path$
	 Icon�5)      �� 5*      $��20 15q�6    $��30(�6/   
���������6=   �� $	 SummonerName�6`   �� 5+      
 �� Orientation$
 
Horizontal=�6!   $
��20 5q�6:   .+�5,      �� $��15q�6%   $��Center=�61   .+�5-      �� $	��WIN��6(   $��15(�63   $
��Bold"�6A   
��� � �6S   �� 5.      $��15(�6C   $
��Bold"�6Q   
�������$��Center=�6u   ��6(   �� $
	 Wins�6u   5/      �� 50      $��15q�6%   $��Center=�61   .+�51      �� $��LOSSES��6(   $��15(�66   $
��Bold"�6D   
���  ��6V   �� 52      $��15(�6E   $
��Bold"�6S   
�������$��Center=�6w   ��6(   �� $	 Losses�6w   53      �� 54      $��15q�6%   $��Center=�61   .+�55      �� $��
Queue Type��6(   $��15(�6:   $
��Bold"�6H   
�����@�6Z   �� 56      $��15(�6H   $
��Bold"�6V   
�������$��Center=�6z   ��6(   �� $	 	QueueType�6z   57      59      �� 5:      $��30q�6!   .+�5;      �� $��LEVEL��6$   $��15(�61   
���   �6?   �� 5<      $��45(�6@   
�������$��Center=�6`   ��6$   �� $	 Level�6`   5=      � 5>      $
��20 0q�6   .+�5?      �� $
��Left=�6!     MaterialDesignFlatButton#��[ 6<   $	��100��6n   .��5@        $ Search=�66   $��26��6D   $��26��6O   5A      �� 5B      -   5        $��Right=�5B   !   $	��100��6=   $��Login��6I   6v   5C      5D      5E      �� 5F      $��Right=�6   $��30 10q�65   .+�5G      �� $	��200��6;   $	��200��6G   ��6   �� $	 
RankedIcon� 5H        5I         
BlurRadius$	 200Q�6+   $ 1Q�6<   5K      �� 5L      $
 
Horizontal=�6   $��Center=�66   $��10q�6S   .+�5M      �� $
��Bold"�6    $��15(�62   
�������$��Center=�6m   $��5q�6�   ��6R   �� $
	 Tier�6�   �� 5N      $
��Bold"�6    $��15(�62   
�������$��5q�6m   ��6R   �� $
	 Rank�6m   5O      5P      5Q      � 5S   
   $	��600��6   $��Right=�6   .+�5T      �� $	��100��6   $	��600��6&   $
 
Horizontal=�62   $	��Top=�6K   .+�5U      �� -   5        $ btn_Historia��5U       " MaterialDesignFlatDarkBgButton#���  6J   $��	20,30,2,0q�6�   $	��130��6�   $��50��6�   $
��Left=�6�   $��Match History��6�   �� 5V      -   5        $ btn_Ranking��5V      #���  6H   $��	20,30,2,0q�6�   $	��130��6�   $��50��6�   $
��Left=�6�   $��Leaderboard��6�   �� 5W         MaterialDesignBody1TextBlock#���  6     MaterialDesignBodyLight#��[ 6S   $	��130��6�   $��20��6�   $��
150,30,2,0q�6�    �� TextAlignment$ Center=�6�   czas6�   5X      �� 5Y      
�������$ 15��6-   $��20,100,20,20q�6?    �� Padding$ 15q�6U   ._�5Z      � .+�5[      /   )LeagueOfLegendsLogin.Windows.UserControl1  -   5          Name$ UserHistory��5[   )   6A   /   )LeagueOfLegendsLogin.Windows.UserControl2  5\      -	   5          Name$ UserLeaderBoard��5\   )   6D   5]      5^      5_      5a      5c      