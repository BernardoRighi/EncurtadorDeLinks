namespace EncurtadorDeLinks
{
    partial class FrmEncurtador
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
            this.txtUrlLonga = new System.Windows.Forms.TextBox();
            this.btnEncurtar = new System.Windows.Forms.Button();
            this.txtUrlEncurtada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEncurtarListaDeLinks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Longa:";
            // 
            // txtUrlLonga
            // 
            this.txtUrlLonga.Location = new System.Drawing.Point(24, 50);
            this.txtUrlLonga.Name = "txtUrlLonga";
            this.txtUrlLonga.Size = new System.Drawing.Size(722, 22);
            this.txtUrlLonga.TabIndex = 1;
            // 
            // btnEncurtar
            // 
            this.btnEncurtar.Location = new System.Drawing.Point(24, 90);
            this.btnEncurtar.Name = "btnEncurtar";
            this.btnEncurtar.Size = new System.Drawing.Size(722, 47);
            this.btnEncurtar.TabIndex = 2;
            this.btnEncurtar.Text = "Encurtar Link";
            this.btnEncurtar.UseVisualStyleBackColor = true;
            this.btnEncurtar.Click += new System.EventHandler(this.btnEncurtar_Click);
            // 
            // txtUrlEncurtada
            // 
            this.txtUrlEncurtada.Location = new System.Drawing.Point(24, 178);
            this.txtUrlEncurtada.Name = "txtUrlEncurtada";
            this.txtUrlEncurtada.Size = new System.Drawing.Size(722, 22);
            this.txtUrlEncurtada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL Encurtada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUrlEncurtada);
            this.groupBox1.Controls.Add(this.txtUrlLonga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEncurtar);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitlinks Individuais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEncurtarListaDeLinks);
            this.groupBox2.Location = new System.Drawing.Point(25, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitlinks Coletivos";
            // 
            // btnEncurtarListaDeLinks
            // 
            this.btnEncurtarListaDeLinks.Location = new System.Drawing.Point(27, 28);
            this.btnEncurtarListaDeLinks.Name = "btnEncurtarListaDeLinks";
            this.btnEncurtarListaDeLinks.Size = new System.Drawing.Size(722, 47);
            this.btnEncurtarListaDeLinks.TabIndex = 3;
            this.btnEncurtarListaDeLinks.Text = "Encurtar Links";
            this.btnEncurtarListaDeLinks.UseVisualStyleBackColor = true;
            this.btnEncurtarListaDeLinks.Click += new System.EventHandler(this.btnEncurtarListaDeLinks_Click);
            // 
            // FrmEncurtador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEncurtador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Encurtador de Links";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlLonga;
        private System.Windows.Forms.Button btnEncurtar;
        private System.Windows.Forms.TextBox txtUrlEncurtada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEncurtarListaDeLinks;
    }
}

