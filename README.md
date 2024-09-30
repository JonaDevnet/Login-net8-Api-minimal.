# 🔐 API Minimalista para Login en C# con ADO.NET y Encriptación

Este proyecto es una API minimalista en C# diseñada para manejar un único método POST que permite el inicio de sesión de usuarios. Utiliza **ADO.NET** para conectarse a una base de datos, y cuenta con un servicio de encriptación y desencriptación para almacenar las contraseñas como hashes seguros. Todo el sistema está diseñado siguiendo una arquitectura en capas, facilitando la mantenibilidad y escalabilidad.

## 🚀 Características

- **API Minimalista**: Un único endpoint POST para el login.
- **ADO.NET**: Conexión eficiente a la base de datos.
- **Encriptación Segura**: Implementación de hashing de contraseñas para asegurar las claves de usuario.
- **Arquitectura en Capas**: Separación lógica en capas (UI, Negocios, Datos).

## 📁 Estructura del Proyecto

```bash
📦ProyectoAPI
 ┣ 📂CapaDatos
 ┣ 📂CapaNegocios
 ┣ 📂CapaServicios
 ┣ 📂CapaAPI
 ┣ 📂CapaEncriptacion
 ┣ 📜Program.cs
 ┗ 📜README.md
```
## 🛠️ Tecnologías Utilizadas

- **C# (.NET)**: Lenguaje principal para el desarrollo de la API.
- **ADO.NET**: Para la gestión de las consultas a la base de datos.
- **Encriptación Hash**: Almacenamiento seguro de contraseñas.
- **Arquitectura en Capas**: Facilita la separación de responsabilidades en el proyecto.

## 🔗 Índice

1. [Instalación](#instalación)
2. [Uso](#uso)
3. [Contribuciones](#contribuciones)
4. [Enlace al Front-End](#front-end)
5. [Licencia](#licencia)

## 📥 Instalación

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/proyectoAPI.git
   ```
   ## 🚀 Uso

El único endpoint POST disponible para el login es el siguiente:

### POST /api/login

**Descripción**: Este endpoint verifica las credenciales del usuario, usando **ADO.NET** para consultar en la base de datos y el servicio de **encriptación** para comparar los hashes de las contraseñas.

#### Request

```json
{
  "username": "usuario",
  "password": "contraseña"
}
```
#### Response

- **200 OK**: Autenticación exitosa.
- **401 Unauthorized**: Credenciales inválidas.

## 🤝 Contribuciones

Si deseas contribuir a este proyecto, puedes hacer un fork, crear una rama con tus mejoras, y enviar un pull request. ¡Las contribuciones son bienvenidas!

## 🎨 Front-End

Para acceder al código del front-end que interactúa con esta API, dirígete al siguiente repositorio:

👉 [Front-End del Proyecto](https://github.com/JonaDevnet/UI-Winforms-GunaUI2-For-Login)

## 📜 Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.


