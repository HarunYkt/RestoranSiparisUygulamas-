namespace RestoranSiparisUygulaması
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnKayit = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            txtTelefon = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 114);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 147);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 183);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "E-Posta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 224);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 257);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefon No";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(289, 292);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(114, 23);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(322, 106);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(322, 144);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 7;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(322, 180);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(100, 23);
            txtEposta.TabIndex = 8;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(322, 221);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(322, 254);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefon);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnKayit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnKayit;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private TextBox txtTelefon;
    }
}