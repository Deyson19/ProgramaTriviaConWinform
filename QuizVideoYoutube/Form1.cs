﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizVideoYoutube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            FormularioPreguntas fr = new FormularioPreguntas();
            fr.Show();
            this.Hide();
            
        }

        private void textoCerrarFormulario_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
