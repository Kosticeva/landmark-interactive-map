   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	       HCI_Project.MapWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  NATURAL HERITAGE MAP��5   	    � WindowStartupLocation$ CenterScreen=�6&    � WindowStyle$ ThreeDBorderWindow=�6K    � Topmost .  #��Z��6|   #��Z��6�   ���	#FF00009F � WindowState$ 	Maximized=�6   � 
ResizeMode$ NoResize=�6$   � Icon$1 +/HCI_Project;component/Images/17086-200.png��6:   J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$&  local:CustomCommands.NewLandmark��5      6t     5   
   -   5        $* $local:CustomCommands.NewLandmarkType��5      6|     5	   
   -   5        $! local:CustomCommands.NewTag��5	      6j     5
   
   -   5        $ local:CustomCommands.Save��5
      6f     5   
   -   5        $ local:CustomCommands.Exit��5      6f     5   
   -   5        $( "local:CustomCommands.ListLandmarks��5      6x     5   
   -   5        $! local:CustomCommands.Delete��5      6r     5   
   -	   5        $ local:CustomCommands.Cut��5      6l     5   
   -
   5        $ local:CustomCommands.Copy��5      6n     5   
   -   5        $  local:CustomCommands.Paste��5      6p   	 J� InputBindings	 5      �� 5   
   

 �� Key$
 S��6    �� 	Modifiers$ Controlf�6    �� Command$ local:CustomCommands.Save��61   6W   �� 5   
   $
 F4��6   $	 Altf�6   $ local:CustomCommands.Exit��6.   6T   �� 5   
   $
 L��6   $ Controlf�6   $&  local:CustomCommands.NewLandmark��61   6^   �� 5   
   $
 Y��6   $ Controlf�6   $* $local:CustomCommands.NewLandmarkType��61   6b   �� 5   
   $
 T��6   $ Controlf�6   $! local:CustomCommands.NewTag��61   6Y   �� 5   
   $
 F��6   $ Controlf�6   $( "local:CustomCommands.ListLandmarks��61   6`   �� 5   
   $
 Delete��6   $! local:CustomCommands.Delete��6"   6J   �� 5   
   $
 X��6   $ Controlf�6   $ local:CustomCommands.Cut��61   6V   �� 5   
   $
 C��6   $ Controlf�6   $ local:CustomCommands.Copy��61   6W   �� 5   
   $
 V��6   $ Controlf�6   $  local:CustomCommands.Paste��61   6X   .��5      ]� 
�������.+�5      o� $	��Top=�6   ��5       �� 5!      .R�5"      ]� $��Stretch=�6$   6D   5#      .@�5%      m� $
��File��6   $
��Left=�6)   $��44(�6K   $	��120��6Y   ���	#FF055D79$��Footlight MT)�6|    m� StaysOpenOnClick .  m� Icon 5&      �� 5'      $,��&/HCI_Project;component/Images/file.png��6    .@�5)      m� $��New...��6#    . .@�5*      m� $��Landmark��6'    m� Command$&  local:CustomCommands.NewLandmark��69    � ToolTip$) #To create new landmark, click here.��6e    5+      �� 5,      $1��+/HCI_Project;component/Images/17086-200.png��6$   5.      m� 5/      $��Landmark Type��6'   $* $local:CustomCommands.NewLandmarkType��6>   $. (To create new landmark type, click here.��6m    50      �� 51      $,��&/HCI_Project;component/Images/type.png��6$   53      m� 54      $	��Tag��6'   $! local:CustomCommands.NewTag��64   $$ To create new tag, click here.��6Z    55      �� 56      $,��&/HCI_Project;component/Images/tags.png��6$   58      59      m� 5:      $
��Save��6#   $ local:CustomCommands.Save��61   $. (To save all created changes, click here.��6U   5;      m� 5<      $
��Exit��6   $ local:CustomCommands.Exit��6-   $/ )To exit Natural Heritage Map, click here.��6Q   5=      5>      m� 5?      $
��Edit��6   $
��Left=�6-   $��44(�6O   $	��120��6]   ���	#FF055D79$��Footlight MT)�6�    .  5@      �� 5A      $,��&/HCI_Project;component/Images/edit.png��6    .@�5C      m� -   5        $	��Cut��5C      $	��Cut��6*   $ local:CustomCommands.Cut��67    5D      �� 5E      $+��%/HCI_Project;component/Images/Cut.png��6$   5G      m� 5H      -   5        $
��Copy��5H      $
��Copy��6+   $ local:CustomCommands.Copy��69    5I      �� 5J      $1��+/HCI_Project;component/Images/copy-icon.png��6$   5L      m� 5M      -   5        $��Paste��5M      $��Paste��6,   $  local:CustomCommands.Paste��6;    5N      �� 5O      $-��'/HCI_Project;component/Images/Paste.png��6$   5Q      m� 5R      -   5        $��Delete��5R      $��Delete��6-   $! local:CustomCommands.Delete��6=   $7 1To delete selected landmark from map, click here.��6c    5S      �� 5T      $2��,/HCI_Project;component/Images/delete1600.png��6$   5V      �� 5W      6"   m� 5X      $��List all landmarks��6   $( "local:CustomCommands.ListLandmarks��6;   $7 1To view a list of all your landmarks, click here.��6h    5Y      �� 5Z      $0��*/HCI_Project;component/Images/list1600.png��6$   5\      5]      m� 5^      $
��View��6   $
��Left=�6)   $��44(�6K   $	��120��6Y   ���	#FF055D79$��Footlight MT)�6|    .  5_      �� 5`      $,��&/HCI_Project;component/Images/view.png��6    .@�5b      ]� -   5        $
��Left=�5b       .+�5c      �� $��
Change Map��6$   $��5,0,0,0q�66   $��44(�6G   ���	#FF055D79$��Center=�6l   5d      �� 5e      m� 5f      $��Toolbox ...��6   .@�5g      ]� $
��Left=�6$   .+�5h      �� -   5        $��CB��5h   '   $
��Left=�61   
����������	#FF055D79���	#FF003F65 J� Opacity$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $$ To enable toolbox, click here.��6I   � LayoutTransform 5i   "   �� 5j   &    �� ScaleX$	 1.5Q�65    �� ScaleY$	 1.5Q�6B   5l      �� 5m      $��Visible��6(   $��5,0,0,0q�67   $��44(�6H   ���	#FF055D79$��Center=�6m   5n      ]� 5o      $
��Left=�6$   .+�5p      	� -   5        $	��RBH��5p   *   $
��Left=�65   
����������	#FF055D79���	#FF003F65$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $$ To enable toolbox, click here.��6O   	� 	GroupName$ Orientation��6x   5q   "   �� 5r   &   $	 1.5Q�65   $	 1.5Q�6B   5t      �� 5u      $��
Horizontal��6(   $��5,0,0,0q�6:   $��44(�6K   ���	#FF055D79$��Center=�6p   5v      ]� 5w      $
��Left=�6$   .+�5x      	� -   5        $	��RBV��5x   *   $
��Left=�65   
����������	#FF055D79���	#FF003F65$ 1Q�6�   $��0q�6�   $��1q�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $$ To enable toolbox, click here.��6O  $ Orientation��6x   5y   "   �� 5z   &   $	 1.5Q�65   $	 1.5Q�6B   5|      �� 5}      $��Vertical��6(   $��5,0,0,0q�68   $��44(�6I   ���	#FF055D79$��Center=�6n   5~      5      5�      m� 5�      $
��Help��6   $��44(�6)   ���	#FF055D79$	��120��6N   $��Footlight MT)�6Z   $��Right=�6t   $��Right=�6�    5�      �� 5�      $3��-/HCI_Project;component/Images/missing_pic.png��6   5�      5�      �� 5�   
   -   5        $
��Goal��5�      $
��Auto��6   $
��Auto��6*    J� 	AllowDrop . ��5�      �� 5�       �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6   .+�5�      `� -   5        $��Target��5�      $y�Hidden=�6(    `� Orientation$ Vertical=�6<   $	��400��6S   $
��Left=�6`   $��50��6{   .�5�      c� -   5        $
��Barr��5�      
�������$��50��69   $	��200��6D   .@�5�      �� -   5        $��40��5�      $��40��6(    c� OverflowMode$ Never=�64   .��5�      �� $1��+/HCI_Project;component/Images/17086-200.png��6    $) #To create new landmark, click here.��6U   5�      �� 5�      -   5        $��40��5�      $��40��6(   $ Never=�64   .��5�      �� $,��&/HCI_Project;component/Images/type.png��6    $. (To create new landmark type, click here.��6P   5�      �� 5�      -   5        $��40��5�      $��40��6(   $ Never=�64   .��5�      �� $,��&/HCI_Project;component/Images/tags.png��6    $$ To create new tag, click here.��6P   5�      �� 5�      -   5        $��40��5�      $��40��6(   $ Never=�64   .��5�      �� $0��*/HCI_Project;component/Images/list1600.png��6    $, &To view created landmarks, click here.��6T   5�      5�      c� 5�      -   5        $��Barr1��5�      
�������$��50��6:   $	��200��6E   .@�5�      �� $��40��6   $��40��6(   $ Never=�64   $��local:CustomCommands.Cut��6Q   .��5�      �� $+��%/HCI_Project;component/Images/Cut.png��6    5�      �� 5�      $��40��6   $��40��6(   $ Never=�64   $��local:CustomCommands.Copy��6Q   .��5�      �� $1��+/HCI_Project;component/Images/copy-icon.png��6    5�      �� 5�      $��40��6   $��40��6(   $ Never=�64   $ ��local:CustomCommands.Paste��6Q   .��5�      �� $-��'/HCI_Project;component/Images/Paste.png��6    5�      �� 5�      $��40��6   $��40��6(   $ Never=�64   $!��local:CustomCommands.Delete��6Q   .��5�      �� $2��,/HCI_Project;component/Images/delete1600.png��6    5�      5�      5�      5�      5�      5�      