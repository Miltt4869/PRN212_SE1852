   M S B A M L   `   `   `  ����G  CTraMi_WFPApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TraMi_WFPAppTraMi_WFPApp  5      )    #TraMi_WFPApp.OrderManagementControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:TraMi_WFPApp     5      .��5	      � ���#f9fafb$��20q�6    .+�5
   
   �� .+�5      �� $��QUẢN LÝ ĐƠN HÀNG��6   $��22(�5      $
��Bold"�5      ���#2b3e50$��Center=�5      $��0,0,0,20q�5      �� 5      -   5        $��+ Tạo đơn hàng mới��5      $	��180��5      $��35��5      $��0,0,0,15q�5      ���#28a745
�������$
��Bold"�5      ���#28a745  � Cursor$
  Hand��5      $
��Left=�5      5      &   System.Windows.Controls.DataGrid  5"      -   5          Name$ dgOrders��5"         AutoGenerateColumns$ False��5#         
IsReadOnly$
 True��5$         SelectionMode$ Single=�5%      $	��240��5'         RowBackground
 �����   AlternatingRowBackground �#f0f0f0���#ddd$��1q�5+         CanUserAddRows$ False��5,         HeadersVisibility$ Column=�5-      	   ColumnHeaderHeight$	 36Q�5.      $��14(�5/      
   GridLinesVisibility$
 
Horizontal=�50         	RowHeight$ 36Q�51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã đơn��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	OrderID+6U     54      $ Khách hàng��6)   $ * 6\    6=   �� *
CustomerID+6\     55      $ Nhân viên��6)   $ * 6[    6<   �� *
EmployeeID+6[     56      $ Ngày đặt��6)   $	 150 6Y    6;   �� *	OrderDate+6Y   58      �� 5;      $��Chi tiết đơn hàng��6   $��0,20,0,0q�5<      $
��Bold"�5=      ���#2b3e50���#ccc$��10q�5@      .��5A        -   5        $ dgOrderDetails��5A      $ False��5B      $
 True��5C      
 ����� �#f5f5f5$ Column=�5F      $	 34Q�5G      $ 32Q�5H      $��13(�5I       5J        5K      $ Sản phẩm��6-   $ * 6]    6?   �� *	ProductID+6]     5L      $
 Giá��6-   $	 100 6X    6:   �� *	UnitPrice+6X     5M      $ Số lượng��6-   $	 100 6\    6?   �� *
Quantity+6\     5N      $ Chiết khấu (%)��6-   $	 120 6b    6E   �� *
Discount+6b   5P      5Q      5R      5S      5T      