   M S B A M L   `   `   `  ����?  ;WPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF1WPF1  5   	   1clr-namespace:WPF1.PropertiesWPF1.Properties  5   	       WPF1.TeamWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:WPF1     5   	   .langclr-namespace:WPF1.Properties     5   	     � Title$  
TeamWindow��5	   	   $	��400��6   $	��400��6)    � 	Resources 5         
background �� 
StartPoint �� EndPoint � Offset � Color  	animation :� RoutedEvent �� TargetProperty	 W� To	 g� Duration
 g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     �� 5   
   $	 0,0&�61   $	 1,1&�6B   ��5      � $ 0Q�6   $ DarkBlue��6*   � 5      $ 0Q�6   $
 Blue��6*   � 5      $ 1Q�6   $ 
BlueViolet��6*   5      :� 5   
   $ Grid.Loaded��6)   [�5      �� 5      .��5      �� .��5      W� $( "Background.GradientStops[1].Offset�5   %   $ 1X�5   %   $	 0:0:5D�5   %   
 . $ Forever��5   %   5      5      5!      5"      .��5$      � $��	-5,0,-2,0q�6   #��[  6    � RowDefinitions 5%   
   �� 5&      6   �� 5'      6   �� 5(      6   �� 5)      6   �� 5*      6   �� 5+      6   �� 5,      6   �� 5-      6   �� 5.      6    � ColumnDefinitions 50   
   �� 51      6!   �� 52      6!   .+�55   
   �� $��0��6   $��0��6   $��Center=�6-      WPF1.Properties.Resources   
lblCountry#��Z 6J   $
��Bold"�6y   �� 56   
   -   5         ��Name$ lblCountryData��56   J   $��0��6   $��1��6   $��Center=�6-   $
��data��6b   �� 57   
   $��1��6   $��0��6   $��Center=�6-      lblCode#��Z 6J   $
��Bold"�6v   �� 58   
   -   5        $ lblCodeData��58   J   $��1��6   $��1��6   $��Center=�6-   $
��data��6_   �� 59   
   $��2��6   $��0��6   $��Center=�6-      lblGamesPlayed#��Z 6J   $
��Bold"�6}   �� 5:   
   -   5        $ lblGamesPlayedData��5:   J   $��2��6   $��1��6   $��Center=�6-   $
��data��6f   �� 5;   
   $��3��6   $��0��6   $��Center=�6-      lblWins#��Z 6J   $
��Bold"�6v   �� 5<   
   -   5        $ lblWinsData��5<   J   $��3��6   $��1��6   $��Center=�6-   $
��data��6_   �� 5=   
   $��4��6   $��0��6   $��Center=�6-      	lblLosses#��Z 6J   $
��Bold"�6x   �� 5>   
   -   5        $ lblLossesData��5>   J   $��4��6   $��1��6   $��Center=�6-   $
��data��6a   �� 5?   
   $��5��6   $��0��6   $��Center=�6-      lblDraws#��Z 6J   $
��Bold"�6w   �� 5@   
   -   5        $ lblDrawsData��5@   J   $��5��6   $��1��6   $��Center=�6-   $
��data��6`   �� 5A   
   $��6��6   $��0��6   $��Center=�6-      lblGoalsFor#��Z 6J   $
��Bold"�6z   �� 5B   
   -   5        $ lblGoalsForData��5B   J   $��6��6   $��1��6   $��Center=�6-   $
��data��6c   �� 5C   
   $��7��6   $��0��6   $��Center=�6-      lblGoalsAgainsts#��Z 6J   $
��Bold"�6   �� 5D   
   -   5        $ lblGoalsAgainstsData��5D   J   $��7��6   $��1��6   $��Center=�6-   $
��data��6h   �� 5E   
   $��8��6   $��0��6   $��Center=�6-      lblGoalDifferential#��Z 6J   $
��Bold"�6�   �� 5F   
   -	   5        $ lblGoalDifferentialData��5F   J   $��8��6   $��1��6   $��Center=�6-   $
��data��6k   5H      5I      