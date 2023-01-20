namespace _200601078_Metehan_Yanik
{
    partial class TranskriptEkrani
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
            this.ganoHesaplaBtn = new System.Windows.Forms.Button();
            this.ganoTxt = new System.Windows.Forms.TextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dersDataGrid)).BeginInit();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersDataGrid
            // 
            this.dersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersDataGrid.Location = new System.Drawing.Point(74, 39);
            this.dersDataGrid.Name = "dersDataGrid";
            this.dersDataGrid.RowTemplate.Height = 25;
            this.dersDataGrid.Size = new System.Drawing.Size(736, 232);
            this.dersDataGrid.TabIndex = 5;
            // 
            // ganoHesaplaBtn
            // 
            this.ganoHesaplaBtn.Location = new System.Drawing.Point(354, 290);
            this.ganoHesaplaBtn.Name = "ganoHesaplaBtn";
            this.ganoHesaplaBtn.Size = new System.Drawing.Size(142, 47);
            this.ganoHesaplaBtn.TabIndex = 6;
            this.ganoHesaplaBtn.Text = "GANO HESAPLA";
            this.ganoHesaplaBtn.UseVisualStyleBackColor = true;
            this.ganoHesaplaBtn.Click += new System.EventHandler(this.ganoHesaplaBtn_Click);
            // 
            // ganoTxt
            // 
            this.ganoTxt.Location = new System.Drawing.Point(335, 343);
            this.ganoTxt.Name = "ganoTxt";
            this.ganoTxt.ReadOnly = true;
            this.ganoTxt.Size = new System.Drawing.Size(174, 23);
            this.ganoTxt.TabIndex = 7;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.anaSayfaBtn);
            this.groupbox.Controls.Add(this.ganoHesaplaBtn);
            this.groupbox.Controls.Add(this.ganoTxt);
            this.groupbox.Controls.Add(this.dersDataGrid);
            this.groupbox.Location = new System.Drawing.Point(44, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(893, 391);
            this.groupbox.TabIndex = 8;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "GANO Hesaplama Ekranı";
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.Location = new System.Drawing.Point(680, 294);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(130, 43);
            this.anaSayfaBtn.TabIndex = 8;
            this.anaSayfaBtn.Text = "Ana Sayfaya Dön";
            this.anaSayfaBtn.UseVisualStyleBackColor = true;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            // 
            // TranskriptEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 462);
            this.Controls.Add(this.groupbox);
            this.Name = "TranskriptEkrani";
            this.Text = "Transkript Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dersDataGrid)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dersDataGrid;
        private Button ganoHesaplaBtn;
        private TextBox ganoTxt;
        private GroupBox groupbox;
        private Button anaSayfaBtn;
    }
}