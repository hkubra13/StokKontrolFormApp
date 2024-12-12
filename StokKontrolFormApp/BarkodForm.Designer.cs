namespace StokKontrolFormApp
{
    partial class BarkodForm
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
            barkodAra_btn = new Button();
            barkodSil_btn = new Button();
            barkodGuncelle_btn = new Button();
            barkodEkle_btn = new Button();
            barkodDataGrid = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            beden_txt = new TextBox();
            label2 = new Label();
            renk_txt = new TextBox();
            label1 = new Label();
            barkod_txt = new TextBox();
            cinsiyet_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)barkodDataGrid).BeginInit();
            SuspendLayout();
            // 
            // barkodAra_btn
            // 
            barkodAra_btn.Location = new Point(856, 407);
            barkodAra_btn.Name = "barkodAra_btn";
            barkodAra_btn.Size = new Size(116, 29);
            barkodAra_btn.TabIndex = 43;
            barkodAra_btn.Text = "Ara";
            barkodAra_btn.UseVisualStyleBackColor = true;
            // 
            // barkodSil_btn
            // 
            barkodSil_btn.Location = new Point(856, 372);
            barkodSil_btn.Name = "barkodSil_btn";
            barkodSil_btn.Size = new Size(116, 29);
            barkodSil_btn.TabIndex = 42;
            barkodSil_btn.Text = "Sil";
            barkodSil_btn.UseVisualStyleBackColor = true;
            // 
            // barkodGuncelle_btn
            // 
            barkodGuncelle_btn.Location = new Point(455, 407);
            barkodGuncelle_btn.Name = "barkodGuncelle_btn";
            barkodGuncelle_btn.Size = new Size(116, 29);
            barkodGuncelle_btn.TabIndex = 41;
            barkodGuncelle_btn.Text = "Güncelle";
            barkodGuncelle_btn.UseVisualStyleBackColor = true;
            // 
            // barkodEkle_btn
            // 
            barkodEkle_btn.Location = new Point(455, 372);
            barkodEkle_btn.Name = "barkodEkle_btn";
            barkodEkle_btn.Size = new Size(116, 29);
            barkodEkle_btn.TabIndex = 40;
            barkodEkle_btn.Text = "Ekle";
            barkodEkle_btn.UseVisualStyleBackColor = true;
            // 
            // barkodDataGrid
            // 
            barkodDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            barkodDataGrid.Location = new Point(455, 106);
            barkodDataGrid.Name = "barkodDataGrid";
            barkodDataGrid.RowHeadersWidth = 51;
            barkodDataGrid.Size = new Size(517, 240);
            barkodDataGrid.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 268);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 37;
            label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 212);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 36;
            label3.Text = "Beden:";
            // 
            // beden_txt
            // 
            beden_txt.Location = new Point(210, 212);
            beden_txt.Name = "beden_txt";
            beden_txt.Size = new Size(151, 27);
            beden_txt.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 163);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 34;
            label2.Text = "Renk:";
            // 
            // renk_txt
            // 
            renk_txt.Location = new Point(210, 160);
            renk_txt.Name = "renk_txt";
            renk_txt.Size = new Size(151, 27);
            renk_txt.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 103);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 32;
            label1.Text = "Barkod:";
            // 
            // barkod_txt
            // 
            barkod_txt.Location = new Point(210, 103);
            barkod_txt.Name = "barkod_txt";
            barkod_txt.Size = new Size(151, 27);
            barkod_txt.TabIndex = 31;
            // 
            // cinsiyet_txt
            // 
            cinsiyet_txt.Location = new Point(210, 268);
            cinsiyet_txt.Name = "cinsiyet_txt";
            cinsiyet_txt.Size = new Size(151, 27);
            cinsiyet_txt.TabIndex = 44;
            // 
            // BarkodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 538);
            Controls.Add(cinsiyet_txt);
            Controls.Add(barkodAra_btn);
            Controls.Add(barkodSil_btn);
            Controls.Add(barkodGuncelle_btn);
            Controls.Add(barkodEkle_btn);
            Controls.Add(barkodDataGrid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(beden_txt);
            Controls.Add(label2);
            Controls.Add(renk_txt);
            Controls.Add(label1);
            Controls.Add(barkod_txt);
            Name = "BarkodForm";
            Text = "BarkodForm";
            ((System.ComponentModel.ISupportInitialize)barkodDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button barkodAra_btn;
        private Button barkodSil_btn;
        private Button barkodGuncelle_btn;
        private Button barkodEkle_btn;
        private DataGridView barkodDataGrid;
        private Label label4;
        private Label label3;
        private TextBox beden_txt;
        private Label label2;
        private TextBox renk_txt;
        private Label label1;
        private TextBox barkod_txt;
        private TextBox cinsiyet_txt;
    }
}