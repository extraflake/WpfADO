   M S B A M L   `   `   `  ����A  =WpfADO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfADOWpfADO  5   	       WpfADO.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfADO     5   	   -   5          � Title$!  Mitra Integrasi Informatika��5   	   $	��400��6-   $	��800��6:   .��5
      � .+�5   
   �� $
��Left=�6   $	��370��60   $	��Top=�6=   $	��790��6U    J� RenderTransformOrigin$ 0.484,0.502&�6a   .@�5      �� $��Supplier��6   
�������.��5      � ���	#FFE5E5E5.+�5      �� $��Supplier Detail��6   $
��Left=�68   $	��330��6S   $	��Top=�6`   $	��195��6x   
������.��5      ��  �� Orientation$ Vertical=�6%   .+�5      �� $��Id��6(   64   �� 5      -   5        $��IdBox��5   &   $	��100��63   $��	-70,0,0,0q�6?    �� 
IsReadOnly . 6f   �� 5      $
��Nama��6(   66   �� 5      -   5        $��NamaBox��5   &   $	��150��65   $��	-20,0,0,0q�6A   6V   �� 5      $��Nomor Handphone��6(   6A   �� 5      -   5        $��NomorBox��5   &   $	��120��66   $��	-50,0,0,0q�6B   6z   �� 5      $��Alamat��6(   68   �� 5      -   5        $��	AlamatBox��5   &   $	��150��67   $��50��6C   $��	-20,0,0,0q�6O   6d   �� 5      $��	Kecamatan��6(   6;   �� 5      -   5        $��KecamatanComboBox��5   '   $	��170��6@    �� DisplayMemberPath$
 Name��6v    �� SelectedValuePath$ Id��6�   ��6L   ��  �� Path$ getKecamatan�6�   �� 5      $��	Kelurahan��6(   6;   �� 5      -   5        $��KelurahanComboBox��5   '   $	��170��6@   $
 Name��6v   $ Id��6�   ��6L   �� $ getKelurahan�6�   �� 5      $��Kode Pos��6(   6:   �� 5      -   5        $��
KodePosBox��5   &   $��70��68   $��
-100,0,0,0q�6C   6Y   5      5      &   System.Windows.Controls.DataGrid  5       -	   5        $��SupplierGrid��5          AutoGenerateColumns .  $
��Left=�6O   $	��240��6j   $��
200,10,0,0q�6w   $	��Top=�6�   $	��575��6�   
�����_�   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   �� $ Id�6[     5#      $
	 Nama��61   
 6?   �� $
 Name�6_     5$      $	 Nomor Handphone��61   
 6J   �� $ Phone�6k     5%      $	 Alamat��61   
 6A   �� $ Address�6d     5&      $	 	Kelurahan��61   
 6D   �� $ Kelurahan.Name�6n     5'      $	 	Kecamatan��61   
 6D   �� $ Kecamatan.Name�6n     5(      $	 Kode Pos��61   
 6C   �� $ 
PostalCode�6i     5)      $	 Tanggal Bergabung��61   
 6L   �� $ 
CreateDate�6r     5*      $	 Tanggal Perubahan Data��61   
 6Q   �� $ 
UpdateDate�6w     5+      $	 Tanggal Keluar��61   
 6I   �� $ 
DeleteDate�6o   5-      �� 5.      $��Action��6   $
��Left=�6/   $��75��6J   $	��Top=�6V   $	��575��6n   $��200,255,0,0q�6z   
������.��5/      �� $ 
Horizontal=�6%   .+�50      �� -
   5        $��SimpanButton��50   %   $	��150��69   $��30��6E   $��20,0,0,0q�6Q   
������$��SIMPAN��6{   6�   �� 51      -   5        $��
UbahButton��51   %   $	��150��67   $��30��6C   $��40,0,0,0q�6O   
�������$
��UBAH��6z   6�   �� 52      -   5        $��HapusButton��52   %   $	��150��68   $��30��6D   $��35,0,0,0q�6P   
����p��$��HAPUS��6}   6�   53      54      55      56      �� 57      $
��Item��6   
�������.��58      � ���	#FFE5E5E560   59      5:      5;      5<      