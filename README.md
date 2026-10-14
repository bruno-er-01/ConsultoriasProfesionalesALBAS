# ALBAS: sistema de gestión de citas y casos

Aplicación de escritorio para **Asesores & Consultores Inti (ALBAS)**, una consultora legal. Registra clientes, casos y citas, y ofrece **5 dashboards de gestión** para que la administración tome decisiones con datos.

Proyecto final del curso *Fundamentos de Sistemas de Información* (UPC), desarrollado en equipo de 5 personas.

## Funcionalidades

- **Inicio de sesión con dos roles:** Administrador y Especialista, cada uno con su propio menú.
- **Gestión de clientes, casos, citas y especialistas:** registro, búsqueda, edición y eliminación lógica (los registros se desactivan, no se borran).
- **Recordatorio de citas próximas** para el especialista.
- **Recuperación y cambio de contraseña**, validando el correo registrado del usuario.
- **Exportación de reportes a PDF.**
- **Registro de accesos** (log de inicios de sesión).

### Dashboards

| Dashboard | Qué muestra |
| --- | --- |
| Demanda por área | Casos por área legal y su porcentaje del total |
| Carga laboral por especialista | Casos totales, activos y cerrados de cada especialista |
| Citas ausentes | Monto perdido por citas no asistidas, por mes |
| Antigüedad de casos | Tiempo que llevan abiertos los casos |
| Montos | Ingresos por periodo y por modalidad de cita |

## Tecnologías

- **Lenguaje:** C# (.NET Framework 4.7.2)
- **Interfaz:** Windows Forms, con gráficos de `System.Windows.Forms.DataVisualization`
- **Acceso a datos:** Entity Framework 6 (Database First) y LINQ
- **Base de datos:** SQL Server
- **Reportes:** iTextSharp (PDF)
- **Control de versiones:** Git y GitHub

## Arquitectura

El sistema está organizado en **3 capas**:

```
CapaPresentacion  →  formularios y dashboards (Windows Forms)
       ↓
CapaNegocios      →  reglas y validaciones del negocio
       ↓
CapaDatos         →  acceso a SQL Server con Entity Framework y consultas LINQ
```

**Modelo de datos:** 8 tablas (`Usuario`, `Administrador`, `Especialista`, `Cliente`, `Area`, `Caso`, `Cita`, `Reporte`). Un caso pertenece a un cliente y a un especialista, y cada caso agrupa varias citas.

## Cómo ejecutarlo

1. Ejecuta [`database/schema_BD_ALBAS.sql`](database/schema_BD_ALBAS.sql) en SQL Server Management Studio. Crea la base `BD_ALBAS` con todas sus tablas.
2. Abre `ConsultoriasProfesionalesAlba.sln` en Visual Studio.
3. Restaura los paquetes NuGet (clic derecho en la solución, *Restore NuGet Packages*).
4. Si tu servidor no es la instancia local por defecto, cambia `data source=.` en `CapaPresentacion/App.config`.
5. Ejecuta `CapaPresentacion` como proyecto de inicio.

> El script incluye solo la estructura de la base de datos. Los datos de prueba no se publican porque contienen información personal.

## Posibles mejoras

- Guardar las contraseñas con hash (por ejemplo, BCrypt) en vez de texto plano.
- Mover la cadena de conexión a una configuración por entorno.

## Autor

**Bruno Eustaquio Romani** · Estudiante de Ingeniería de Sistemas de Información (UPC)
[LinkedIn](https://www.linkedin.com/in/bruno-eustaquio-romani) · [GitHub](https://github.com/bruno-er-01)
