# 🚗 Microservicio API MarcasAutos - Backend C# (.NET 8) | PostgreSQL | Docker | XUnit

## 📋 Descripción General
Este proyecto es una **API RESTful** desarrollada con **.NET 8**, diseñada para gestionar la entidad **MarcasAutos**. Permite consultar todas las marcas registradas en la base de datos PostgreSQL.

El objetivo principal es demostrar buenas prácticas de desarrollo backend aplicando:
- **Clean Code** y principios SOLID
- **Patrones de diseño**
- **Entity Framework Core** (con migraciones & seed data)
- **Pruebas unitarias con XUnit**
- **Docker Compose** para entorno de desarrollo


## 🏛️ Arquitectura del Proyecto
Se utilizó una **arquitectura hexagonal (Ports & Adapters)**, común en microservicios, para mantener separación de responsabilidades, facilitar el testing y escalar la solución.

### 📦 Estructura de carpetas:

├── src
│   ├── AutoBrands.Api                // API REST Controllers & Middlewares
│   ├── AutoBrands.Application        // Casos de uso (Business Logic)
│   ├── AutoBrands.Domain             // Entidades y contratos (Interfaces)
│   ├── AutoBrands.Infrastructure    // Persistencia, DbContext, Repositorios
├── tests
│   ├── AutoBrands.Api.Tests          // Pruebas para la capa API
│   ├── AutoBrands.Application.Tests  // Pruebas para la capa Application
│   ├── AutoBrands.Domain.Tests       // Pruebas para la capa Domain
│   └── AutoBrands.Infrastructure.Tests // Pruebas para la capa Infraestructura
├── docker-compose.yml                // Orquestador de contenedores (API + DB)
├── README.md                         // Documentación


## 🏗️ Principales Tecnologías & Versiones
| Herramienta              | Versión |
|--------------------------|---------|
| .NET SDK                  | 8.0.x   |
| Entity Framework Core     | 8.x     |
| PostgreSQL                | 16.x    |
| Docker / Docker Compose   | Latest  |
| XUnit                     | 2.4.x   |
| FluentAssertions          | 6.x     |

## 📐 Patrones de Diseño Aplicados
| Patrón                         | Descripción |
|---------------------------------|-------------|
| **Repository Pattern**          | Abstrae la lógica de acceso a datos. |
| **Dependency Injection (DI)**   | Inyección de dependencias para bajo acoplamiento. |
| **Hexagonal Architecture**      | Separación entre lógica de dominio, infraestructura y presentación. |
| **Unit of Work (via DbContext)**| Coordinación de transacciones en EF Core. |

## 🛠️ Funcionalidades Implementadas
✅ Conexión a PostgreSQL via Entity Framework  
✅ Migraciones automáticas
✅ Seed Data inicial (3 marcas de autos)  
✅ Endpoint REST: `/api/marcasautos` para obtener marcas  
✅ Pruebas unitarias con EF InMemory + XUnit  
✅ Docker Compose (API + PostgreSQL)  


## 🧪 Pruebas Unitarias
Se utilizaron **XUnit** junto con **EF Core InMemory** para las pruebas del controlador.

- ✅ Cobertura superior al 70%
- ✅ Mock de repositorios
- ✅ Pruebas de integración sobre el endpoint `GET /api/marcasautos`
- ✅ FluentAssertions para mejorar legibilidad

### Ejecutar pruebas:

dotnet test

### 🐳 Docker Compose
El archivo docker-compose.yml orquesta:

Un contenedor PostgreSQL (puerto 5432)

Un contenedor MarcasAutos.Api (puerto 8080)

### Comandos básicos:

docker-compose build
docker-compose up

### La API estará disponible en:
📍 http://localhost:8080/api/marcasautos

### 📝 Pasos para Ejecutar Localmente

1. **Clonar repositorio:**

git clone https://github.com/AlexanderROrtiz/AutoBrandsApi.git
cd <tu-repo-clonado>

2. **Configurar Base de Datos (local o Docker):**

Usa el archivo docker-compose.yml para levantar PostgreSQL.

Verifica cadena de conexión en appsettings.json.

3. **Ejecutar migraciones & seed:**

dotnet ef database update --project MarcasAutos.Infrastructure

4. **Levantar la API:**

dotnet run --project MarcasAutos.Api

5. **Probar el Endpoint:**

Navega a: http://localhost:8080/api/marcasautos

### 📊 Mejores Prácticas Aplicadas

- **Principios SOLID en todas las capas.**

- **Separación de responsabilidades (Domain, Application, Infra, API).**

- **Uso de IRepository<T> genérico.**

- **Logging estructurado.**

- **Código documentado con comentarios explicativos.**

- **Estilo de código basado en Clean Code.**

### 🎯 Consideraciones Finales
Este proyecto es una base robusta y escalable para microservicios en C#, cumpliendo con buenas prácticas modernas de desarrollo backend profesional.

### Contacta para más información o sugerencias de mejora.

**LinkedIn: https://www.linkedin.com/in/roberth-ortiz-b526331a9/**

**¡Gracias por tu interés!**

