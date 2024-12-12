namespace StokKontrolFormApp
{
    partial class UrunForm
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
            urunKod_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            urunAd_txt = new TextBox();
            label3 = new Label();
            urunStok_txt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            departmanUrun_combo = new ComboBox();
            urunDataGrid = new DataGridView();
            urunEkle_btn = new Button();
            urunGuncelle_btn = new Button();
            urunSil_btn = new Button();
            urunAra_btn = new Button();
            urunGoster_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)urunDataGrid).BeginInit();
            SuspendLayout();
            // 
            // urunKod_txt
            // 
            urunKod_txt.Location = new Point(112, 42);
            urunKod_txt.Name = "urunKod_txt";
            urunKod_txt.Size = new Size(151, 27);
            urunKod_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 45);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Kodu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı:";
            // 
            // urunAd_txt
            // 
            urunAd_txt.Location = new Point(112, 99);
            urunAd_txt.Name = "urunAd_txt";
            urunAd_txt.Size = new Size(151, 27);
            urunAd_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Ürün Stok:";
            // 
            // urunStok_txt
            // 
            urunStok_txt.Location = new Point(112, 151);
            urunStok_txt.Name = "urunStok_txt";
            urunStok_txt.Size = new Size(151, 27);
            urunStok_txt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 207);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Departman:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 261);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 9;
            label5.Text = "Barkod:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 8;
            // 
            // departmanUrun_combo
            // 
            departmanUrun_combo.FormattingEnabled = true;
            departmanUrun_combo.Location = new Point(112, 204);
            departmanUrun_combo.Name = "departmanUrun_combo";
            departmanUrun_combo.Size = new Size(151, 28);
            departmanUrun_combo.TabIndex = 10;
            // 
            // urunDataGrid
            // 
            urunDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunDataGrid.Location = new Point(357, 45);
            urunDataGrid.Name = "urunDataGrid";
            urunDataGrid.RowHeadersWidth = 51;
            urunDataGrid.Size = new Size(517, 240);
            urunDataGrid.TabIndex = 11;
            // 
            // urunEkle_btn
            // 
            urunEkle_btn.Location = new Point(357, 311);
            urunEkle_btn.Name = "urunEkle_btn";
            urunEkle_btn.Size = new Size(116, 29);
            urunEkle_btn.TabIndex = 12;
            urunEkle_btn.Text = "Ekle";
            urunEkle_btn.UseVisualStyleBackColor = true;
            // 
            // urunGuncelle_btn
            // 
            urunGuncelle_btn.Location = new Point(357, 346);
            urunGuncelle_btn.Name = "urunGuncelle_btn";
            urunGuncelle_btn.Size = new Size(116, 29);
            urunGuncelle_btn.TabIndex = 13;
            urunGuncelle_btn.Text = "Güncelle";
            urunGuncelle_btn.UseVisualStyleBackColor = true;
            // 
            // urunSil_btn
            // 
            urunSil_btn.Location = new Point(758, 311);
            urunSil_btn.Name = "urunSil_btn";
            urunSil_btn.Size = new Size(116, 29);
            urunSil_btn.TabIndex = 14;
            urunSil_btn.Text = "Sil";
            urunSil_btn.UseVisualStyleBackColor = true;
            // 
            // urunAra_btn
            // 
            urunAra_btn.Location = new Point(758, 346);
            urunAra_btn.Name = "urunAra_btn";
            urunAra_btn.Size = new Size(116, 29);
            urunAra_btn.TabIndex = 15;
            urunAra_btn.Text = "Ara";
            urunAra_btn.UseVisualStyleBackColor = true;
            // 
            // urunGoster_btn
            // 
            urunGoster_btn.Location = new Point(357, 10);
            urunGoster_btn.Name = "urunGoster_btn";
            urunGoster_btn.Size = new Size(94, 29);
            urunGoster_btn.TabIndex = 16;
            urunGoster_btn.Text = "Göster";
            urunGoster_btn.UseVisualStyleBackColor = true;
            urunGoster_btn.Click += urunGoster_btn_Click;
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 425);
            Controls.Add(urunGoster_btn);
            Controls.Add(urunAra_btn);
            Controls.Add(urunSil_btn);
            Controls.Add(urunGuncelle_btn);
            Controls.Add(urunEkle_btn);
            Controls.Add(urunDataGrid);
            Controls.Add(departmanUrun_combo);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(urunStok_txt);
            Controls.Add(label2);
            Controls.Add(urunAd_txt);
            Controls.Add(label1);
            Controls.Add(urunKod_txt);
            Name = "UrunForm";
            Text = "UrunForm";
            ((System.ComponentModel.ISupportInitialize)urunDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urunKod_txt;
        private Label label1;
        private Label label2;
        private TextBox urunAd_txt;
        private Label label3;
        private TextBox urunStok_txt;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ComboBox departmanUrun_combo;
        private DataGridView urunDataGrid;
        private Button urunEkle_btn;
        private Button urunGuncelle_btn;
        private Button urunSil_btn;
        private Button urunAra_btn;
        private Button urunGoster_btn;
    }
}