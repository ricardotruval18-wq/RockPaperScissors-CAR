using Proyecto.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto.UI
{
    public partial class Form2 : Form
    {
        private Juego juegoActual = new Juego();

        public Form2()
        {
            InitializeComponent();

            // Vincular los eventos de los botones si no se hizo desde el diseñador visual
            button1.Click += Button1_Click;
            button3.Click += ButtonSalir_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Opcion eleccionTurno;

            if (radioButton1.Checked)
            {
                eleccionTurno = Opcion.Piedra;
            }
            else if (radioButton2.Checked)
            {
                eleccionTurno = Opcion.Papel;
            }
            else if (radioButton3.Checked)
            {
                eleccionTurno = Opcion.Tijera;
            }
            else
            {
                MessageBox.Show("Selecciona Piedra, Papel o Tijera antes de confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la jugada y procesarla
            Jugada opcionJugador = new Jugada { OpcionElegida = eleccionTurno };

            // 2. Guardar la jugada y recalcular las estadísticas/frecuencias en el core
            juegoActual.almacenarInformacion(opcionJugador);

            // 3. Obtener la jugada de la máquina (que ya analiza el historial con los métodos peek)
            Opcion jugadaMaquina = juegoActual.jugadaMaquina();

            // 4. Procesar el resultado de la partida UNA SOLA VEZ
            Resultados resultadoPartida = juegoActual.procesarEleccion(opcionJugador, jugadaMaquina);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            string resul;

            if (resultadoPartida == Resultados.Ganador)
            {
                resul = "¡Ganaste!";
            }
            else if (resultadoPartida == Resultados.Empate)
            {
                resul = "Empate";
            }
            else if (resultadoPartida == Resultados.Perdedor)
            {
                resul = "Perdiste";
            }
            else
            {
                resul = "Error";
            }

            // Mostrar el resultado en el Label de la interfaz
            lblResultado.Text = resul;
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }

    }
}
