namespace StokKontrolFormApp
{
    partial class CalisanForm
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
            calisanAra_btn = new Button();
            calisanSil_btn = new Button();
            calisanGuncelle_btn = new Button();
            calisanEkle_btn = new Button();
            calisanDataGrid = new DataGridView();
            departmanCalisan_combo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            calisanSoyad_txt = new TextBox();
            label2 = new Label();
            calisanAd_txt = new TextBox();
            label1 = new Label();
            calisanKod_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)calisanDataGrid).BeginInit();
            SuspendLayout();
            // 
            // calisanAra_btn
            // 
            calisanAra_btn.Location = new Point(808, 391);
            calisanAra_btn.Name = "calisanAra_btn";
            calisanAra_btn.Size = new Size(116, 29);
            calisanAra_btn.TabIndex = 30;
            calisanAra_btn.Text = "Ara";
            calisanAra_btn.UseVisualStyleBackColor = true;
            // 
            // calisanSil_btn
            // 
            calisanSil_btn.Location = new Point(808, 356);
            calisanSil_btn.Name = "calisanSil_btn";
            calisanSil_btn.Size = new Size(116, 29);
            calisanSil_btn.TabIndex = 29;
            calisanSil_btn.Text = "Sil";
            calisanSil_btn.UseVisualStyleBackColor = true;
            // 
            // calisanGuncelle_btn
            // 
            calisanGuncelle_btn.Location = new Point(407, 391);
            calisanGuncelle_btn.Name = "calisanGuncelle_btn";
            calisanGuncelle_btn.Size = new Size(116, 29);
            calisanGuncelle_btn.TabIndex = 28;
            calisanGuncelle_btn.Text = "Güncelle";
            calisanGuncelle_btn.UseVisualStyleBackColor = true;
            // 
            // calisanEkle_btn
            // 
            calisanEkle_btn.Location = new Point(407, 356);
            calisanEkle_btn.Name = "calisanEkle_btn";
            calisanEkle_btn.Size = new Size(116, 29);
            calisanEkle_btn.TabIndex = 27;
            calisanEkle_btn.Text = "Ekle";
            calisanEkle_btn.UseVisualStyleBackColor = true;
            // 
            // calisanDataGrid
            // 
            calisanDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calisanDataGrid.Location = new Point(407, 90);
            calisanDataGrid.Name = "calisanDataGrid";
            calisanDataGrid.RowHeadersWidth = 51;
            calisanDataGrid.Size = new Size(517, 240);
            calisanDataGrid.TabIndex = 26;
            // 
            // departmanCalisan_combo
            // 
            departmanCalisan_combo.FormattingEnabled = true;
            departmanCalisan_combo.Location = new Point(162, 249);
            departmanCalisan_combo.Name = "departmanCalisan_combo";
            departmanCalisan_combo.Size = new Size(151, 28);
            departmanCalisan_combo.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 252);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 22;
            label4.Text = "Departman:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 199);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 21;
            label3.Text = "Çalışan Soyad:";
            // 
            // calisanSoyad_txt
            // 
            calisanSoyad_txt.Location = new Point(162, 196);
            calisanSoyad_txt.Name = "calisanSoyad_txt";
            calisanSoyad_txt.Size = new Size(151, 27);
            calisanSoyad_txt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 147);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 19;
            label2.Text = "Çalışan Ad:";
            // 
            // calisanAd_txt
            // 
            calisanAd_txt.Location = new Point(162, 144);
            calisanAd_txt.Name = "calisanAd_txt";
            calisanAd_txt.Size = new Size(151, 27);
            calisanAd_txt.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 90);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 17;
            label1.Text = "Çalışan Kodu:";
            // 
            // calisanKod_txt
            // 
            calisanKod_txt.Location = new Point(162, 87);
            calisanKod_txt.Name = "calisanKod_txt";
            calisanKod_txt.Size = new Size(151, 27);
            calisanKod_txt.TabIndex = 16;
            // 
            // CalisanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 506);
            Controls.Add(calisanAra_btn);
            Controls.Add(calisanSil_btn);
            Controls.Add(calisanGuncelle_btn);
            Controls.Add(calisanEkle_btn);
            Controls.Add(calisanDataGrid);
            Controls.Add(departmanCalisan_combo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(calisanSoyad_txt);
            Controls.Add(label2);
            Controls.Add(calisanAd_txt);
            Controls.Add(label1);
            Controls.Add(calisanKod_txt);
            Name = "CalisanForm";
            Text = "CalisanForm";
            ((System.ComponentModel.ISupportInitialize)calisanDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calisanAra_btn;
        private Button calisanSil_btn;
        private Button calisanGuncelle_btn;
        private Button calisanEkle_btn;
        private DataGridView calisanDataGrid;
        private ComboBox departmanCalisan_combo;
        private Label label4;
        private Label label3;
        private TextBox calisanSoyad_txt;
        private Label label2;
        private TextBox calisanAd_txt;
        private Label label1;
        private TextBox calisanKod_txt;
    }
}