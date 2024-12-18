namespace StokKontrolFormApp
{
    partial class TedarikciForm
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
            tedarikciAra_btn = new Button();
            tedarikciSil_btn = new Button();
            tedarikciGuncelle_btn = new Button();
            tedarikciEkle_btn = new Button();
            tedarikciDataGrid = new DataGridView();
            label3 = new Label();
            tedarikciTel_txt = new TextBox();
            label2 = new Label();
            tedarikciAd_txt = new TextBox();
            label1 = new Label();
            tedarikciKod_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tedarikciDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tedarikciAra_btn
            // 
            tedarikciAra_btn.Location = new Point(829, 405);
            tedarikciAra_btn.Name = "tedarikciAra_btn";
            tedarikciAra_btn.Size = new Size(116, 29);
            tedarikciAra_btn.TabIndex = 56;
            tedarikciAra_btn.Text = "Ara";
            tedarikciAra_btn.UseVisualStyleBackColor = true;
            tedarikciAra_btn.Click += tedarikciAra_btn_Click;
            // 
            // tedarikciSil_btn
            // 
            tedarikciSil_btn.Location = new Point(829, 370);
            tedarikciSil_btn.Name = "tedarikciSil_btn";
            tedarikciSil_btn.Size = new Size(116, 29);
            tedarikciSil_btn.TabIndex = 55;
            tedarikciSil_btn.Text = "Sil";
            tedarikciSil_btn.UseVisualStyleBackColor = true;
            tedarikciSil_btn.Click += tedarikciSil_btn_Click;
            // 
            // tedarikciGuncelle_btn
            // 
            tedarikciGuncelle_btn.Location = new Point(428, 405);
            tedarikciGuncelle_btn.Name = "tedarikciGuncelle_btn";
            tedarikciGuncelle_btn.Size = new Size(116, 29);
            tedarikciGuncelle_btn.TabIndex = 54;
            tedarikciGuncelle_btn.Text = "Güncelle";
            tedarikciGuncelle_btn.UseVisualStyleBackColor = true;
            tedarikciGuncelle_btn.Click += tedarikciGuncelle_btn_Click;
            // 
            // tedarikciEkle_btn
            // 
            tedarikciEkle_btn.Location = new Point(428, 370);
            tedarikciEkle_btn.Name = "tedarikciEkle_btn";
            tedarikciEkle_btn.Size = new Size(116, 29);
            tedarikciEkle_btn.TabIndex = 53;
            tedarikciEkle_btn.Text = "Ekle";
            tedarikciEkle_btn.UseVisualStyleBackColor = true;
            tedarikciEkle_btn.Click += tedarikciEkle_btn_Click;
            // 
            // tedarikciDataGrid
            // 
            tedarikciDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tedarikciDataGrid.Location = new Point(428, 104);
            tedarikciDataGrid.Name = "tedarikciDataGrid";
            tedarikciDataGrid.RowHeadersWidth = 51;
            tedarikciDataGrid.Size = new Size(517, 240);
            tedarikciDataGrid.TabIndex = 52;
            tedarikciDataGrid.CellContentClick += tedarikciDataGrid_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 213);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 50;
            label3.Text = "Tedarikçi Telefon:";
            // 
            // tedarikciTel_txt
            // 
            tedarikciTel_txt.Location = new Point(183, 210);
            tedarikciTel_txt.Name = "tedarikciTel_txt";
            tedarikciTel_txt.Size = new Size(151, 27);
            tedarikciTel_txt.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 161);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 48;
            label2.Text = "Tedarikçi Ad:";
            // 
            // tedarikciAd_txt
            // 
            tedarikciAd_txt.Location = new Point(183, 158);
            tedarikciAd_txt.Name = "tedarikciAd_txt";
            tedarikciAd_txt.Size = new Size(151, 27);
            tedarikciAd_txt.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 104);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 46;
            label1.Text = "Tedarikçi Kod:";
            // 
            // tedarikciKod_txt
            // 
            tedarikciKod_txt.Location = new Point(183, 101);
            tedarikciKod_txt.Name = "tedarikciKod_txt";
            tedarikciKod_txt.Size = new Size(151, 27);
            tedarikciKod_txt.TabIndex = 45;
            // 
            // TedarikciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 535);
            Controls.Add(tedarikciAra_btn);
            Controls.Add(tedarikciSil_btn);
            Controls.Add(tedarikciGuncelle_btn);
            Controls.Add(tedarikciEkle_btn);
            Controls.Add(tedarikciDataGrid);
            Controls.Add(label3);
            Controls.Add(tedarikciTel_txt);
            Controls.Add(label2);
            Controls.Add(tedarikciAd_txt);
            Controls.Add(label1);
            Controls.Add(tedarikciKod_txt);
            Name = "TedarikciForm";
            Text = "TedarikciForm";
            Load += TedarikciForm_Load;
            ((System.ComponentModel.ISupportInitialize)tedarikciDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tedarikciAra_btn;
        private Button tedarikciSil_btn;
        private Button tedarikciGuncelle_btn;
        private Button tedarikciEkle_btn;
        private DataGridView tedarikciDataGrid;
        private Label label3;
        private TextBox tedarikciTel_txt;
        private Label label2;
        private TextBox tedarikciAd_txt;
        private Label label1;
        private TextBox tedarikciKod_txt;
    }
}