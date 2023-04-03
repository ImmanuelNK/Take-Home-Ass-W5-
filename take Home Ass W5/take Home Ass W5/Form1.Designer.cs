namespace take_Home_Ass_W5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_judul = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_cty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ctydet = new System.Windows.Forms.Label();
            this.label_nmdet = new System.Windows.Forms.Label();
            this.label_hgdet = new System.Windows.Forms.Label();
            this.label_stcdet = new System.Windows.Forms.Label();
            this.textBox_namadet = new System.Windows.Forms.TextBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.comboBox_categ = new System.Windows.Forms.ComboBox();
            this.button_all = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_namacty = new System.Windows.Forms.Label();
            this.button_addcty = new System.Windows.Forms.Button();
            this.button_rmvcty = new System.Windows.Forms.Button();
            this.textBox_namacat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(50, 37);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(74, 16);
            this.label_judul.TabIndex = 0;
            this.label_judul.Text = "PRODUCT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 252);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(647, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(304, 224);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label_cty
            // 
            this.label_cty.AutoSize = true;
            this.label_cty.Location = new System.Drawing.Point(644, 37);
            this.label_cty.Name = "label_cty";
            this.label_cty.Size = new System.Drawing.Size(82, 16);
            this.label_cty.TabIndex = 3;
            this.label_cty.Text = "CATEGORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DETAIL";
            // 
            // label_ctydet
            // 
            this.label_ctydet.AutoSize = true;
            this.label_ctydet.Location = new System.Drawing.Point(33, 432);
            this.label_ctydet.Name = "label_ctydet";
            this.label_ctydet.Size = new System.Drawing.Size(65, 16);
            this.label_ctydet.TabIndex = 5;
            this.label_ctydet.Text = "Category:";
            // 
            // label_nmdet
            // 
            this.label_nmdet.AutoSize = true;
            this.label_nmdet.Location = new System.Drawing.Point(50, 399);
            this.label_nmdet.Name = "label_nmdet";
            this.label_nmdet.Size = new System.Drawing.Size(47, 16);
            this.label_nmdet.TabIndex = 5;
            this.label_nmdet.Text = "Nama:";
            // 
            // label_hgdet
            // 
            this.label_hgdet.AutoSize = true;
            this.label_hgdet.Location = new System.Drawing.Point(50, 467);
            this.label_hgdet.Name = "label_hgdet";
            this.label_hgdet.Size = new System.Drawing.Size(48, 16);
            this.label_hgdet.TabIndex = 6;
            this.label_hgdet.Text = "Harga:";
            // 
            // label_stcdet
            // 
            this.label_stcdet.AutoSize = true;
            this.label_stcdet.Location = new System.Drawing.Point(54, 498);
            this.label_stcdet.Name = "label_stcdet";
            this.label_stcdet.Size = new System.Drawing.Size(44, 16);
            this.label_stcdet.TabIndex = 7;
            this.label_stcdet.Text = "Stock:";
            // 
            // textBox_namadet
            // 
            this.textBox_namadet.Location = new System.Drawing.Point(112, 396);
            this.textBox_namadet.Name = "textBox_namadet";
            this.textBox_namadet.Size = new System.Drawing.Size(405, 22);
            this.textBox_namadet.TabIndex = 8;
            this.textBox_namadet.Text = " ";
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(112, 464);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(148, 22);
            this.textBox_harga.TabIndex = 9;
            this.textBox_harga.Text = " ";
            this.textBox_harga.TextChanged += new System.EventHandler(this.textBox_harga_TextChanged);
            this.textBox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_harga_KeyPress);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(112, 495);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(148, 22);
            this.textBox_stock.TabIndex = 10;
            this.textBox_stock.Text = " ";
            this.textBox_stock.TextChanged += new System.EventHandler(this.textBox_stock_TextChanged);
            this.textBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stock_KeyPress);
            // 
            // comboBox_categ
            // 
            this.comboBox_categ.FormattingEnabled = true;
            this.comboBox_categ.Location = new System.Drawing.Point(112, 429);
            this.comboBox_categ.Name = "comboBox_categ";
            this.comboBox_categ.Size = new System.Drawing.Size(148, 24);
            this.comboBox_categ.TabIndex = 11;
            this.comboBox_categ.SelectedIndexChanged += new System.EventHandler(this.comboBox_categ_SelectedIndexChanged);
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(283, 37);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(44, 23);
            this.button_all.TabIndex = 12;
            this.button_all.Text = "All";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(333, 37);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(49, 23);
            this.button_filter.TabIndex = 13;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.Enabled = false;
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(408, 37);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(109, 24);
            this.comboBox_filter.TabIndex = 14;
            this.comboBox_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(266, 452);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 47);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Add Product";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(425, 452);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(73, 47);
            this.button_remove.TabIndex = 16;
            this.button_remove.Text = "Remove Product";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(354, 452);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(72, 47);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Edit Product";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_namacty
            // 
            this.label_namacty.AutoSize = true;
            this.label_namacty.Location = new System.Drawing.Point(641, 302);
            this.label_namacty.Name = "label_namacty";
            this.label_namacty.Size = new System.Drawing.Size(47, 16);
            this.label_namacty.TabIndex = 18;
            this.label_namacty.Text = "Nama:";
            // 
            // button_addcty
            // 
            this.button_addcty.Location = new System.Drawing.Point(716, 324);
            this.button_addcty.Name = "button_addcty";
            this.button_addcty.Size = new System.Drawing.Size(73, 47);
            this.button_addcty.TabIndex = 20;
            this.button_addcty.Text = "Add Product";
            this.button_addcty.UseVisualStyleBackColor = true;
            this.button_addcty.Click += new System.EventHandler(this.button_addcty_Click);
            // 
            // button_rmvcty
            // 
            this.button_rmvcty.Location = new System.Drawing.Point(795, 324);
            this.button_rmvcty.Name = "button_rmvcty";
            this.button_rmvcty.Size = new System.Drawing.Size(76, 47);
            this.button_rmvcty.TabIndex = 21;
            this.button_rmvcty.Text = "Remove Category";
            this.button_rmvcty.UseVisualStyleBackColor = true;
            this.button_rmvcty.Click += new System.EventHandler(this.button_rmvcty_Click);
            // 
            // textBox_namacat
            // 
            this.textBox_namacat.Location = new System.Drawing.Point(694, 296);
            this.textBox_namacat.Name = "textBox_namacat";
            this.textBox_namacat.Size = new System.Drawing.Size(243, 22);
            this.textBox_namacat.TabIndex = 23;
            this.textBox_namacat.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 291);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 549);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_namacat);
            this.Controls.Add(this.button_rmvcty);
            this.Controls.Add(this.button_addcty);
            this.Controls.Add(this.label_namacty);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.comboBox_categ);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.textBox_namadet);
            this.Controls.Add(this.label_stcdet);
            this.Controls.Add(this.label_hgdet);
            this.Controls.Add(this.label_nmdet);
            this.Controls.Add(this.label_ctydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_cty);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_judul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_cty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ctydet;
        private System.Windows.Forms.Label label_nmdet;
        private System.Windows.Forms.Label label_hgdet;
        private System.Windows.Forms.Label label_stcdet;
        private System.Windows.Forms.TextBox textBox_namadet;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.ComboBox comboBox_categ;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label_namacty;
        private System.Windows.Forms.Button button_addcty;
        private System.Windows.Forms.Button button_rmvcty;
        private System.Windows.Forms.TextBox textBox_namacat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

