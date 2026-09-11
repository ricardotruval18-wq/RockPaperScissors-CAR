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
        private juego juegoActual = new juego();
        public Form3()
        {
            InitializeComponent();
        }
        private void radioButton1(object sender , EventArgs e)
        {
            
        }
        private void radioButton2(object sender , EventArgs e)
        {
            
        }
        private void radioButton2(object sender , EventArgs e)
        {
            
        }

        private void button1(object sender, EventArgs e)
        {
            Opcion seleccionUsuario;
            if (radioButton1.Checked)
            {
                eleccionTurno(Opcion.Piedra);
            } else if (radioButton2.Checked)
            {
                eleccionTurno(Opcion.Papel);
            } else if(radioButton3.Checked)
            {
                eleccionTurno(Opcion.Tijeras);
            }
            else
            {
                return;
            }
        }

        private void eleccionTurno(Opcion seleccionUsuario)
        {
            Jugada resultadoRonda = juego.procesarEleccion(seleccionUsuario);
        }

    }
}
