   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Client.AddBindingClient.AddBinding  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	       Client.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Client.AddBinding     5   	   ^kPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$%  Тестовое задание��5
   	   $	��427��6"   $	��534��6/   ���#A50AA5 � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value   TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border-  'System.Windows.Input.KeyboardNavigation	 �� 
TargetType
 ��Name �� CornerRadius J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName ]� 
Conditions �� Property �� Value  ButtonBaseControlTemplate1 ��Name �� ContentStringFormat �� ContentStringFormat  ButtonBaseControlTemplate2��%�  '��       '�� 5    &	  �    &	     &	 0    '�� S    7   7  7  'G� 	    7   7  7  &	 y    &	 �    �� 5   
   " ��6   �5      �� 5       � ��
 �   �6/   �� 5       � ��
 �����6/    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �����63   �� 5       � ��
 �   �63   �� 5       �@�Cursor$
 Hand��6/   5      5      �� 5   
   " ��6   �5      �� 5        � ��
 �   �6/   �� 5!       � ��
 �����6/    5#      P� 5$       �@��
IsSelected . . �5%      ��  � ��
 �����63   �� 5&       � ��
 �   �63   5'      P� 5(       �@J�IsMouseOver . . �5)      ��  �@�Cursor$
 Hand��6/   �� 5*       � ��
 �����63   �� 5+       � ��
 �   �63   5,      5.      �� 5/   
   $ 	#FFABAdB3��68   �� 50   
   $ 	#FF7EB4EA��6;   �� 51   
   $ 	#FF569DE5��67   �� 52   
   " ��6   .�53      ��  � ��# � ��6+   �� 54       � ��8   6,   �� 55       � ��# � ��6+   �� 56       � ��$ 1q�60   �� 57       �@ TabNavigation$
 None=�6A   �� 58       � ��$
 Left=�6;   �� 59       �@�FocusVisualStyle 61   Z� �� 5:       �@J�	AllowDrop . 6*   �� 5;       �@��PanningMode$ VerticalFirst=�69   �� 5<       �@��IsFlicksEnabled .  67   �� 5=       � �� 5>      �� 5?      "	 ��6&   .R�5@      �� $
 border��6!   $ 10,10,10,10��61   #��z��6L   #��z��6x   #��z��6�    . ._�5A      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5B       5C      P� 5D       � {� .  . �5E   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5F      P� 5G       �@J�IsMouseOver . . �5H   "   �� $ border��6@   8   � ��6T   �� 5I   "    �@�Cursor$	 Pen��6;   5J      P� 5K       �@J�IsKeyboardFocused . . �5L   "   �� $ border��6@   8   � ��6T   5M      5O      5Q       5R      ]� 5S       5T      �� 5U      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5V       �@��IsSelectionActive .  6A   ./�5X      ��  �@��SelectionBrush# � /�67   5Y      P� 5Z       �@J�IsMouseOver . . �5[      ��  � ��
 �����63   �� 5\       �@�Cursor$	 Pen��6/   5]      5_      �� 5`   
   " G�6   .�5a      ��  �@G�PasswordChar$	 ●��6-   �� 5b       � ��# � ��6+   �� 5c       � ��8   6,   �� 5d       � ��# � ��6+   �� 5e       � ��$ 1q�60   �� 5f       �@ TabNavigation$
 None=�6A   �� 5g       � ��$
 Left=�6;   �� 5h       �@�FocusVisualStyle 61   Z� �� 5i       �@J�	AllowDrop . 6*   �� 5j       �@��PanningMode$ VerticalFirst=�69   �� 5k       �@��IsFlicksEnabled .  67   �� 5l       � �� 5m      �� 5n      "	 G�6&   .R�5o      �� $
 border��6!   $ 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5p      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5q       5r      P� 5s       � {� .  . �5t   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5u      P� 5v       �@J�IsMouseOver . . �5w   "   �� $ border��6@   8   � ��6T   �� 5x   "    �@�Cursor$	 Pen��6;   5y      P� 5z       �@J�IsKeyboardFocused . . �5{   "   �� $ border��6@   8   � ��6T   5|      5~      5�       5�      ]� 5�       5�      �� 5�      + �@G�#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@G�IsSelectionActive .  6A   ./�5�      ��  �@G�SelectionBrush# � /�67   5�      5�      �� 5�   
   "	 ��6=   .R�5�      �� $
 border��6   $ 10��6%   #��z��67   #��z��6c   #��z��6�    . ._�5�      �� $ contentPresenter��6#   #��z��6=   #��z��6q   # z 6�   |�.  #��z��6�   #��z��6&  ��. # z 6d  #��z��6�  5�       5�      P� 5�       �@��IsDefaulted . . �5�      �� $ border��64   # � ��6H    � ��5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ border��63    � �� �	#FFBEE6FD6G   �� 5�      $ border��64    � �� �	#FF3C7FB16H   5�      P� 5�       � �� . . �5�      �� $ border��63    � �� �	#FFC4E5F66G   �� 5�      $ border��64    � �� �	#FF2C628B6H   5�      P� 5�       �@d�	IsChecked$
 TrueY�6<   . �5�      �� $ border��63    � �� �	#FFBCDDEE6G   �� 5�      $ border��64    � �� �	#FF245A836H   5�      P� 5�       � {� .  . �5�      �� $ border��63    � �� �	#FFF4F4F46G   �� 5�      $ border��64    � �� �	#FFADB2B56H   �� 5�      $ contentPresenter��6?    � �� �	#FF8383836]   5�      5�      �� 5�   
   "	 ��6=   .R�5�      �� $
 border��6   $ 10��6%   #��z��67   #��z��6c   #��z��6�    . ._�5�      �� $ contentPresenter��6#   #��z��6=   #��z��6q   # z 6�   |�.  #��z��6�   #��z��6&  ��. # z 6d  #��z��6�  5�       5�      P� 5�       �@��IsDefaulted . . �5�      �� $ border��64   # � ��6H    � ��5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ border��63    � �� �	#FFBEE6FD6G   �� 5�      $ border��64    � �� �	#FF3C7FB16H   5�      P� 5�       � �� . . �5�      �� $ border��63    � �� �	#FFC4E5F66G   �� 5�      $ border��64    � �� �	#FF2C628B6H   5�      P� 5�       �@d�	IsChecked$
 TrueY�6<   . �5�      �� $ border��63    � �� �	#FFBCDDEE6G   �� 5�      $ border��64    � �� �	#FF245A836H   5�      P� 5�       � {� .  . �5�      �� $ border��63    � �� �	#FFF4F4F46G   �� 5�      $ border��64    � �� �	#FFADB2B56H   �� 5�      $ contentPresenter��6?    � �� �	#FF8383836]   5�      5�      5�      .��5�      �� -   5        $��panel��5�      
������ .@�5�   
   �� -   5        $��authorization��5�      ��5�      �� 5�       �� Orientation$ 
Horizontal=�6   .+�5�      �� $��3q�6    Авторизация68   5�      ��5�      �� 5�      .+�5�      � $	��315��6   
������ .+�5�      �� $��43,86,248,164q�6    $��Введите логин��67   
�������$
��Bold"�6b   �� 5�      -   5         ��Name$ login��5�   "   $
��Left=�6�   $��23��6�   $��
228,86,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��165��6�   ��61   ��  �� Path$ AuthorizeData.Login� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5�      $��43,128,298,122q�6    $!��Введите пароль��68   
�������$
��Bold"�6d   G� 5�      -   5         G�Name$ passwd��5�   &   $
��Left=�67   $��23��6R   $��228,128,0,0q�6_   $	��Top=�6t   $	��165��6�   .  (System.Windows.Interactivity.Interaction   	Behaviors 5�      2   ,Client.AddBinding.DependencyPropertyBehavior  5�   "      UpdateEvent$ PasswordChanged��5�   %      Property$ Password��5�   %      Binding 5�   %   �� *AuthorizeData.Password+$ PropertyChanged=�5�      �� 5�      -   5          ��Name$	  log��5�   !   $��Вход��6.   ! � Cursor$
! Hand��6=   $
��Bold"�6K   $
��Left=�6]   $��318,178,0,0q�6x   $	��Top=�6�   $��81��6�   #���  6�   $��29��6  ��6�   �� *LogIn+ 5�      ��%�  &	       �� 5�   "   "	 ��6U   .R�5�   &   �� $
 border��6-   $ 10��6=   #��z��6O   #��z��6{   #��z��6�    . ._�5�   *   �� $ contentPresenter��6;   #��z��6U   #��z��6�   # z 6�   |�.  #��z��6�   #��z��6>  ��. # z 6|  #��z��6�  5�   '    5�   &   P� 5�   *    �@��IsDefaulted . . �5�   .   �� $ border��6L   # � ��6`    � ��5�   +   P� 5�   *    �@J�IsMouseOver . . �5�   .   �� $ border��6K    � �� �	#FFBEE6FD6_   �� 5�   .   $ border��6L    � �� �	#FF3C7FB16`   5�   +   P� 5�   *    � �� . . �5�   .   �� $ border��6K    � �� �	#FFC4E5F66_   �� 5�   .   $ border��6L    � �� �	#FF2C628B6`   5�   +   P� 5�   *    �@d�	IsChecked$
 TrueY�6T   . �5�   .   �� $ border��6K    � �� �	#FFBCDDEE6_   �� 5�   .   $ border��6L    � �� �	#FF245A836`   5�   +   P� 5�   *    � {� .  . �5�   .   �� $ border��6K    � �� �	#FFF4F4F46_   �� 5�   .   $ border��6L    � �� �	#FFADB2B56`   �� 5�   .   $ contentPresenter��6W    � �� �	#FF8383836u   5�   +   5�   #   5�      5�      �� 5�      -   5        " ��Name$" registr��5�   $   $
