namespace Proje_Hastane
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHastaGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSekreterGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastaGirisi
            // 
            this.btnHastaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGirisi.Location = new System.Drawing.Point(12, 12);
            this.btnHastaGirisi.Name = "btnHastaGirisi";
            this.btnHastaGirisi.Size = new System.Drawing.Size(210, 145);
            this.btnHastaGirisi.TabIndex = 0;
            this.btnHastaGirisi.Text = "Hasta Giriş";
            this.btnHastaGirisi.UseVisualStyleBackColor = true;
            this.btnHastaGirisi.Click += new System.EventHandler(this.btnHastaGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor";
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisi.Location = new System.Drawing.Point(245, 12);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(210, 145);
            this.btnDoktorGirisi.TabIndex = 2;
            this.btnDoktorGirisi.Text = "Doktor Giriş";
            this.btnDoktorGirisi.UseVisualStyleBackColor = true;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(555, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // btnSekreterGirisi
            // 
            this.btnSekreterGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterGirisi.Location = new System.Drawing.Point(494, 12);
            this.btnSekreterGirisi.Name = "btnSekreterGirisi";
            this.btnSekreterGirisi.Size = new System.Drawing.Size(210, 145);
            this.btnSekreterGirisi.TabIndex = 4;
            this.btnSekreterGirisi.Text = "Sekreter Giriş";
            this.btnSekreterGirisi.UseVisualStyleBackColor = true;
            this.btnSekreterGirisi.Click += new System.EventHandler(this.btnSekreterGirisi_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSekreterGirisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoktorGirisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHastaGirisi);
            this.Name = "FrmGirisler";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoktorGirisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSekreterGirisi;
    }
}

