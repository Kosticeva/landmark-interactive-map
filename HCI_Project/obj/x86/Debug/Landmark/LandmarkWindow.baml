   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	        HCI_Project.LandmarkWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  Landmark Options��5   	    � WindowStartupLocation$ CenterScreen=�6"    � WindowStyle$ ThreeDBorderWindow=�6G    � Topmost .  #��Z��6x   #��Z��6�   ���	#FF00009F � WindowState$ 	Maximized=�6   � 
ResizeMode$ NoResize=�6    � Icon$1 +/HCI_Project;component/Images/17086-200.png��66  ��5      �� 5   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   	 J� CommandBindings	 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5        
   Command$.
 (local:CustomLandmarkCommands.ManageTypes��5
      6|     5   
   -   5        $-
 'local:CustomLandmarkCommands.ManageTags��5      6z     5   
   -   5        $-
 'local:CustomLandmarkCommands.OkLandmark��5      6z     5   
   -   5        $1
 +local:CustomLandmarkCommands.CancelLandmark��5      6�     5   
   -   5        $/
 )local:CustomLandmarkCommands.ExitLandmark��5      6~    J� InputBindings 5      �� 5   
   
 �� Key$ Y��6    �� 	Modifiers$ Controlf�6    �� Command$. (local:CustomLandmarkCommands.ManageTypes��61   6f   �� 5   
   $ T��6   $ Controlf�6   $- 'local:CustomLandmarkCommands.ManageTags��61   6e   �� 5   
   $ Enter��6   $ Controlf�6!   $- 'local:CustomLandmarkCommands.OkLandmark��65   6i   �� 5   
   $ Escape��6   $1 +local:CustomLandmarkCommands.CancelLandmark��6"   6Z   �� 5   
   $ F4��6   $	 Altf�6   $/ )local:CustomLandmarkCommands.ExitLandmark��6.   6d    � 	Resources 5      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value ��Name J� Opacity �� Path �� StringFormat �� RelativeSource �� AncestorType(  "System.Windows.Controls.DatePicker��%Q  '        �� 5   
   "  6   .�5      ��  � �� 5      �� 5      .R�5      �� $ PART_TextBox��6"   $��32(�5   e   $��Footlight MT)�6s   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   ��5   "   �� $ SelectedDate�$ dd MMM yyyy�� �� "  5   �   5      5!      5"      5#      .��5$      � $
��Auto��6   $
��Auto��6   
������� � ColumnDefinitions 5%   
   �� 5&      $��25 �6   �� 5'      $	��655 �6   �� 5(      �� 5)      $��25 �6    � RowDefinitions 5+   
   �� 5,      $��70 �6   �� 5-      �� 5.      $��70 �6   .+�50   
   �� $1��+/HCI_Project;component/Images/17086-200.png��6   $��2��6E   $��0��6R   $��4��6b   $��Bottom=�6v   $��Center=�6�   ]� 51   
   $��0��6   $��1��6!   $��2��61   52      ]� 53   
   $��2��6   $��1��6!   $��2��61   54      � 55   
   $��1��6   $��1��6   $ 1Q�6,   $��0q�68    56      �� 57      $	��100 �6#   �� 58      $	��180 �6#   �� 59      $��40 �6#   �� 5:      $	��220 �6#   �� 5;      $��50 �6#   �� 5<      $��65 �6#    5>      �� 5?      $��50 �6    �� 5@      $��50 �6    �� 5A      $	��100 �6    �� 5B      $��15 �6    �� 5C      $��55 �6    �� 5D      $��55 �6    �� 5E      $��50 �6    �� 5F      $��50 �6    �� 5G      $��50 �6    �� 5H      $��50 �6    .+�5J      �� -   5        $��ID��5J      $��Landmark ID:��6"   $��0��66   $��0��6C   $��2��6S   $��Right=�6g   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5K      -   5        $��Namee��5K      $��Landmark name:��6%   $��1��6<   $��0��6I   $��2��6Y   $��Right=�6m   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5L      -	   5        $��Description��5L      $��Description:��6+   $��2��6?   $��0��6L   $��2��6\   $��Right=�6p   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6   �� 5M      -
   5        $��Climate��5M      $��Climate:��6'   $��4��67   $��0��6D   $��2��6T   $��Right=�6h   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5N      -   5        $��TouristStatus��5N      $��Tourist status:��6-   $��5��6D   $��0��6Q   $��2��6a   $��Right=�6u   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  �� 5O      -   5        $��AnnualRevenue��5O      $��Annual revenue($):��6-   $��6��6G   $��0��6T   $��2��6d   $��Right=�6x   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  �� 5Q      -   5        $��ID_Field��5Q      $�� ��6&   $��0��6.   $��5 5 5 5q�6;   $��3��6L   $��3��6\   $��Stretch=�6p   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6  $ �� HorizontalScrollBarVisibility$ Disabled=�6   �� MaxLines$ 1��6=   �� SelectionBrush �	#FF055D79  �� SelectionOpacity$	  0.5Q�6e  ! �� 	UndoLimit$	! 200��6|  "" �� VerticalScrollBarVisibility$
