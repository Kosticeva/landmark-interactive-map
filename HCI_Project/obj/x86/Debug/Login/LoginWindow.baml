   M S B A M L   `   `   `  ����F  BHCI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HCI_ProjectHCI_Project  5   	       HCI_Project.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:HCI_Project     5   	   -   5          � Title$  LoginWindow��5   	   #��Z��6   $
��1000��6Z    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}    � WindowStyle$ ThreeDBorderWindow=�6�    � WindowState$ Normal=�6�    � Icon$1 +/HCI_Project;component/Images/17086-200.png��6�   $��70(�6     HCI_Project.HelpProvider   HelpKey$ Login��62  ��5      �� 5   
    �� ImageSource$7 1/HCI_Project;component/Images/phys_world_map_.jpg��6    �� Opacity$	 0.2Q�6U   	 J� CommandBindings	 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5        
   Command$
 ApplicationCommands.Help��5
      6<   .��5      � $
��Auto��6   $	��800��6   
������� J� Opacity$ 1Q�68    � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $	��210 �6   �� 5      $��30 �6   �� 5      $	��400 �6   �� 5      $��40 �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5       $��50 �6   �� 5!      �� 5"      $��70 �6   �� 5#      $��70 �6   .+�5%   
   �� -   5        $��Title0��5%      $��Welcome to the��6"   $��1��68   $��2��6E   $��3��6U   $��WrapWithOverflow=�6i   ���	#FF055D79$��44(�6�   $��Gabriola)�6�    �� TextAlignment$ Center=�6�   $��Normal$�6�   $
��Bold"�6�   $��Center=�6   �� 5&   
   -   5        $��Title1��5&      $��NATURAL HERITAGE MAP��6"   $��2��6>   $��0��6K   $��7��6[   $��80(�6o   $
��Bold"�6}   $��Italic$�6�   $��Gabriola)�6�   $
��None=�6�   $ 1Q�6�   ���	#FF055D79���	#00ECF6F8$ Center=�6  }�.   J� 	AllowDrop .  $��Center=�6D   J� OpacityMask 6`  �� 6w   �� EndPoint$ 1,0.5&�6�   �� 
StartPoint$ 0,0.5&�6�  .��6�  �  � Color$ Black��6�   � Offset$ 0Q�6�  � 6�  $ White��6�  $ 1Q�6�  6  61  �� 5'   
   -   5        $��Title2��5'      $#��Please enter your credentials��6"   $��4��6G   $��1��6T   $��5��6d   $ 1Q�6x   ���	#00ECF6F8���	#FF055D79$��44(�6�   $��Footlight MT)�6�   $ Center=�6�   $
��Bold"�6�   $��Normal$�6  $��Center=�6  63  �� 5(   
   -   5        $��
UsernameLW��5(      $��	Username:��6&   $��7��67   $��1��6D   $��2��6T   $��Right=�6h   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5)   
   -   5        $��
PasswordLW��5)      $��	Password:��6&   $��8��67   $��1��6D   $��2��6T   $��Right=�6h   $��32(�6�   $��Footlight MT)�6�   ���	#00ECF6F8���	#FF055D79$ 1Q�6�   $
��Bold"�6�   $��Center=�6�   �� 5+   
   -   5        $��UN_Field_LW��5+      $ LogIn|Username��6%   $��7��6Q   $��5 5 5 5q�6^   $��4��6o   $��Stretch=�6   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6�    �� AutoWordSelection .  � Cursor$ Arrow��6  $ �� HorizontalScrollBarVisibility$ Disabled=�6#   �� MaxLines$ 1��6L   �� SelectionBrush
 ����� �� SelectionOpacity$ 1Q�6p   �� 	UndoLimit$	 200��6�  " �� VerticalScrollBarVisibility$
 Auto=�6�   � ToolTip$' !Here you can enter your username.��6�   �� TextWrapping$
 Wrap=�6�   �� 
CaretBrush
 �����.��6  ��5,      �� 5-        �� Path$  Username�6   ! �� UpdateSourceTrigger$! PropertyChanged=�6*   " �� ValidationRules" 5.      5  /System.Windows.Controls.ExceptionValidationRule  5/         HCI_Project.NameValidation  50      ,  &System.Windows.Controls.ValidationRule#   ValidationStep$# RawProposedValue=�6/   52      .��53      $ =� ErrorTemplate$ 54      �� 55      .R�56      � $	��Grd��6    57      �� 58      $��50 �6,   �� 59      $��50 �6,    5;      �� 5<      .+�5>      �� % ��Name$% textBox��6Q   $��0��64   $��1��6D   6Q   �� 5?      $
��Info��6#   $��0��6/   $��0��6?   
���  ��$��Segoe UI)�6   $��28(�6�   $
��Bold"�6�   ��6L   �� *[0].ErrorContent+6�   5@      5A      .��5B   (   5C      G� 5D   
   -	   5        $��PS_Field_LW��5D      $ LoginPassword��6)   $��8��6T   $��5 5 5 5q�6a   $��4��6r   $��1��6�   $��Stretch=�6�   $��32(�6�   $��Footlight MT)�6�   ���	#FF257D99
�������$ 1Q�6  $ Arrow��6  & G� SelectionBrush
& �����' G� SelectionOpacity$' 1Q�68  $' !Here you can enter your password.��6M  ( G� 
CaretBrush
( �����6�  �� 5E   
   -
   5        $��
ErrorBlock��5E      $��9��6&   $��5 5 5 5q�63   $��4��6D   $��Stretch=�6T   $��28(�6r   $��Segoe UI)�6�   $ 1Q�6�   $ Arrow��6�   
���  ��$�� ��6�   $
��Bold"�6�   �� 5F   
   -   5        $��LogIn��5F      $��Log In��6   $ 
StartUsing��6/   $��21��6W   $��5 5 5 5q�6e   $��3��6v   $��3��6�   ���	#FF055D79
����������	#FF055D79$��Footlight MT)�6�   $��40(�6�   $ 1Q�6  $��0q�6  $��Right=�6  $��0q�68  $
��Bold"�6L  $
 Hand��6r  $��Center=�6�  $��Center=�6�  $��Normal&�6�  $6 0To start using Natural Heritage Map, click here.��6�  �� 5G   
   -   5        $��SignIn��5G      $��Sign In��6   $ SignInAttempt��61   $��5 5 5 5q�6\   $��12��6m   $��1��6{   $��3��6�   ���	#FF055D79���	#FF055D79
�������$��Footlight MT)�6�   $��40(�6�   $ 1Q�6	  $
��Left=�6  $��0q�61  $��Center=�6E  $
��Bold"�6i  $
 Hand��6�  $��Center=�6�  $' !To create an account, click here.��6�  �� 5H   
   $1��+/HCI_Project;component/Images/17086-200.png��6   $ Introduction��6E   $��11��6o   $��2��6}   $��0��6�   $��7��6�   $��Center=�6�   5I      5J      