   M S B A M L   `   `   `  ����  Presentacion    Presentacion.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  Login��5	   	   $	��350��6   $	��525��6$   .��5      � $	��300��6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   .+�5      �� $ 
Horizontal=�6   $��80��62   $��Center=�6>   $��10q�6[   .+�5      �� $"��/application/image/login.png��6   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��40��6O   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   $��Bottom=�6w   $
��5 5 q�6�    J� RenderTransformOrigin$ 0.239,-0.498&�6�   ��66   ��  �� ElementName$ txt_usuario�� �� Path$ BorderBrush�6�   �� 5      -   5         ��Name$ txt_usuario��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��6/      
IsFloating . $��center=�6�   $	��200��6�   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��40��6O   .+�5        $
 Lock=�6*   $��Bottom=�6z   $	��5 5q�6�   ��66   �� $ txt_contraseña��$ BorderBrush�6�   G� 5      -   5        	 G�Name$	 txt_contraseña��5      $ Password��66    . $��center=�6�   $	��200��6�   5      �� 5      $ 
Horizontal=�6   $��40��62   .+�5      �� -   5        
 ��Name$
 cmb_Rol��5      $	��200��6,   $��
26 0.6 0 0q�68   $ Seleccione Rol��6L   .@�5      �� .��6#   Administrador62   �� 5      .��6#   
Empleado6-   5      5      �� 5      $ Vertical=�6   $��50��60   .+�5       �� $ 
Horizontal=�6   $��Center=�66   .+�5!      �� -   5         ��Name$ btn_ingresar��5!      ���#71b100$��Ingresar��6H   $
��Left=�6[   $��10q�6v   $	��Top=�6�   $	��150��6�   $ 0.606,0.496&�6�   $��34��6�   5"      5#      �� 5$      $ Vertical=�6   $��30��60   .+�5%      �� -   5         ��Name$ 	lbl_Error��5%      $��center=�6+   
���  ��|�.  6m   5&      5'      5(      5)      