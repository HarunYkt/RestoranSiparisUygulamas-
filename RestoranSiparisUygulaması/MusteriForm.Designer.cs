namespace RestoranSiparisUygulaması
{
    partial class MusteriForm
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
            listViewMenu = new ListView();
            btnSiparisVer = new Button();
            txtAdet = new TextBox();
            SuspendLayout();
            // 
            // listViewMenu
            // 
            listViewMenu.Location = new Point(296, 47);
            listViewMenu.Name = "listViewMenu";
            listViewMenu.Size = new Size(388, 145);
            listViewMenu.TabIndex = 0;
            listViewMenu.UseCompatibleStateImageBehavior = false;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.Location = new Point(388, 267);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(174, 52);
            btnSiparisVer.TabIndex = 1;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = true;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(425, 238);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(100, 23);
            txtAdet.TabIndex = 2;
            txtAdet.Text = "Kaç Adet";
            // 
            // MusteriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAdet);
            Controls.Add(btnSiparisVer);
            Controls.Add(listViewMenu);
            Name = "MusteriForm";
            Text = "MusteriForm";
            Load += MusteriForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewMenu;
        private Button btnSiparisVer;
        private TextBox txtAdet;
    }
}