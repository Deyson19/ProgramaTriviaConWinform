using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizVideoYoutube
{
    public partial class FormularioPreguntas : Form
    {
        public FormularioPreguntas()
        {
            InitializeComponent();
            panelPregunta2.Hide();
            panelResultados.Hide();
        }
        int puntos = 0;

        void respuestaIncorrecta()
        {
            FormularioRInCorrecta formularioIncorrecto = new FormularioRInCorrecta();
            formularioIncorrecto.ShowDialog();
            restarPuntos();
        }
        void respuestaCorrecta()
        {
            FormularioRCorrecta correcta = new FormularioRCorrecta();
            correcta.ShowDialog();
            sumarPuntos();
        }

        #region Manejo de la cantidad de puntos
        void sumarPuntos()
        {
            puntos = puntos + 500;
            labelCantidadPuntos.Text = puntos.ToString();
        }
        void restarPuntos()
        {
            if (puntos >=200)
            {
                puntos = puntos - 100;
            }
            labelCantidadPuntos.Text = puntos.ToString();
        }
        #endregion

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region Panel de la pregunta 2
        private void btn1986_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btn1945_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelResultados.Show();

            labelCantidadPuntos.Hide();
            labelParaPuntaje.Hide();
            labelPuntosFinales.Text = puntos.ToString();
           
        }

        private void btn1935_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }
        #endregion

        private void btn196huesos_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btn206huesos_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelPregunta2.Show();
        }
    }
}
