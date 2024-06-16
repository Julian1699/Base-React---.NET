# Backend del Sistema de Gestión de Objetos 

| .NET | PostgreSQL |

## Aplicación de Gestión de Objetos con .NET y PostgreSQL

¡Bienvenido al repositorio del backend de la Aplicación de Gestión de Objetos! En esta aplicación, utilizamos .NET para el desarrollo del backend, proporcionando una API robusta y segura.

## Descripción

El objetivo central de este backend es proporcionar una API eficiente y centralizada para la gestión de objetos abstractos. .NET se utiliza en el backend para construir un sistema escalable y seguro.

## Características Clave

### Backend con .NET

- **Controladores REST**: Utilizamos controladores REST para definir y gestionar las rutas y acciones de la API.
- **Persistencia con Entity Framework Core**: La gestión de datos se realiza a través de Entity Framework Core, asegurando una interacción eficiente con la base de datos.
- **Documentación con Swagger**: La API está documentada con Swagger, proporcionando una interfaz interactiva para probar los endpoints.
- **Base de Datos PostgreSQL**: Utilizamos PostgreSQL para la gestión de bases de datos relacional.

### 4. Configurar Conexión a tu Base de Datos

Para que la aplicación se conecte correctamente a tu base de datos local, es crucial configurar el archivo `appsettings.json` con las credenciales de conexión adecuadas. Este proyecto está diseñado para aceptar conexiones a bases de datos PostgreSQL.

#### Configuración de `appsettings.json`

Asegúrate de que tu archivo `appsettings.json` tenga la siguiente estructura y que reemplaces los valores con tus propias credenciales de base de datos:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "Connection": "Host=localhost;Port=5432;Database=tu-schema;Username=tu-usuario;Password=tu-contraseña;"
  }
}
```

#### Instalar Dependencias del Backend y Ejecutarlo

Sigue estos pasos para instalar las dependencias necesarias y ejecutar el backend de la aplicación:

Navega al directorio del backend:

```bash
    cd ../backend-.net
```

Restaura las dependencias del proyecto:

```bash
    dotnet restore
```

Ejecuta la aplicación:

```bash
    dotnet run
```

### Configurar el ORM para Crear la Tabla "objeto"

Para configurar Entity Framework Core y asegurarte de que la tabla `objeto` se cree en el esquema de base de datos correcto, debes realizar los siguientes pasos:

#### Crear el esquema en PostgreSQL:

Asegúrate de tener un esquema llamado `try` (o el nombre que prefieras) en tu base de datos PostgreSQL. Puedes crear el esquema utilizando el siguiente comando SQL en tu herramienta de administración de PostgreSQL:

```sql
CREATE SCHEMA try;
```

#### Ejecutar la migración para crear la tabla `objeto`:

1. En el Visual Studio, navega a `Herramientas > Administrador de Paquetes NuGet > Consola del Administrador de Paquetes`.

2. En la consola, ejecuta el siguiente comando para aplicar las migraciones y crear la tabla `objeto` en el esquema `try` de la base de datos PostgreSQL:

```bash
    PM> Update-Database
```

Después de ejecutar este comando, la tabla objeto se creará en el esquema tryapi de tu base de datos PostgreSQL.

### Acceder a la aplicación:

Accede a la siguiente ruta una vez se haya puesto en marcha la aplicación:

```bash
    http://localhost:5001/swagger/index.html
```

### Funcionalidades CRUD

#### Crear Objeto
Permite a los usuarios agregar nuevos objetos a la base de datos mediante una solicitud HTTP POST.

#### Leer Objetos
Permite a los usuarios ver una lista de todos los objetos almacenados. Los datos se obtienen mediante una solicitud HTTP GET.

#### Leer Objeto por ID
Permite a los usuarios obtener un objeto específico por su ID mediante una solicitud HTTP GET.

#### Actualizar Objeto
Permite a los usuarios editar los detalles de un objeto existente. Los datos modificados se envían mediante una solicitud HTTP PUT.

#### Eliminar Objeto
Permite a los usuarios eliminar un objeto de la base de datos mediante una solicitud HTTP DELETE.

#### Buscar Objetos por Filtros
Permite a los usuarios buscar objetos en la base de datos utilizando varios filtros (nombre, descripción, precio, fecha de creación). La búsqueda se realiza mediante una solicitud HTTP GET con parámetros de consulta.

### Tecnologías Empleadas

#### Backend
- **.NET**: Framework para construir aplicaciones web.
- **Entity Framework Core**: Para interactuar con la base de datos.
- **Swagger**: Documentación interactiva de la API.
- **PostgreSQL**: Sistema de gestión de bases de datos relacional.
