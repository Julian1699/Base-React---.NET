# Frontend del Sistema de Gestión de Objetos 

| React |

## Aplicación de Gestión de Objetos con React JS

¡Bienvenido al repositorio del frontend de la Aplicación de Gestión de Objetos! En esta aplicación, utilizamos React para el desarrollo del frontend, proporcionando una experiencia de usuario dinámica y amigable.

## Descripción

El objetivo central de este frontend es proporcionar una interfaz de usuario eficiente y centralizada para la gestión de objetos abstractos. React JS se utiliza en el frontend para construir una interfaz interactiva y receptiva.

## Características Clave

### Frontend React JS
- **Componentes Dinámicos**: Utilizamos componentes de React para crear una interfaz de usuario dinámica y modular.
- **Bootstrap para Estilos**: Se emplea Bootstrap para asegurar un diseño consistente y responsivo.
- **Iconos con Font Awesome**: Implementación de iconos vectoriales mediante Font Awesome.
- **Comunicación Asincrónica**: Axios se utiliza para manejar las solicitudes HTTP asincrónicas hacia el backend.

## Funcionalidades CRUD

### Crear (AgregarObjeto.js)
Permite a los usuarios agregar nuevos objetos a la base de datos mediante un formulario. Los datos se envían al backend utilizando una solicitud HTTP POST.

### Leer (ListadoObjetos.js)
Permite a los usuarios ver una lista de todos los objetos almacenados. Los datos se obtienen del backend mediante una solicitud HTTP GET.

### Actualizar (EditarObjeto.js)
Permite a los usuarios editar los detalles de un objeto existente. Los datos modificados se envían al backend utilizando una solicitud HTTP PUT.

### Eliminar (ListadoObjetos.js)
Permite a los usuarios eliminar un objeto de la base de datos. La eliminación se realiza mediante una solicitud HTTP DELETE.

### Buscar Objetos (ListadoObjetos.js)
Permite a los usuarios buscar objetos en la base de datos utilizando varios filtros (nombre, descripción, precio, fecha de creación). La búsqueda se realiza mediante una solicitud HTTP GET con parámetros de consulta.

## Tecnologías Empleadas

### Frontend
- **React**: Biblioteca de JavaScript para construir interfaces de usuario.
- **Bootstrap**: Framework CSS para el diseño responsivo.
- **Font Awesome**: Biblioteca de iconos vectoriales.
- **Axios**: Cliente HTTP para realizar solicitudes a la API.

## Instalación y Ejecución

### Prerrequisitos

- Node.js y npm instalados en su máquina.

### Pasos

1. Clonar el repositorio:

    ```bash
    git clone https://github.com/Julian1699/Base-React-SpringBoot.git
    ```

2. Instalar las dependencias:

    ```bash
    cd frontend-react
    ```

    ```bash
    npm install
    ```

3. Ejecutar la aplicación:
    ```bash
    npm start
    ```

4. Acceder a la aplicación en [http://localhost:3000].

## Componentes Principales

### Navbar.js
Este componente define la barra de navegación de la aplicación, utilizando `react-router-dom` para la navegación entre diferentes rutas.

### AgregarObjeto.js
Este componente permite agregar un nuevo objeto mediante un formulario. Utiliza `axios` para enviar la solicitud POST al backend.

### EditarObjeto.js
Este componente permite editar un objeto existente. Utiliza `axios` para enviar la solicitud PUT al backend.

### ListadoObjetos.js
Este componente muestra una lista de todos los objetos y permite buscar, editar y eliminar objetos mediante interacciones con el backend.

### Bienvenida.js
Este componente muestra una página de bienvenida con información básica sobre la aplicación y enlaces a otras secciones importantes.

### Informacion.js
Este componente proporciona detalles sobre la aplicación, sus características y cómo utilizarla.

### Tecnologias.js
Este componente lista y describe las tecnologías utilizadas en la construcción de la aplicación, mostrando los logos y una breve descripción de cada tecnología.
