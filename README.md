# Sistema de Gestión de Objetos 
| React | .NET | PostgreSQL |

## Aplicación de Gestión de Objetos con React JS, .NET y PostgreSQL

![App React+ Net](https://github.com/Julian1699/Base-React-.NET/assets/114323630/0cb18341-f76b-47a5-9130-5456acaa5ba0)

¡Bienvenido al repositorio del proyecto de la Aplicación de Gestión de Objetos! En esta versión, hemos empleado PostgreSQL para una mayor escalabilidad y rendimiento. La aplicación utiliza tecnologías modernas como React y .NET.

![image](https://github.com/Julian1699/Base-React-.NET/assets/114323630/8a02ad63-58ed-4f9e-b9c2-145deb9b46c9)

## Descripción

El objetivo central de esta aplicación es proporcionar una plataforma eficiente y centralizada para la gestión de objetos abstractos. Hemos combinado React en el frontend y .NET en el backend para ofrecer una experiencia de usuario dinámica y una base sólida.

## Características Clave

### Frontend React
Hemos utilizado React para construir una interfaz de usuario altamente interactiva y dinámica. Los componentes de React están organizados jerárquicamente, brindando una experiencia fluida y receptiva a los usuarios.

### Gestión de Estilos con Bootstrap
La apariencia profesional y amigable para el usuario se logra mediante el uso de Bootstrap, que permite aplicar estilos y diseño de manera coherente.

### Comunicación Asincrónica
La biblioteca Axios gestiona las peticiones HTTP asincrónicas entre el frontend y el backend, lo que garantiza respuestas eficientes y en tiempo real.

### Backend con .NET
Hemos implementado .NET en el backend para crear un sistema robusto y seguro. Esto nos permite manejar rutas, autenticación, autorización y la lógica empresarial en general.

### Controladores REST
Hemos utilizado controladores REST de .NET para definir y gestionar las diversas rutas y acciones disponibles en la aplicación.

### Persistencia con Entity Framework Core
La capa de persistencia y gestión de datos se realiza a través de Entity Framework Core. En esta versión hemos utilizado PostgreSQL, lo que mejora la escalabilidad y el rendimiento.

## Tecnologías Empleadas

### Frontend
- **React**: Biblioteca de JavaScript para construir interfaces de usuario.
- **Bootstrap**: Framework CSS para el diseño responsivo.
- **Font Awesome**: Biblioteca de iconos vectoriales.
- **Axios**: Cliente HTTP para realizar solicitudes a la API.

### Backend
- **.NET**: Framework para construir aplicaciones web.
- **Entity Framework Core**: Para interactuar con la base de datos.
- **Swagger**: Documentación interactiva de la API.
- **PostgreSQL**: Sistema de gestión de bases de datos relacional.

## Instalación y Ejecución

### Prerrequisitos
- Node.js y npm instalados en su máquina.
- .NET SDK 6.0 instalado en su máquina.
- PostgreSQL instalado y configurado.

### Pasos

### 1. Clonar el repositorio:
    ```bash
    git clone https://github.com/Julian1699/Base-React-.NET.git
    ```

### 2. Instalar dependencias del frontend:

    ```bash
        cd frontend-react
    ```

    ```bash
        npm install
    ```

### 3. Ejecutar el frontend:

    ```bash
        npm start
    ```

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

### Accede a la aplicación en las siguiente direcciones: 

Frontend: http://localhost:3000
Backend: http://localhost:5001
Swagger: http://localhost:5001/swagger/index.html
