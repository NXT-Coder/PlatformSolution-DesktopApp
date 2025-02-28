namespace PlatformImpact2
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smPlatform = new System.Windows.Forms.ToolStripMenuItem();
            this.smKontenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.smProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTakedown = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smAddProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smPlatform,
            this.smKontenProject,
            this.smProduct,
            this.smAddProducer,
            this.msLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smPlatform
            // 
            this.smPlatform.Name = "smPlatform";
            this.smPlatform.Size = new System.Drawing.Size(78, 20);
            this.smPlatform.Text = "PLATFROM";
            this.smPlatform.Click += new System.EventHandler(this.smPlatform_Click);
            // 
            // smKontenProject
            // 
            this.smKontenProject.Name = "smKontenProject";
            this.smKontenProject.Size = new System.Drawing.Size(114, 20);
            this.smKontenProject.Text = "KONTEN PROJECT";
            this.smKontenProject.Click += new System.EventHandler(this.smKontenProject_Click);
            // 
            // smProduct
            // 
            this.smProduct.Name = "smProduct";
            this.smProduct.Size = new System.Drawing.Size(72, 20);
            this.smProduct.Text = "PRODUCT";
            this.smProduct.Click += new System.EventHandler(this.smProduct_Click);
            // 
            // btnTakedown
            // 
            this.btnTakedown.Location = new System.Drawing.Point(557, 314);
            this.btnTakedown.Name = "btnTakedown";
            this.btnTakedown.Size = new System.Drawing.Size(75, 23);
            this.btnTakedown.TabIndex = 5;
            this.btnTakedown.Text = "TAKEDOWN";
            this.btnTakedown.UseVisualStyleBackColor = true;
            this.btnTakedown.Click += new System.EventHandler(this.btnTakedown_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // smAddProducer
            // 
            this.smAddProducer.Name = "smAddProducer";
            this.smAddProducer.Size = new System.Drawing.Size(106, 20);
            this.smAddProducer.Text = "ADD PRODUCER";
            this.smAddProducer.Click += new System.EventHandler(this.smAddProducer_Click);
            // 
            // msLogout
            // 
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(65, 20);
            this.msLogout.Text = "LOGOUT";
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTakedown);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smPlatform;
        private System.Windows.Forms.ToolStripMenuItem smKontenProject;
        private System.Windows.Forms.ToolStripMenuItem smProduct;
        private System.Windows.Forms.Button btnTakedown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem smAddProducer;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.Button button1;
    }
}