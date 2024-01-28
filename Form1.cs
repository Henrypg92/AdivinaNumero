using System;
using System.Windows.Forms;

namespace ProyectoFinal_Henry_Pérez_Granados
{
    /// <summary>
    /// Clase principal del formulario del juego de adivinanzas de números.
    /// </summary>
    public partial class Form1 : Form
    {
        private int numeroSecreto;
        private int intentosRestantes;

        /// <summary>
        /// Constructor de la clase Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }

        /// <summary>
        /// Inicializa el juego, establece variables y muestra mensajes iniciales.
        /// </summary>
        private void IniciarJuego()
        {
            // Inicializar variables al inicio del juego
            numeroSecreto = GenerarNumeroAleatorio();
            intentosRestantes = 10;

            // Mostrar mensaje de bienvenida
            MostrarMensaje("¡Bienvenido al juego de adivinanzas de números!");

            // Habilitar controles necesarios
            txtSuposicion.Enabled = true;
            btnEnviar.Enabled = true;
            btnReiniciar.Enabled = false;

            // Limpiar el TextBox de suposiciones
            txtSuposicion.Text = "";

            // Mostrar mensaje de intentos restantes
            MostrarMensaje($"Intentos restantes: {intentosRestantes}");

            // Limpiar el Label de mensaje
            lblSugerencia.Text = "";
        }

        /// <summary>
        /// Genera un número aleatorio entre 1 y 100.
        /// </summary>
        /// <returns>Número aleatorio generado.</returns>
        private int GenerarNumeroAleatorio()
        {
            // Generar un número aleatorio entre 1 y 100
            Random random = new Random();
            return random.Next(1, 101);
        }

        /// <summary>
        /// Muestra un mensaje en el Label de intento.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        public void MostrarMensaje(string mensaje)
        {
            // Mostrar mensajes en el Label de mensajes
            lblIntento.Text = mensaje;
        }

        /// <summary>
        /// Verifica la suposición del jugador y actualiza la interfaz en consecuencia.
        /// </summary>
        private void VerificarSuposicion()
        {
            try
            {
                // Obtener la suposición del jugador
                int suposicion = int.Parse(txtSuposicion.Text);

                // Decrementar los intentos restantes
                intentosRestantes--;

                // Verificar la suposición del jugador
                if (suposicion == numeroSecreto)
                {
                    MostrarMensaje("¡Felicidades! Has adivinado el número.");
                    lblSugerencia.Text = "";
                    FinalizarJuego();
                }
                else
                {
                    // Muestra un mensaje indicando que el número ingresado por el usuario es demasiado bajo o alto
                    if (numeroSecreto < suposicion)
                    {
                        lblSugerencia.Text = "Demasiado alto";
                    }
                    else
                    {
                        lblSugerencia.Text = "Demasiado bajo";
                    }

                    // Verificar intentos restantes
                    if (intentosRestantes == 0)
                    {
                        MostrarMensaje($"Se acabaron los intentos. El número secreto era {numeroSecreto}.");
                        FinalizarJuego();
                    }
                    else
                    {
                        MostrarMensaje($"Intentos restantes: {intentosRestantes}");
                    }
                }
            }
            catch (FormatException)
            {
                // Manejar error si la entrada no es un número
                MostrarMensaje("Por favor, ingresa un número válido.");
            }
        }

        /// <summary>
        /// Finaliza el juego y deshabilita controles.
        /// </summary>
        private void FinalizarJuego()
        {
            // Deshabilitar controles después de finalizar el juego
            txtSuposicion.Enabled = false;
            btnEnviar.Enabled = false;
            btnReiniciar.Enabled = true;
        }

        /// <summary>
        /// Maneja el clic en el botón "Enviar".
        /// </summary>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Manejar el clic en el botón "Enviar"
            VerificarSuposicion();
        }

        /// <summary>
        /// Maneja el clic en el botón "Reiniciar".
        /// </summary>
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Manejar el clic en el botón "Reiniciar"
            IniciarJuego();
        }
    }
}
