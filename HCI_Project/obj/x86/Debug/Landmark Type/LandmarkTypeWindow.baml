   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	   $    HCI_Project.LandmarkTypeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  Landmark type options��5   	   #��Z��6'   $
��1000��6d    � 
ResizeMode$ NoResize=�6q    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�   ��5      �� 5   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5        	   Command$%	 local:CustomTypeCommands.OkType��5
      6n     5   
   -   5        $)	 #local:CustomTypeCommands.CancelType��5      6v     5   
   -   5        $'	 !local:CustomTypeCommands.ExitType��5      6r   
 J� InputBindings
 5      �� 5   
   
 �� Key$ Enter��6    �� 	Modifiers$ Controlf�6!    �� Command$% local:CustomTypeCommands.OkType��65   6a   �� 5   
   $ F4��6   $	 Altf�6   $' !local:CustomTypeCommands.ExitType��6.   6\   �� 5   
   $ Escape��6   $) #local:CustomTypeCommands.CancelType��6"   6R   .��5      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      �� 5      $	��150 �6   �� 5      $��40 �6   �� 5      $��70 �6   �� 5      $��70 �6    � ColumnDefinitions 5    
   �� 5!      $��40 �6   �� 5"      $��40 �6   �� 5#      �� 5$      $��30 �6   �� 5%      $	��240 �6   �� 5&      $��50 �6   �� 5'      $	��100 �6   �� 5(      $��40 �6   .+�5*   
   �� -   5        $��ID��5*      $��Landmark type ID:��6   $��3��67   $��1��6D   $��2��6T   $��Right=�6h   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5+   
   -   5        $��Color��5+      $��Landmark type name:��6!   $��4��6=   $��0��6J   $��3��6Z   $��Right=�6n   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5,   
   -   5        $��Description��5,      $ ��Landmark type description:��6'   $��5��6I   $��2��6V   $��Right=�6f   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $	��Top=�6�   $
��Wrap=�6   �� TextAlignment$ Right=�6"  �� 5-   
   -   5        $��Iconn��5-      $��Landmark type icon:��6!   $��WrapWithOverflow=�6<   $��6��6\   $��1��6i   $��2��6y   $��Right=�6�   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6  $	��Top=�6  $ Right=�65  �� 5/   
   -	   5        $��
LTID_Field��5/      $�� ��6$   $��3��6,   $��5 5 5 5q�69   $��4��6J   $��3��6Z   $��Stretch=�6n   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6  $ �� HorizontalScrollBarVisibility$ Disabled=�6   �� MaxLines$ 1��6;   �� SelectionBrush �	#FF055D79 �� SelectionOpacity$	 0.5Q�6c   �� 	UndoLimit$	 200��6z  " �� VerticalScrollBarVisibility$
 Auto=�6�   � ToolTip$' !Unique ID for your landmark type.��6�   �� TextWrapping$
 Wrap=�6�   �� 
CaretBrush
 �����6�  �� 50   
   -
   5        $��LTName_Field��50      $�� ��6&   $��4��6.   $��5 5 5 5q�6;   $��4��6L   $��3��6\   $��Stretch=�6p   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $ Disabled=�6  $ 1��6=   �	#FF055D79$	 0.5Q�6e  $	 200��6|  $
 Auto=�6�  $" Name for your landmark type.��6�  $
 Wrap=�6�  
 �����6�  �� 51   
   -   5        $��LTDescription_Field��51      $�� ��6-   $��5��65   $��5 5 5 5q�6B   $��4��6S   $��3��6c   $��Stretch=�6w   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    . $ Arrow��6  $
 Auto=�6  $	 200��6@   �	#FF055D79$	 0.5Q�6j  $	 200��6�  $
 Auto=�6�  $ WrapWithOverflow=�6�  }�.   �� AcceptsReturn .   �� 
AcceptsTab .  $( "Description of your landmark type.��6  
 �����6?  �� 52   
   -   5        $��Choose_Icon��52      $��Browse��6$   $��6��65   $��5��6B   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6�   $ 1Q�6�   $��0q�6�   $��Right=�6�   $��0q�6�   $
��Bold"�6  $
 Hand��6  $	��Top=�6$  $��2��6<  $��5,5,5,5q�6P  $@ :To browse for an image for your landmark type, click here.��6x  �� 53   
   -   5        $	��Img��53      $��6��6   $��4��6(   $��1��68   $
��Left=�6L   $	��Top=�6g   $��5q�6�   $k eThis is the image you chose for your landmark type. To change the image, click the ''Browse'' button.��6�   ��6   ��  �� Path$ 
Image_Path�  �� UpdateSourceTrigger$  PropertyChanged=�6�   �� 54   
   -   5        $��	MainTitle��54      $A��;Please fill in all information about your new landmark type��6%   $��0��6h   $��3��6u   $��8��6�   $��44(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6  $��Center=�6)  $��WrapWithOverflow=�6F  $ Center=�6f  �� 55   
   -   5        ! �� IsCancel! . $��Cancel��55   !   $
��Left=�62   $��Center=�6M   $��9��6h   $��5 5 5 5q�6u   $��1��6�   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6  $ 1Q�6  $��0q�6   $��0q�6,  $
��Bold"�6@  $
 Hand��6R  $0 *To cancel all created changes, click here.��6u  �� 56   
   -   5        $��Accept��56      $��Right=�6#   $��Center=�6?   $��9��6Z   $��5 5 5 5q�6g   $��5��6x   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6�   $ 1Q�6  $��0q�6  $��0q�6  $
��Bold"�62  $
 Hand��6D  $. (To save all created changes, click here.��6c  �� 57   
   $1��+/HCI_Project;component/Images/17086-200.png��6   $��9��6E   $��1��6R   $��0��6c   $��8��6s   $��Stretch=�6�   $��Center=�6�   58      59      