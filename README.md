
---

## 🚀 Cómo ejecutar

1. Abre la solución `CarRental.sln` en Visual Studio o VS Code.
2. Ejecuta el proyecto `CarRental.API`.
3. Accede a Swagger en: `https://localhost:<puerto>/swagger`

---

## 📦 Endpoints disponibles

### 🚘 Gestión de Coches

| Método | Endpoint              | Descripción                          |
|--------|------------------------|--------------------------------------|
| POST   | `/api/cars/insert`     | Crear coche                          |
| GET    | `/api/cars/getAll`     | Listar todos los coches              |

> **Tipo de coche (`type`) puede ser:**
> - `0` = Small
> - `1` = SUV
> - `2` = Premium

---

### 🔄 Alquileres

| Método | Endpoint              | Descripción                          |
|--------|------------------------|--------------------------------------|
| POST   | `/api/rent`            | Alquilar uno o más coches            |
| POST   | `/api/return`          | Devolver coche y calcular extra price|

---

### 👤 Clientes

| Método | Endpoint                        | Descripción                          |
|--------|----------------------------------|--------------------------------------|
| GET    | `/api/clients/getAll`           | Listar clientes                      |
| GET    | `/api/clients/{id}/loyalty`     | Ver puntos de fidelidad del cliente  |

---

## 💰 Reglas de Precio

### Premium Cars
- 300€/día
- Extra: 300€ + 20%

### SUV Cars
- Primeros 7 días: 150€/día
- Día 8 a 30: 80% del precio
- Día 31+: 50% del precio
- Extra: 150€ + 60% del precio Small

### Small Cars
- Primeros 7 días: 50€/día
- Día 8+: 60% del precio
- Extra: 50€ + 30%

---

## 🎁 Puntos de Fidelidad

- Premium: 5 puntos
- SUV: 3 puntos
- Small: 1 punto

---

## 📋 Datos precargados

Al iniciar la app, se crean los siguientes clientes:

- Marc (ID: 1)
- Alex (ID: 2)
- David (ID: 3)

Al iniciar la app, se crean los siguientes coches:

- Id  1 BMW M4 Premium
- Id  2 Hyundai TUCSON SUV 
- Id  3 Nissan Juke SUV
- Id  4 Seat Ibiza Small
- Id  5 Mercedes GLC Coupe Premium

---

## ⚙️ Tecnologías

- .NET 8
- ASP.NET Core Web API
- Swagger UI
- Inyección de dependencias
- Arquitectura por capas

---

## 📌 Notas

- Todos los datos se almacenan en **memoria**, no existe dependencia de base de datos.
- Se crea la inyección de dependencias en modo Singleton para evitar que cree una instancia nueva por cada llamada a la API y así mantener los datos.

---

## 🧑‍💻 Autor

> Desarrollado como parte del reto técnico por Marc López Mestres
