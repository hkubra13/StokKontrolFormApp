namespace StokKontrolFormApp
{
    partial class SatisForm
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
            satisCalisan_combo = new ComboBox();
            label6 = new Label();
            satisSeriNo_combo = new ComboBox();
            satisTarih_picker = new DateTimePicker();
            satisAra_btn = new Button();
            satisSil_btn = new Button();
            satisGuncelle_btn = new Button();
            satisEkle_btn = new Button();
            satisDataGrid = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            satisMiktar_txt = new TextBox();
            label2 = new Label();
            satisFiyat_txt = new TextBox();
            label1 = new Label();
            satisKod_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)satisDataGrid).BeginInit();
            SuspendLayout();
            // 
            // satisCalisan_combo
            // 
            satisCalisan_combo.FormattingEnabled = true;
            satisCalisan_combo.Location = new Point(176, 351);
            satisCalisan_combo.Name = "satisCalisan_combo";
            satisCalisan_combo.Size = new Size(151, 28);
            satisCalisan_combo.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 355);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 50;
            label6.Text = "Çalışan:";
            // 
            // satisSeriNo_combo
            // 
            satisSeriNo_combo.FormattingEnabled = true;
            satisSeriNo_combo.Location = new Point(176, 298);
            satisSeriNo_combo.Name = "satisSeriNo_combo";
            satisSeriNo_combo.Size = new Size(151, 28);
            satisSeriNo_combo.TabIndex = 49;
            // 
            // satisTarih_picker
            // 
            satisTarih_picker.Location = new Point(176, 247);
            satisTarih_picker.Name = "satisTarih_picker";
            satisTarih_picker.Size = new Size(151, 27);
            satisTarih_picker.TabIndex = 48;
            // 
            // satisAra_btn
            // 
            satisAra_btn.Location = new Point(822, 386);
            satisAra_btn.Name = "satisAra_btn";
            satisAra_btn.Size = new Size(116, 29);
            satisAra_btn.TabIndex = 47;
            satisAra_btn.Text = "Ara";
            satisAra_btn.UseVisualStyleBackColor = true;
            satisAra_btn.Click += satisAra_btn_Click;
            // 
            // satisSil_btn
            // 
            satisSil_btn.Location = new Point(822, 351);
            satisSil_btn.Name = "satisSil_btn";
            satisSil_btn.Size = new Size(116, 29);
            satisSil_btn.TabIndex = 46;
            satisSil_btn.Text = "Sil";
            satisSil_btn.UseVisualStyleBackColor = true;
            satisSil_btn.Click += satisSil_btn_Click;
            // 
            // satisGuncelle_btn
            // 
            satisGuncelle_btn.Location = new Point(421, 386);
            satisGuncelle_btn.Name = "satisGuncelle_btn";
            satisGuncelle_btn.Size = new Size(116, 29);
            satisGuncelle_btn.TabIndex = 45;
            satisGuncelle_btn.Text = "Güncelle";
            satisGuncelle_btn.UseVisualStyleBackColor = true;
            satisGuncelle_btn.Click += satisGuncelle_btn_Click;
            // 
            // satisEkle_btn
            // 
            satisEkle_btn.Location = new Point(421, 351);
            satisEkle_btn.Name = "satisEkle_btn";
            satisEkle_btn.Size = new Size(116, 29);
            satisEkle_btn.TabIndex = 44;
            satisEkle_btn.Text = "Ekle";
            satisEkle_btn.UseVisualStyleBackColor = true;
            satisEkle_btn.Click += satisEkle_btn_Click;
            // 
            // satisDataGrid
            // 
            satisDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            satisDataGrid.Location = new Point(421, 85);
            satisDataGrid.Name = "satisDataGrid";
            satisDataGrid.RowHeadersWidth = 51;
            satisDataGrid.Size = new Size(517, 240);
            satisDataGrid.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 301);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 42;
            label5.Text = "Seri No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 252);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 41;
            label4.Text = "Satış Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 194);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 40;
            label3.Text = "Satış Miktarı:";
            // 
            // satisMiktar_txt
            // 
            satisMiktar_txt.Location = new Point(176, 191);
            satisMiktar_txt.Name = "satisMiktar_txt";
            satisMiktar_txt.Size = new Size(151, 27);
            satisMiktar_txt.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 142);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 38;
            label2.Text = "Satış Fiyatı:";
            // 
            // satisFiyat_txt
            // 
            satisFiyat_txt.Location = new Point(176, 139);
            satisFiyat_txt.Name = "satisFiyat_txt";
            satisFiyat_txt.Size = new Size(151, 27);
            satisFiyat_txt.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 85);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 36;
            label1.Text = "Satış Kodu:";
            // 
            // satisKod_txt
            // 
            satisKod_txt.Location = new Point(176, 82);
            satisKod_txt.Name = "satisKod_txt";
            satisKod_txt.Size = new Size(151, 27);
            satisKod_txt.TabIndex = 35;
            // 
            // SatisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 578);
            Controls.Add(satisCalisan_combo);
            Controls.Add(label6);
            Controls.Add(satisSeriNo_combo);
            Controls.Add(satisTarih_picker);
            Controls.Add(satisAra_btn);
            Controls.Add(satisSil_btn);
            Controls.Add(satisGuncelle_btn);
            Controls.Add(satisEkle_btn);
            Controls.Add(satisDataGrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(satisMiktar_txt);
            Controls.Add(label2);
            Controls.Add(satisFiyat_txt);
            Controls.Add(label1);
            Controls.Add(satisKod_txt);
            Name = "SatisForm";
            Text = "SatisForm";
            ((System.ComponentModel.ISupportInitialize)satisDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satisCalisan_combo;
        private Label label6;
        private ComboBox satisSeriNo_combo;
        private DateTimePicker satisTarih_picker;
        private Button satisAra_btn;
        private Button satisSil_btn;
        private Button satisGuncelle_btn;
        private Button satisEkle_btn;
        private DataGridView satisDataGrid;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox satisMiktar_txt;
        private Label label2;
        private TextBox satisFiyat_txt;
        private Label label1;
        private TextBox satisKod_txt;
    }
}