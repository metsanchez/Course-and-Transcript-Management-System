namespace _200601078_Metehan_Yanik
{
    partial class KayitSilmeEkrani
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
            this.dersDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.dersSilBtn = new System.Windows.Forms.Button();
            this.dersKoduTxtBox = new System.Windows.Forms.TextBox();
            this.dersiBulBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dersDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersDataGrid
            // 
            this.dersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersDataGrid.Location = new System.Drawing.Point(105, 22);
            this.dersDataGrid.Name = "dersDataGrid";
            this.dersDataGrid.RowTemplate.Height = 25;
            this.dersDataGrid.Size = new System.Drawing.Size(736, 249);
            this.dersDataGrid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anaSayfaBtn);
            this.groupBox1.Controls.Add(this.iptalBtn);
            this.groupBox1.Controls.Add(this.dersDataGrid);
            this.groupBox1.Controls.Add(this.dersSilBtn);
            this.groupBox1.Controls.Add(this.dersKoduTxtBox);
            this.groupBox1.Controls.Add(this.dersiBulBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 485);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Sil";
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.Location = new System.Drawing.Point(398, 437);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(99, 41);
            this.anaSayfaBtn.TabIndex = 19;
            this.anaSayfaBtn.Text = "Ana Sayfaya Dön";
            this.anaSayfaBtn.UseVisualStyleBackColor = true;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(491, 327);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(155, 53);
            this.iptalBtn.TabIndex = 18;
            this.iptalBtn.Text = "İPTAL";
            this.iptalBtn.UseVisualStyleBackColor = true;
            // 
            // dersSilBtn
            // 
            this.dersSilBtn.Location = new System.Drawing.Point(248, 327);
            this.dersSilBtn.Name = "dersSilBtn";
            this.dersSilBtn.Size = new System.Drawing.Size(155, 53);
            this.dersSilBtn.TabIndex = 17;
            this.dersSilBtn.Text = "DERSI SIL";
            this.dersSilBtn.UseVisualStyleBackColor = true;
            this.dersSilBtn.Click += new System.EventHandler(this.dersSilBtn_Click);
            // 
            // dersKoduTxtBox
            // 
            this.dersKoduTxtBox.Location = new System.Drawing.Point(248, 282);
            this.dersKoduTxtBox.Name = "dersKoduTxtBox";
            this.dersKoduTxtBox.Size = new System.Drawing.Size(155, 23);
            this.dersKoduTxtBox.TabIndex = 1;
            // 
            // dersiBulBtn
            // 
            this.dersiBulBtn.Location = new System.Drawing.Point(505, 277);
            this.dersiBulBtn.Name = "dersiBulBtn";
            this.dersiBulBtn.Size = new System.Drawing.Size(121, 28);
            this.dersiBulBtn.TabIndex = 2;
            this.dersiBulBtn.Text = "Dersi Bul";
            this.dersiBulBtn.UseVisualStyleBackColor = true;
            this.dersiBulBtn.Click += new System.EventHandler(this.dersiBulBtn_Click);
            // 
            // KayitSilmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 509);
            this.Controls.Add(this.groupBox1);
            this.Name = "KayitSilmeEkrani";
            this.Text = "Kayıt Silme";
            this.Load += new System.EventHandler(this.KayitSilmeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dersDataGrid;
        private GroupBox groupBox1;
        private Button dersSilBtn;
        private TextBox dersKoduTxtBox;
        private Button dersiBulBtn;
        private Button iptalBtn;
        private Button anaSayfaBtn;
    }
}