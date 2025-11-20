# FINAL_POO_Ejercicio_1
Vamos a desarrollar una "Agenda de contactos" aplicando los contenidos de la materia Programación Orientada a Objetos en la Universidad Abierta Interamericana UAI

La agenda contiene numeros celulares de Empleados provenientes de Argentina,Buenos Aires, por lo que se debe colocar el telefono con este formato ( +54 11 1234-7890 ).

La Clase Empleados debe respetar el encapsulamiento y cada persona debe mostrarse en el DataGridView.

Los atributos seran los sigientes
| Empleado |
- Apellido
- Nombre
- Telefono

Esta agenda tendra dos categorias |Administrativo y Operario|

Los Administrativos tendran un sueldo de 800USD y los Operarios tendran un sueldo de 600USD mensuales.
Al calculo del sueldo final se le asignara un estimulo del 2% por año trabajado en la empresa.

- Se tendra que crear utilizando LINQ una busqueda incremental de Empleados por el apellido
- Ordenar Descendentemente la grilla y Ascendentemente por sueldo final y por Nombre

-----------------------------------------------------------------------------------------

Crearemos una segunda tabla que muestre Equipos, estos equipos tienen

- Codigo
- Fecha_Entrada
- Uso ( Este campo podra ser True o False, en caso de ser False, la fecha de salida debera ser 1/12/2999 por defecto )
- Fecha_Salida
- Fecha_Compra
- Valor Compra
- Valor Final ( Cada año dede la compra el equipo pierde un 15% de su valor )

Tendremos una tercera tabla que muestre el Codigo del equipo y que Administrativo lo compro ( Se seleccionara un administrativo y se le asignara un equipo, pero si se selecciona un Operario y quieres agregarle un equipo no se podra)

Esta tercera tabla debera actualizarse al seleccionar un operario y mostrar solo los equipos que agrego el operario

