   M S B A M L   `   `   `  ����V  RTest Management Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Test_Management_ApplicationTest_Management_Application  5   	   /    )Test_Management_Application.StartUpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Test_Management_Application     5   	     � Title$  StartUpWindow��5   	   $��899.865��6   $	��772��60   .��5	      � ���#102542$��	0,0,0,-12q�6     � ColumnDefinitions 5
   
   �� 5      $
��197* �6   �� 5      $
��199* �6   .+�5   
   �� -   5         ��Name$ 
btnLecture��5      $��
7,752,0,57q�6%   ���	#FF4040C1.��5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $	��363��6N   .+�5      �� $
��More��6   $��24(�6'   $��10,0,0,0q�66   $��Yu Gothic Light)�6H   ���#f03a476f   �� 5      $!��Resources/expand-button.png��6   $��	230,0,0,0q�6=   5      5      �� 5   
   -   5        $ 
btnStudent��5      $��32,752,10,57q�6%   ���	#FF4040C1$��1��6k   .��5      �� $ 
Horizontal=�6   $��Right=�62   $	��338��6N   .+�5      �� $
��More��6   $��24(�6'   $��10,0,0,0q�66   $��Yu Gothic Light)�6H   ���#f03a476e   �� 5      $!��Resources/expand-button.png��6   $��	200,0,0,0q�6=   5      5      �� 5   
   -   5         ��Name$ label��5      $?��9Welcome To Multiple-Choice  Test  Management Application ��6   ���#f03a47$
��Left=�6x   $��60,187.385,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 2.14,-0.724&�6�   $��24(�6�   $	��633��6�   $��Yu Gothic UI Semilight)�6  $
��44.9��6%  $��2��63  �� 5   
   $��259,-73,258,583q�6   $��2��6-   ��5      �� 5       �� ImageSource$D >Resources/2754c534-ecd1-4de2-b46f-f3081938d4f9_200x200 (1).png��6   5      �� 5    
   -   5        $ label1��5       $5��/Made For Student and lectureres                ��6    ���#f03a47$
��Left=�5!   '   $��62,222.285,0,0q�6B   $	��Top=�6Z   $��Yu Gothic Light)�6r   $��211.32��6�   $��31.552��6�   �� 5"   
   $
��Left=�6   $	��162��6/   $��107,293,0,0q�6<   $	��Top=�6Q   $	��155��6i   ��5#      �� 5$      $ Resources/lecture (1).png��6   5&      �� 5'   
   $
��Left=�6   $	��162��6/   $��131,285,0,0q�6<   $	��Top=�6Q   $	��154��6i   $��1��6u   ��5(      �� 5)      $ Resources/Learning.png��6   5+      �� 5,   
   -   5        $ label1_Copy��5,      $��Lecturer��6%   ���#f03a47$
��Left=�6M   $��139,467,0,0q�6h   $	��Top=�6}   $��Yu Gothic Light)�6�   $��99��6�   $��40��6�   $��20(�6�   �� 5-   
   -   5        $ label1_Copy1��5-      $��Student ��6&   ���#f03a47$
��Left=�5.      $��168,467,0,0q�63   $	��Top=�6H   $��Yu Gothic Light)�6`   $��90��6}   $��36��6�   $��1��6�   $��20(�6�   �� 5/   
   
���   �$��2q�6%   $��23,526,29,199q�69    �� CornerRadius$ 10,10,10,10��6P   ._�50      �� $ Vertical=�6   .+�51      �� $��Create Test��6   $
��Left=�6.   $��14(�6I   ���#f03a47$��	10,20,0,0q�6l   $��Yu Gothic UI Light)�6   �� 52      $��View Student Marks��6   $��14(�65   ���#f03a47$��10,5,0,0q�6X   $��Yu Gothic UI Light)�6j   �� 53      $��View Student Marks��6   $��14(�65   ���#f03a47$��10,5,0,0q�6X   $��Yu Gothic UI Light)�6j   54      55      �� 56   
   
���   �$��2q�6%   $��42.929,526,12.929,199q�69   $ 10,10,10,10��6X   $��1��6s   ._�57      �� $ Vertical=�6   .+�58      �� $��	Take Test��6   $
��Left=�6,   $��14(�6G   ���#f03a47$��	10,20,0,0q�6j   $��Yu Gothic UI Light)�6}   �� 59      $��
View Marks��6   $��14(�6-   ���#f03a47$��10,5,0,0q�6P   $��Yu Gothic UI Light)�6b   �� 5:      $��View Memorandum��6   $��14(�62   ���#f03a47$��10,5,0,0q�6U   $��Yu Gothic UI Light)�6g   5;      5<      5>      5?      