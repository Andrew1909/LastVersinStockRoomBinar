   M S B A M L   `   `   `  ����I  EStockroomBinar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StockroomBinar.PagesStockroomBinar.Pages  5      -    'StockroomBinar.Pages.Print3DProfilsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:StockroomBinar.Pages     5        N� 
Background  �#303841 N� ShowsNavigationUI .   N� Title$ Print3DProfilsPage��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $+��%Профили для 3D печати��6   $��30(�65   $��Century Gothic)�6C   
�������$��0,0,0,10q�6r   �� 5      -   5         ��Name$ Search��5   b   $��35��6   $	��300��6#   
�������
 � Tag$5 /Поиск по названию профиля��6B   $
��Left=�6�   $��	50,0,0,10q�6�      	SearchBox#��[  6�   �� 5      -   5         ��Name$ PrintProfilsView��5      
�������$	��545��6E   $	��734��6R   ��5      �� 5      .R�5      �� $
��auto��6!    �� Padding$ 1q�6/   ���#464451$��Center=�6Q    �� CornerRadius$ 7��6n   $
��auto��6   ._�5      �� $ 
Horizontal=�6)   $
��Left=�6B   	 � Cursor$	  ��6~   $��40��6�   ��6]   �� *	ViewColor+.+�5   "   �� $��../Image/filePic.png��6(   $��30��6F   �� 5   "   $ Vertical=�6-   $��	10,0,10,0q�6D   $	��300��6W   .+�5   &   �� $��19(�6M   $
��Wrap=�6[   ��60   �� *NameProfile+6[   5   #   �� 5   "   $ 
Horizontal=�6-   .+�5   &   �� $��OpenFile��6�   -   5        $��Открыть��5   -   $��30��6?   $	��100��6K   ���#202225$��0q�6l   
�������$��	12,0,10,0q�6�   �� 5   &   $��
DeleteFile��6�   -   5        $��Удалить��5   -   $��30��6?   $	��100��6K   ���#202225$��0q�6l   
�������6�   5   #   5       5!      5"      5$      �� 5%      -   5        
 ��Name$
 AddNewProfile��5%      $'��!+ Добавить профиль��6,     MaterialDesignFlatButton#���  6I   
�������$��Center=�6�   $��Bottom=�6�   $��15(�6�   $��	0,20,10,0q�6�   5&       � 5'   
   -   5          �Name$ MyFrame��5'      50      51      