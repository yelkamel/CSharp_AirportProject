   M S B A M L   `   `   `  ����I  EAirportProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Airport.ViewModelAirport.ViewModel  5   	       AirportProject.ListBagage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6
view_modelclr-namespace:Airport.ViewModel     5   	     � Title$  
ListBagage��5   	   $	��700��6   $	��700��6*   
������� � 
ResizeMode$ NoResize=�6M    � 	Resources 5         	vm_bagage S� 
ObjectType    Airport.ViewModel.VMBagage��%"   &	        S� 5   
   "  60   5      .��5
      � .+�5   
   � $
��Left=�6   $	��650��6*   $��10,0,0,0q�67   $	��Top=�6I   $	��672��6a   .+�5      �� $��Liste des bagages��6   $
��Left=�60   $��	11,16,0,0q�6K   $	��Top=�6^   $	��507��6v   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
all_bagage��5   G   $
��Left=�5      $��	10,45,0,0q�62      AutoGenerateColumns .  $	��Top=�5      $	��652��6.   $	��586��6:   ��5      �� *ListAllBagage+ �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Id_bagage��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6<   
   
Visibility$
 Hidden=�6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *	Id_bagage+6d     5      $ CodeIata��6)   $	 * 6;    6E   �� *
CodeIata+  5      $ IdTache��6)   $	 * 6:    6D   �� *	IdTache+  5      $ 	Compagnie��6)   $	 * 6<    6F   �� *	Compagnie+  5      $ Ligne��6)   $	 * 68    6B   �� *Ligne+  5      $ DateCreation��6)   $	 * 6?    6I   �� *DateCreation+  5      $ status_ejection_surete��6)   $	 * 6I    6S   �� *status_ejection_surete+  5      $ 
cle_global��6)   $	 * 6=    6G   �� *
cle_global+  5      $ jour_exploitation��6)   $	 * 6D    6N   �� *jour_exploitation+5      5      5      5      