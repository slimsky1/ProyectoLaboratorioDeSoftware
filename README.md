# Proyecto Laboratorio De Software
 Trabajo Final para la materia laboratorio de software

# Descripción
Este proyecto tiene como fin poner en practica el uso de la arquitectura DDD (Domain Driven Design) empleandolo en metodos ABM, así como también realizar pruebas untarias e inyección de dependencias utilizando el paquete Ninject.

# Pre-Requisitos
Antes de ejecutar el proyecto en tu máquina deberás tener instalado [Visual Studio](https://visualstudio.microsoft.com/es/downloads/), así como un gestor de base de datos, este proyecto utilizó como gestor de base de datos [MySql](https://www.mysql.com/downloads/).

# Iniciar Proyecto
Una ves que ya se haya descargado y abierto el proyecto se deberán seguir los siguientes pasos.
* Dentro de la carpeta del proyecto se encontrará una carpeta llamada **BBDD**, dentro de esta se encontrarán 2 scripts correspondientes a las 2 tablas necesarias en la base de datos, deberán  ejecutarse para poder utilizarlas en el proyecto.
* Dentro de Visual Studio, en el namespace llamado **InfraestructuraPersistencia** se deberá agregar el paquete **MySql.Data**.
* Dentro del namespace llamado **Presentacion** se deberá agregar el paquete **Ninject** para poder trabajar con inyección de dependencia necesaria en el proyecto.
* En el mismo namespace **Presentacion** se encontrará un archivo con el nombre **app.config**. Este mismo dispone de unas tags necesarias para identificar los datos de conexión a la base de datos. Se deberá copiar los datos en la propiedad _connectionString_. A continuación se mostrará un ejemplo de los datos completos.
```
<connectionStrings>
   <add name="MySQLServerConnection" connectionString="datasource=127.0.0.1;port=3306;username=root;password=inicio123;database=labdesoft1;"></add>
</connectionStrings>
```
* Dependiendo la versión de Visual Studio instalada puede darse el caso de que en el namespace **LaboratorioTest** arrojen errores que se solucionan instalando, o en el caso de ya tenerlos actualizando los paquetes **MSTest.TestAdapter** y **MSTest.TestFramework**.

Siguiendo estos pasos el proyecto debería estar listo para ejecutarse.
