   M S B A M L   `   `   `  ���� F  BSyncronizer, Version=2.4.8.3, Culture=neutral, PublicKeyToken=null/clr-namespace:MoskvinWorkersMoskvinWorkers      MoskvinWorkers.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:MoskvinWorkers       � Title$  Synchronizer��$	��400��$
��1100�� � Left$ 10��
 � Top$ 10�� � WindowState$ Normal=�$��13(�$
��1000��$	��400�� � 
ResizeMode$ CanResizeWithGrip=� � 	Resources    StandardBorderBrush �� Color  StandardBackgroundBrush  HoverBorderBrush  SelectedBackgroundBrush  SelectedForegroundBrush  DisabledForegroundBrush  NormalBrush  NormalBorderBrush  HorizontalNormalBrush 	 HorizontalNormalBorderBrush 
 ListBoxBackgroundBrush �� 
StartPoint �� EndPoint	 � Color
 � Offset  StandardBrush  
GlyphBrush  PressedBrush  ScrollBarLineButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Path �� RelativeSource �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions �� Triggers  FavsScrollViewer �� VerticalOffset � Value �� ScrollableHeight � Maximum  �� ViewportHeight! �� ViewportSize*" �� #ComputedVerticalScrollBarVisibility# �� Orientation$ �� HorizontalOffset% �� ScrollableWidth& �� ViewportWidth,' �� %ComputedHorizontalScrollBarVisibility  CenterCellStyle*  $System.Windows.Controls.DataGridCell  linkStyleForFile( �� Binding) �� ElementName* �� Value  	linkStyle��%�  &	        &	      &	       &	 0     &	 @     &	 Q     &	 a     &	 q     &	 �     &		 �     &	
 �     &	     &	 p    &	 �    &	 G    7  7  7  7  7  &	 �    &	     7  7  &	 �    7  7  7  7  7 	 7  7  &	 �    7  7  7  7  7  7  7  '�� s	    7  7  &	 �
    &	 �    &	 B    &	 �    �� $
 #888���� $
 #FFF���� $
 #DDD���� $
 Gray���� $ White���� $
 #888���� $
 #888���� $
 #888���� $
 #888���� $
 #888���� $	 0,0&�$ 1,0.001&���� � $	 White��$	
 0.0Q�� $	 White��$	
 0.6Q�� $	 #DDDDDD��$	
 1.2Q��� $	 0,0&�$	 0,1&���� � $
	 #FFF��$	
 0.0Q�� $
	 #CCC��$	
 1.0Q��� $
 #444���� $	 0,0&�$	 0,1&���� � $	 	#FF82A8EA��$
 0.958Q�� $	 	#FF3577EA��$
 0.674Q�� $	 	#FF3577EA��$
 0.351Q�� $	 	#FF82A8EA��$
 0.092Q�� $	 	#FF2663CD��$
 0.502Q��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � |� .  ��  � �� �� " ��.R��� $��Border��$��1q�$ 2��8��  8�� $��1q�._�F� $��Center=�$��Center=�8�� ���� $ Content� �� *TemplatedParent+ P�  � �� . . ��� $ Border��8   � ��P�  � {� .  . ��� 8   � ���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " ��.R��� 
������ �� " n�.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " n�.R��� $��Border11��$ 2��#��z��#��z��$��1q�._�F� $��Center=�$��Center=�8��  ���� $ Content� �� *TemplatedParent+ P�  �@J�IsMouseOver . . ��� $ Border11��8   � ���� " ��.R��  �� $��18���� $��0.00001* ��� $��18��.+��� $��3��$ 2�����#F0F0F0�� $��0��8��  $��18��$��ScrollBar.LineUpCommand��$��M 0 4 L 8 4 L 4 0 Z��]� $��
PART_Track��$��1����.  �� 8�� $��ScrollBar.PageUpCommand�� n� 8�� $��1,0,1,0q�8�� 8��  �� 8�� $��ScrollBar.PageDownCommand���� $��3��8�� $��18��$��ScrollBar.LineDownCommand��$��M 0 0 L 4 4 L 8 0 Z���� " ��.R��  �� $��18���� $��0.00001* ��� $��18��.+��� $��3��$ 2�����#F0F0F0�� $��0��8��  $��18��$��ScrollBar.LineLeftCommand��$��M 4 0 L 4 8 L 0 4 Z��]� $��
PART_Track��$��1����.   �� 8�� $��ScrollBar.PageLeftCommand�� n� 8�� $��0,1,0,1q�8�� 8��  �� 8�� $ ��ScrollBar.PageRightCommand���� $��3��8�� $��18��$ ��ScrollBar.LineRightCommand��$��M 0 0 L 4 4 L 0 8 Z���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle .  P�  �@��Orientation$ 
Horizontal=�. ���  � ��$
 Auto����  � ��$ 18����  � ��8   P�  �@��Orientation$ Vertical=�. ���  � ��$ 18����  � ��$
 Auto����  � ��8  �� " ��.���  �@�OverridesDefaultStyle . ��  � �� �� " ��.R��  �� $
��Auto ���  �� �� $
��Auto �.+��� $��1���� $��PART_VerticalScrollBar��# z # z #! z  #y�z" �� $��PART_HorizontalScrollBar��$# 
Horizontal=�$��1��$��1��# z$ # z% #! z& #y�z' �� "  .���  � �� �� "  .R�� #��z��.+��� $��Center=�$��Center=��� " ��.���  �@J�Opacity$ 0Q� �� ( �� $) stackPanFile��$ IsMouseOver�* True.a���  �@J�Opacity$ 1Q��� " ��.���  �@J�Opacity$ 0Q� �� ( �� $) stackpanelka��$ IsMouseOver�* True.a���  �@J�Opacity$ 1Q���  � ��$ 48��.���  �� $
��455* ��� $	��100 �.+�o� $��23��$��Times New Roman)�$��Center=�
�������$��13(�
���   �$	��Top=�
���   �$��1q�.@�m� $��Источник��.@�m� -   $��Добавить файл��+ � ToolTip$A+ ;Добавить новый файл в источники.��, m� Icon, �� $ ��Image/png/Document-Add.png��$��16��$��16��m� -   $!��Добавить папку��$8+ 2Добавить папку в источники.��, �� $��Image/png/Folder-Add.png��$��16��$��16��m� -   $ ��Редактировать��$E+ ?Редактировать выбранный источник.��, �� $��Image/edit.ico��$��16��$��16��m� -   $��menuRemoveFile��$��Удалить��$K+ EУдалить из списка выбранный источник.��, �� $��Image/delete.ico��$��16��$��16��m� $��Путь��.@�m� -   $��Добавить файл��$7+ 1Добавить новый файл в пути.��, �� $ ��Image/png/Document-Add.png��$��16��$��16��m� -   $!��Добавить папку��$.+ (Добавить папку в пути.��, �� $��Image/png/Folder-Add.png��$��16��$��16��m� -   $��menuRemovePath��$��Удалить��$C+ =Удалить из списка выбранный путь.��{�.  m� $��Анализ��.@�m� -   $��Всё��$7+ 1Анализировать весь список.��m� $��Выбранное��$V+ PАнализировать только выделенные источники.��{�.  m� $ ��Синхронизация��.@�m� -	   $��
menuDoSync��$-��'Синхронизировать всё��$R+ LСинхронизировать весь список источников.��m� $;��5Синхронизировать выделенное��$\+ VСинхронизировать только выделенные источники.��{�.  m� $��Список��.@�m� -
   $��menuSelectList��$��Выделить всё��$B+ <Выделить весь список источников.��m� -   $��menuClearList��$#��Очистить список��$@+ :Очистить все список источников.��m� -   $��menuClearSelectedRoots��$'��!Удалить выбранные��$=+ 7Очистить выбранные источники.��{�. m� $��Настройки��.@�m� -   $��menuLastSession��$8��2Загружать последнюю сессию��{�.  - m� IsCheckable- . $>+ 8Добавить путь для копирования.��. m� 	IsChecked. �� *LoadLastSession+/ �� UpdateSourceTrigger$/ PropertyChanged=�0 �� Mode$0 TwoWay=�m� $(��"Копировать в папку��{�.  .@�m� $'��!Только содержимое��. . m� $��Всю папку��m� $��Помощь��.@�m� -   $��menuHelp��$��Справка��, �� $��0,2,0,2q�$��Image/png/16/Help.png��m� -   $��	menuAbout��$��О программе��$R+ LПросмотреть информацию об этой программе��, �� $��0,2,0,2q�$"��Image/png/16/Information.png��m� -   $��
Выход��$)+ #Выйти из программы.��&   System.Windows.Controls.DataGrid  -   $
��grid��$��5,25,5,8q�1   AutoGenerateColumns1 .  2   
IsReadOnly2 . 3   CanUserAddRows3 . 4   SelectionMode$4 Extended=�5   RowDetailsVisibilityMode$5 VisibleWhenSelected=�6 J� 	AllowDrop6 . $��1,1,3,1q� =  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow��%�  '        '  �     '  �    7  '�� `    �� "  .�-   ��  � ��$ Calibri)���  � ��$ 14(���  �@ RowBackground �	#FF93D2FD��   �@ AlternatingRowBackground �	#FFE0E8F1�� % �@ HorizontalScrollBarVisibility$ Visible=���  � ��
 � � ��� "  .���  � �� �	#FF1B41EE��  � ��
 �������  � ��
 �   ���  � ��$ 1q���  � ��$ 30����  � ��$ SemiBold"���  � ��$ Stretch=���  � ��$ 0,0,17,0q���  � ��$ 	0,0,-17,0q��� "   P�  �@ 
