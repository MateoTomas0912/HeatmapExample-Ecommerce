# Heatmap Example Ecommerce

Este es un proyecto de ejemplo para demostrar cómo implementar un sistema de heatmap en un entorno de comercio electrónico. El proyecto tiene como objetivo capturar eventos de usuarios (como clics o desplazamientos) en una página web y almacenarlos en el backend. Estos datos se pueden utilizar para generar un mapa de calor y analizar el comportamiento de los usuarios en el sitio.

## Tecnologías Usadas

Este proyecto utiliza las siguientes tecnologías:

- **Frontend**: 
  - **JavaScript**: Para la lógica interactiva de la página web, incluida la captura de eventos de usuarios.
  - **HTML**: Para la estructura y contenido de la página web.
  - **CSS**: Para los estilos visuales y diseño responsivo de la página web.

- **Backend**: 
  - **.NET Core**: Para gestionar las solicitudes del frontend, procesar los eventos del mapa de calor y almacenarlos en el servidor.

## Cómo Clonar el Repositorio

Para clonar este repositorio, sigue estos pasos:

1. Abre tu terminal.
2. Ejecuta el siguiente comando para clonar el repositorio:

```bash
git clone https://github.com/MateoTomas0912/HeatmapExample-Ecommerce.git
```

3. Una vez clonado el repositorio, navega a la carpeta del proyecto:

```bash
cd HeatmapExample-Ecommerce
```

4. Para el backend de .NET Core, navega a la carpeta correspondiente y ejecuta:

```bash
cd Backend
dotnet restore
dotnet run
```

5. Para el frontend, si usas Node.js o un entorno similar, ejecuta:

```bash
cd Frontend
npm install
npm start
```

Esto debería levantar el proyecto tanto en el backend como en el frontend y permitirte interactuar con el sistema de heatmap.

## Apertura a la Colaboración

Este proyecto está abierto a colaboraciones. Si tienes ideas para mejorar el proyecto, solucionar errores o agregar nuevas funcionalidades, no dudes en hacer un **fork** del repositorio, realizar tus cambios y enviar un **pull request**.

**Pasos para colaborar:**

1. Haz un fork del repositorio.
2. Crea una nueva rama para tus cambios: `git checkout -b nombre-de-la-rama`.
3. Realiza tus modificaciones y haz commit: `git commit -am 'Descripción de los cambios'`.
4. Sube tus cambios a tu fork: `git push origin nombre-de-la-rama`.
5. Abre un pull request describiendo los cambios que realizaste.

## Licencia

Este proyecto está bajo la **Licencia MIT**. 
