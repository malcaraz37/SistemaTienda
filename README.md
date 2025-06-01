🛒 SistemaTienda - Registro de Productos, Proveedores y Entradas
SistemaTienda es una aplicación web desarrollada con Blazor Server que permite administrar productos, proveedores y las entradas de inventario de una tienda. El sistema fue creado como parte de un proyecto académico para aprender a implementar operaciones CRUD (crear, leer, actualizar y eliminar) con un enfoque en arquitectura limpia y buenas prácticas de desarrollo en C# y Entity Framework Core.

🎯 Objetivo del proyecto
El propósito de este proyecto es simular un sistema de inventario básico que facilite la administración de entradas de productos en una tienda. Se busca reforzar el uso de:

Blazor Server para crear interfaces interactivas en tiempo real.

Entity Framework Core para el manejo de datos.

Patrón repositorio para separar la lógica de acceso a datos.

Relaciones entre entidades (Producto-Proveedor).

Además, se contempló que el sistema pudiera escalar en un futuro conectándose a una base de datos SQL real.

🧩 Funcionalidades principales
📦 Productos
Registrar nuevos productos indicando nombre, precio, stock y proveedor.

Consultar el listado de productos con sus datos principales.

Editar o eliminar productos registrados.

🧾 Proveedores
Registrar proveedores con datos como nombre, contacto, teléfono y correo electrónico.

Visualizar el listado completo de proveedores.

Editar o eliminar registros existentes.

📥 Entradas
Registrar entradas de productos indicando:

Producto recibido

Cantidad ingresada

Fecha

Descripción del pedido

Visualizar un historial de entradas con:

Producto relacionado

Cantidad ingresada

Fecha de registro

Stock actual del producto

Nombre del proveedor del producto

Posibilidad de editar o eliminar entradas del historial.


⚙️ Tecnologías utilizadas
C# con .NET 7

Blazor Server

Entity Framework Core

Bootstrap 5 para el diseño visual

Microsoft SQL Server (en simulación local)

🧪 Estado actual del sistema
El CRUD de Proveedores está completamente funcional.

Las validaciones en Producto y Entrada ya están activas.

El sistema ya muestra correctamente el nombre del proveedor en el historial de entradas.

El proyecto ha sido probado y validado para cumplir con las actividades académicas correspondientes.

