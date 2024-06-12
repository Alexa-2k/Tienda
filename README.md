# Tienda
A2.  DSOO 

Desarrollar un sistema de gestión de productos para una tienda. 
Nuestro objetivo es administrar diferentes tipos de productos y calcular el precio total de venta de cada uno de ellos.
Los productos en nuestro sistema tienen tres atributos comunes: nombre, precio y tipo. 
Sin embargo, existen dos tipos específicos de productos: los perecederos y los no perecederos .
Los productos perecederos  tienen un atributo adicional llamado "días a caducar", que indica cuántos días les quedan antes de que caduquen. Por otro lado, los productos no perecederos  tienen un atributo llamado "categoria" que especifica la categoría a la que pertenecen.
Para hacer:
Para cumplir con los requisitos, debemos crear constructores, getters, setters y el método mostrarDatos en ambas clases de productos.

Tendremos una función llamada "calcularPrecioTotal" , que según cada clase hará una cosa u otra, a esta función le pasaremos un número siendo la cantidad de productos 

En Producto, simplemente seria multiplicar el precio por la cantidad de productos especificados. 
En Perecedero, aparte de lo que hace producto, el precio se reducirá dependiendo de los días a caducar según las siguientes reglas: 
Si le queda 1 día para caducar, se reducirá 4 veces el precio final. 
Si le quedan 2 días para caducar, se reducirá 3 veces el precio final. 
Si le quedan 3 días para caducar, se reducirá a la mitad de su precio final. 
En NoPerecedero, el cálculo es igual al de Producto sin ninguna modificación adicional.
Para probar nuestro sistema, crearemos una clase de prueba llamada "Test"  y crearemos una lista de productos. 

Luego, mostraremos el precio total de vender 5 productos de cada tipo. 

Podés crear tus propios objetos de producto dentro del array para realizar la prueba.
