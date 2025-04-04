# Taller-2-Scripting
## Preguntas 
---
## Qué son los principios SOLID?
"Una clase debe tener una única razón para cambiar."
esto ayuda a evitar que una clase acumule múltiples responsabilidades, lo que genera acoplamiento y fragilidad.
### S Single Responsibility Principle (SRP)
"Una clase debe tener una única razón para cambiar."
esto ayuda a evitar que una clase acumule múltiples responsabilidades, lo que genera acoplamiento y fragilidad.
### O Open/Closed Principle (OCP)
Extiende el comportamiento sin modificar código existente.
Añadir una nueva funcionalidad requiere modificar código existente, se introduce riesgo de romper lo que ya funciona.
### L Liskov Substitution Principle (LSP)
Extiende el comportamiento sin modificar código existente.
Añadir una nueva funcionalidad requiere modificar código existente, se introduce riesgo de romper lo que ya funciona.
### I Interface Segregation Principle (ISP)
"Las subclases no deben alterar el comportamiento esperado de la superclase.
Si una función usa una clase base, debe funcionar igual con cualquier subclase.
### D Dependency Inversion Principle (DIP)
""Módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones."
El acoplamiento directo a implementaciones concretas dificulta los cambios.

## ¿Cómo asegura una única instancia?
---
El primer paso es declarar un constructor privado para evitar que otras clases instancien la clase directamente.
***1. Constructor privado*** 
se crea un campo estático que almacenará la única instancia de la clase. Este campo es privado para evitar el acceso directo desde otras clases.
![Captura de pantalla 2025-04-04 020229](https://github.com/user-attachments/assets/1d16ff1e-6eca-44b4-96a3-cc47b9eceb32)
***2. Instancia Estática***
Se implementa un método estático que permite acceder a la instancia. Este método verifica si la instancia ya ha sido creada; si no es así, la crea.
![Captura de pantalla 2025-04-04 020406](https://github.com/user-attachments/assets/d66a13ba-ecbd-40ad-8462-f28d880bbab3)
***3. Método de Acceso Controlado***
Se implementa un método estático que permite acceder a la instancia. Este método verifica si la instancia ya ha sido creada; si no es así, la crea.
![Captura de pantalla 2025-04-04 020623](https://github.com/user-attachments/assets/a0095189-4122-45e4-9261-274d1004cdec)

## ¿Cómo funciona el patrón Observer?
---
Es un patrón de diseño que establece una relación de dependencia uno a muchos entre objetos, de tal manera que cuando un objeto (el sujeto) cambia su estado, todos sus dependientes (los observadores) son notificados y actualizados automáticamente. Este patrón es muy útil en situaciones donde un cambio en un objeto requiere que se actualicen otros objetos sin que estos estén acoplados entre sí.

- Sujeto (Subject): Mantiene una lista de observadores y notifica cambios.
- Observador (Observer): Interfaz que define el método de actualización que los observadores deben implementar.
- Notificación: Cuando el estado del sujeto cambia, se notifica a todos los observadores registrados.

## ¿Y en qué situaciones es útil?
---
**1. Interfaces gráficas:**  El patrón Observer permite que la vista se actualice automáticamente cuando el modelo de datos cambia, manteniendo sincronizada la información con su representación visual.
**2. Sistemas basados en eventos:** Es útil para gestionar eventos como clics de botones o cambios de estado, permitiendo que distintas partes del sistema respondan sin estar directamente acopladas entre sí.
**3. Notificaciones y mensajería:** Facilita la comunicación entre componentes al permitir que se registren para recibir actualizaciones, lo que resulta ideal en sistemas donde se deben enviar notificaciones a múltiples elementos.
**4. Desarrollo de videojuegos:** Se emplea para manejar eventos como colisiones, movimientos de personajes o cambios en el estado del juego, lo que contribuye a una arquitectura modular y flexible.

## ¿Qué es un antipatrón?
---
Un antipatrón es un enfoque o solución que, aunque puede parecer razonable en un principio, resulta ser ineficaz o contraproducente en la práctica. Los antipatrónes son patrones de diseño que se han identificado como problemáticos y que pueden llevar a un código difícil de mantener, poco eficiente o propenso a errores. Reconocer y evitar antipatrónes es fundamental para mejorar la calidad del software.

## ¿Qué es un delegados?
---
Un delegado en C# es un tipo que representa referencias a métodos con una lista de parámetros y un tipo de retorno específicos. Los delegados permiten encapsular métodos, lo que significa que puedes pasar métodos como parámetros, almacenar métodos en variables y llamar a esos métodos de manera flexible.

## Consulte un código o librería nativo de C# que use el patrón decorador
---
## Diferencias en las Implementaciones de Patrones
---
**- Patrones Creacionales**

**Singleton:** Variaciones en la creación de la instancia (perezosa vs. ansiosa).
**Factory Method:** Diferencias en la delegación de la creación de objetos


**- Patrones Estructurales:**

**Adapter:** Adaptación mediante herencia o composición.
**Decorator:** Manejo de instancias y cadena de decoradores.


**-Patrones de Comportamiento:**

**Observer:** Gestión de notificaciones (sincronización vs. asincronización).
**Strategy:** Selección y aplicación de estrategias.
