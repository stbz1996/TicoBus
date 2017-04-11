use proyecto;
-- ######################################################### -- Inicio del codigo del Evento
SET GLOBAL event_scheduler = ON;                             -- habilita la opcion de los eventos
DROP EVENT IF EXISTS hacerPagosDiarios;                     -- Borra el evento si existe, para sobreescribirlo
CREATE EVENT `hacerPagosDiarios`                             -- Nombre del evento
	ON SCHEDULE EVERY 1 DAY STARTS '2016-11-24 23:59:30'     -- Lo hace cada dia, desde el 2016-11-23, la hora es militar
	ON COMPLETION NOT PRESERVE ENABLE                        -- sentencia necesaria
DO                                                           -- Acá se define lo que se va a hacer
	 call hacer_pagos_por_empresa();

	

-- ######################################################### -- Fin de los comandos a ejecutar(no lleva nada para el cierre)
-- verificar detalles
