   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	        HCI_Project.ListTagsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  Choose existing tag��5   	   #��Z��6%   $
��1000��6b    � 
ResizeMode$ NoResize=�6o    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '  �     �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5	       � ��
	 �����6+   �� 5
       � ��$	 Footlight MT)�6+   �� 5       � ��$	 16(�6)   5      �� 5   
   "  6   .�5      ��  � ��	 �	#FF257D996,   �� 5       � ��
	 �����6+   �� 5       � ��$	 Footlight MT)�6+   �� 5       � ��$	 16(�6)   5      5      
 J� CommandBindings
 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$&  local:CustomTagsCommands.NewTag1��5      6p     5   
   -   5        $) #local:CustomTagsCommands.DeleteTag1��5      6v     5   
   -   5        $% local:CustomTagsCommands.AddTag��5      6n     5   
   -   5        $( "local:CustomTagsCommands.RemoveTag��5      6t     5   
   -   5        $% local:CustomTagsCommands.OkTags��5      6n     5   
   -   5        $) #local:CustomTagsCommands.CancelTags��5      6v     5   
   -   5        $' !local:CustomTagsCommands.ExitTags��5      6r     5   
   -	   5        $&  local:CustomTagsCommands.EditTag��5      6p    J� InputBindings 5      �� 5   
   
 �� Key$ N��6    �� 	Modifiers$ Controlf�6    �� Command$&  local:CustomTagsCommands.NewTag1��61   6^   �� 5    
   $ X��6   $ Controlf�6   $) #local:CustomTagsCommands.DeleteTag1��61   6a   �� 5!   
   $ V��6   $ Controlf�6   $% local:CustomTagsCommands.AddTag��61   6]   �� 5"   
   $
 Back��6   $( "local:CustomTagsCommands.RemoveTag��6!   6P   �� 5#   
   $ Enter��6   $ Controlf�6!   $% local:CustomTagsCommands.OkTags��65   6a   �� 5$   
   $ Escape��6   $) #local:CustomTagsCommands.CancelTags��6"   6R   �� 5%   
   $ F4��6   $	 Altf�6   $' !local:CustomTagsCommands.ExitTags��6.   6\   �� 5&   
   $ E��6   $ Controlf�6   $&  local:CustomTagsCommands.EditTag��61   6^   ��5(      �� 5)   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   .��5+      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � RowDefinitions 5,   
   �� 5-      $��40 �6   �� 5.      $��50 �6   �� 5/      $��50 �6   �� 50      $��40 �6   �� 51      $��50 �6   �� 52      $��10 �6   �� 53      $��50 �6   �� 54      $��10 �6   �� 55      �� 56      $��70 �6    � ColumnDefinitions 58   
   �� 59      $��40 �6   �� 5:      $��40 �6   �� 5;      $	��100 �6   �� 5<      $��40 �6   �� 5=      $	��160 �6   �� 5>      $��40 �6   �� 5?      $	��160 �6   �� 5@      $��40 �6   �� 5A      $	��100 �6   �� 5B      $��40 �6   �� 5C      $��40 �6   .+�5E   
   �� $1��+/HCI_Project;component/Images/17086-200.png��6   $��9��6E   $��0��6R   $��11��6b   $��Stretch=�6w   $��Center=�6�   �� 5F   
   -
   5        $��Titlee��5F      $8��2Here you can find existing tags or create your own��6"   $��1��6\   $��2��6i   $��0��6z   $��11��6�   $��40(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6  $��Center=�6  $��Center=�6.  $��WrapWithOverflow=�6K   �� TextAlignment$ Center=�6k  �� 5G   
   -   5        $��Title1��5G      $��Existing tags��6"   $��6��67   $��1��6D   $��4��6T   $��32(�6h   $��Footlight MT)�6v   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��WrapWithOverflow=�6  $ Center=�64  $��5q�6K  �� 5H   
   -   5        $��Title2��5H      $��	Your tags��6"   $��6��63   $��6��6A   $��32(�6Q   $��Footlight MT)�6_   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��WrapWithOverflow=�6�   $ Center=�6  $��4��64  $��5q�6H  �� 5J   
   -   5        $��NewTag��5J      $��New Tag��6   $��5,5,5,5q�61   $��4��6B   $��1��6O   $��2��6_   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6%   � Cursor$
 Hand��67  $	��Top=�6E  $��2��6]   � ToolTip$# To add a new tag, click here.��6�  �� 5K   
   -   5        $��Delete��5K      $��
