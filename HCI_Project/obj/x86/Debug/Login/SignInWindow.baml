   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	       HCI_Project.SignInWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  SignInWindow��5   	   #��Z��6   $
��1000��6[    � 
ResizeMode$ NoResize=�6h    � WindowStartupLocation$ CenterScreen=�6~    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�   ��5      �� 5   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   .��5	      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68   	 � RowDefinitions	 5
   
   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      �� 5      $��70 �6   �� 5      $��70 �6   
 � ColumnDefinitions
 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $	��210 �6   �� 5      $��30 �6   �� 5      $	��400 �6   �� 5      $��40 �6   �� 5       $��40 �6   .+�5"   
   �� -   5        $��Title1��5"      $��Welcome to the��6"   $��1��68   $��2��6E   $��3��6U   $��WrapWithOverflow=�6i   ���	#FF055D79$��44(�6�   $��Gabriola)�6�    �� TextAlignment$ Center=�6�   $��Normal$�6�   $
��Bold"�6�   $��Center=�6   �� 5#   
   -   5        $��Title11��5#      $��NATURAL HERITAGE MAP��6#   $��2��6?   $��1��6L   $��0��6]   $��7��6m   $��80(�6�   $
��Bold"�6�   $��Italic$�6�   $��Gabriola)�6�   $
��None=�6�   $ 1Q�6�   ���	#FF055D79���	#00ECF6F8$ Center=�6  }�.   J� 	AllowDrop .  $��Center=�6V   J� OpacityMask 6r  �� 6�   �� EndPoint$ 1,0.5&�6�   �� 
StartPoint$ 0,0.5&�6�  .��6�  �  � Color$ Black��6�   � Offset$ 0Q�6�  � 6�  $ White��6�  $ 1Q�6  6  6C  �� 5$   
   -   5        $��Manual1��5$      $?��9Please fill in the following fields to create new account��6#   $��3��6d   $��0��6q   $��7��6�   $��3��6�   $��WrapWithOverflow=�6�   ���	#FF055D79$��44(�6�   $��Footlight MT)�6�   $ Center=�6  $��Normal$�6  $
��Bold"�6/  $��Center=�6A  �� 5%   
   -   5        $��Name1��5%      $��	Username:��6!   $��7��62   $��1��6?   $��2��6O   $��Right=�6c   $��32(�6   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5&   
   -   5        $��Email1��5&      $��Email:��6"   $��8��60   $��1��6=   $��2��6M   $��Right=�6a   $��32(�6}   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5'   
   -   5        $��Password��5'      $��	Password:��6$   $��9��65   $��1��6B   $��2��6R   $��Right=�6f   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5(   
   -   5        $��UN_Field_SW��5(      $��7��6%   $��5 5 5 5q�62   $��4��6C   $��1��6S   $��Stretch=�6g   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6�    �� SelectionBrush
 ����� �� MaxLines$ 1��6"   �� 	UndoLimit$	 200��6/   �� SelectionOpacity$ 1Q�6?  $ �� HorizontalScrollBarVisibility$ Disabled=�6T  " �� VerticalScrollBarVisibility$
 Auto=�6}   � ToolTip$0 *Here you can enter your specific username.��6�   �� TextWrapping$
 Wrap=�6�   �� 
CaretBrush
 �����.��6�  ��5)      �� 5*       �� Path$ Name_Username�6    �� UpdateSourceTrigger$ PropertyChanged=�6/    �� ValidationRules 5+      5  /System.Windows.Controls.ExceptionValidationRule  5,      $  HCI_Project.UsernameValidation  5-      ,  &System.Windows.Controls.ValidationRule    ValidationStep$  RawProposedValue=�63   5/      .��50      ! =� ErrorTemplate! 51      �� 52      .R�53      � $	��Grd��6   	 54      �� 55      $��50 �6,   �� 56      $��50 �6,   .+�58      �� " ��Name$" textBox��6Q   $��0��64   $��1��6D   6Q   �� 59      $
��Info��6$   $��0��60   $��0��6@   
���  ��$��Segoe UI)�6�   $��28(�6�   $
��Bold"�6�   ��6M   �� *[0].ErrorContent+6�   5:      5;      .��5<   (   5=      �� 5>   
   -	   5        $��EM_Field_SW��5>      $��8��6%   $��5 5 5 5q�62   $��4��6C   $��1��6S   $��Stretch=�6g   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�   $	 200��6�   
 �����$ 1Q�6
  $ 1��6  $ Disabled=�6,  $ Arrow��6U   . $
 Auto=�6}  $: 4Here you can enter your e-mail for contact purposes.��6�  $
 Wrap=�6�  
 �����6�  G� 5?   
   -
   5        $��PS_Field_SW��5?      $��9��6)   $��5 5 5 5q�66   $��4��6G   $��1��6W   $��Stretch=�6k   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�   $ Arrow��6�   # G� SelectionBrush
# �����$ G� SelectionOpacity$$ 1Q�6  $' !Here you can enter your password.��6"  % G� 
CaretBrush
% �����6N  �� 5@   
   -   5        $��Accept��5@      $��Right=�6#   $��Center=�6?   $��12��6Z   $��5 5 5 5q�6h   $��4��6y   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6�   $ 1Q�6  $��0q�6  $��0q�6  $
��Bold"�63  $
 Hand��6E  $R LTo create your new account and start using Natural Heritage Map, click here.��6d  �� 5A   
   -   5        & �� IsCancel& . $��Cancel��5A   !   $
��Left=�62   $��Center=�6M   $��12��6h   $��5 5 5 5q�6v   $��1��6�   $��2��6�   ���	#FF055D79
����������	#FF003F65$��Footlight MT)�6�   $��40(�6  $ 1Q�6  $��0q�6!  $��0q�6-  $
��Bold"�6A  $
 Hand��6S  $0 *To cancel all created changes, click here.��6a  6�  �� 5B   
   $1��+/HCI_Project;component/Images/17086-200.png��6   $��11��6E   $��2��6S   $��0��6d   $��7��6t   $��Center=�6�   5C      5D      