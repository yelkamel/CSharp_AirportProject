   M S B A M L   `   `   `  ����I  EAirportProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Airport.ViewModelAirport.ViewModel  5   	   !    AirportProject.DepartureVol   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6
view_modelclr-namespace:Airport.ViewModel     5   	     � 
ResizeMode$  NoResize=�6<    � Title$  Listes des vols du départ��5   	   $��400.925��6+   $��788.164��6<   
������� � 	Resources 5       
  vm_vol S� 
ObjectType   Airport.ViewModel.VMVol 	 event   Airport.ViewModel.Event��%D   &	        &	      S� 5   
   "  6-   S� 5   
   "  6,   5	      .��5      � $
��Left=�6   $	��370��6&   $	��Top=�63   $	��778��6K    � RowDefinitions 5   
   �� 5      $
��149* �6   �� 5      $
��221* �6   .+�5   
   �� $��Attributs disponible��6   $
��Left=�61   $��20,0,0,0q�6L   $	��Top=�5       J� RenderTransformOrigin$ -1.127,-4.565&�6+   $	��255��6Q   $	��180��6^   $��2��6j   .��5      �� -   5         ��Name$ critere_vol_list��5       �� SelectedValuePath$	 Key��5       �� DisplayMemberPath$ Value��5      $
��Left=�5      $	��233��6/   $	��Top=�6<   $	��168��6T   ��5   1   �� *
Vol_Fields+	 �� Source#	 [  5   T   5      �� 5   
   $��Attributs affiches��6   $
��Left=�6/   $��	338,0,0,0q�6J   $	��Top=�5      $ -0.099,-1.522&�6+   $	��255��6Q   $	��430��6^   $��2��6j   .��5      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 fields_table��5      $
��Left=�6-   $	��233��6H   $	��Top=�6U   $	��418��6m      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Attribut��6*      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6<      
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Name+  5      $	 Nom��6*   $ * 67    .   6T   �� *ID+5      5      �� 5    
   -   5         ��Name$ 	ajouter_b��5    ^   $
��Left=�6   $��222,73,0,50q�6-   $	��102��6B   ��5!      �� 5"      .R�5#      ��  �� CornerRadius$ 5��6   $	��0.5q�6.   
�������._�5$      �� $��
Ajouter >>��6+   $��Center=�6@   $��Center=�6]   5%      5&      5(      �� 5)   
   -   5        $
��Left=�5)      $��222,123,0,0q�6,   $	��Top=�6A   $	��102��6Y   $��26��6e   ��5*      �� 5+      .R�5,      �� $ 5��6   $	��0.5q�6.   
�������._�5-      �� $��
>> Retirer��6+   $��Center=�6@   $��Center=�6]   5.      5/      51      52      53      