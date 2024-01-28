# Juego de Adivinanzas de Números

Este es un simple juego de adivinanzas de números desarrollado en C# utilizando Windows Forms. El jugador tiene que adivinar un número secreto generado aleatoriamente entre 1 y 100 con un límite de intentos. El juego proporciona pistas sobre si la suposición del jugador es demasiado alta o demasiado baja.

## Funcionalidades

- Genera un número aleatorio entre 1 y 100 al iniciar el juego.
- Permite al jugador ingresar suposiciones y verifica si son correctas.
- Proporciona pistas sobre si la suposición del jugador es demasiado alta o demasiado baja.
- Limita el número de intentos del jugador.
- Ofrece la opción de reiniciar el juego después de que se agoten los intentos o se adivine el número.

## Clases Principales

### `Form1`

- Clase principal del formulario del juego de adivinanzas de números.
- Contiene la lógica principal del juego, incluyendo la generación de números aleatorios, verificación de suposiciones del jugador y control de interfaz.

## Métodos Principales

- `IniciarJuego()`: Inicializa el juego, establece variables y muestra mensajes iniciales.
- `GenerarNumeroAleatorio()`: Genera un número aleatorio entre 1 y 100.
- `MostrarMensaje(string mensaje)`: Muestra un mensaje en la interfaz del juego.
- `VerificarSuposicion()`: Verifica la suposición del jugador y actualiza la interfaz en consecuencia.
- `FinalizarJuego()`: Finaliza el juego y deshabilita los controles.

## Controles de Interfaz

- `txtSuposicion`: TextBox para que el jugador ingrese su suposición.
- `btnEnviar`: Botón para enviar la suposición del jugador.
- `btnReiniciar`: Botón para reiniciar el juego.

## Autor

Este juego fue desarrollado por Henry Pérez Granados como parte de un proyecto final.