" Auto=�6�  # � ToolTip$"# Unique ID for your landmark.��6�  $ �� TextWrapping$
$ Wrap=�6�  % �� 
CaretBrush
% �����6�  �� 5R      -   5        $��
Name_Field��5R      $�� ��6(   $��1��60   $��5 5 5 5q�6=   $��3��6N   $��3��6^   $��Stretch=�6r   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $ Disabled=�6  $ 1��6?   �	#FF055D79$	  0.5Q�6g  $	! 200��6~  $
" Auto=�6�  $# Name for your landmark.��6�  $
$ Wrap=�6�  
% �����6�  �� 5S      -   5        $��Description_Field��5S      $�� ��6/   $��2��67   $��5 5 5 5q�6D   $��3��6U   $��3��6e   $��Stretch=�6y   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6  $	 200��6B   �	#FF055D79$	  0.5Q�6l  $	! 200��6�  $
" Auto=�6�  $$ WrapWithOverflow=�6�  
% �����}�.  & �� AcceptsReturn& .  ' �� 
AcceptsTab' .  $��2��6'  $## Description of your landmark.��68  �� 5T      -   5        $��Climate_Field��5T      $��4��6,   $��5q�69   $��3��6D   $��3��6T   $��Stretch=�6h   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99$ 1Q�6�   $ Arrow��6�   ���	#FF055D79( �� SelectedIndex$( 0��6�   $��5q�6	  $6# 0Climate type in which your landmark is situated.��6  5U      �� 5V      -   5        $��TouristStatus_Field��5V      $��5��62   $��5q�6?   $��3��6J   $��3��6Z   $��Stretch=�6n   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99$ 1Q�6�   $ Arrow��6�   ���	#FF055D79$( 0��6�   $��5q�6  $&#  Tourist status of your landmark.��6  5W      �� 5X      -   5        $��AnnualRevenue_Field��5X      $��6��61   $��5 5 5 5q�6>   $��3��6O   $��3��6_   $��Stretch=�6s   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6  $ 1��6<   �	#FF055D79$	  0.5Q�6d  $	! 200��6{  $" Disabled=�6�  $7# 1Annual revenue your landmark earns (in dollars). ��6�  
% �����) � DataContext) 6�  �� $ {0:c}��.��6.  ��5Y      �� 5Z      $ Revenue�6   * �� UpdateSourceTrigger$* PropertyChanged=�6-   + �� ValidationRules+ 5[      5  /System.Windows.Controls.ExceptionValidationRule  5\      (  "HCI_Project.LandmarkDataValidation  5]      ,  &System.Windows.Controls.ValidationRule,   ValidationStep$, RawProposedValue=�6;   5_      .��5`       5a      �� 5b      -   5        $	��Eco��5b      $��7��6"   $��4��6/   ���	#FF003F65$��Center=�6W   $��Center=�6{   $��0q�6�   $��Center=�6�   $��Center=�6�   ���	#FF055D79$/# )Is your landmark ecologically endangered?��6�   - � LayoutTransform- 5c      �� 5d      . �� ScaleX$. 2Q�6%   / �� ScaleY$/ 2Q�60   5f      �� 5g      -   5        $��Danger��5g      $��8��6%   $��4��62   ���	#FF003F65$��Center=�6Z   $��Center=�6~   $
��9,10q�6�   $��Center=�6�   ���	#FF055D79$7# 1Is your landmark a habitat of endangered species?��6�   - 5h      �� 5i      $. 2Q�6%   $/ 2Q�60   5k      �� 5l      -   5        $��	Habitated��5l      $��9��6(   $��4��65   ���	#FF003F65$��Center=�6]   $��Center=�6�   $��0q�6�   $��Center=�6�   $��Center=�6�   ���	#FF055D79$4# .Is your landmark located in urban environment?��6�   - 5m      �� 5n      $. 2Q�6%   $/ 2Q�60   5p      �� 5q      -   5        $��Eco_Text��5q      $"��It is ecologicaly endangered��6(   $��7��6L   $��0��6Y   $��4��6i   $��Right=�6}   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  $��5q�6(  �� 5r      -   5        $��Danger_Text��5r      $+��%It is a habitat of endangered species��6+   $��8��6X   $��0��6e   $��4��6u   $��Right=�6�   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6  $��Center=�6  $��5q�64  �� 5s      -   5        $��Habitable_Text��5s      $(��"It is located in urban environment��6.   $��9��6X   $��0��6e   $��4��6u   $��Right=�6�   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6  $��Center=�6  5t      � 5v   
   $��1��6   $��2��6   $ 1Q�6,    5w      �� 5x      $��35 �6#   �� 5y      $	��150 �6#   �� 5z      $��40 �6#   �� 5{      $��40 �6#   �� 5|      $��40 �6#   �� 5}      �� 5~      $��75 �6#   �� 5      $��50 �6#    5�      �� 5�      $��50 �6    �� 5�      $��50 �6    �� 5�      $��50 �6    �� 5�      �� 5�      $��25 �6    �� 5�      $��50 �6    �� 5�      $��50 �6    �� 5�      $��50 �6    �� 5�      $��50 �6    �� 5�      $��25 �6    .+�5�      �� -   5        $��DiscoveryDate��5�      $��Date of discovery:��6-   $��0��6G   $��0��6T   $��4��6d   $��Right=�6x   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6    5�      -   5        $��DateDiscovery��5�      $��0��6.   $��5��6;   $��Footlight MT)�6K   $��32(�6e   $��Stretch=�6s   $��Center=�6�   ���	#FF055D79$��5,0,0,0q�6�   $��3��6�   $@# :Select a date at which your landmark was first discovered.��6�   �� 5�      -   5        $��LandmarkType��5�      $��Landmark type:��6,   $��1��6B   $��0��6O   $��4��6_   $��Right=�6s   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  �� 5�      -   5        $��Chosen_landmark_type��5�      $�� ��62   $��1��6:   $��5 5 5 5q�6G   $��5��6X   $��3��6h   $��Stretch=�6|   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6   $	 200��6E   �	#FF055D79$	  0.5Q�6o  $	! 200��6�  $
" Auto=�6�  $
$ Wrap=�6�  
% �����}�.  & .  ' .  0 �� 
IsReadOnly0 . $�# {This is the ID of your landmark's selected landmark type. To change landmark type or create your own, click ''Choose type''��60  �� 5�      -   5        $��	Choose_LT��5�      $��Choose type��6&   $��2��6<   $��0,0,5,0q�6I   $��5��6Z   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6  $
 Hand��6.  $��3��6T  $F# @To select existing landmark type or create your own, click here.��6h  �� 5�      -   5        $��Iconn��5�      $��Landmark icon: ��6%   $��3��6<   $��1��6I   $��Right=�6Y   $��32(�6u   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6�   $��2��6  $��WrapWithOverflow=�6  �� 5�      -   5        $	��Img��5�      $��3��6   $��3��6,   $��3��6<   $��5,5,5,5q�6P   $
��Left=�6a   $	��Top=�6|   $��1��6�   $7# 1This is the image you selected for your landmark.��6�   ��6�   �� *
Image_Path+$* PropertyChanged=�6�   �� 5�      -    5        $��Choose_Icon��5�      $��Browse��6(   $��3��69   $��5,5,5,5q�6F   $��6��6W   $��2��6g   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��30(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6-  $
 Hand��6?  $	��Top=�6M  $;# 5To browse for an image for your landmark, click here.��6|  �� 5�      -!   5        $
��Tags��5�      $��Tags:��6$   $��5��61   $��1��6>   $��Right=�6N   $��32(�6j   $��Footlight MT)�6x   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6�   �� 5�      -"   5        $��
Tags_Field��5�      $�� ��6(   $��5��60   $��3��6=   $��5 5 5 5q�6N   $��3��6_   $��5��6o   $��Stretch=�6�   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6'  $	 200��6L   �	#FF055D79$	  0.5Q�6v  $	! 200��6�  $
" Auto=�6�  $
$ Wrap=�6�  
% �����}�.  & .  ' .  0 .  $b# \These are all Tag ID's you added for your landmark. To add a new tag, click ''Manage tags''.��68  6�  �� 5�      -#   5        $��Choose_T��5�      $��Manage tags��6%   $��8��6;   $	��5,0q�6H   $��5��6U   $��3��6e   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��32(�6�   $ 1Q�6�   $��5q�6�   $��Right=�6�   $��0q�6  $
��Bold"�6+  $
 Hand��6=  $	��Top=�6K  $4# .To add a new tag to your landmark, click here.��6z  5�      �� 5�   
   -$   5        $��	MainTitle��5�      $O��IPlease fill in all information about you new landmark in following fields��6%   $��0��6v   $��1��6�   $��2��6�   $��40(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6	  $��Center=�6  $��Center=�66  �� 5�   
   $��Accept��6   $��Right=�6#   $��Center=�6?   $��11��6Z   $��5 5 5 5q�6h   $��2��6y   $��1��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��30(�6�   $ 1Q�6  $��5q�6  $��0q�6  $
��Bold"�63  $
 Hand��6E  $-��'local:CustomLandmarkCommands.OkLandmark��6S  $.# (To save all created changes, click here.��6�  �� 5�   
   1 �� IsCancel1 . $��Cancel��6!   $
��Left=�62   $��Center=�6M   $��11��6h   $��5 5 5 5q�6v   $��1��6�   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��30(�6  $ 1Q�6  $��5q�6!  $��0q�6-  $
��Bold"�6A  $
 Hand��6S  $1��+local:CustomLandmarkCommands.CancelLandmark��6a  $0# *To cancel all created changes, click here.��6�  5�      5�      