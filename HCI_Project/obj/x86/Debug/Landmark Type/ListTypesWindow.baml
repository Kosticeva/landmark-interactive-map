   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	   !    HCI_Project.ListTypesWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  Choose existing type��5   	   #��Z��6&   $
��1000��6c    � 
ResizeMode$ NoResize=�6p    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '  �     �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5	       � ��
	 �����6+   �� 5
       � ��$	 Footlight MT)�6+   �� 5       � ��$	 16(�6)   5      �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5       � ��
	 �����6+   �� 5       � ��$	 Footlight MT)�6+   �� 5       � ��$	 16(�6)   5      5      
 J� CommandBindings
 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$0 *local:CustomTypesCommands.NewLandmarkType1��5      6�     5   
   -   5        $2 ,local:CustomTypesCommands.SelectLandmarkType��5      6�     5   
   -   5        $2 ,local:CustomTypesCommands.DeleteLandmarkType��5      6�     5   
   -   5        $( "local:CustomTypesCommands.EditType��5      6s     5   
   -   5        $' !local:CustomTypesCommands.OkTypes��5      6q     5   
   -   5        $+ %local:CustomTypesCommands.CancelTypes��5      6y     5   
   -   5        $) #local:CustomTypesCommands.ExitTypes��5      6u    J� InputBindings 5      �� 5   
   
 �� Key$ N��6    �� 	Modifiers$ Controlf�6    �� Command$0 *local:CustomTypesCommands.NewLandmarkType1��61   6h   �� 5   
   $ V��6   $ Controlf�6   $2 ,local:CustomTypesCommands.SelectLandmarkType��61   6j   �� 5    
   $ X��6   $ Controlf�6   $2 ,local:CustomTypesCommands.DeleteLandmarkType��61   6j   �� 5!   
   $ E��6   $ Controlf�6   $( "local:CustomTypesCommands.EditType��61   6`   �� 5"   
   $ Enter��6   $ Controlf�6!   $' !local:CustomTypesCommands.OkTypes��65   6c   �� 5#   
   $ Escape��6   $+ %local:CustomTypesCommands.CancelTypes��6"   6T   �� 5$   
   $ F4��6   $	 Altf�6   $) #local:CustomTypesCommands.ExitTypes��6.   6^   ��5&      �� 5'   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   .��5)      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � RowDefinitions 5*   
   �� 5+      $��10 �6   �� 5,      $��50 �6   �� 5-      $��50 �6   �� 5.      $��40 �6   �� 5/      $��50 �6   �� 50      $��50 �6   �� 51      $��20 �6   �� 52      �� 53      $��70 �6    � ColumnDefinitions 55   
   �� 56      $��40 �6   �� 57      $��40 �6   �� 58      $	��100 �6   �� 59      $��50 �6   �� 5:      $��30 �6   �� 5;      $	��300 �6   �� 5<      �� 5=      $��40 �6   �� 5>      $	��100 �6   �� 5?      $��40 �6   .+�5A   
   �� $1��+/HCI_Project;component/Images/17086-200.png��6   $��8��6E   $��0��6R   $��10��6b   $��Stretch=�6w   $��Center=�6�   �� 5B   
   -	   5        $��Titlee��5B      $B��<Here you can find existing landmark types or create your own��6"   $��1��6f   $��2��6s   $��1��6�   $��8��6�   $��40(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6
  $��Center=�6  $��Center=�67  $��WrapWithOverflow=�6T   �� TextAlignment$ Center=�6t  �� 5C   
   -
   5        $��LblFind��5C      $��Selected type:��6#   $��4��69   $��0��6F   $��4��6V   $��Right=�6j   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5D   
   -   5        $
