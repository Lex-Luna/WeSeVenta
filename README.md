# 🛒 Microservicio de Productos – Spring Boot + JPA + Docker + PostgreSQL

Este proyecto es un microservicio desarrollado con **Spring Boot 3.5.12**, **Maven**, **JPA/Hibernate** y **PostgreSQL 15**, que expone un CRUD completo para la gestión de productos.
Está preparado para ejecutarse en contenedores mediante **Docker** y **Docker Compose**.

---

## 🚀 Tecnologías utilizadas

- **Java 21**
- **Spring Boot 3.5.12**
- **Spring Web**
- **Spring Data JPA**
- **Hibernate**
- **PostgreSQL 15**
- **Docker & Docker Compose**
- **Maven**

---

## 📦 Endpoints del CRUD

### ➤ Crear producto
`POST /api/productos`
Body JSON:
```json
{
  "nombre": "Producto ejemplo",
  "precio": 10.99
}
```

### ➤ Obtener todos los productos
`GET /api/productos`

### ➤ Obtener producto por ID
`GET /api/productos/{id}`

### ➤ Actualizar producto
`PUT /api/productos/{id}`
Body JSON:
```json
{
  "nombre": "Producto actualizado",
  "precio": 12.50
}
```

### ➤ Eliminar producto
`DELETE /api/productos/{id}`

---

## 🐳 Ejecución con Docker

Asegúrate de tener Docker Desktop instalado.

### 1. Construir y levantar contenedores
```bash
docker compose up -d
```

### 2. Detener contenedores
```bash
docker compose down
```

---

## 🗄️ Base de datos

El servicio utiliza PostgreSQL 15 como base de datos.
Las credenciales se configuran mediante variables de entorno en `docker-compose.yml` y `.env`.

---

## ⚙️ Configuración

- **Puerto del servidor**: 8080
- **JPA/Hibernate**: DDL auto-update activado
- **Base de datos**: Configurada vía variables de entorno (`SPRING_DATASOURCE_URL`, etc.)

---

## 📁 Estructura del proyecto

```
src/
 └── main/
     ├── java/
     │   └── com.lexcorp.apirest
     │       ├── controller/
     │       ├── entity/
     │       ├── repository/
     │       └── service/
     └── resources/
         ├── application.properties
         └── static/
```

---

## 🧑‍💻 Autor

**Alexis**
Desarrollador backend, especializado en Java, Spring Boot y entornos Dockerizados.

---

## 📋 Requisitos

- Java 21
- Maven 3.6+
- Docker & Docker Compose

---

## 🚀 Ejecutar localmente

```bash
mvn spring-boot:run
```

Asegúrate de tener PostgreSQL corriendo localmente o vía Docker.
