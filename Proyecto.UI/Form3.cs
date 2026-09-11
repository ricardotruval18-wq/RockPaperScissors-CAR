using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto.Core;

namespace Proyecto.UI
{
    public partial class Form3 : Form
    {
        private Juego juegoActual = new Juego();

        public Form3()
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
            Jugada resultadoRonda = new Jugada { OpcionElegida = eleccionTurno };
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            string resul;
        
            if (juegoActual.procesarEleccion(resultadoRonda, eleccionTurno) == Resultados.Ganador) {
                resul = "Ganaste";
            }
            else if (juegoActual.procesarEleccion(resultadoRonda, eleccionTurno) == Resultados.Empate) {
                resul = "Empate";
            }
            else if (juegoActual.procesarEleccion(resultadoRonda, eleccionTurno) == Resultados.Perdedor) {
                resul = "Perdiste";
            }
            else { resul = " Error"; }
            lblResultado.Text = $"{resul}"; 
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