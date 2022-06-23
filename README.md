# ParqueaderoBackEnd_SV



El sistema es un servidor backend diseñado para un sistema de negocio de alojamiento de vehículos. Consta de dos Proyectos una dll (PARQUEADERO.BL) y la API (PARQUEADERO.API). Cabe resaltar que la primera maneja la comunicación con la base de datos.
El lenguaje de programación elegido fue C#, con .NET Framwork.



El sistema trabaja bajo Layer Architecture, así se tienen las capas: i) Servicios ii) Lógica iii) Acceso a datos e integración. La arquitectura se encuentra diagramada en el archivo adjunto arquitectura.pdf.



El sistema de persistencia con el que trabaja el sistema es SQLSERVER 2019, el script de creación de la DataBase esta en el archivo adjunto parqueadero_SV.sql.
Los métodos expuestos de la API son POST, GET, PUT, y DELETE. El CRUD de la API esta dado de acuerdo a la entidad vehículos  su documentación respectiva está hecha sobre Swagger [https://localhost:44360/swagger/ui/index]



Para la autorización autenticación se uso JWT, con tokens de periodo de expiración de un año, el método GET de la API no necita de autentificarse para utilizarlo caso contrario del resto de métodos que necesitan autenticación de usuario. 



Usuario demuestra con autenticación
```
 "usuario":"santiago.v",
 "password":"12345"

```




Token previamente generado para el usuario de muestra, el tipo de token es: Bearer Token

```
Token: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InNhbnRpYWdvLnYiLCJuYmYiOjE2NTU5NTU3ODgsImV4cCI6MTY4NzQ5MTc4OCwiaWF0IjoxNjU1OTU1Nzg4LCJpc3MiOiJodHRwczovLyIsImF1ZCI6Imh0dHBzOi8vIn0.FX2tmNjGH2yCguE7kSqV4vHrHuIk769G0DOec6SdJi4
```





Nota: La consulta de los vehículos esta formulada por paginación y también filtrada para los vehículos que no tengan una hora de salida que se los considera como que siguen dentro del parqueadero. La cuota del parqueadero es de 1 dólar por hora o fracción.
