namespace StokKontrolFormApp
{
    partial class DepartmanForm
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
            departmanAra_btn = new Button();
            departmanSil_btn = new Button();
            departmanGuncelle_btn = new Button();
            departmanEkle_btn = new Button();
            departmanDataGrid = new DataGridView();
            label2 = new Label();
            departmanAd_txt = new TextBox();
            label1 = new Label();
            departmanKod_txt = new TextBox();
            yenile_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)departmanDataGrid).BeginInit();
            SuspendLayout();
            // 
            // departmanAra_btn
            // 
            departmanAra_btn.Location = new Point(842, 409);
            departmanAra_btn.Name = "departmanAra_btn";
            departmanAra_btn.Size = new Size(116, 29);
            departmanAra_btn.TabIndex = 43;
            departmanAra_btn.Text = "Ara";
            departmanAra_btn.UseVisualStyleBackColor = true;
            departmanAra_btn.Click += departmanAra_btn_Click;
            // 
            // departmanSil_btn
            // 
            departmanSil_btn.Location = new Point(842, 374);
            departmanSil_btn.Name = "departmanSil_btn";
            departmanSil_btn.Size = new Size(116, 29);
            departmanSil_btn.TabIndex = 42;
            departmanSil_btn.Text = "Sil";
            departmanSil_btn.UseVisualStyleBackColor = true;
            departmanSil_btn.Click += departmanSil_btn_Click;
            // 
            // departmanGuncelle_btn
            // 
            departmanGuncelle_btn.Location = new Point(441, 409);
            departmanGuncelle_btn.Name = "departmanGuncelle_btn";
            departmanGuncelle_btn.Size = new Size(116, 29);
            departmanGuncelle_btn.TabIndex = 41;
            departmanGuncelle_btn.Text = "Güncelle";
            departmanGuncelle_btn.UseVisualStyleBackColor = true;
            departmanGuncelle_btn.Click += departmanGuncelle_btn_Click;
            // 
            // departmanEkle_btn
            // 
            departmanEkle_btn.Location = new Point(441, 374);
            departmanEkle_btn.Name = "departmanEkle_btn";
            departmanEkle_btn.Size = new Size(116, 29);
            departmanEkle_btn.TabIndex = 40;
            departmanEkle_btn.Text = "Ekle";
            departmanEkle_btn.UseVisualStyleBackColor = true;
            departmanEkle_btn.Click += departmanEkle_btn_Click;
            // 
            // departmanDataGrid
            // 
            departmanDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmanDataGrid.Location = new Point(441, 108);
            departmanDataGrid.Name = "departmanDataGrid";
            departmanDataGrid.RowHeadersWidth = 51;
            departmanDataGrid.Size = new Size(517, 240);
            departmanDataGrid.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 165);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 34;
            label2.Text = "Departman Ad:";
            // 
            // departmanAd_txt
            // 
            departmanAd_txt.Location = new Point(196, 162);
            departmanAd_txt.Name = "departmanAd_txt";
            departmanAd_txt.Size = new Size(151, 27);
            departmanAd_txt.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 108);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 32;
            label1.Text = "Departman Kodu:";
            // 
            // departmanKod_txt
            // 
            departmanKod_txt.Location = new Point(196, 105);
            departmanKod_txt.Name = "departmanKod_txt";
            departmanKod_txt.Size = new Size(151, 27);
            departmanKod_txt.TabIndex = 31;
            // 
            // yenile_btn
            // 
            yenile_btn.Location = new Point(441, 73);
            yenile_btn.Name = "yenile_btn";
            yenile_btn.Size = new Size(94, 29);
            yenile_btn.TabIndex = 44;
            yenile_btn.Text = "Yenile";
            yenile_btn.UseVisualStyleBackColor = true;
            yenile_btn.Click += yenile_btn_Click;
            // 
            // DepartmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 543);
            Controls.Add(yenile_btn);
            Controls.Add(departmanAra_btn);
            Controls.Add(departmanSil_btn);
            Controls.Add(departmanGuncelle_btn);
            Controls.Add(departmanEkle_btn);
            Controls.Add(departmanDataGrid);
            Controls.Add(label2);
            Controls.Add(departmanAd_txt);
            Controls.Add(label1);
            Controls.Add(departmanKod_txt);
            Name = "DepartmanForm";
            Text = "DepartmanForm";
            Load += DepartmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)departmanDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button departmanAra_btn;
        private Button departmanSil_btn;
        private Button departmanGuncelle_btn;
        private Button departmanEkle_btn;
        private DataGridView departmanDataGrid;
        private Label label2;
        private TextBox departmanAd_txt;
        private Label label1;
        private TextBox departmanKod_txt;
        private Button yenile_btn;
    }
}