IsSelected . . ���  � ��8   ��  � ��
 �����.���  � ��$ 40���� " �� P�  �@ 
IsSelected . . ���  � ��
 � ������� $ 0.5,1&�$ 0.5,0&�.��� $	 Black��� $	 	#FF919191��$
 0.163Q�� $	 Black��$
 0.984Q�� $	 	#FF959090��$
 0.977Q�� $	 	#FFC7C4C4��$
 0.566Q�7   Columns7 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn8   Header$8 ID��9   Width5  /System.Windows.Controls.DataGridLengthConverter$9 30 :   	CellStyle#: [ 1  +System.Windows.Controls.DataGridBoundColumn;   Binding; �� $ FileID�$/ PropertyChanged=�$0 TwoWay=�<   HeaderTemplate< �� .R��� $��ID��$��Center=�$��Center=�$��Calibri)�
�������4	  .System.Windows.Controls.DataGridTemplateColumn	  $9 * < �� .R��  �� $��90 ��� $��* �.+��� $��5,0,0,0q�$��0��= �� Orientation$= 
Horizontal=�$
��Left=�.+��� $��btnAddRootFile��-   $E+ ?Добавить файл в список источников.��
������ .���� $ ��Image/png/Document-Add.png��$��24��$��24���� $��btnAddRootFolder��-   $��10,0,0,0q�$G+ AДобавить папку в список источников.��
������ .���� $��Image/png/Folder-Add.png��$��24��$��24���� $��Center=�$��1��$��Источник��$��Center=�
�������$��0q�> 	  CellTemplate> �� .R�� $��stackPanFile�� �� $
��Auto ��� $��* �.+��� $��0��$
��Left=�$��16��$��16������ *FileTypeImage+$/ PropertyChanged=�$0 TwoWay=��� $��20,0,0,0q�$
��Left=�$��Center=�$��0������ *
FileName+$/ PropertyChanged=�$0 TwoWay=��� $��1��$= 
Horizontal=�$��Right=�.+��� -   $��22��$��22��$5+ /Открыть в проводнике Windows.��
������ $��0q�.���� $��Image/16/openfolder.ico���� -   $��22��$��22��$8+ 2Узнать больше об источнике.��
������ $��0q�.���� $��Image/info.ico���� -   $��22��$��22��$2+ ,Редактировать источник.��
������ $��0q�.���� $��Image/edit.ico���� -   $��22��$��22��$&+  Удалить источник.��
������ $��0q�.���� $��Image/delete.ico��	  $9 * < �� .R�� 
���   � �� $��90 ��� $��* �.+��� $��5,0,0,0q�$��0��$= 
Horizontal=�$
��Left=�.+��� $��btnAddSyncFile��-   $;+ 5Добавить файл в список путей.��
������ .���� $ ��Image/png/Document-Add.png��$��24��$��24���� $��btnAddSyncFolder��-   $��10,0,0,0q�$=+ 7Добавить папку в список путей.��
������ .���� $��Image/png/Folder-Add.png��$��24��$��24���� $��Center=�$��1��$��Путь��$��Center=�
��� ���$��0q�> �� .R��� $	��sdv��$
��Left=�$
��Auto��$��0q�
������ ���� *
PathToCopy+$/ PropertyChanged=�$0 TwoWay=����� .R��� ? K� IsItemsHost? . ���� .R��� $��stackpanelka��$= 
Horizontal=�
������ .+��� $��
borderPath��
������$��1q�@ J� SnapsToDevicePixels@ . $ 3��A �� Padding$A 3q�$��3q�$
��Auto��._��� $��txtblock������ �� $��18���� -   $��http://www.google.com?�B �� TextDecorationsB Z� .�.��� $��tbInfo��$��5,0,0,0q�$.+ (Узнать больше о файле.���� $��Image/info.ico��$��16��$��16���� $��18���� C �Name$C 	hyperEdit��-   $��http://www.google.com?�B Z� .�.��� $��tbEdit��
����i��$��5,0,0,0q�$ + Редактировать���� $��Image/edit.ico��$��16��$��16���� $��18���� $C hyper��-   $��http://www.google.com?�B Z� .�.��� $��tbRemove��
����i��$��5,0,0,0q�$+ Удалить���� $��Image/delete.ico��$��16��$��16������ "  .�-   �� -   $��btnSync��$-+ 'Начать синхронизацию��$��1��$��361,5,361,30q�.���� $= 
Horizontal=�.+��� $��Image/refresh.ico��$��60��$��60���� $&�� Синхронизировать��$��Center=�$
��Bold"�$��20(�
���  ���� -    $��btnAnalysis��$
��Left=�$C+ =Произвести анализ файлов и папок.��$��	10,0,0,37q�$��1��$��Bottom=�$	��180��$��58������ $ 0.5,1&�$ 0.5,0&�.��� $	 	#FFA8B7D8��$
 0.391Q�� $	 	#FFA8B7D8��$
 0.233Q�� $	 	#FF6888D1��$
 0.984Q�� $	 	#FF92A4CB��$
 0.849Q�� $	 	#FF7A9AE0��$
 0.023Q�� $	 	#FFA8B7D8��$

 0.64Q�.���� $= 
Horizontal=�
������ .+��� $��Image/9.ico��$��60��$��60���� $��Анализ��$
��Bold"�$��Center=�$��20(�
�������� $��25��$��0,75,0,0q�$��1��$	��Top=����� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF878484��� $	 	#FF919191��$
 0.163Q�� $	 	#FF9E9898��$
 0.984Q�� $	 	#FF959090��$
 0.977Q�� $	 	#FF9E9D9D��$
 0.295Q�� $	 	#FF919090��$
 0.767Q�.@��� $��0q����� *FileList.Count+�� � $	��200��$��18��$ 1Q