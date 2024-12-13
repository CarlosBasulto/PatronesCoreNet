
# PatronesCoreNet

## Descripción

**PatronesCoreNet** es un proyecto desarrollado en .NET Core 8 que contiene ejemplos prácticos de patrones de diseño organizados en las tres categorías principales: **Patrones Creacionales**, **Patrones Estructurales** y **Patrones de Comportamiento**. Este proyecto tiene como objetivo facilitar la comprensión y aplicación de los patrones de diseño en el desarrollo de software mediante un enfoque práctico y modular.

---

## ¿Qué son los patrones de diseño?

Los patrones de diseño son soluciones reutilizables a problemas comunes que surgen durante el diseño de software. Estos patrones proporcionan un lenguaje común y estructuras probadas para diseñar aplicaciones robustas, escalables y mantenibles.

Los patrones de diseño ayudan a:
- Reducir la complejidad del diseño.
- Mejorar la comunicación entre desarrolladores.
- Promover la reutilización del código.
- Incrementar la flexibilidad y la escalabilidad del software.

---

## Categorías de patrones de diseño

Los patrones de diseño se clasifican en tres categorías principales:

### 1. **Patrones Creacionales**
Estos patrones se enfocan en cómo se crean los objetos, asegurando que la lógica de creación esté separada del uso de los objetos.

#### Ejemplo incluido: **Singleton**
- **Descripción**: Garantiza que una clase tenga solo una instancia y proporciona un punto de acceso global a esa instancia.
- **Archivo**: `Creational/Singleton.cs`

---

### 2. **Patrones Estructurales**
Estos patrones tratan sobre cómo se organizan y relacionan las clases y objetos para formar estructuras complejas de manera eficiente.

#### Ejemplo incluido: **Decorator**
- **Descripción**: Permite agregar funcionalidad adicional a un objeto de forma dinámica sin alterar su estructura original.
- **Archivo**: `Structural/Decorator.cs`

---

### 3. **Patrones de Comportamiento**
Estos patrones se centran en la comunicación e interacción entre los objetos, definiendo cómo colaboran para cumplir sus responsabilidades.

#### Ejemplo incluido: **Strategy**
- **Descripción**: Define una familia de algoritmos, encapsula cada uno de ellos y permite que sean intercambiables en tiempo de ejecución.
- **Archivo**: `Behavioral/Strategy.cs`

---

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

```
PatronesCoreNet/
├── Creational/
│   ├── Singleton.cs
├── Structural/
│   ├── Decorator.cs
├── Behavioral/
│   ├── Strategy.cs
├── Program.cs
├── PatronesCoreNet.csproj
└── README.md
```

### Archivos principales
- **Creational/**: Contiene los patrones creacionales, como el Singleton.
- **Structural/**: Contiene los patrones estructurales, como el Decorator.
- **Behavioral/**: Contiene los patrones de comportamiento, como el Strategy.
- **Program.cs**: Punto de entrada del programa, donde se ejecutan y demuestran los patrones.

---

## Cómo ejecutar el proyecto

1. **Clona este repositorio**:
   ```bash
   git clone <url-del-repositorio>
   cd PatronesCoreNet
   ```

2. **Restaura las dependencias (si es necesario)**:
   ```bash
   dotnet restore
   ```

3. **Compila el proyecto**:
   ```bash
   dotnet build
   ```

4. **Ejecuta el proyecto**:
   ```bash
   dotnet run
   ```

---

## Resultado esperado

Al ejecutar el proyecto, se mostrará en la consola un ejemplo práctico de cada patrón:

```plaintext
Demostración de Patrones de Diseño:
¿Singleton es la misma instancia? True
Decorador A (Componente base)
Estrategia A aplicada a datos de ejemplo
Estrategia B aplicada a datos de ejemplo
```

---

## Contribuciones

Si tienes sugerencias o quieres añadir más patrones al proyecto, ¡no dudes en crear un pull request o abrir un issue!

---

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.

