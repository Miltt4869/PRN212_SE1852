   M S B A M L   `   `   `  ����G  CTraMi_WFPApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TraMi_WFPAppTraMi_WFPApp  5   ;  +    %TraMi_WFPApp.ProductManagementControl   6   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6>   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6�   ,localclr-namespace:TraMi_WFPApp     6;  .��5      � ���#f0f4f8.+�5   
   �� $��10q�6     �� Padding$  15q�6   
������� �� CornerRadius$ 10��6=   ���#ccc$��1q�6b   ._�5      �� .+�5      �� $��QUẢN LÝ SẢN PHẨM��6   $��20(�64   $
��Bold"�6B   ���#2b3e50$��0,0,0,15q�6i   $��Center=�6{   �� 5       �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�66   .+�5	      �� -   5         ��Name$ 	txtSearch��5	      $	��200��61   $��30��6=   $��0,0,10,0q�6I   $��5q�6[   ���#f5f5f5���#ccc$��1q�5
   B   �� 5      -   5        $��	🔍 Tìm��5      $��80��6.   $��30��69   ���#3498db
����������#2980b9 � Cursor$
 Hand��5   G   $��0,0,10,0q�6U   �� 5      -   5        $��	➕ Thêm��5      $��80��6.   $��30��69   ���#2ecc71
����������#27ae60$
 Hand��5   D   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
dgProducts��5         AutoGenerateColumns$ False��5         
IsReadOnly$
 True��5         SelectionMode$ Single=�5      $	��300��5      	   RowBackground
	 �����
   AlternatingRowBackground
 �#f9f9f9   GridLinesVisibility$ 
Horizontal=�5      ���#ddd$��1q�5         HeadersVisibility$ Column=�5         ColumnHeaderHeight$ 35Q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	ProductID+6W     5!      $ Tên SP��6-   $ * 6]    6=   �� *ProductName+6]     5"      $ 
Danh mục��6-   $ 80 6^    6?   �� *
CategoryID+6^     5#      $
 Giá��6-   $ 80 6X    6:   �� *	UnitPrice+6X     5$      $ 	Tồn kho��6-   $ 80 6_    6>   �� *UnitsInStock+6_   4  .System.Windows.Controls.DataGridTemplateColumn  5%      $ 	Tác vụ��61   $	 150 6A      CellTemplate 5&      �� 5'   "   .R�5(   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5)   *   �� -   5        $��✏️��5)   1   $��35��6>   $��4q�6I   ���#f39c12
�������$
 Hand��6�   �� 5*   *   -   5        $��🗑️��5*   1   $��35��6?   $��4q�6J   ���#e74c3c
�������$
 Hand��6�   5+   '   5,   #   5.      50      51      52      53      54      