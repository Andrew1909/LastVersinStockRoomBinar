   M S B A M L   `   `   `  ����I  EStockroomBinar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StockroomBinar.PagesStockroomBinar.Pages  5      /    )StockroomBinar.Pages.ManufacturerInfoPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:StockroomBinar.Pages     5        N� 
Background  �#303841 N� ShowsNavigationUI .   N� Title$ ManufacturerInfoPage��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ Serch��5   U   $��35��6   $	��300��6#   
 � Tag$A ;Поиск по названию производителя��6/   $
��Left=�6�   $��	50,0,0,10q�6�      	SearchBox#��[  6�   �� 5      -   5         ��Name$ ManufacturerView��5      
�������$	��580��6E   $	��768��6R   ��5      �� 5      .R�5      �� $
��auto��6    �� Padding$ 1q�6+   ���#464451$��Center=�6M    �� CornerRadius$ 7��6j   $
��auto��6{   ._�5      �� $ 
Horizontal=�6%   $
��Left=�6>   ��6Y   �� *	ViewColor+.+�5      �� $�� ��6$   $��2(�60   �� 5      $ Vertical=�6)   $
��auto��6@   $	��240��6N   .+�5   "   �� $
��Wrap=�6O   $��22(�6c   $��	Underline{�6q   $��0,0,0,5q�6�   ��6,   �� *NameManufacturer+6�   �� 5   "   $ 
Horizontal=�6-   $��0,0,0,1q�6F   .+�5   *   �� $��../Image/countryIco.png��60   $��20��6Q   �� 5   *   $��  Страна: ��64   �� 5   &   ��60   �� *	Country+5   #   �� 5   &   $ 
Horizontal=�61   $��0,0,0,1q�6J   .+�5   *   �� $��../Image/NDSIco.png��60   $��20��6M   �� 5   *   $��
  НДС: ��64   
�������6D   �� 5    &   
���������60   �� *NDS+6F   5!   #   �� 5"   &   $ 
Horizontal=�61   $��0,0,0,1q�6J   .+�5#   *   �� $��../Image/qualityIco.png��60   $��20��6Q   �� 5$   *   $��  Качество: ��64   
�������6I   �� 5%   &   
���������60   �� *	Quality+6J   5&   #   �� 5'   &   $ 
Horizontal=�61   $��0,0,0,1q�6J   .+�5(   *   �� $"��../Image/deliverspeedIco.png��60   $��20��6V   �� 5)   *   $+��%  Скорость доставки: ��64   
�������6R   �� 5*   &   
���������60   �� *SpeedDeliver+6O   5+   #   5,      �� 5-      $ Vertical=�6)   $
��auto��6A   $	��300��6O   .+�5/   &   �� $��Заметки: ��60   
�������$��	Underline{�6U   $��0,0,0,0q�6q   �� 50   "   
�������$
��Wrap=�6W   ��6,   �� *Notes+6W   �� 52   &   	 ��Name$	 ManufactSite��6-   -   5          MaterialDesignFlatButton#���  52   ^   $
��Left=�6�   $��0,5,0,0q�6�   y�6�   �� *SiteVisibleButton+.��53   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�54   .   �� $%��../Image/sitemanufaturerIco.png��64   $��20��6]   �� 55   .   $*��$ Сайт производителя��68   
�������6S   56   +   57   '   58   #   �� 59      $
	 Edit��6%   -   5        $��30��59   F   $	��160��6R   $ ��Редактировать��6^   #���  6v   ���#202225
�������$��3,0,0,0q�6�   �� 5:      $�� ��6$   $��2(�60   5;      5<      5=      5?      �� 5@   
   -   5        $	 AddNewManufacturer��5@      $>��8+ Добавить новго производителя��6-   #���  6V   
�������$��Center=�6�   $��Bottom=�6�   $��15(�6�   $��	0,20,10,0q�6  5A       � 5B   
   -   5        
  �Name$
 MyFrame��5B      5C      5D      