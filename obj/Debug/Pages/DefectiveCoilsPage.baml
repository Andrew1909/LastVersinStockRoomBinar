   M S B A M L   `   `   `  ����I  EStockroomBinar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StockroomBinar.PagesStockroomBinar.Pages  5      -    'StockroomBinar.Pages.DefectiveCoilsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:StockroomBinar.Pages     5        N� 
Background  �#303841 N� Title$ DefectiveCoilsPage��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $+��%Бракованный пластик��6   $��30(�67   $��Century Gothic)�6E   
�������$��0,0,0,0q�6t   5      �� 5      $�� ��6   $��1(�6    �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ SearchColor��5      
������    	SearchBox#���   6I   
�������
 � Tag$1 +Поиск по названию цвета��6�   $��35��6�   $	��300��6�   $
��Left=�6�   .��6  5      �� 5      $�� ��6   �� 5      -   5         ��Name$ 	PlastType��5      $	��200��6.   $��35��6:   ���#F5F5F5$��15(�6\   $��0,0,10,0q�6�   5      �� 5      -   5        $ PlastManufact��5      $	��210��62   ���#F5F5F5$��15(�6T   $��35��6b   5      5      �� 5      $�� ��6   &   System.Windows.Controls.DataGrid  5       -   5          Name$ PlastitDefectiveView��5    �     MaterialDesignDataGrid#���  6     MaterialDesignDataGridCell   	CellStyle# �  6H      AutoGenerateColumns .  $	��510��6�   	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Название цвета��6)      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	ColorName+6_     5#      $
 Тип платика��6)    .  6>   �� *PlasticType+6^     5$      $ 
 Кол-во катушек��6)    .  6A   �� *NumberСoils+6a     5%      $
 Вес��6)    .  66   �� *Weight+6Q     5&      $ 
 Производитель��6)    .  6@   �� *Manufacturer+6a     5'      $
 Тип платика��6)    .  6>   �� *DefectiveType+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5(         CellTemplate 5)      �� 5*      .R�5+   "   �� $ Vertical=�6-   .+�5,   &   ��  ��Name$ AddRecyclingName��6/   -   5        ���#202225 d� 	IsChecked 5,   �   �� *StatusRecucling+6�   5-   #   5.      50      52      �� 53      $�� ��6   �� 54      $ 
Horizontal=�6   $��Right=�62   .+�55      �� -   5         ��Name$ RecyclingNameDel��55      $��0q�63   $4��.Отправить на переработку��6G   $��40��6j   $	��240��6v   ���#2022256�   �� 56      $�� ��6   58      59       � 5:   
   -   5          �Name$ MyFrame��5:      5;      5<      