   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	   $    HCI_Project.LandmarkListWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  List of all landmarks��5   	   #��Z��6'   $
��1000��6d    � 
ResizeMode$ NoResize=�6q    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '  �     �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5	       � ��
	 �����6+   �� 5
       � ��$	 Footlight MT)�6+   �� 5       � ��$	 20(�6)   5      �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5       � ��
	 �����6+   �� 5       � ��$	 Footlight MT)�6+   �� 5       � ��$	 20(�6)   5      5      
 J� CommandBindings
 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$+ %local:CustomListCommands.EditLandmark��5      6z     5   
   -   5        $- 'local:CustomListCommands.DeleteLandmark��5      6~     5   
   -   5        $* $local:CustomListCommands.OkLandmarks��5      6x     5   
   -   5        $. (local:CustomListCommands.CancelLandmarks��5      6�     5   
   -   5        $, &local:CustomListCommands.ExitLandmarks��5      6|    J� InputBindings 5      �� 5   
   
 �� Key$ E��6    �� 	Modifiers$ Controlf�6    �� Command$+ %local:CustomListCommands.EditLandmark��61   6c   �� 5   
   $ X��6   $ Controlf�6   $- 'local:CustomListCommands.DeleteLandmark��61   6e   �� 5   
   $ Enter��6   $ Controlf�6!   $* $local:CustomListCommands.OkLandmarks��65   6f   �� 5   
   $ Escape��6   $. (local:CustomListCommands.CancelLandmarks��6"   6W   �� 5    
   $ F4��6   $	 Altf�6   $, &local:CustomListCommands.ExitLandmarks��6.   6a   ��5"      �� 5#   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   .��5%      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � RowDefinitions 5&   
   �� 5'      $��40 �6   �� 5(      $��50 �6   �� 5)      $��10 �6   �� 5*      $��50 �6   �� 5+      $��10 �6   �� 5,      $��50 �6   �� 5-      $��50 �6   �� 5.      $��40 �6   �� 5/      �� 50      $	��150 �6   �� 51      $��40 �6   �� 52      $��70 �6   �� 53      $��60 �6    � ColumnDefinitions 55   
   �� 56      $��40 �6   �� 57      $��40 �6   �� 58      $��80 �6   �� 59      $	��170 �6   �� 5:      $��30 �6   �� 5;      �� 5<      $��60 �6   �� 5=      $��40 �6   �� 5>      $	��100 �6   �� 5?      $��40 �6   .+�5B   
   �� -   5        $��Smthing��5B      $��Search:��6#   $��1��62   $��2��6B   $��3��6V   $��32(�6c   $��Footlight MT)�6q   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   $
��Left=�6�   $��WrapWithOverflow=�6   �� TextAlignment$ Center=�6-  $��5q�6D  �� 5C   
   -   5        $��Search��5C      $��3��6    $��3��6-   $��3��6=   $��5 5 5 5q�6Q   $��Stretch=�6b   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6�   $ �� HorizontalScrollBarVisibility$ Disabled=�6   �� MaxLines$	 200��6/   �� SelectionBrush �	#FF055D79 �� SelectionOpacity$	 0.5Q�6Y   �� 	UndoLimit$	 200��6p  " �� VerticalScrollBarVisibility$
 Auto=�6�   �� TextWrapping$
 Wrap=�6�  }�.   �� AcceptsReturn .    �� 
AcceptsTab  .  ! � ToolTip$I! CTo find a landmark with specific name or property, enter data here.��6$  " J� 	AllowDrop" .  # �� 
CaretBrush# 6�  Z� 6r  �� 5D   
   -	   5        $��Titlee��5D      $6��0Here you can find and edit all created landmarks��6"   $��2��6Z   $��1��6k   $��8��6{   $��40(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  $��Center=�6  $��WrapWithOverflow=�6;  $ Center=�6[  $��5q�6r  �� 5E   
   -
   5        $��
Columns...��5E      $��3��6&   $��6��63   $��3��6C   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6�   $
��Bold"�6	  $
 Hand��6  $��Center=�6)  $N! HTo edit col, select the one you want from the list above and click here.��6[  &   System.Windows.Controls.DataGrid  5G   
   -   5        $  Name$$ dgrLandmarks��5G      $��5��6)   $��7��66   $��1��6G   $��8��6W   %   
