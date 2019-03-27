# Ejecutar el siguiente Script de DB y crearlo en dblocal

Conectarse a: `(localdb)\mssqllocaldb` con SQL Management o el IDE de su gusto y ejecutar los siguientes queries SQL:


``` sql
CREATE DATABASE USERSDB;

GO

CREATE TABLE USUARIOS(
    Alias NVARCHAR(100) PRIMARY KEY,
    Clave NVARCHAR(100)
);

GO

INSERT INTO dbo.USUARIOS (Alias, Clave)
VALUES ('mikemir', 'Clav3!');
```

Luego correr el Proyecto: `CleanArchitecture.NetCore.Application.WebApi`

>**Nota:** Debes poner el proyecto como proyecto de inicio.