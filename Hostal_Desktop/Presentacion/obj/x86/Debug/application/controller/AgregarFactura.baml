   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Presentacion.application.controller#Presentacion.application.controller  5   	   8    2Presentacion.application.controller.AgregarFactura   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Presentacion.application.controller     5   	     � Title$  AgregarFactura��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� $��Agregar Factura��6   $
��Left=�6*   $��
254,15,0,0q�6E   $	��Top=�6Y   �� 5   
   $��N° de Factura��6   $
��Left=�6(   $��	33,58,0,0q�6C   $	��Top=�6V    J� RenderTransformOrigin$ 
0.18,0.436&�6n   �� 5   
   $
��Left=�6   $��23��6-   $��
139,64,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   �� 5   
   $��Rut Cliente��6   $
��Left=�6&   $��
27,104,0,0q�6A   $	��Top=�6U   �� 5   
   $
��Left=�6   $��23��6-   $��138,108,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   �� 5   
   $��Código Producto��6   $
��Left=�6*   $��
22,149,0,0q�6E   $	��Top=�6Y   $ -1.263,0.205&�6q   �� 5   
   $
��Left=�6   $��23��6-   $��140,151,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   �� 5   
   $��Cantidad��6   $
��Left=�6#   $��
29,199,0,0q�6>   $	��Top=�6R   �� 5   
   $
��Left=�6   $��23��6-   $��146,197,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   �� 5   
   $��Servicio��6   $
��Left=�6#   $��
30,245,0,0q�6>   $	��Top=�6R   �� 5   
   $
��Left=�6   $��144,247,0,0q�6.   $	��Top=�6C   $	��120��6[   �� 5   
   $��Nombre Cliente��6   $
��Left=�6)   $��356,105,0,0q�6D   $	��Top=�6Y   �� 5   
   $
��Left=�6   $��23��6-   $��484,112,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   �� 5   
   $��Nombre Producto��6   $
��Left=�6*   $��356,155,0,0q�6E   $	��Top=�6Z   $ 0.193,0.359&�6r   �� 5   
   $
��Left=�6   $��23��6-   $��484,160,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   �� 5   
   $��Precio��6   $
��Left=�6!   $��367,204,0,0q�6<   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��23��6-   $��493,203,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   �� 5   
   $��Valor Factura��6   $
��Left=�6(   $��367,245,0,0q�6C   $	��Top=�6X   �� 5   
   $
��Left=�6   $��23��6-   $��492,241,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   �� 5   
   $��Agregar Factura��6   $
��Left=�6+   $��335,320,0,0q�6F   $	��Top=�6[   $	��125��6s   $ 0.5,0.5&�6   $��35��6�   z�5      V� 5      .~�5       �� �� 5!      �� 5"       �� Angle$ 0.346Q�6&   T� 5#      5$      5&      5(      5)      