# PRUEBA TÉCNICA

- [PRUEBA TÉCNICA](#prueba-técnica)
- [INSTRUCCIONES](#instrucciones)
- [RESPUESTAS](#respuestas)


# INSTRUCCIONES

Realice la siguiente prueba generando los scripts / archivos que aplique para cada uno y súbalo a un repositorio GIT en cualquier servicio en la nube. El link deberá ser enviado al correo electrónico de donde recibió la prueba para poderlo descargar y revisar.

1.  Escriba el código de una página ASPX que solicite el nombre del usuario, contraseña, y que valide que los campos no vayan vacíos antes de enviar la solicitud al servidor.

2.	Escriba un documento XML que permita intercambiar información de tarjetas de crédito entre dos sistemas distintos: nombre del sistema, localización, número de tarjeta, ID único de cliente, etc.

3.	Con el siguiente modelo de base de datos:


Catálogos:
-   PROYECTO: Listado de proyectos de tarjetas que existen (Ejemplo: Premia, Konmi, Yujule, etc.)
-   PRODUCTO: listado de productos de tarjetas que hay. (ejemplo Premia Clásica, Premia Oro, Premia Platinum)
-   TIPO: Tipo de mensaje (ejemplo de mensaje de texto, mail, mensaje en el estado de cuenta)
-   TIPO_INFORMACION: Tipo del mensaje. Ejemplo mensaje de bienvenida, mensaje de mora, mensaje de promoción

Otras:
-   FORMATO_MENSAJE: son los formatos de los mensajes existentes.
-   MENSAJE: si el mensaje aplica a que proyecto y que producto

    A.  Escriba la consulta en SQL que devuelva el nombre del proyecto y sus productos correspondientes del proyecto premia cuyo código es 1
    
    B.	Escriba una consulta SQL que devuelva los distintos mensajes que hay, indicando a qué proyecto y producto pertenecen.

    C.	Escriba una consulta SQL que devuelva los distintos mensajes que hay, indicando a qué proyecto y producto pertenecen. Pero si el mensaje está en todos los productos de un proyecto, en lugar de mostrar cada producto, debe mostrar el nombre del proyecto y un solo producto que diga “TODOS”.


4.	Escrba el código de una clase, en sintaxis C# que permita hacer conexiones a una base de datos cualquiera, y que devuelva en uno de sus métodos un Dataset al hacer un SELECT, y en otro de sus métodos el número de filas afectadas al ejecutar un INSERT, UPDATE o DELETE. También debe poder devolver el número de filas que devolvería un SELECT si se ejecutara.

5.	Construya un modelo Entidad Relación que permita llevar el control de Canje de sus puntos acumulados por premios.

    a.	El artículo debe tener código, nombre, tipo y subtipo.

    b.	Se debe manejar la existencia de artículos por sucursal. Ejemplo, está la sucursal Promerica Majadas y Promerica Columbus y en cada sucursal existen artículos como DVD de Disney, lapiceros, mouse, etc. Y cada sucursal debe saber qué cantidad posee en inventario.

    c.	Van a existir varias promociones para canjear y estas van a estar compuestas por varios artículos. Estas promociones poseen rangos de fecha de vigencia y en dichas promociones estará el costo de los puntos y el precio del artículo

    d.	El canje debe tener ID del artículo, Cantidad Canjeada, Precio del artículo, la promoción y observaciones.

#   RESPUESTAS

[Repuestas](Respuestas.md)