��Left=�65   $��228,189,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   �� 6�   -   5        # �Name$
# link��5�   �   
�������$
��Bold"�6�   $ � Cursor$
$ Hand��6�   % �� Command% 6�   �� *ClickRegisterCommand+.�6  �� $�Регистрация��6
  6   6,  5�      5�      5�      �� 5�   
   -   5        $��registration��5�      & �� 
IsSelected& 6&   �� *
IsRegister+$ PropertyChanged=���5      �� 5     $ 
Horizontal=�6   .+�5     �� $��3q�6    Регистрация68   5     ��5     �� 5     .+�5     � $	��351��6   .+�5	     �� -	   5        ' ��Name$' 
page2label��5	      $#��Заполните форму��64   
�������$
��Bold"�6a   $��13(�6s   $
��Left=�6�   $��3,10,0,0q�6�   $	��Top=�6�   $��30��6�   $	��149��6�   �� 5
     -
   5        $' label��5
      $��Имя��6/   
�������$
��Bold"�6P   $
��Left=�6b   $��	26,40,0,0q�6}   $	��Top=�6�   $��26��6�   $��50��6�   �� 5     -   5        $ 	firstName��5  "   $
��Left=�6�   $��23��6�   $��
176,44,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6�   $��1��6�   ��65   �� $ CurrentUser.FirstName�$ PropertyChanged=�6�   �� 5     -   5        $' label1��5      $��Фамилия��60   
�������$
��Bold"�6U   $
��Left=�6g   $��	26,86,0,0q�6�   $	��Top=�6�   $��26��6�   $��80��6�   �� 5     -   5        $ lastName��5  "   $
��Left=�6�   $��23��6�   $��
176,89,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6�   $��1��6�   ��64   �� $ CurrentUser.LastName�$ PropertyChanged=�6�   �� 5     -   5        $' label2��5      $��Email��60   
�������$
��Bold"�6S   $
��Left=�6e   $��
26,132,0,0q�6�   $	��Top=�6�   $��26��6�   $��50��6�   �� 5     -   5        $ email��5  "   $
��Left=�6   $��23��6�   $��176,136,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6�   $��1��6�   ��61   �� $ CurrentUser.Email�$ PropertyChanged=�6�   �� 5     -   5        $' label3��5      $��Путь к фото��60   
�������$
��Bold"�6Y   $
��Left=�6k   $��
26,177,0,0q�6�   $	��Top=�6�   $��26��6�   $��96��6�   �� 5     -   5        $ imageUrl��5  "   {�.  $
��Left=�6�   $��23��6�   $��176,181,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6  $��1��6  ��6F   �� $ CurrentUser.AvatarPath�$ PropertyChanged=�6  �� 5     -   5        $  	selectUrl��5  !   $
��Bold"�64   $��Выбрать��6F   $
��Left=�6X   $��346,178,0,0q�6s   $	��Top=�6�   $��94��6�   $��28��6�   #���  6�   ��6�   �� *UpdateAvatarPath+6�   �� 5     -   5        $' label4��5      $��
Логин��60   
�������$
��Bold"�6S   $
��Left=�6e   $��
26,220,0,0q�6�   $	��Top=�6�   $��26��6�   $��58��6�   �� 5     -   5        $ restrLog��5  "   $
��Left=�6�   $��23��6�   $��176,224,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6�   $��1��6�   ��64   �� $ CurrentUser.Logins�$ PropertyChanged=�6�   �� 5     -   5        $' label5��5      $��Пароль��60   
�������$
��Bold"�6T   $
��Left=�6g   $��
26,260,0,0q�6�   $	��Top=�6�   $��26��6�   $��66��6�   G� 5     -   5        $ password��5  &   $
��Left=�69   $��23��6T   $��176,263,0,0q�6`   $	��Top=�6v   $	��149��6�   $��1��6�    5       5  "   $ PasswordChanged��5  %   $ Password��5  %    5  %   �� *CurrentUser.Passwords+5     �� 5     -   5        $  button��5  !   $
��Left=�6M   $��176,302,0,0q�6h   $	��Top=�6}   $	��142��6�   $��33��6�   #���  6�   ��61   �� *	AddUser+.��6�   " Зарегестрировать6�   5      5!     5#     �� 5$  
   -   5        $��account��5$     {�6!   �� *
IsEnable+$ PropertyChanged=�& 6e   �� *
IsEnable+$ PropertyChanged=���5%     �� 5&     $ 
Horizontal=�6   .+�5'     �� $��3q�6    Аккаунт64   5(     ��5*     �� 5+     $��0,-4,0,4q�6   .+�5,     � $	��352��6   .+�5-     �� -   5        ( ��Name$( image��5-      $��20,32,332,139q�6�   ��6/   �� $ CurrentUser.AvatarPath�$ PropertyChanged=�6�   �� 5.     -   5        $ accountName��5.  "   
������ $��24��6�   $
 Wrap=�6�   $��370,-250,20,0q�6�   ��67   �� $ CurrentUser.FirstName�$ PropertyChanged=�6�   �� 5/     -   5        $ accountLastName��5/  "   
������ $��24��6�   $
 Wrap=�6�   $��210,-250,160,0q�6�   ��6;   �� $ CurrentUser.LastName�$ PropertyChanged=�6�   �� 50     -   5        $ accountEmail��50  "   
������ $��24��6�   $
 Wrap=�6�   $��210,-160,100,0q�6�   ��68   �� $ CurrentUser.Email�$ PropertyChanged=�6�   �� 51     -   5        $ accountLogin��51  "   
������ $��24��6�   $
 Wrap=�6�   $��210,-60,100,0q�6�   ��68   �� $ CurrentUser.Logins�$ PropertyChanged=�6�   �� 52     -   5        $ accountPass��52  "   
������ $��24��6�   $��210,184,104,144q�6�   y�67   �� *ShowPassword+$ PropertyChanged=���6�   �� $ CurrentUser.Passwords�$ PropertyChanged=�6�   G� 53     -   5        $ accountPassword��53  &   
������ $��24��6�   $��210,40,99,0q�6�   y�6?   �� *HiddenPasswordBox+$ PropertyChanged=� 54       55  "   $ PasswordChanged��56  %   $ Password��57  %    58  %   �� *CurrentUser.Passwords+$ PropertyChanged=�5:     �� 5;     -    5        $  updateButton��5;  !   $��Обновить��67   
�������$
��Bold"�6]   $
��Left=�6o   $��308,263,0,0q�6�   $	��Top=�6�   $	��138��6�   $��37��6�   #���  6�   ��6�   �� *UpdateCurrentUser+6�   �� 5<     -!   5        $  showPass��5<  !   
������ $��0��6L   $
��Left=�6X   $��389,184,0,0q�6s   $	��Top=�6�   $��31��6�   $��24��6�   )   Triggers) 5=     /  )System.Windows.Interactivity.EventTrigger  5>  "   *   	EventName$* 	MouseDown��61   .  (System.Windows.Interactivity.TriggerBase+   Actions.+ 5?  &   6  0System.Windows.Interactivity.InvokeCommandAction  ,   Command, 6<   �� *MouseDownCommand+5@  #     5A  "   $* MouseUp��61   .+ 5B  &     , 6<   �� *MouseUpCommand+5C  #   5E     �� 5F     -"   5        $ 
updatePath��5F  "   $y�Hidden=�66   $
��Left=�6J   $��22��6e   $��
38,232,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $	��120��6  ��6�   �� $ CurrentUser.AvatarPath�$ PropertyChanged=�6  �� 5G     -#   5        $  updatePhoto��5G  !   
�������$
��Bold"�6I   $��Обновить фото��6[   $
��Left=�6s   $��
38,267,0,0q�6�   $	��Top=�6�   $	��114��6�   #���  6�   $��35��6#  ��6�   �� *UpdateAvatarPath+6#  �� 5H     -$   5        $ 	accountId��5H  "   $y�Hidden=�6   $
��Left=�6�   $��22��6�   $��
38,306,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��65   �� $ CurrentUser.Id�$ PropertyChanged=�6�   5I     5J     5L     5M     5N     