Delete Tag��6   $��5,5,5,5q�64   $��4��6E   $��3��6R   $��2��6b   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6(  $
 Hand��6:  $	��Top=�6H  $��2��6`  $F @To delete tag, select a tag from the list below and  click here.��6�  �� 5L   
   -   5        $��Search��5L      $��Search for tag��6    $��4��66   $��6��6C   $��4��6S   $��5 5 5 5q�6g   $��Stretch=�6x   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection . $ Arrow��6  $ �� HorizontalScrollBarVisibility$ Disabled=�6   �� MaxLines$	 200��6E   �� SelectionBrush �	#FF055D79 �� SelectionOpacity$	 0.5Q�6o   �� 	UndoLimit$	 200��6�  " �� VerticalScrollBarVisibility$
 Auto=�6�   �� TextWrapping$
 Wrap=�6�    �� 
CaretBrush
  �����}�.  ! �� AcceptsReturn! .  " �� 
AcceptsTab" .  $D >To find a tag with specific name or property, enter data here.��6  6h  &   System.Windows.Controls.DataGrid  5M   
   -   5        #  Name$# dgrCreatedTags��5M      $��8��6+   $��5,5,5,5q�68   $��1��6I   $��4��6Y   $   
IsReadOnly$ . %   AutoGenerateColumns% .  $& �� IsSynchronizedWithCurrentItem$
& TrueY�6�   $'   HorizontalScrollBarVisibility$' Disabled=�6�   ( �� IsTextSearchEnabled( . )   HorizontalGridLinesBrush) �	#FF257D99*   VerticalGridLinesBrush* �	#FF257D99���	#FF257D99���	#FF257D99
�������$��3q�6�  $O IHere you can see all the tags that have been created in this application.��6�  +   MinColumnWidth$+ 50Q�6B  ,   MaxColumnWidth$	, 300Q�6V  - J� 	AllowDrop- . ��6m   �� . �� Path$. 	ExistTags�/   Columns/ 5N      4  .System.Windows.Controls.DataGridTemplateColumn  5O      ,  &System.Windows.Controls.DataGridColumn0   Header$0 ID��6)   1   Width5  /System.Windows.Controls.DataGridLengthConverter$	1 100 65   2   CellTemplate2 5P      �� 5Q      .R�5R      �� $
��Wrap=�6A   ��6(   �� $. ID�6A   5S      5U        5V      $0 Color��6)   $1 50 68   2 5W      �� 5X      .R�5Y      �� ��6)   �� $. Color�3 �� Mode$3 TwoWay=�4 �� UpdateSourceTrigger$4 PropertyChanged=�5Z      5\        5]      $0 Description��6)   $	1 190 6>   2 5^      �� 5_      .R�5`      �� $
��Wrap=�6J   ��6(   �� $. Description�6J   5a      5c      5e        5g   
   -   5        $# dgrSelectedTags��5g      $��8��6,   $��5,5,5,5q�69   $��6��6J   $��4��6Z   $ . % .  $
& TrueY�6�   $' Disabled=�6�   ( . ) �	#FF257D99* �	#FF257D99���	#FF257D99���	#FF257D99
�������$��3q�6�  $7 1Here you can see all tags added to your landmark.��6�  $	, 300Q�6(  $+ 50Q�6=  - . ��6n   �� $. MyTags�/ 5h        5i      $0 ID��6)   $	1 100 65   2 5j      �� 5k      .R�5l      �� $
��Wrap=�6A   ��6(   �� $. ID�6A   5m      5o        5p      $0 Color��6)   $1 50 68   2 5q      �� 5r      .R�5s      �� ��6)   �� $. Color�$3 TwoWay=�$4 PropertyChanged=�5t      5v        5w      $0 Description��6)   $	1 190 6>   2 5x      �� 5y      .R�5z      �� $
��Wrap=�6J   ��6(   �� $. Description�6J   5{      5}      5      �� 5�   
   -   5        $��OK��5�      $��Accept��6   $��5,5,5,5q�6,   $��9��6=   $��7��6J   $��3��6Z   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6   $
 Hand��62  $��Center=�6@  $. (To save all created changes, click here.��6n  �� 5�   
   -   5        $��Cancel��5�      $��Cancel��6   $��5,5,5,5q�60   $��9��6A   $��1��6N   $��2��6^   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $
��Left=�6�   $��0q�6  $
��Bold"�6#  $
 Hand��65  $��Center=�6C  $0 *To cancel all created changes, click here.��6u  5�      5�      