namespace WindowsFormsApp2
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
            this.txtDoAm = new System.Windows.Forms.TextBox();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(85, 384);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 31);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(166, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(409, 384);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 31);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 384);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(328, 384);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhuVuc,
            this.Gio,
            this.NhietDo,
            this.DoAm});
            this.dataGridView1.Location = new System.Drawing.Point(1, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 208);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(166, 13);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(100, 20);
            this.txtGio.TabIndex = 6;
            this.txtGio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.Location = new System.Drawing.Point(166, 52);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhuVuc.TabIndex = 7;
            // 
            // txtDoAm
            // 
            this.txtDoAm.Location = new System.Drawing.Point(438, 52);
            this.txtDoAm.Name = "txtDoAm";
            this.txtDoAm.Size = new System.Drawing.Size(100, 20);
            this.txtDoAm.TabIndex = 8;
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(438, 12);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(100, 20);
            this.txtNhietDo.TabIndex = 9;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(104, 18);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(23, 13);
            this.txt.TabIndex = 10;
            this.txt.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhiệt độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Độ ẩm";
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "MaKhuVuc";
            this.MaKhuVuc.HeaderText = "Mã kv";
            this.MaKhuVuc.Name = "MaKhuVuc";
            // 
            // Gio
            // 
            this.Gio.DataPropertyName = "Gio";
            this.Gio.HeaderText = "Giờ";
            this.Gio.Name = "Gio";
            // 
            // NhietDo
            // 
            this.NhietDo.DataPropertyName = "NhietDo";
            this.NhietDo.HeaderText = "Nhiệt độ";
            this.NhietDo.Name = "NhietDo";
            // 
            // DoAm
            // 
            this.DoAm.DataPropertyName = "DoAm";
            this.DoAm.HeaderText = "Độ ẩm";
            this.DoAm.Name = "DoAm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.txtDoAm);
            this.Controls.Add(this.txtMaKhuVuc);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.TextBox txtMaKhuVuc;
        private System.Windows.Forms.TextBox txtDoAm;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoAm;
    }
}