# ProyectoFinal-Ap1
## Comenzando...

Siguiende las instrucciones dadas a continuación, se podrá hacer buen uso del programa, para de esta manera evitar comenter errores en su uso.

La primera ventana con que se hará interaccion es con el Login.

 ![imagen](https://user-images.githubusercontent.com/54722249/69550721-e5d6c480-0f71-11ea-9fc0-2af7ebae859b.png)

En este registro debemos ingresae el Usuario y la contraseña de un Usuario previamente registrados para poder acceder, en caso de no haber creado ningun usuario el Usuario será: **Adim** y la contraseña: **123**. Luego de ingresados los datos se accede pulsando el botón de Ingresar o simplemente pulsando **Enter**.

Luego de ingresado se pueden cambiar los datos de este usuario. Además, sólo el administrador tiene acceso a editar, crear y consultar usuarios.

## Menú

![imagen](https://user-images.githubusercontent.com/54722249/69552034-21728e00-0f74-11ea-849a-1491743905fb.png)

Este el menú principal de nuestro programa, el cual se abrirá luego de pasar el Login, desde este formulario podremos acceder a los diversos registros y consultas de los que dispone nuestro programa, ademas de poder cerrar la sección actual.

# Registros
## Pacientes

![imagen](https://user-images.githubusercontent.com/54722249/69553116-f852fd00-0f75-11ea-9e39-48afa3ad2509.png)

Este registro nos permite registrar nuevos pacientes, como tambien eliminar y modificar pacientes existentes. 

## Citas

![imagen](https://user-images.githubusercontent.com/54722249/69553403-88914200-0f76-11ea-94f2-567039092b9d.png)

En este registro podremos crear nuevas citas, Las cuales para poder Guardar no debe coincidir la hora de ese dia, con la hora de una cita ya programada para el mismo dia. Además nos permite Eliminar o Modificar Citas ya creadas.

## Tipos de Procedimientos

![imagen](https://user-images.githubusercontent.com/54722249/69553733-05242080-0f77-11ea-9ac0-ac47eb48a124.png)

Este formulario nos sirve para la creación de nuevos tipos de procedimientos, los cuales se le podrán realizar a los clientes. Aquí además se puede Modificar y Eliminar Tios de rocedimientos.

## Procedimientos

![imagen](https://user-images.githubusercontent.com/54722249/69554284-f12cee80-0f77-11ea-8c80-b41efce581a5.png)

Este formulario nos permite guardar la informacion sobre un determinado proceso que se le comience a realizar a un determinado paciente, En este podemos ir agregando como detalle las citas que el paciente vaya agotando, con una descripción de los que se avanzó o se hizo en esta cita, hasta terminar el procedimiento.

## Cobros

![imagen](https://user-images.githubusercontent.com/54722249/69554874-cf803700-0f78-11ea-99b2-96bf7a787e64.png)

En este formulario se registra el cobro de un determinado procedimiento, este se puede hacer mediante abonos, o se puede saldar completo el costo del procedimiento. Este formulario cuenta con un DataGridView en el cual se muestran los pacientes que tienen deudas asi como el Id del procedimiento, para que asi sea mas fácil la busquea.

## Usuarios

![imagen](https://user-images.githubusercontent.com/54722249/69555777-16226100-0f7a-11ea-82b4-f63394c0deed.png)

En este formulario se nos permite registrar un nuevo Usuario, asi como modificar información de un determinado usuario o eliminarlo. Cabe destacar que esta acción solo la puede ralizar el Administrador.

# Consultas

![imagen](https://user-images.githubusercontent.com/54722249/69556474-24bd4800-0f7b-11ea-9176-ec64d9b17343.png)

Esta es la Consulta de pacientes, en la cual se puede filtrar por un rango de fecha, en conjunto con otros Filtros contenidos en un combobox y el textbox de criterio. Al pulsar el botón consultar, se cargaran en el grid los datos que cumplan con los filtros dados. Cabe destacar que si no se coloca ningun filtro, se cargaran todos los datos de esta entidad.

Además cuenta con un botón de imprimir el cual nos imprime un reporte que tambien cumple con los filtros realizados en la consulta.

Las demás consultas son similares a esta, solo variando que algunas no tienen rango de fecha.

# Autor de este Proyecto

Jeferson Raul Ortega Brito

# Herramientas Empleadas en este proyecto

  
    -Visual Studio C# -Heramienta de Desarrollo
    -SQL Server -Gestor de Base de Datos
    -Mozilla Firefox -Navegador del cual fueron extraidos iconos, ademas de buscar soluciones a diversos erroes

# Agradecimientos

A mi profesor Enel ALmonte, el cual puso todo su esfuerzo en que aprendieramos lo necesario en la asignatura Programación Aplicada 1, puso en marcha diversas estrategias para que se nos hiciera más fácil de comprender el contenido y que sus estudiantes pusieramos empeño en aprender.

# Objetivos

Esperando que este proyecto pueda cumplir con las espectativas.









