   M S B A M L   `   `   `  ����  TraMi_WFPApp,    &TraMi_WFPApp.CustomerManagementControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6?   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6�   $
��Auto��6�   $	��800��6�   .��5      � ���#f9fafb.+�5   
   �� $��20q�6   .+�5      �� $��QUẢN LÝ KHÁCH HÀNG��6   $��22(�5      $
��Bold"�5      ���#2b3e50$��Center=�5	      $��0,0,0,20q�5
      �� 5        �� Orientation$  
Horizontal=�6   $
��Left=�62   $��0,0,0,20q�6M   .+�5      �� -   5         ��Name$ 	txtSearch��5      $	��220��5      $��30��5      $��0,0,10,0q�5      $��5q�5      $��14(�5      $��Center=�5      
����������#ccc$��1q�5       � ToolTip$* $Nhập tên hoặc SĐT khách hàng��5      �� 5      -   5        $��🔍 Tìm kiếm��5      $	��100��5      $��30��5      $��0,0,10,0q�5      ���#2d89ef
����������#2d89ef$
��Bold"�5        � Cursor$
 Hand��5!      5"      �� 5#      -   5        $��	➕ Thêm��5#      $	��100��5$      $��30��5%      ���#28a745
����������#28a745$
��Bold"�5)      $
 Hand��5*      5+      5,      &   System.Windows.Controls.DataGrid  5/      -   5          Name$ dgCustomers��5/         AutoGenerateColumns$ False��50         
IsReadOnly$
 True��51         SelectionMode$ Single=�52      $	��350��53         RowBackground
 �����	   AlternatingRowBackground	 �#f0f0f0���#ddd$��1q�57      
   CanUserAddRows$
 False��58         HeadersVisibility$ Column=�59         ColumnHeaderHeight$ 36Q�5:      $��14(�5;         GridLinesVisibility$ 
Horizontal=�5<         	RowHeight$ 36Q�5=         Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
CustomerID+6T     5@      $ Tên công ty��6)   $ * 6^    6>   �� *CompanyName+6^     5A      $ Tên liên hệ��6)   $ * 6^    6>   �� *ContactName+6^     5B      $
 SĐT��6)   $	 120 6P    66   �� *Phone+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5C      $ 	Tác vụ��6-   $	 150 6=      CellTemplate 5D      �� 5E      .R�5F   "   �� $  
Horizontal=�6-   $��Center=�6F   .+�5G   &   �� -   5        $��✏️��5G   -   $ Sửa��5H   )   $��34��5I   )   $��30��5J   )   $	��4,0q�5K   )   ���#ffc107
����������#ffc107$
��Bold"�5O   )   $
 Hand��5P   )   5Q   )   �� 5R   &   -   5        $��🗑️��5R   -   $
 Xóa��5S   )   $��34��5T   )   $��30��5U   )   $	��4,0q�5V   )   ���#dc3545
����������#dc3545$
��Bold"�5Z   )   $
 Hand��5[   )   5\   )   5]   #   5^      5`      5b      5c      5d      5e      