   M S B A M L   `   `   `  ����I  EStockroomBinar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StockroomBinar.PagesStockroomBinar.Pages  5      ,    &StockroomBinar.Pages.For3DPrintingPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:StockroomBinar.Pages     5        N� 
Background  �#303841 N� Title$ For3DPrintingPage��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��../Image/3dprinterIco.png��6   $��30��6;   �� 5      $�� ��6   �� 5      $"��Для 3D принтеров��6   $��30(�64   
�������$��0,0,0,0q�6V   5      �� 5      $�� ��6   $��1(�6    �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ SearchColor��5      
������    	SearchBox#���   6I   
�������
 � Tag$&  Поиск по названию��6�   $��35��6�   $	��300��6�   $
��Left=�6�   .��6�   5      �� 5      $�� ��6   5      �� 5      $�� ��6   &   System.Windows.Controls.DataGrid  5      -   5          Name$ ForPrintView��5   �     MaterialDesignDataGrid#���  6     MaterialDesignDataGridCell   	CellStyle# �  6H      AutoGenerateColumns .  $	��510��6�   ���#F5F5F5   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6)   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Name+6T     5!      $	 Кол-во��6)   
 .  69   �� *Count+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5"         CellTemplate 5#      �� 5$      .R�5%      �� $ 
Horizontal=�6)   .+�5'   &   ��  ��Name$
 Plus��6-   -   5        $��11(�5'   N   $��20��6\   ���#2F3136$��0q�6~   .��5(   *   �� $��+��64   $��Center=�6=   $��Center=�6Z   5)   '   �� 5*   &   $�� ��6,   �� 5+   &   $ Minus��6-   -   5        $��11(�5+   P   $��20��6^   ���#2F3136$��0q�6   .��5,   *   �� $��-��64   $��Center=�6=   $��Center=�6Z   5-   '   5.   #   5/      51      53      �� 54      -   5        $ AddItem��54      $��+ Добавить��6&     MaterialDesignFlatButton#���  6;   
�������$
��Left=�6�   $��15(�6�   $��0,20,0,0q�6�   6�   55      58      59      