namespace RestoranSiparisUygulaması
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
            label1 = new Label();
            txtEposta = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 187);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "E-Posta";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(427, 179);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(100, 23);
            txtEposta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 216);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(427, 216);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(413, 256);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(129, 23);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(413, 305);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(129, 23);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtEposta);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEposta;
        private Label label2;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayitOl;

    }
}
