namespace QuizVideoYoutube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoTituloPrincipal = new System.Windows.Forms.Label();
            this.textoCerrarFormulario = new System.Windows.Forms.Label();
            this.textoDescriptivo = new System.Windows.Forms.Label();
            this.imagenLogoTrivia = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonIniciarQuiz = new System.Windows.Forms.Button();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogoTrivia)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTituloPrincipal
            // 
            this.textoTituloPrincipal.AutoSize = true;
            this.textoTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textoTituloPrincipal.Location = new System.Drawing.Point(280, 45);
            this.textoTituloPrincipal.Name = "textoTituloPrincipal";
            this.textoTituloPrincipal.Size = new System.Drawing.Size(211, 25);
            this.textoTituloPrincipal.TabIndex = 0;
            this.textoTituloPrincipal.Text = "Bienvenidos A Mi Quiz";
            // 
            // textoCerrarFormulario
            // 
            this.textoCerrarFormulario.AutoSize = true;
            this.textoCerrarFormulario.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoCerrarFormulario.Location = new System.Drawing.Point(733, -1);
            this.textoCerrarFormulario.Name = "textoCerrarFormulario";
            this.textoCerrarFormulario.Size = new System.Drawing.Size(23, 23);
            this.textoCerrarFormulario.TabIndex = 1;
            this.textoCerrarFormulario.Text = "X";
            this.textoCerrarFormulario.Click += new System.EventHandler(this.textoCerrarFormulario_Click);
            // 
            // textoDescriptivo
            // 
            this.textoDescriptivo.AutoSize = true;
            this.textoDescriptivo.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textoDescriptivo.Location = new System.Drawing.Point(269, 102);
            this.textoDescriptivo.Name = "textoDescriptivo";
            this.textoDescriptivo.Size = new System.Drawing.Size(260, 28);
            this.textoDescriptivo.TabIndex = 2;
            this.textoDescriptivo.Text = "Trivia Sobre Cultura General ";
            // 
            // imagenLogoTrivia
            // 
            this.imagenLogoTrivia.Image = ((System.Drawing.Image)(resources.GetObject("imagenLogoTrivia.Image")));
            this.imagenLogoTrivia.Location = new System.Drawing.Point(289, 177);
            this.imagenLogoTrivia.Name = "imagenLogoTrivia";
            this.imagenLogoTrivia.Size = new System.Drawing.Size(188, 123);
            this.imagenLogoTrivia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenLogoTrivia.TabIndex = 3;
            this.imagenLogoTrivia.TabStop = false;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInferior.Controls.Add(this.label2);
            this.panelInferior.Controls.Add(this.label1);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 410);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(753, 38);
            this.panelInferior.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(611, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para Youtube";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de quiz";
            // 
            // botonIniciarQuiz
            // 
            this.botonIniciarQuiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIniciarQuiz.FlatAppearance.BorderSize = 0;
            this.botonIniciarQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIniciarQuiz.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonIniciarQuiz.Location = new System.Drawing.Point(304, 336);
            this.botonIniciarQuiz.Name = "botonIniciarQuiz";
            this.botonIniciarQuiz.Size = new System.Drawing.Size(173, 37);
            this.botonIniciarQuiz.TabIndex = 5;
            this.botonIniciarQuiz.Text = "Iniciar el Quiz";
            this.botonIniciarQuiz.UseVisualStyleBackColor = false;
            this.botonIniciarQuiz.Click += new System.EventHandler(this.botonIniciarQuiz_Click);
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this;
            this.moverFormulario.Vertical = true;
            // 
            // formularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(753, 448);
            this.Controls.Add(this.botonIniciarQuiz);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.imagenLogoTrivia);
            this.Controls.Add(this.textoDescriptivo);
            this.Controls.Add(this.textoCerrarFormulario);
            this.Controls.Add(this.textoTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogoTrivia)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTituloPrincipal;
        private System.Windows.Forms.Label textoCerrarFormulario;
        private System.Windows.Forms.Label textoDescriptivo;
        private System.Windows.Forms.PictureBox imagenLogoTrivia;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonIniciarQuiz;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
    }
}
