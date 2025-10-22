namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            boton_Iniciar = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            boton_Reinciciar = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(58, 127);
            label1.Name = "label1";
            label1.Size = new Size(205, 149);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(279, 127);
            label2.Name = "label2";
            label2.Size = new Size(205, 149);
            label2.TabIndex = 0;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(507, 127);
            label3.Name = "label3";
            label3.Size = new Size(205, 149);
            label3.TabIndex = 0;
            label3.Text = "00";
            // 
            // boton_Iniciar
            // 
            boton_Iniciar.AutoSize = true;
            boton_Iniciar.Cursor = Cursors.Hand;
            boton_Iniciar.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            boton_Iniciar.ForeColor = Color.Lime;
            boton_Iniciar.Location = new Point(22, 11);
            boton_Iniciar.Name = "boton_Iniciar";
            boton_Iniciar.Size = new Size(130, 37);
            boton_Iniciar.TabIndex = 0;
            boton_Iniciar.Text = "Iniciar";
            boton_Iniciar.Click += label4_Click;
            boton_Iniciar.MouseLeave += boton_Iniciar_MouseLeave;
            boton_Iniciar.MouseHover += label4_MouseHover;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(boton_Iniciar);
            panel1.Location = new Point(191, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 62);
            panel1.TabIndex = 1;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseHover += panel1_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(160, 33);
            label5.Name = "label5";
            label5.Size = new Size(430, 77);
            label5.TabIndex = 2;
            label5.Text = "Cronometro";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(boton_Reinciciar);
            panel2.Location = new Point(416, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 62);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.MouseLeave += panel2_MouseLeave;
            panel2.MouseHover += panel2_MouseHover;
            // 
            // boton_Reinciciar
            // 
            boton_Reinciciar.AutoSize = true;
            boton_Reinciciar.Cursor = Cursors.Hand;
            boton_Reinciciar.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            boton_Reinciciar.ForeColor = Color.Lime;
            boton_Reinciciar.Location = new Point(14, 11);
            boton_Reinciciar.Name = "boton_Reinciciar";
            boton_Reinciciar.Size = new Size(168, 37);
            boton_Reinciciar.TabIndex = 1;
            boton_Reinciciar.Text = "Reiniciar";
            boton_Reinciciar.Click += boton_Reinciciar_Click;
            boton_Reinciciar.MouseLeave += boton_Reinciciar_MouseLeave;
            boton_Reinciciar.MouseHover += boton_Reinciciar_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label boton_Iniciar;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Label boton_Reinciciar;
    }
}
