   M S B A M L   `   `   `  ����  TraMi_WFPApp    TraMi_WFPApp.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��360��6   $	��420��6$    � WindowStartupLocation$ CenterScreen=�60   ���#f5f5f5 � 
ResizeMode$ NoResize=�6j   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $ ��Đăng nhập hệ thống��6   $��22(�6.   $
��Bold"�6<   ���#333$��Center=�5      $��0,0,0,20q�61   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   $��	0,10,0,20q�6X   .+�5      	� -   5         	�Name$ rdoAdmin��5      $��Admin��6,   $��14(�6<   $
��10,0q�6J    d� 	IsChecked$
 TrueY�6X   6i   	� 5      -   5        $ rdoCustomer��5      $��Customer��6/   $��14(�6B   $
��10,0q�6P   6^   5      �� 5   
   $��2��6   $ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� -   5         ��Name$ lblUser��5      $��Tên đăng nhập��6)   $��SemiBold"�6>   ���#4446T   �� 5      -   5         ��Name$ txtUsername��5      $��30��6+   $��0,5,0,0q�67   ���#f9f9f9���#ccc$��1q�6p   5      �� 5   
   $��3��6   $ Vertical=�6"   $��0,0,0,10q�69   .+�5       �� -   5        $ lblPassword��5       $��Mật khẩu��6-   $��SemiBold"�6=   ���#4446S   G� 5!      -   5        	 G�Name$	 txtPassword��5!      $��30��6/   $��0,5,0,0q�6;   ���#f9f9f9���#ccc$��1q�6t   5"      �� 5%   
   $��4��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,20,0,0q�6X   .+�5&      �� -   5        $��Đăng nhập��5&      $	��120��6)   $��35��65   $
��10,0q�6A   ���#4CAF50
�������$
��Bold"�5'   =   $��0q�5(   ,   
 � Cursor$

 Hand��6@   �� 5)      -   5        $��Thoát��5)      $��80��6%   $��35��60   $
��10,0q�6<   ���#e53935
�������$
��Bold"�5*   =   $��0q�5+   ,   $

 Hand��6@   5,      5-      5/      