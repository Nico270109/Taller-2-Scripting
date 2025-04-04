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
