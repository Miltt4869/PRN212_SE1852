   M S B A M L   `   `   `  ����G  CTraMi_WFPApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TraMi_WFPAppTraMi_WFPApp  5      &     TraMi_WFPApp.OrderHistoryControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:TraMi_WFPApp     5      $	��500��5      $	��800��6   .��5	      � $��20q�6     � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $)��#Lịch sử đơn hàng của bạn��6   $��16(�64   $
��Bold"�6B   $��0,0,0,10q�6T   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgOrders��5      $��0��6%      AutoGenerateColumns$ False��62      
IsReadOnly$
 True��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã đơn��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	OrderID+6Q     5      $ Ngày đặt��6%   $	 200 6U    67   �� *	OrderDate+6U     5      $ Xử lý bởi NV��6%   $	 150 6Z    6;   �� *
EmployeeID+6Z   5      �� 5   
   $��Chi tiết đơn hàng��6   $
��Bold"�6-   $��0,10,0,5q�6?   $��1��6Q     5   
   -   5        $ 	dgDetails��5      $��2��6&   $ False��63   $
 True��6O    5        5      $ Sản phẩm��6%   $ * 6U    67   �� *	ProductID+6U     5       $
 Giá��6%   $ * 6P    62   �� *	UnitPrice+6P     5!      $ SL��6%   $ * 6N    61   �� *
Quantity+6N     5"      $ Giảm giá (%)��6%   $ * 6X    6;   �� *
Discount+6X   5$      5%      5&      