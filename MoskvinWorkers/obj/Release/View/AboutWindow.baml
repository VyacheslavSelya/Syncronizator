   M S B A M L   `   `   `  ����   Syncronizer     MoskvinWorkers.AboutWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -   $��windowAbout��  � Title$  О программе��$��382.059��$��599.334�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ CanMinimize=� � Triggers :�  :� RoutedEvent$ Loaded��[��� .���� .��W�  �� TargetProperty$ Width� �� 
TargetName$ lblSync�� W� From$ 70X�	 W� To$	 424X�	 g� AutoReverse	 .  
 g� Duration$
 0:0:1D�W� $ FontSize�$ lblSync��$ 30X�$ 36X�	 .  $
 0:0:1D��� .���� $ Height�$ gridOfContacts��.��W� $ 0X�$	 117X�	 .  $
 0:0:1D��� .���� $ Opacity�$ imgMS��.��W� $ 0X�$ 1X�	 .  $
 0:0:1D��� .���� $ Opacity�$ imgSharp��.��W� $ 0X�$ 1X�	 .  $
 0:0:1D��� .���� $ Opacity�$ boreder��.��W� $	 0.5X�$ 1X�	 .  g� RepeatBehavior$ Forever��$
 0:0:1D�.��� .+��� -   $��
Выход��$��	0,0,10,10q�$��44��$��Bottom=�$��Right=�$��75���� -   $��lblSync��$ ��Синхронизатор��$
��Left=�$��10,0,0,0q�$��Center=�$��Center=�$	��Top=�$	��232��$��55��$��30(�
���� �� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 3Q�� -   $��gridOfContacts��$	��117��$��
10,60,10,0q�$	��Top=� � ColumnDefinitions �� $	��150 ��� $	��200 � � RowDefinitions �� �� �� .+��� $��Авторы��$��0��$��0��$��Center=�$��15(�
���   �$��Italic$�$��SemiBold"�      Color$ DeepSkyBlue��   
BlurRadius$ 5Q�$ 2Q��� $%��Версия программы��$��0��$��1��$��Center=�$��15(�
���   �$��Italic$�$��SemiBold"�   $ DeepSkyBlue��$ 5Q�$ 2Q��� $��E-mail��$��0��$��2��$��Center=�$��15(�
���   �$��Italic$�$��SemiBold"�   $ DeepSkyBlue��$ 5Q�$ 2Q��� $2��,Москвин В.В., Селяков В.А.��$��1��$��0��$��Center=�$��Center=�$��20(�$��
0,0,-155,0q�$��SemiBold"�   $ 	SlateBlue���� -   $��
lblVersion��$��1��$��1��$��Center=�$��Center=�$��20(�$��
0,0,-155,0q�$��SemiBold"��� $��1��$��2��$��Center=�$��Center=�$��16(�$��
0,0,-155,0q�$��SemiBold"�   $ 	LightBlue��$ 5Q�$ 0Q�.���� $��v.selyakov@yandex.ru?�.�v.selyakov@yandex.ru�� -    ��Name$ imgSharp��$9��3pack://application:,,,/Image/png/MSVisualCSharp.jpg��$��307,182,52,71q��� -   $ imgMS��$��Center=�$4��.pack://application:,,,/Image/png/Microsoft.png��$	��105��$��Bottom=�$	��230��$��51,0,312,71q��� -   $��boreder��
�������
��� � �$��2q�$��Center=�$��44��$��10,0,359,10q�$��Bottom=�$	��224�� �� CornerRadius$ 10��._��� $
��Wrap=�$��10(�$	��8,0q��� $��SemiBold"�$��Italic$�.�53Если Вам нравится программа, то�� KIВы можете оказать помощь разработчикам.�� -	   $��borderThank��
�������
��� � �$��2q�$��Center=�$��44��$��239,0,90,10q�$��Bottom=�$	��264��$ 10��._��� $
��Wrap=�$��10(�$	��8,0q��� $'�!Вы можете сказать ���� $��Italic$�$��SemiBold"�
���  ��.�СПАСИБОpnавторам программы, написав им на почту всего несколько слов �� $��Italic$�$��SemiBold"�
���  ��.�БЛАГОДАРНОСТИ!