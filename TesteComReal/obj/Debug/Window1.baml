   M S B A M L   `   `   `  ����  TesteComReal    TesteComReal.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  Window1��5      $	��600��6   $	��800��6"    � 	Resources 5       
  cmFile��%q   &	        �� 5   
   .@�5      m� $��Connect��6   �� 5      m� 5	      $
��Exit��6   5
      5      .��5      � .+�5   
   o� -   5        $��menuPrincipal��5      $��30��6   $	��Top=�60   .@�5      m� -   5        $��menuArquivo��5   �   $��Arquivo��6    m� IsCheckable .  $��Center=�6<   $��Center=�6`   $��Center=�6�   $��Center=�6�   $
��Auto��6�    �� ItemBindingGroup 5      &   System.Windows.Data.BindingGroup  5         NotifyOnValidationError .     Name 6#   Z� 63   .@�5      m� -   5        $��menuConectar��5   �   $��Conectar��6   $��Center=�6-   $��Center=�6J   $��Center=�6e    � ContextMenu 5      �� 5      $��RightToLeft=�6&   5      �� 5      m� 5      -   5        $��menuSair��5   )   $
��Sair��6   69   5      m� 5      -   5        $��
menuOpcoes��5   '   $��Opções��6   .@�5      m� -   5        $��menuEscreverRegistros��5   7   $��Escrever Registros��6   6T   m� 5      -   5        $��menuEscreverCoils��5   3   $��Escrever Coils��6   6L   5      m� 5      -   5        $��	menuAjuda��5   &   $��Ajuda��6   67   5       �� 5!   
   -	   5        $��txtID��5!   T   $��23��6   $
��Left=�6   $��184.341,80.19,0,0q�69   $	��Top=�6a   $	��120��6y   �� 5"   
   -
   5        $��txtQntLeituras��5"   U   $��23��6   $
��Left=�6   $��184.341,165.93,0,0q�69   $	��Top=�6k   $	��120��6�   �� 5#   
   -   5        $��txtEndereço��5#   I   $
��Left=�6   $��184.341,123.06,0,0q�6-   $	��120��6\   $��23.267��6h   $	��Top=�6x   �� 5$   
   -   5        $��label1��5$   Q   $��23��6   $
��Left=�6   $��20.006,80.19,0,0q�67   $	��Top=�6_   $��145.758��6w   $��Endereço do dispositivo:��6�   $
��Bold"�6�   6�   �� 5%   
   -   5        $��label2��5%   R   $��23��6   $
��Left=�6   $��20.006,165.93,0,0q�67   $	��Top=�6`   $��145.682��6x   $
��Bold"�6�   .��6�   Quantidade de leituras:6�   �� 5&   
   -   5        $��label3��5&   V   $��37.154��6   $
��Left=�6    $��20.006,123.06,0,0q�6;   $	��Top=�6d   $��145.682��6|   $
��Bold"�6�   .��6�   Endereço de começo:6�   �� 5'   
   -   5        $��listBox1��5'   3   $��337.244,80.19,267.223,0q�6   $��168.622��6C   $	��Top=�6T   �� 5(   
   -   5        $��label4��5(   Q   $
��Bold"�6   $��23��6"   $��337.244,0,295.074,252.933q�6.   $��Bottom=�6_   .��6z   Número de falhas:6�   �� 5)   
   -   5        $��label5��5)   P   $
��Bold"�6   $��23��6"   $��337.244,257.22,295.074,0q�6.   $	��Top=�6^   .��6v   Total de mensagens:6�   �� 5*   
   -   5        $��lblTotalMensagens��5*   g   $
��Bold"�6   $��23��6"   $��Right=�6.   $��0,0,231.498,252.933q�6J   $��Bottom=�6�   $��72.879��6�   .��6�   06�   �� 5+   
   -   5        $��lblNumFalhas��5+   f   $
��Bold"�6   $��23��6"   $��Right=�6.   $��0,257.22,231.498,0q�6J   $	��Top=�6z   $��72.879��6�   .��6�   06�   �� 5,   
   -   5        $��
gbxFuncoes��5,   ?   $��	Funções��6   $��27.151,0,0,54.302q�6$   $��153.306��6Q   $
��Left=�6b   $��Bottom=�6}   $��180.054��6�   .��5-      � -   5        $��grid1��5-      $��154.332��6    $��100.433��60   .+�5.      	� -   5        $��rbtCoil��5.   I   $��16��6   $��22.864,28.58,11.432,0q�6*   $	��Top=�6X   .��6p   	Ler Coils6{   	� 5/      -   5        $��rbtRegistro��5/      $��22.864,0,11.468,30.009q�61   $��16.122��6Q   $��Bottom=�6a   .��6|   Ler Registros6�   50      51      �� 52   
   -   5        $��label6��52   d   $
��Bold"�6   $��23��6"   $
��Left=�6.   $��228.64,0,0,54.302q�6I   $��Bottom=�6r   $��75.701��6�   .��6�   
Intervalo:6�   �� 53   
   -   5        $��txtIntervalo��53   D   $��23.267��6   $��297.232,0,374.398,52.035q�6"   $��Bottom=�6X   �� 54   
   -   5        $��btnReset��54   V   $��23��6   $��Right=�6   $��0,0,295.074,211.492q�69   $��Bottom=�6f   $��75��6�   .��6�   Reset6�   55      56      