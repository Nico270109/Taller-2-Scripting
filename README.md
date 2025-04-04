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

# Ejemplos de Patrones
---

### Singleton
---
Asegurar que solo exista una instancia de la clase AudioManager que controla sonidos en una aplicación.

Program
``` C#
namespace Ejercicio_1_Singleton
{
   using System;

namespace SingletonAudioManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var audio = Audio.Instance;
            audio.PlaySound("Taylor Swift");
            audio.ToggleSFX();
            audio.PlaySound("Ariana Grande");
            audio.ToggleMusic();

            var otroAudio = Audio.Instance;
            Console.WriteLine("¿Es el mismo AudioManager?"  +  (audio == otroAudio));
        }
    }
}

}
```

Audio
``` C#
namespace Ejercicio_1_Singleton
{
    class Audio
    {
  
            private static Audio _instance;
            private static readonly object _lock = new object();

            private bool musicOn = true;
            private bool sfxOn = true;

            private Audio()
            {
                Console.WriteLine("Audio inicializado.");
            }

            public static Audio Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Audio();
                        return _instance;
                    }
                }
            }

            public void ToggleMusic()
            {
                musicOn = !musicOn;
                Console.WriteLine(musicOn ? "Música activada." : "Música desactivada.");
            }

            public void ToggleSFX()
            {
                sfxOn = !sfxOn;
                Console.WriteLine(sfxOn ? "Efectos activados." : "Efectos desactivados.");
            }

            public void PlaySound(string soundName)
            {
                if (sfxOn)
                    Console.WriteLine("Reproduciendo efecto:" + (soundName));
                else
                    Console.WriteLine("No se puede reproducir " + (soundName) + ", efectos desactivados.");
            }
        }
}
```
![Captura de pantalla 2025-04-04 044600](https://github.com/user-attachments/assets/c31a72d8-807d-4ddf-8b60-116052898511)

### Observer sin Delegado
---
El código simula un sistema donde un sensor de sismos avisa a varias ciudades registradas cada vez que detecta un temblor.

``` C#
namespace Observer_sin_delegado
{
    class Program
    {
            static void Main(string[] args)
            {
                // Crear el sensor
                var sensor = new Sensor();

                // Crear las ciudades y registrarlas
                var ciudad1 = new Ciudad("Quito");
                var ciudad2 = new Ciudad("Medellín");
                sensor.Registrar(ciudad1);
                sensor.Registrar(ciudad2);

                // Simular un par de sismos
                sensor.SimularSismo(4.2);
                sensor.SimularSismo(7.5);
            }
    }

        // La clase Sensor (el sujeto)
        class Sensor
        {
            private List<Ciudad> ciudades = new List<Ciudad>();

            public void Registrar(Ciudad ciudad)
            {
                ciudades.Add(ciudad);
            }

            public void SimularSismo(double magnitud)
            {
                Console.WriteLine("\n ¡Sismo detectado! Magnitud: " + (magnitud));
                foreach (var ciudad in ciudades)
                {
                    ciudad.RecibirAviso(magnitud);
                }
            }
        }

        // La clase Ciudad (el observador)
        class Ciudad
        {
            private string nombre;

            public Ciudad(string nombre)
            {
                this.nombre = nombre;
            }

            public void RecibirAviso(double magnitud)
            {
                Console.WriteLine( "" + (nombre) + " recibe alerta: sismo de " + (magnitud) + " grados.");
            }
        }
}

```
![Captura de pantalla 2025-04-04 052929](https://github.com/user-attachments/assets/ea8f1884-fdad-4e0a-aac8-b8a99e94e35e)

## Observer con Delgado
---
El código simula un sistema donde un sensor de sismos avisa a varias ciudades registradas cada vez que detecta un temblor.

``` C#
namespace Observer_con_Delegado
{
 
        class Program
        {
            static void Main(string[] args)
            {
                Sensor sensor = new Sensor();

                Ciudad ciudad1 = new Ciudad("Pereira");
                Ciudad ciudad2 = new Ciudad("Medellin");

                // Suscribimos los métodos al evento
                sensor.AlertaSismo += ciudad1.ResponderAlerta;
                sensor.AlertaSismo += ciudad2.ResponderAlerta;

                // Simulamos dos sismos
                sensor.SimularSismo(5.1);
                sensor.SimularSismo(8.3);
            }
        }

        // Definimos un delegado para las alertas
        public delegate void AlertaSismoDelegate(double magnitud);

        class Sensor
        {
            // Evento basado en el delegado
            public event AlertaSismoDelegate AlertaSismo;

            public void SimularSismo(double magnitud)
            {
                Console.WriteLine("\n Sismo detectado con magnitud:" + (magnitud));

                // Invocamos el evento si hay suscriptores
                if (AlertaSismo != null)
                {
                    AlertaSismo(magnitud);
                }
            }
        }

        class Ciudad
        {
            private string nombre;

            public Ciudad(string nombre)
            {
                this.nombre = nombre;
            }

            public void ResponderAlerta(double magnitud)
            {
                Console.WriteLine("" + nombre + " recibe alerta: sismo de " + magnitud + " grados.");
            }
        }
}
```
![Captura de pantalla 2025-04-04 055447](https://github.com/user-attachments/assets/9c06bcce-97f8-470c-9137-c4d1f590e9a9)



## Ejercicio Unity
---
```C#
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IMoveStrategy moveStrategy;
    [SerializeField] private TMP_Text strategyText; // Texto para mostrar la estrategia actual

    private void Start()
    {
        moveStrategy = new WalkStrategy();
        UpdateStrategyText("Walk");
    }

    private void Update()
    {
        moveStrategy.Move(transform);
    }

    public void SetRun()
    {
        moveStrategy = new RunStrategy();
        UpdateStrategyText("Run");
        Debug.Log("Cambiado a correr.");
    }

    public void SetWalk()
    {
        moveStrategy = new WalkStrategy();
        UpdateStrategyText("Walk");
        Debug.Log("Cambiado a caminar.");
    }

    private void UpdateStrategyText(string strategy)
    {
        if (strategyText != null)
        {
            strategyText.text = "Current Strategy: " + strategy;
        }
    }
}
```

```c#
using System;
using System.IO;
using System.CodeDom.Compiler;

class Program
{
    static void Main()
    {
        using var sw = new StringWriter();
        using var writer = new IndentedTextWriter(sw, "  ");

        writer.WriteLine("Raíz:");
        writer.Indent++;
        writer.WriteLine("Hijo 1");
        writer.WriteLine("Hijo 2");
        writer.Indent--;

        Console.WriteLine(sw.ToString());
    }
}
```
