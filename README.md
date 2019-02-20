# VacacionalesApp

Proyecto para el registro de paquetes vacacionales hecho en el lenguaje Visual Basic (en desarrollo)

## Notas

Hace falta el archivo App.config en el proyecto, para hacer que funcione se ocupa crear o modificar el ya existente que se crea automaticamente.

### En caso de tenerlo agregar o modificar esta linea de codigo:

```
<connectionStrings>
    <add name="ConexionMySQL" connectionString="SERVER=yourserver; DATABASE=yourdatabase; UID=yourdatabaseuser; PASSWORD=yourpassword"/>
</connectionStrings>
```

### En caso de que no lo tenga, crearlo y agregar esto:

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
    </startup>

  <connectionStrings>
    <add name="ConexionMySQL" connectionString="SERVER=yourserver; DATABASE=yourdatabase; UID=yourdatabaseuser; PASSWORD=yourpassword"/>
  </connectionStrings>
</configuration>
```
Y al final guardar en la carpeta raiz del proyecto como App.config
