   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	       HCI_Project.TagWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   %localclr-namespace:HCI_Project  5   	   -   5          � Title$  Tag options��5   	   #��Z��6   $
��1000��6Z    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�    J� 	AllowDrop .  ��5      �� 5   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   	 J� CommandBindings	 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5        
   Command$#
 local:CustomTagCommands.OkTag��5      6k     5   
   -   5        $'
 !local:CustomTagCommands.CancelTag��5      6s     5   
   -   5        $%
 local:CustomTagCommands.ExitTag��5      6o    J� InputBindings 5      �� 5   
   
 �� Key$ Enter��6    �� 	Modifiers$ Controlf�6!    �� Command$# local:CustomTagCommands.OkTag��65   6_   �� 5   
   $ F4��6   $	 Altf�6   $% local:CustomTagCommands.ExitTag��6.   6Z   �� 5   
   $ Escape��6   $' !local:CustomTagCommands.CancelTag��6"   6P   .��5      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $��40 �6   �� 5      �� 5      $��70 �6   �� 5      $��70 �6    � ColumnDefinitions 5!   
   �� 5"      $��40 �6   �� 5#      $	��250 �6   �� 5$      $��30 �6   �� 5%      $	��200 �6   �� 5&      �� 5'      $��40 �6   �� 5(      $��40 �6   .+�5*   
   �� -   5        $��ID��5*      $��Tag ID:��6   $��3��6-   $��1��6:   $��Right=�6J   $��32(�6f   $��Footlight MT)�6t   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5+   
   -   5        $��Color��5+      $��
Tag color:��6!   $��5��64   $��1��6A   $��Right=�6Q   $��32(�6m   $��Footlight MT)�6{   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6�   �� 5,   
   -   5        $��Description��5,      $��Tag description:��6'   $��4��6?   $��0��6L   $��2��6\   $��Right=�6p   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6   �� 5.   
   -   5        $��TagID_Field��5.      $�� ��6%   $��3��6-   $��5q�6:   $��3��6E   $��2��6U   $��Stretch=�6i   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6�   $ �� HorizontalScrollBarVisibility$ Disabled=�6   �� MaxLines$ 1��66   �� SelectionBrush �	#FF055D79 �� SelectionOpacity$	 0.5Q�6^   �� 	UndoLimit$	 200��6u  " �� VerticalScrollBarVisibility$
 Auto=�6�   � ToolTip$ Unique ID for your tag.��6�   �� TextWrapping$
 Wrap=�6�   �� 
CaretBrush
 �����6�  �� 5/   
   -	   5        $��TagDescription_Field��5/      $�� ��6.   $��4��66   $��5q�6C   $��3��6N   $��2��6^   $��Stretch=�6r   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6  $	 200��6;   �	#FF055D79$	 0.5Q�6e  $	 200��6|  $
 Auto=�6�  $ WrapWithOverflow=�6�  }�.   �� AcceptsReturn .   �� 
AcceptsTab .  $ Description of your tag.��6  
 �����60  �� 50   
   -
   5        $��	MainTitle��50      $7��1Please fill in all information about your new tag��6%   $��0��6^   $��0��6o   $��3��6|   $��7��6�   $��44(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6  $��Center=�6  $��Center=�60  $��WrapWithOverflow=�6M   �� TextAlignment$ Center=�6m  #  Xceed.Wpf.Toolkit.ColorPicker  51   
   -   5        $��ClrPcker_Background��51      $��5��66   $��3��6C   $��5,5,5,5q�6S   $��Center=�6d   $��Stretch=�6�   $	��Top=�6�       ShowRecentColors  . !   SelectedColor$! WhiteX�6�   $��40��6�   "   DisplayColorAndName" . #   	ColorMode$# ColorCanvas=�6  $��2��6+  $ Color of your tag.��6?  $��Footlight MT)�6\  ���	#FF257D99���	#FF257D99$   ShowStandardColors$ . 6�  �� 52   
   -   5        $��Accept��52      $��Right=�6#   $��Center=�6?   $��9��6Z   $��5,5,5,5q�6g   $��4��6x   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6�   $ 1Q�6  $��0q�6  $��0q�6  $
��Bold"�62  $
 Hand��6D  $# To save your tag, click here.��6c  �� 53   
   -   5        % �� IsCancel% . $��Cancel��53   !   $
��Left=�62   $��Center=�6M   $��9��6h   $��5 5 5 5q�6u   $��1��6�   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6  $ 1Q�6  $��0q�6   $��0q�6,  $
��Bold"�6@  $
 Hand��6R  $0 *To cancel all created changes, click here.��6u  �� 54   
   $1��+/HCI_Project;component/Images/17086-200.png��6   $��9��6E   $��0��6R   $��7��6b   $��Center=�6v   $��Center=�6�   56      57      