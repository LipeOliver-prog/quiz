namespace quiz
{
    partial class frmp5
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
            this.rbtCerta4 = new System.Windows.Forms.RadioButton();
            this.rbtCerta2 = new System.Windows.Forms.RadioButton();
            this.rbtCerta3 = new System.Windows.Forms.RadioButton();
            this.rbtCerta = new System.Windows.Forms.RadioButton();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtCerta4
            // 
            this.rbtCerta4.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta4.Location = new System.Drawing.Point(429, 337);
            this.rbtCerta4.Name = "rbtCerta4";
            this.rbtCerta4.Size = new System.Drawing.Size(232, 28);
            this.rbtCerta4.TabIndex = 15;
            this.rbtCerta4.TabStop = true;
            this.rbtCerta4.Text = "BusqueBox.Show();";
            this.rbtCerta4.UseVisualStyleBackColor = false;
            // 
            // rbtCerta2
            // 
            this.rbtCerta2.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta2.Location = new System.Drawing.Point(439, 263);
            this.rbtCerta2.Name = "rbtCerta2";
            this.rbtCerta2.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta2.TabIndex = 14;
            this.rbtCerta2.TabStop = true;
            this.rbtCerta2.Text = "Application.Show();";
            this.rbtCerta2.UseVisualStyleBackColor = false;
            // 
            // rbtCerta3
            // 
            this.rbtCerta3.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta3.Location = new System.Drawing.Point(113, 337);
            this.rbtCerta3.Name = "rbtCerta3";
            this.rbtCerta3.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta3.TabIndex = 13;
            this.rbtCerta3.TabStop = true;
            this.rbtCerta3.Text = "this.Close();";
            this.rbtCerta3.UseVisualStyleBackColor = false;
            this.rbtCerta3.CheckedChanged += new System.EventHandler(this.rbtCerta3_CheckedChanged);
            // 
            // rbtCerta
            // 
            this.rbtCerta.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta.Location = new System.Drawing.Point(113, 263);
            this.rbtCerta.Name = "rbtCerta";
            this.rbtCerta.Size = new System.Drawing.Size(226, 28);
            this.rbtCerta.TabIndex = 12;
            this.rbtCerta.TabStop = true;
            this.rbtCerta.Text = "MessageBox.Show();";
            this.rbtCerta.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(314, 403);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(99, 29);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(118, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "Qual o comando para chamar caixa de dialogo?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quiz.Properties.Resources.quizpergunta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.rbtCerta4);
            this.Controls.Add(this.rbtCerta2);
            this.Controls.Add(this.rbtCerta3);
            this.Controls.Add(this.rbtCerta);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "frmp5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmp5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtCerta4;
        private System.Windows.Forms.RadioButton rbtCerta2;
        private System.Windows.Forms.RadioButton rbtCerta3;
        private System.Windows.Forms.RadioButton rbtCerta;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label1;
    }
}