   M S B A M L   `   `   `  ����G  CTraMi_WFPApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TraMi_WFPAppTraMi_WFPApp  5           TraMi_WFPApp.ReportControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:TraMi_WFPApp     5      .��5	      � ���#f9fafb.+�5
   
   �� $��20q�6   .+�5      �� $��BÁO CÁO ĐƠN HÀNG��6   $��22(�5      $
��Bold"�5      ���#2b3e50$��Center=�5      $��0,0,0,20q�5      �� 5        �� Orientation$  
Horizontal=�6   $��0,0,0,10q�62   .+�5      �� $��Từ ngày:��6   $��Center=�6,   $��0,0,10,0q�6G   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpFrom��5      $	��150��6-   �� 5      $��Đến ngày:��6   $��	20,0,10,0q�6-   $��Center=�6@     5      -   5        $
 dpTo��5      $	��150��6+   �� 5      -   5        $��📊 Xem báo cáo��5      $	��140��62   $��30��6>   $��20,0,0,0q�6J   ���#2d89ef
�������$
��Bold"�5   A   ���#2d89ef � Cursor$
 Hand��5   /   5      5      &   System.Windows.Controls.DataGrid  5       -   5          Name$ dgReport��5          AutoGenerateColumns$ False��5!      $	��300��5"         
IsReadOnly$
 True��5#         RowBackground
 �����   AlternatingRowBackground �#f0f0f0���#ddd$��1q�5'         CanUserAddRows$ False��5(      	   HeadersVisibility$	 Column=�5)      
   ColumnHeaderHeight$
 36Q�5*      $��14(�5+         GridLinesVisibility$ 
Horizontal=�5,         	RowHeight$ 36Q�5-         Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã đơn��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	OrderID+6U     50      $ Khách hàng��6)   $ * 6\    6=   �� *
CustomerID+6\     51      $ Nhân viên��6)   $ * 6[    6<   �� *
EmployeeID+6[     52      $ Ngày đặt��6)   $	 150 6Y    6;   �� *	OrderDate+6Y     53      $ Tổng tiền��6)   $	 150 6\    6<   �� *TotalAmount+6\   55      �� 58      -   5         ��Name$ 
txtSummary��58      $
��Bold"�59      $��14(�5:      $��0,10,0,0q�5;      ���#2b3e505<      5=      5>      5?      