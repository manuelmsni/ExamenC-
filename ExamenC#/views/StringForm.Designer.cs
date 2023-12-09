namespace ExamenC_.views
{
    partial class StringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            mensaje = new Label();
            texto = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(mensaje);
            flowLayoutPanel1.Controls.Add(texto);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(274, 80);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mensaje.Location = new Point(13, 10);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(0, 21);
            mensaje.TabIndex = 0;
            // 
            // texto
            // 
            texto.Dock = DockStyle.Fill;
            texto.Location = new Point(13, 34);
            texto.Name = "texto";
            texto.Size = new Size(0, 23);
            texto.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(buttonAceptar);
            flowLayoutPanel2.Controls.Add(buttonCancelar);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(19, 13);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(170, 43);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(75, 10);
            buttonAceptar.Margin = new Padding(0);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 0;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += Aceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(0, 10);
            buttonCancelar.Margin = new Padding(0);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += Cancelar_Click;
            // 
            // StringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 80);
            Controls.Add(flowLayoutPanel1);
            Name = "StringForm";
            StartPosition = FormStartPosition.CenterScreen;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label mensaje;
        private TextBox texto;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonAceptar;
        private Button buttonCancelar;
    }
}