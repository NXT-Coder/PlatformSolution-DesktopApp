namespace PlatformImpact2
{
    partial class ProductForm
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
            this.btnCampaign = new System.Windows.Forms.Button();
            this.pbGmbarProduk = new System.Windows.Forms.PictureBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaProduk = new System.Windows.Forms.TextBox();
            this.tbHargaProduk = new System.Windows.Forms.TextBox();
            this.tbDeskripsiProduk = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCariGambar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGmbarProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCampaign
            // 
            this.btnCampaign.Location = new System.Drawing.Point(299, 216);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(75, 30);
            this.btnCampaign.TabIndex = 23;
            this.btnCampaign.Text = "CAMPAIGN";
            this.btnCampaign.UseVisualStyleBackColor = true;
            this.btnCampaign.Click += new System.EventHandler(this.btnCampaign_Click);
            // 
            // pbGmbarProduk
            // 
            this.pbGmbarProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGmbarProduk.Location = new System.Drawing.Point(365, 12);
            this.pbGmbarProduk.Name = "pbGmbarProduk";
            this.pbGmbarProduk.Size = new System.Drawing.Size(171, 162);
            this.pbGmbarProduk.TabIndex = 21;
            this.pbGmbarProduk.TabStop = false;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 30);
            this.btnKembali.TabIndex = 20;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Deskripsi Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Harga Produk";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 255);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(582, 150);
            this.dgvProduct.TabIndex = 22;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNamaProduk);
            this.groupBox1.Controls.Add(this.tbHargaProduk);
            this.groupBox1.Controls.Add(this.tbDeskripsiProduk);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 162);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama Produk";
            // 
            // tbNamaProduk
            // 
            this.tbNamaProduk.Location = new System.Drawing.Point(99, 19);
            this.tbNamaProduk.Name = "tbNamaProduk";
            this.tbNamaProduk.Size = new System.Drawing.Size(225, 20);
            this.tbNamaProduk.TabIndex = 0;
            // 
            // tbHargaProduk
            // 
            this.tbHargaProduk.Location = new System.Drawing.Point(123, 45);
            this.tbHargaProduk.Name = "tbHargaProduk";
            this.tbHargaProduk.Size = new System.Drawing.Size(201, 20);
            this.tbHargaProduk.TabIndex = 1;
            // 
            // tbDeskripsiProduk
            // 
            this.tbDeskripsiProduk.Location = new System.Drawing.Point(99, 71);
            this.tbDeskripsiProduk.Multiline = true;
            this.tbDeskripsiProduk.Name = "tbDeskripsiProduk";
            this.tbDeskripsiProduk.Size = new System.Drawing.Size(225, 85);
            this.tbDeskripsiProduk.TabIndex = 2;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(218, 216);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 30);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 216);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 30);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCariGambar
            // 
            this.btnCariGambar.Location = new System.Drawing.Point(405, 180);
            this.btnCariGambar.Name = "btnCariGambar";
            this.btnCariGambar.Size = new System.Drawing.Size(96, 30);
            this.btnCariGambar.TabIndex = 14;
            this.btnCariGambar.Text = "CARI GAMBAR";
            this.btnCariGambar.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(519, 216);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 417);
            this.Controls.Add(this.btnCampaign);
            this.Controls.Add(this.pbGmbarProduk);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCariGambar);
            this.Controls.Add(this.btnRefresh);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGmbarProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.PictureBox pbGmbarProduk;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaProduk;
        private System.Windows.Forms.TextBox tbHargaProduk;
        private System.Windows.Forms.TextBox tbDeskripsiProduk;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCariGambar;
        private System.Windows.Forms.Button btnRefresh;
    }
}