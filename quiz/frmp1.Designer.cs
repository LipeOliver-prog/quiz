namespace quiz
{
    partial class frmp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.rbtCerta = new System.Windows.Forms.RadioButton();
            this.rbtCerta3 = new System.Windows.Forms.RadioButton();
            this.rbtCerta2 = new System.Windows.Forms.RadioButton();
            this.rbtCerta4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(109, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual a tecla de atalho para executar programa Visual Studio?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Location = new System.Drawing.Point(312, 413);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(99, 29);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // rbtCerta
            // 
            this.rbtCerta.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta.Location = new System.Drawing.Point(113, 265);
            this.rbtCerta.Name = "rbtCerta";
            this.rbtCerta.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta.TabIndex = 6;
            this.rbtCerta.TabStop = true;
            this.rbtCerta.Text = "F5";
            this.rbtCerta.UseVisualStyleBackColor = false;
            this.rbtCerta.CheckedChanged += new System.EventHandler(this.rbtCerta_CheckedChanged);
            // 
            // rbtCerta3
            // 
            this.rbtCerta3.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta3.Location = new System.Drawing.Point(114, 338);
            this.rbtCerta3.Name = "rbtCerta3";
            this.rbtCerta3.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta3.TabIndex = 7;
            this.rbtCerta3.TabStop = true;
            this.rbtCerta3.Text = "F 1";
            this.rbtCerta3.UseVisualStyleBackColor = false;
            this.rbtCerta3.CheckedChanged += new System.EventHandler(this.rbtCerta3_CheckedChanged);
            // 
            // rbtCerta2
            // 
            this.rbtCerta2.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta2.Location = new System.Drawing.Point(427, 265);
            this.rbtCerta2.Name = "rbtCerta2";
            this.rbtCerta2.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta2.TabIndex = 8;
            this.rbtCerta2.TabStop = true;
            this.rbtCerta2.Text = "CTRL + C";
            this.rbtCerta2.UseVisualStyleBackColor = false;
            this.rbtCerta2.CheckedChanged += new System.EventHandler(this.rbtCerta2_CheckedChanged);
            // 
            // rbtCerta4
            // 
            this.rbtCerta4.BackColor = System.Drawing.Color.Transparent;
            this.rbtCerta4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCerta4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCerta4.Location = new System.Drawing.Point(427, 338);
            this.rbtCerta4.Name = "rbtCerta4";
            this.rbtCerta4.Size = new System.Drawing.Size(212, 28);
            this.rbtCerta4.TabIndex = 9;
            this.rbtCerta4.TabStop = true;
            this.rbtCerta4.Text = "F 7";
            this.rbtCerta4.UseVisualStyleBackColor = false;
            this.rbtCerta4.CheckedChanged += new System.EventHandler(this.rbtCerta4_CheckedChanged);
            // 
            // frmp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmp1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.RadioButton rbtCerta;
        private System.Windows.Forms.RadioButton rbtCerta3;
        private System.Windows.Forms.RadioButton rbtCerta2;
        private System.Windows.Forms.RadioButton rbtCerta4;
    }
}