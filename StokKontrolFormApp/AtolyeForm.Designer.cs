namespace StokKontrolFormApp
{
    partial class AtolyeForm
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
            atoyleAra_btn = new Button();
            atoyleSil_btn = new Button();
            atoyleGuncelle_btn = new Button();
            atoyleEkle_btn = new Button();
            atoyleDataGrid = new DataGridView();
            label3 = new Label();
            atoyleTel_txt = new TextBox();
            label2 = new Label();
            atoyleAd_txt = new TextBox();
            label1 = new Label();
            atoyleKod_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)atoyleDataGrid).BeginInit();
            SuspendLayout();
            // 
            // atoyleAra_btn
            // 
            atoyleAra_btn.Location = new Point(829, 405);
            atoyleAra_btn.Name = "atoyleAra_btn";
            atoyleAra_btn.Size = new Size(116, 29);
            atoyleAra_btn.TabIndex = 56;
            atoyleAra_btn.Text = "Ara";
            atoyleAra_btn.UseVisualStyleBackColor = true;
            // 
            // atoyleSil_btn
            // 
            atoyleSil_btn.Location = new Point(829, 370);
            atoyleSil_btn.Name = "atoyleSil_btn";
            atoyleSil_btn.Size = new Size(116, 29);
            atoyleSil_btn.TabIndex = 55;
            atoyleSil_btn.Text = "Sil";
            atoyleSil_btn.UseVisualStyleBackColor = true;
            // 
            // atoyleGuncelle_btn
            // 
            atoyleGuncelle_btn.Location = new Point(428, 405);
            atoyleGuncelle_btn.Name = "atoyleGuncelle_btn";
            atoyleGuncelle_btn.Size = new Size(116, 29);
            atoyleGuncelle_btn.TabIndex = 54;
            atoyleGuncelle_btn.Text = "Güncelle";
            atoyleGuncelle_btn.UseVisualStyleBackColor = true;
            // 
            // atoyleEkle_btn
            // 
            atoyleEkle_btn.Location = new Point(428, 370);
            atoyleEkle_btn.Name = "atoyleEkle_btn";
            atoyleEkle_btn.Size = new Size(116, 29);
            atoyleEkle_btn.TabIndex = 53;
            atoyleEkle_btn.Text = "Ekle";
            atoyleEkle_btn.UseVisualStyleBackColor = true;
            // 
            // atoyleDataGrid
            // 
            atoyleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            atoyleDataGrid.Location = new Point(428, 104);
            atoyleDataGrid.Name = "atoyleDataGrid";
            atoyleDataGrid.RowHeadersWidth = 51;
            atoyleDataGrid.Size = new Size(517, 240);
            atoyleDataGrid.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 213);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 50;
            label3.Text = "Atöyle Telefon:";
            // 
            // atoyleTel_txt
            // 
            atoyleTel_txt.Location = new Point(183, 210);
            atoyleTel_txt.Name = "atoyleTel_txt";
            atoyleTel_txt.Size = new Size(151, 27);
            atoyleTel_txt.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 161);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 48;
            label2.Text = "Atölye Ad:";
            // 
            // atoyleAd_txt
            // 
            atoyleAd_txt.Location = new Point(183, 158);
            atoyleAd_txt.Name = "atoyleAd_txt";
            atoyleAd_txt.Size = new Size(151, 27);
            atoyleAd_txt.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 104);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 46;
            label1.Text = "Atölye Kod:";
            // 
            // atoyleKod_txt
            // 
            atoyleKod_txt.Location = new Point(183, 101);
            atoyleKod_txt.Name = "atoyleKod_txt";
            atoyleKod_txt.Size = new Size(151, 27);
            atoyleKod_txt.TabIndex = 45;
            // 
            // AtolyeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 535);
            Controls.Add(atoyleAra_btn);
            Controls.Add(atoyleSil_btn);
            Controls.Add(atoyleGuncelle_btn);
            Controls.Add(atoyleEkle_btn);
            Controls.Add(atoyleDataGrid);
            Controls.Add(label3);
            Controls.Add(atoyleTel_txt);
            Controls.Add(label2);
            Controls.Add(atoyleAd_txt);
            Controls.Add(label1);
            Controls.Add(atoyleKod_txt);
            Name = "AtolyeForm";
            Text = "AtolyeForm";
            ((System.ComponentModel.ISupportInitialize)atoyleDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button atoyleAra_btn;
        private Button atoyleSil_btn;
        private Button atoyleGuncelle_btn;
        private Button atoyleEkle_btn;
        private DataGridView atoyleDataGrid;
        private Label label3;
        private TextBox atoyleTel_txt;
        private Label label2;
        private TextBox atoyleAd_txt;
        private Label label1;
        private TextBox atoyleKod_txt;
    }
}