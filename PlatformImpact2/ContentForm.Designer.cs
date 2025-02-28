namespace PlatformImpact2
{
    partial class ContentForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJenisKonten = new System.Windows.Forms.TextBox();
            this.cbProduk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProgres = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMinDevelopment = new System.Windows.Forms.Button();
            this.btnMinDesign = new System.Windows.Forms.Button();
            this.btnPlusDevelopment = new System.Windows.Forms.Button();
            this.btnPlusDesign = new System.Windows.Forms.Button();
            this.btnMinPlanning = new System.Windows.Forms.Button();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProgresContent = new System.Windows.Forms.DataGridView();
            this.tbDevelopment = new System.Windows.Forms.TextBox();
            this.tbDesign = new System.Windows.Forms.TextBox();
            this.tbPlanning = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgresContent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbJenisKonten);
            this.groupBox1.Controls.Add(this.cbProduk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 82);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jenis Konten";
            // 
            // tbJenisKonten
            // 
            this.tbJenisKonten.Location = new System.Drawing.Point(105, 19);
            this.tbJenisKonten.Name = "tbJenisKonten";
            this.tbJenisKonten.Size = new System.Drawing.Size(195, 20);
            this.tbJenisKonten.TabIndex = 0;
            // 
            // cbProduk
            // 
            this.cbProduk.FormattingEnabled = true;
            this.cbProduk.Location = new System.Drawing.Point(105, 45);
            this.cbProduk.Name = "cbProduk";
            this.cbProduk.Size = new System.Drawing.Size(195, 21);
            this.cbProduk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produk";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnProgres);
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Controls.Add(this.dgvContent);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 390);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "PUBLISH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProgres
            // 
            this.btnProgres.Location = new System.Drawing.Point(271, 154);
            this.btnProgres.Name = "btnProgres";
            this.btnProgres.Size = new System.Drawing.Size(75, 31);
            this.btnProgres.TabIndex = 22;
            this.btnProgres.Text = "PROGRES";
            this.btnProgres.UseVisualStyleBackColor = true;
            this.btnProgres.Click += new System.EventHandler(this.btnProgres_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(13, 107);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 31);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvContent
            // 
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Location = new System.Drawing.Point(6, 191);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(421, 193);
            this.dgvContent.TabIndex = 15;
            this.dgvContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(175, 107);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 31);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(352, 154);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 26;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMinDevelopment);
            this.groupBox3.Controls.Add(this.btnMinDesign);
            this.groupBox3.Controls.Add(this.btnPlusDevelopment);
            this.groupBox3.Controls.Add(this.btnPlusDesign);
            this.groupBox3.Controls.Add(this.btnMinPlanning);
            this.groupBox3.Controls.Add(this.btnPlanning);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbDeskripsi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.dgvProgresContent);
            this.groupBox3.Controls.Add(this.tbDevelopment);
            this.groupBox3.Controls.Add(this.tbDesign);
            this.groupBox3.Controls.Add(this.tbPlanning);
            this.groupBox3.Location = new System.Drawing.Point(458, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 384);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Developer";
            // 
            // btnMinDevelopment
            // 
            this.btnMinDevelopment.Location = new System.Drawing.Point(111, 69);
            this.btnMinDevelopment.Name = "btnMinDevelopment";
            this.btnMinDevelopment.Size = new System.Drawing.Size(35, 23);
            this.btnMinDevelopment.TabIndex = 35;
            this.btnMinDevelopment.Text = "- 5";
            this.btnMinDevelopment.UseVisualStyleBackColor = true;
            this.btnMinDevelopment.Click += new System.EventHandler(this.btnMinDevelopment_Click);
            // 
            // btnMinDesign
            // 
            this.btnMinDesign.Location = new System.Drawing.Point(111, 43);
            this.btnMinDesign.Name = "btnMinDesign";
            this.btnMinDesign.Size = new System.Drawing.Size(35, 23);
            this.btnMinDesign.TabIndex = 34;
            this.btnMinDesign.Text = "- 5";
            this.btnMinDesign.UseVisualStyleBackColor = true;
            this.btnMinDesign.Click += new System.EventHandler(this.btnMinDesign_Click);
            // 
            // btnPlusDevelopment
            // 
            this.btnPlusDevelopment.Location = new System.Drawing.Point(222, 69);
            this.btnPlusDevelopment.Name = "btnPlusDevelopment";
            this.btnPlusDevelopment.Size = new System.Drawing.Size(35, 23);
            this.btnPlusDevelopment.TabIndex = 33;
            this.btnPlusDevelopment.Text = "+ 5";
            this.btnPlusDevelopment.UseVisualStyleBackColor = true;
            this.btnPlusDevelopment.Click += new System.EventHandler(this.btnPlusDevelopment_Click);
            // 
            // btnPlusDesign
            // 
            this.btnPlusDesign.Location = new System.Drawing.Point(222, 42);
            this.btnPlusDesign.Name = "btnPlusDesign";
            this.btnPlusDesign.Size = new System.Drawing.Size(35, 23);
            this.btnPlusDesign.TabIndex = 32;
            this.btnPlusDesign.Text = "+ 5";
            this.btnPlusDesign.UseVisualStyleBackColor = true;
            this.btnPlusDesign.Click += new System.EventHandler(this.btnPlusDesign_Click);
            // 
            // btnMinPlanning
            // 
            this.btnMinPlanning.Location = new System.Drawing.Point(111, 17);
            this.btnMinPlanning.Name = "btnMinPlanning";
            this.btnMinPlanning.Size = new System.Drawing.Size(35, 23);
            this.btnMinPlanning.TabIndex = 31;
            this.btnMinPlanning.Text = "- 5";
            this.btnMinPlanning.UseVisualStyleBackColor = true;
            this.btnMinPlanning.Click += new System.EventHandler(this.btnMinPlanning_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.Location = new System.Drawing.Point(222, 16);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(35, 23);
            this.btnPlanning.TabIndex = 29;
            this.btnPlanning.Text = "+ 5";
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Deskripsi";
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(116, 97);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(314, 88);
            this.tbDeskripsi.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Planning";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Development";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Design";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProgresContent
            // 
            this.dgvProgresContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgresContent.Location = new System.Drawing.Point(6, 239);
            this.dgvProgresContent.Name = "dgvProgresContent";
            this.dgvProgresContent.Size = new System.Drawing.Size(424, 139);
            this.dgvProgresContent.TabIndex = 23;
            this.dgvProgresContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgresContent_CellClick);
            // 
            // tbDevelopment
            // 
            this.tbDevelopment.Location = new System.Drawing.Point(152, 71);
            this.tbDevelopment.Name = "tbDevelopment";
            this.tbDevelopment.Size = new System.Drawing.Size(64, 20);
            this.tbDevelopment.TabIndex = 2;
            // 
            // tbDesign
            // 
            this.tbDesign.Location = new System.Drawing.Point(152, 45);
            this.tbDesign.Name = "tbDesign";
            this.tbDesign.Size = new System.Drawing.Size(64, 20);
            this.tbDesign.TabIndex = 1;
            // 
            // tbPlanning
            // 
            this.tbPlanning.Location = new System.Drawing.Point(152, 19);
            this.tbPlanning.Name = "tbPlanning";
            this.tbPlanning.Size = new System.Drawing.Size(64, 20);
            this.tbPlanning.TabIndex = 0;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label2);
            this.Name = "ContentForm";
            this.Text = "ContentForm";
            this.Load += new System.EventHandler(this.ContentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgresContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJenisKonten;
        private System.Windows.Forms.ComboBox cbProduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProgres;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMinDevelopment;
        private System.Windows.Forms.Button btnMinDesign;
        private System.Windows.Forms.Button btnPlusDevelopment;
        private System.Windows.Forms.Button btnPlusDesign;
        private System.Windows.Forms.Button btnMinPlanning;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProgresContent;
        private System.Windows.Forms.TextBox tbDevelopment;
        private System.Windows.Forms.TextBox tbDesign;
        private System.Windows.Forms.TextBox tbPlanning;
        private System.Windows.Forms.Button button1;
    }
}