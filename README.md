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
El primer paso es declarar un constructor privado para evitar que otras clases instancien la clase directamente.
1. Constructor privado
se crea un campo estático que almacenará la única instancia de la clase. Este campo es privado para evitar el acceso directo desde otras clases.
2. Instancia Estática
Se implementa un método estático que permite acceder a la instancia. Este método verifica si la instancia ya ha sido creada; si no es así, la crea.
3. Método de Acceso Controlado
