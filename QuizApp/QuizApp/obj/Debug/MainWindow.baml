   M S B A M L   `   `   `  ����  QuizApp    QuizApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quiz Application��5   	   $	��600��6"   $
��1000��6/   .��5      �� .+�5
   
   �� $��Quiz Application��6   $��24(�5      $
��Bold"�6"   $��Center=�5      $��10q�61   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��10q�6K   .+�5      �� $��Filter by Topic:��6   $��Center=�6/   �� 5      -   5         ��Name$ TopicComboBox��5      $	��150��6.   $��5q�6:   6E   �� 5      $��Difficulty Level:��6   $��Center=�60   �� 5      -   5        $ DifficultyComboBox��5      $	��150��63   $��5q�6?   6J   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ QuizDataGrid��5         AutoGenerateColumns .  $��10q�6E      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Question Text��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *QuestionText+6]     5      $ Option A��6%   $ * 6S   	 67   �� *	OptionA+6S     5      $ Option B��6%   $ * 6S   	 67   �� *	OptionB+6S     5      $ Option C��6%   $ * 6S   	 67   �� *	OptionC+6S     5      $ Option D��6%   $ * 6S   	 67   �� *	OptionD+6S     5      $ Correct Answer��6%   $ * 6_   	 6=   �� *CorrectAnswer+6_     5      $ Marks��6%   $	 100 6N   	 64   �� *Marks+6N     5       $ 
Time Limit��6%   $	 100 6W   	 69   �� *	TimeLimit+6W   5"      �� 5%   
   $ 
Horizontal=�6   $��Center=�6.   $��10q�6K   .+�5&      �� -   5        
 ��Name$
 	AddButton��5&      $	��Add��6(   $��80��66   $��5q�6A   6L   �� 5'      -   5        $
 
EditButton��5'      $
��Edit��6)   $��80��68   $��5q�6C   6N   �� 5(      -   5        $
 DeleteButton��5(      $��Delete��6+   $��80��6<   $��5q�6G   6R   5)      � 5,   
   -   5         �Name$ LoadingProgressBar��5,      $��10��62   $	��400��6>   $��10q�6J   $��Center=�6V   $y�Hidden=�6s   �� 5/   
   -   5         ��Name$ StatusLabel��5/      $��Ready��6)   $��Center=�66   $��Italic$�6S   $��10q�6f   50      52      