IsReadOnly% . &   AutoGenerateColumns& .  $' �� IsSynchronizedWithCurrentItem$
' TrueY�6�   (   ColumnHeaderHeight$	( NaNQ�6  $�! �Here you can see all created landmarks or all the landmarks that fulfill the search criteria entered above. To edit a landmark, double click the one you wish edit.��6N  )   MaxColumnWidth$	) 500Q�6�  *   MinColumnWidth$* 50Q�6  $��2q�6%  ���	#00ECF6F8��6k   �� + �� Path$+ AvailableLandmarks�, �� UpdateSourceTrigger$, PropertyChanged=�-   Columns- 5H      4  .System.Windows.Controls.DataGridTemplateColumn  5I      ,  &System.Windows.Controls.DataGridColumn.   Header$. ID��6)   /   Width5  /System.Windows.Controls.DataGridLengthConverter$/ 85 65   0   CellTemplate0 5J      �� 5K      .R�5L      �� $
��Wrap=�6A   ��6(   �� $+ ID�6A   5M      5O        5P      $
. Name��6)   $	/ 100 67   0 5Q      �� 5R      .R�5S      �� $
��Wrap=�6C   ��6(   �� $
+ Name�6C   5T      5V        5W      $. Description��6)   $	/ 200 6>   0 5X      �� 5Y      .R�5Z      �� $
��Wrap=�6J   ��6(   �� $+ Description�6J   5[      5]        5^      $. Climate��6)   $
/ Auto 6:   1   
Visibility$1 Hidden=�6G   0 5_      �� 5`      .R�5a      �� $
��Wrap=�6F   ��6(   �� $+ Climate�6\   5b      5d        5e      $. Tourist status��6)   $
/ Auto 6A   $1 Hidden=�6N   0 5f      �� 5g      .R�5h      �� $
��Wrap=�6F   ��6(   �� $+ TStatus�6\   5i      5k        5l      $. Revenue��6)   $
/ Auto 6:   $1 Hidden=�6G   0 5m      �� 5n      .R�5o      �� $
��Wrap=�6F   ��6(   �� $+ Revenue�6\   5p      5r        5s      $. Ecologically endangered?��6)   $
/ Auto 6K   $1 Hidden=�6X   0 5t      �� 5u      .R�5v      �� 
����������	#FF055D79���	#FF003F65$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   2 d� 	IsChecked2 6'   �� $+ EE�3 � LayoutTransform3 5w   "   �� 5x   &   4 �� ScaleX$	4 1.2Q�65   5 �� ScaleY$	5 1.2Q�6B   5z      5{      5}        5~      $$. Habitat of endangered species?��6)   $
/ Auto 6Q   $1 Hidden=�6^   0 5      �� 5�      .R�5�      �� 
����������	#FF055D79���	#FF003F65$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   2 6'   �� $	+ HAB�3 5�   "   �� 5�   &   $	4 1.2Q�65   $	5 1.2Q�6B   5�      5�      5�        5�      $#. Located in urban environment?��6)   $
/ Auto 6P   $1 Hidden=�6]   0 5�      �� 5�      .R�5�      �� 
����������	#FF055D79���	#FF003F65$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   2 6'   �� $	+ URB�3 5�   "   �� 5�   &   $	4 1.2Q�65   $	5 1.2Q�6B   5�      5�      5�        5�      $. Date of discovery��6)   $
/ Auto 6D   $1 Hidden=�6Q   0 5�      �� 5�      .R�5�      :  4System.Windows.Controls.Primitives.DatePickerTextBox  $��Footlight MT)�6J   $��20(�6d   $��Stretch=�6r   $��Center=�6�   ���	#FF055D79$��5,0,0,0q�6�   6 �� 
IsReadOnly6 . ��60   �� $	+ DoD�6�   5�      5�        5�      $. Landmark Type��6)   $	/ 150 6@   0 5�      �� 5�      .R�5�      �� $
��Wrap=�6G   ��6(   �� $+ TypeView�6G   5�      5�        5�      $. Image��6)   $/ 85 68   0 5�      �� 5�      .R�5�      �� $��75��6F   $��75��6T   ��6$   �� $+ 	imagePath�6f   5�      5�        5�      $
. Tags��6)   $	/ 100 67   0 5�      �� 5�      .R�5�      �� $
��Wrap=�6F   ��6(   �� $+ TagView�6F   5�      5�      5�      �� 5�   
   -   5        $��OK��5�      $��Accept��6   $��5,5,5,5q�6,   $��12��6=   $��7��6K   $��2��6[   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6!  $
 Hand��63  $��Center=�6A  $.! (To save all created changes, click here.��6o  �� 5�   
   -   5        $��Delete��5�      $��Delete landmark��6   $��12��69   $��0��6G   $��10��6W   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Center=�6�   $��0q�6  $
��Bold"�6   $
 Hand��62  $��Center=�6@  $W! QTo delete a landmark, select the one you want from the list above and click here.��6r  �� 5�   
   -   5        $��Cancel��5�      $��Cancel��6   $��5,5,0,5q�60   $��12��6A   $��1��6O   $��2��6_   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $
��Left=�6�   $��0q�6  $
��Bold"�6$  $
 Hand��66  $��Center=�6D  $0! *To cancel all created changes, click here.��6v  5�      5�      