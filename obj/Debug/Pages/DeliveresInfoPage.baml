   M S B A M L   `   `   `  ����I  EStockroomBinar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StockroomBinar.PagesStockroomBinar.Pages  5      ,    &StockroomBinar.Pages.DeliveresInfoPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:StockroomBinar.Pages     5        N� 
Background  �#303841 N� ShowsNavigationUI .   N� Title$ DeliveresInfoPage��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6    � Cursor$  ��6,   .+�5      �� $�� ��6   �� 5      $ 
Horizontal=�6   .+�5      �� $��Заказчик: ��6   $��20(�6.   
�������6<   �� 5      -   5         ��Name$ CostomerText��5      $��20(�62   $��	Underline{�6@   
�������6\   5      �� 5      $ 
Horizontal=�6   .+�5      �� $!��Дата отгрузки: ��6   $��15(�63   
�������6A   �� 5      -   5        $ DataText��5      $��15(�6.   
�������6<   5      �� 5      $ 
Horizontal=�6   .+�5      �� $+��%Процент готовности: ��6   $��15(�68   
�������6F   �� 5      -   5        $ ProcentText��5      $��15(�61   
�������6@   �� 5      $��15(�6   
�������$��%��6=   5      �� 5      $��Center=�6   $��1��61   	 �� X1$ 0��6E   	 �� X2$	 930��6L   	 �� Y1$ 10��6U   		 �� Y2$	 10��6]   
�������6e   �� 5      $�� ��6   &   System.Windows.Controls.DataGrid  5      -   5        
  Name$
 DeliversInfoView��5   �      MaterialDesignDataGrid#���   6     MaterialDesignDataGridCell   	CellStyle# �  6H      AutoGenerateColumns .  $	��500��6�   ���#F5F5F5$	��850��6�   $
��Left=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Код детали��6)      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
CodeDitals+6\     5!      $  Кол-во готовых��6)    .  6A   �� *ReadyDitals+6a     5"      $) #Кол-во для отправки��6)    .  6F   �� *NecessaryCountDitals+6o   4  .System.Windows.Controls.DataGridTemplateColumn  5#         CellTemplate 5$      �� 5%      .R�5&   "   �� $ Vertical=�6-   5(   #   5)      5+      5-      �� 5.      $�� ��6   �� 5/      $ 
Horizontal=�6   $��Right=�62   .+�50      �� -   5         ��Name$ ComplectDeliver��50   m   $3��-Укомплектовать поставку��6   $��0q�6Y   $��30��6�   $	��215��6�   ���#2022256�   �� 51      $�� ��6   �� 52      -   5        $ CloseDeliver��52   H   $%��Закрыть поставку��6   $��0q�64   $��30��6^   $	��200��6j   ���#202225$��Right=�6�   6�   53      54       � 55   
   -   5          �Name$ MyFrame��55      56      57      