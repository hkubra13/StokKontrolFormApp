namespace StokKontrolFormApp
{
    partial class AnaMenu
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
            urun = new Button();
            atolye = new Button();
            satis = new Button();
            departman = new Button();
            barkod = new Button();
            alis = new Button();
            calisan = new Button();
            SuspendLayout();
            // 
            // urun
            // 
            urun.Location = new Point(69, 47);
            urun.Name = "urun";
            urun.Size = new Size(249, 90);
            urun.TabIndex = 0;
            urun.Text = "Ürün";
            urun.UseVisualStyleBackColor = true;
            urun.Click += urun_Click;
            // 
            // atolye
            // 
            atolye.Location = new Point(69, 183);
            atolye.Name = "atolye";
            atolye.Size = new Size(249, 90);
            atolye.TabIndex = 1;
            atolye.Text = "Atöyle";
            atolye.UseVisualStyleBackColor = true;
            atolye.Click += atolye_Click;
            // 
            // satis
            // 
            satis.Location = new Point(69, 319);
            satis.Name = "satis";
            satis.Size = new Size(249, 90);
            satis.TabIndex = 4;
            satis.Text = "Satış";
            satis.UseVisualStyleBackColor = true;
            satis.Click += satis_Click;
            // 
            // departman
            // 
            departman.Location = new Point(383, 183);
            departman.Name = "departman";
            departman.Size = new Size(249, 90);
            departman.TabIndex = 5;
            departman.Text = "Departman";
            departman.UseVisualStyleBackColor = true;
            departman.Click += departman_Click;
            // 
            // barkod
            // 
            barkod.Location = new Point(383, 47);
            barkod.Name = "barkod";
            barkod.Size = new Size(249, 90);
            barkod.TabIndex = 7;
            barkod.Text = "Barkod";
            barkod.UseVisualStyleBackColor = true;
            barkod.Click += barkod_Click;
            // 
            // alis
            // 
            alis.Location = new Point(383, 319);
            alis.Name = "alis";
            alis.Size = new Size(249, 90);
            alis.TabIndex = 8;
            alis.Text = "Alış";
            alis.UseVisualStyleBackColor = true;
            alis.Click += alis_Click;
            // 
            // calisan
            // 
            calisan.Location = new Point(69, 455);
            calisan.Name = "calisan";
            calisan.Size = new Size(249, 90);
            calisan.TabIndex = 9;
            calisan.Text = "Çalışan";
            calisan.UseVisualStyleBackColor = true;
            calisan.Click += calisan_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 605);
            Controls.Add(calisan);
            Controls.Add(alis);
            Controls.Add(barkod);
            Controls.Add(departman);
            Controls.Add(satis);
            Controls.Add(atolye);
            Controls.Add(urun);
            Name = "AnaMenu";
            Text = "AnaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button urun;
        private Button atolye;
        private Button satis;
        private Button departman;
        private Button barkod;
        private Button alis;
        private Button calisan;
    }
}
