   M S B A M L   `   `   `  ����  WpfApp7    WpfApp7.InputWindow_var5   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Input Numbers��5   	   $	��300��6   $	��300��6,   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��	Number 1:��6   $��0��6$   $��0��61   $��Center=�6A   �� 5   
   -   5         ��Name$ Number1TextBox��5      $��0��6*   $��1��67   $��25��6G   $��5q�6S   �� 5   
   $��	Number 2:��6   $��1��6$   $��0��61   $��Center=�6A   $��0,10,0,0q�6\   �� 5   
   -   5        $ Number2TextBox��5      $��1��6*   $��1��67   $��25��6G   $��5q�6S   �� 5   
   $��	Number 3:��6   $��2��6$   $��0��61   $��Center=�6A   $��0,10,0,0q�6\   �� 5   
   -   5        $ Number3TextBox��5      $��2��6*   $��1��67   $��25��6G   $��5q�6S   �� 5!   
   $��Calculation Options��6   $��3��60   $��2��6=   $��0,10,0,0q�6Q   .��5"      �� .+�5#      �� -   5         ��Name$ SummCheckBox��5#      $
��Summ��61   $��5q�6@   �� 5$      -   5        $ LeastMultipleCheckBox��5$      $��Least multiple��6:   $��5q�6S   5%      5&      �� 5(   
   -   5        $��OK��5(      $��4��6   $��1��6+   $��Right=�6;   $��70��6W   6b   5)      5*      