   M S B A M L   `   `   `  ����  PokeBattle_Hamed!    WpfApp1.MVVM.View.FightView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Combat Pokémon��5   	   $	��500��6    $	��800��6-   ���#1E1E1E � WindowStartupLocation$ CenterScreen=�5      .��5
      � .+�5   
   �� -   5         ��Name$ 
ScoreLabel��5      $��Score: 0��6$   $��Center=�5      $	��Top=�6-   $��20(�5      $
��Bold"�6   
�������$��0,10,0,0q�5      �� 5   
   ���#2A9D8F �� CornerRadius$ 10��6&    �� Padding$ 10q�68   $
��Left=�5      $��Center=�6,   $��10q�6G   ._�5      ��  �� Orientation$ Vertical=�6   $��Center=�60   .+�5      �� -   5         ��Name$ PlayerMonsterName��5      $��18(�5      $
��Bold"�6*   
������� �� TextAlignment$ Center=�5      �� 5      -   5        $ PlayerMonsterHealth��5      $��14(�5      
�������$��	0,10,0,10q�5      $ Center=�6/   �� 5      -   5         ��Name$ PlayerMonsterImage��5      $	��150��5      $	��150��6$   $��Uniform=�5      $��	0,10,0,10q�6*   �� 5      $��Sorts :��6   $��16(�6+   $
��Bold"�69   
�������$ Center=�6^   �� 5      -   5        	 ��Name$	 PlayerMonsterSpells��5      $ Vertical=�5       $��Center=�64   5"      5#      5$      �� 5'   
   ���#E63946$ 10��6&   $ 10q�68   $��Right=�5(      $��Center=�6-   $��10q�6H   ._�5)      �� $ Vertical=�6   $��Center=�60   .+�5*      �� -   5        $ OpponentMonsterName��5*      $��18(�5+      $
��Bold"�6*   
�������$ Center=�5,      �� 5-      -   5        $ OpponentMonsterHealth��5-      $��14(�5.      
�������$��	0,10,0,10q�5/      $ Center=�6/   �� 50      -   5        $ OpponentMonsterImage��50      $	��150��51      $	��150��6$   $��Uniform=�52      $��	0,10,0,10q�6*   53      54      �� 57   
   ���#457B9D$ 10��6&   $ 10q�68   $��Center=�58      $��Bottom=�6.   $��10q�6I   ._�59      �� $ 
Horizontal=�6   $��Center=�62   .+�5:      �� $��Attaquer��6   $	��100��6,   $��40��68   ���#ADD8E6
�������$
��Bold"�5;   A   $	��5,0q�5<      �� 5>      $��Se défendre��6   $	��100��6/   $��40��6;   ���#ADD8E6
�������$
��Bold"�5?   A   $	��5,0q�5@      �� 5B      $
��Fuir��6   $	��100��6(   $��40��64   ���#ADD8E6
�������$
��Bold"�5C   A   $	��5,0q�5D      5F      5G      5H      5I      