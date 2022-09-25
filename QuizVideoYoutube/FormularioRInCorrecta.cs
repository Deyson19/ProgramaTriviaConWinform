using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace QuizVideoYoutube
{
    public partial class FormularioRInCorrecta : Form
    {
        public FormularioRInCorrecta()
        {
            InitializeComponent();
            reproducirSonido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string rutaAudio = "E:/sonidos/incorrecto.wav";
        private void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }
    }
}
