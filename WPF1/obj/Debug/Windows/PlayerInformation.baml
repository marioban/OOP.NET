   M S B A M L   `   `   `  ����?  ;WPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF1.WindowsWPF1.Windows  5   	   1clr-namespace:WPF1.PropertiesWPF1.Properties  5   	   $    WPF1.Windows.PlayerInformation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF1.Windows     5   	   .langclr-namespace:WPF1.Properties     5   	     � Title$  PlayerInformation��5	   	   $	��250��6#   $	��250��60    � 	Resources 5         
background �� 
StartPoint �� EndPoint � Offset � Color  	animation :� RoutedEvent �� TargetProperty	 W� To	 g� Duration
 g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     �� 5   
   $	 0,0&�61   $	 1,1&�6B   ��5      � $ 0Q�6   $ 	LightGray��6*   � 5      $ 0Q�6   $ DimGray��6*   � 5      $ 1Q�6   $ DarkGray��6*   5      :� 5   
   $ Grid.Loaded��6)   [�5      �� 5      .��5      �� .��5      W� $( "Background.GradientStops[1].Offset�5   %   $ 1X�5   %   $	 0:0:5D�5   %   
 . $ Forever��5   %   5      5      5!      5"      .��5$      � #��[  6    � RowDefinitions 5%   
   �� 5&      6   �� 5'      6   �� 5(      6   �� 5)      6   �� 5*      6   �� 5+      6    � ColumnDefinitions 5-   
   �� 5.      6!   �� 5/      6!   .+�53   
   �� -   5         ��Name$
 Name��53      $��0��6   $��0��6+      WPF1.Properties.Resources   lblName#��Z 6;   $��Center=�54      $��Center=�55      $
��Bold"�6+   6?   �� 56   
   -   5        $ ShirtNumber��56      $��1��6&   $��0��63      lblShirtNumber#��Z 6C   $��Center=�57      $��Center=�58      $
��Bold"�6+   6?   �� 59   
   -   5        $ Captain��59      $��2��6!   $��0��6.      
lblCaptain#��Z 6>   $��Center=�5:      $��Center=�5;      $
��Bold"�6+   6?   �� 5<   
   -   5        $ Position��5<      $��3��6"   $��0��6/      lblPosition#��Z 6?   $��Center=�5=      $��Center=�5>      $
��Bold"�6+   6?   �� 5?   
   -   5        $ GoalsScored��5?      $��4��6%   $��0��62      lblScoredGoals#��Z 6B   $��Center=�5@      $��Center=�5A      $
��Bold"�6+   6?   �� 5B   
   -   5        $ YellowCards��5B      $��5��6%   $��0��62      lblYellowCards#��Z 6B   $��Center=�5C      $��Center=�5D      $
��Bold"�6+   6?   �� 5F   
   -   5        $ lblName��5F      $��0��6!   $��1��6.   $�� ��6>   $��Center=�5G      $��Center=�5H      6-   �� 5I   
   -   5        $ lblShirtNumber��5I      $��1��6(   $��1��65   $�� ��6E   $��Center=�5J      $��Center=�5K      6-   �� 5L   
   -	   5        $ 
lblCaptain��5L      $��2��6$   $��1��61   $�� ��6A   $��Center=�5M      $��Center=�5N      6-   �� 5O   
   -
   5        $ lblPosition��5O      $��3��6%   $��1��62   $�� ��6B   $��Center=�5P      $��Center=�5Q      6-   �� 5R   
   -   5        $ lblGoals��5R      $��4��6#   $��1��60   $�� ��6@   $��Center=�5S      $��Center=�5T      6-   �� 5U   
   -   5        $ lblYellowCards��5U      $��5��6(   $��1��65   $�� ��6E   $��Center=�5V      $��Center=�5W      6-   5Z      5[      