��LTID��5D      $�� ��6   $��4��6&   $��5��63   $��5 5 5 5q�6C   $��Stretch=�6T   $��32(�6r   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6�   $ �� HorizontalScrollBarVisibility$ Disabled=�6�    �� MaxLines$ 1��6!   �� SelectionBrush �	#FF055D79 �� SelectionOpacity$	 0.5Q�6I   �� 	UndoLimit$	 200��6`  " �� VerticalScrollBarVisibility$
 Auto=�6p   �� 
IsReadOnly . $��Stretch=�6�   � ToolTip$F @ID and name of the landmark type you selected for your landmark.��6�    �� TextWrapping$
  Wrap=�6  ! �� 
CaretBrush
! �����6   �� 5E   
   -   5        $��	SearchLbl��5E      $��Search:��6%   $��5��64   $��2��6A   $��Right=�6R   $��32(�6n   $��Footlight MT)�6|   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   $��2��6�   �� 5F   
   -   5        $��NewType��5F      $��New Type��6    $��5,5,5,5q�63   $��4��6D   $��6��6Q   $��3��6a   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6'  $
 Hand��69  $	��Top=�6G  $0��*local:CustomTypesCommands.NewLandmarkType1��6_  $��2��6�  $0 *To create a new landmark type, click here.��6�  �� 5G   
   -   5        $��Search��5G      $�� ��6    $��5��6(   $��5��65   $��5 5 5 5q�6E   $��Stretch=�6V   $��32(�6t   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6�   $ Disabled=�6�   $ 1��6#   �	#FF055D79$	 0.5Q�6K  $	 200��6b  $
 Auto=�6r  $��Stretch=�6�  $F @ID and name of the landmark type you selected for your landmark.��6�  $
  Wrap=�6�  
! �����6)  &   System.Windows.Controls.DataGrid  5H   
   -   5        "  Name$" dgrTypes��5H      $��7��6%   $��5,5,5,5q�63   $��1��6D   $��8��6T   #   
IsReadOnly# . $   AutoGenerateColumns$ .  $% �� IsSynchronizedWithCurrentItem$
% TrueY�6�   $&   HorizontalScrollBarVisibility$
& Auto=�6�   ' �� IsTextSearchEnabled' . (   HorizontalGridLinesBrush( �	#FF257D99)   VerticalGridLinesBrush) �	#FF257D99���	#FF257D99���	#FF257D99
�������$��3q�6�  $� �Here you can see all landmark types that have been created in this application. To edit a landmark type, double click the one you wish to change.��6  $��Footlight MT)�6�  $��16(�6�  ��6h   �� * �� Path$* ltypes�+   Columns+ 5I      4  .System.Windows.Controls.DataGridTemplateColumn  5J      ,  &System.Windows.Controls.DataGridColumn,   Header$, ID��6)   -   Width5  /System.Windows.Controls.DataGridLengthConverter$	- 150 65   .   CellTemplate. 5K      �� 5L      .R�5M      �� $
��Wrap=�6A   ��6(   �� $* ID�6A   5N      5P        5Q      $
, Name��6)   $	- 200 67   . 5R      �� 5S      .R�5T      �� $
��Wrap=�6C   ��6(   �� $
* Name�6C   5U      5W        5X      $, Description��6)   $	- 360 6>   . 5Y      �� 5Z      .R�5[      �� $
��Wrap=�6J   ��6(   �� $* Description�6J   5\      5^      5`      �� 5a   
   -   5        $��OK��5a      $��Accept��6   $��5,5,5,5q�6,   $��8��6=   $��6��6J   $��3��6Z   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6   $
 Hand��62  $��Center=�6@  $. (To save all created changes, click here.��6n  �� 5b   
   -   5        $��Select��5b      $��Select��6   $��5,5,5,5q�60   $��8��6A   $��4��6N   $��3��6^   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6$  $
 Hand��66  $��Center=�6D  $2��,local:CustomTypesCommands.SelectLandmarkType��6_  $n hTo select a landmark type for your landmark, select the one you wish from the list above and click here.��6�  �� 5c   
   -   5        $��Delete��5c      $��Delete��6   $��5,5,5,5q�60   $��8��6A   $��3��6N   $��3��6^   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $
��Left=�6�   $��0q�6  $
��Bold"�6#  $
 Hand��65  $��Center=�6C  $[ UTo delete a landmark type, select a landmark type from the list above and click here.��6u  �� 5d   
   -   5        $��Cancel��5d      $��Cancel��6   $��5,5,5,5q�60   $��8��6A   $��1��6N   $��2��6^   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $
��Left=�6�   $��0q�6  $
��Bold"�6#  $
 Hand��65  $��Center=�6C  $0 *To cancel all created changes, click here.��6u  5e      5f      