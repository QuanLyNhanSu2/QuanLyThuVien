namespace Quanlythuvien.View
{
    partial class UCDocgia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbDocgia = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbGhichu = new System.Windows.Forms.RichTextBox();
            this.dtpNamsinh = new System.Windows.Forms.DateTimePicker();
            this.cmbHehoc = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTendocgia = new System.Windows.Forms.TextBox();
            this.txtMathe = new System.Windows.Forms.TextBox();
            this.btnThemHinhanh = new System.Windows.Forms.Button();
            this.pcbHinhanh = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSapxep = new System.Windows.Forms.ComboBox();
            this.btnLammoidanhsach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhanh)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(482, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý Độc giả";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(800, 34);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(204, 20);
            this.txtTimkiem.TabIndex = 5;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(1010, 31);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(76, 25);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbDocgia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 530);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Độc giả";
            // 
            // lsbDocgia
            // 
            this.lsbDocgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDocgia.Location = new System.Drawing.Point(3, 16);
            this.lsbDocgia.Name = "lsbDocgia";
            this.lsbDocgia.Size = new System.Drawing.Size(195, 511);
            this.lsbDocgia.TabIndex = 0;
            this.lsbDocgia.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNu);
            this.groupBox2.Controls.Add(this.rbNam);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThemmoi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rtbGhichu);
            this.groupBox2.Controls.Add(this.dtpNamsinh);
            this.groupBox2.Controls.Add(this.cmbHehoc);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.txtTendocgia);
            this.groupBox2.Controls.Add(this.txtMathe);
            this.groupBox2.Controls.Add(this.btnThemHinhanh);
            this.groupBox2.Controls.Add(this.pcbHinhanh);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(201, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin độc giả";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(287, 104);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 39;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(228, 104);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 39;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(809, 171);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(78, 25);
            this.btnLammoi.TabIndex = 13;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(725, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 25);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(641, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 25);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(557, 171);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(78, 25);
            this.btnThemmoi.TabIndex = 12;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(655, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Dịa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Năm sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tên độc giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Hệ học";
            // 
            // rtbGhichu
            // 
            this.rtbGhichu.Location = new System.Drawing.Point(708, 19);
            this.rtbGhichu.Name = "rtbGhichu";
            this.rtbGhichu.Size = new System.Drawing.Size(177, 99);
            this.rtbGhichu.TabIndex = 25;
            this.rtbGhichu.Text = "";
            // 
            // dtpNamsinh
            // 
            this.dtpNamsinh.Location = new System.Drawing.Point(463, 49);
            this.dtpNamsinh.Name = "dtpNamsinh";
            this.dtpNamsinh.Size = new System.Drawing.Size(183, 20);
            this.dtpNamsinh.TabIndex = 24;
            // 
            // cmbHehoc
            // 
            this.cmbHehoc.FormattingEnabled = true;
            this.cmbHehoc.Items.AddRange(new object[] {
            "Sinh viên Quân sự",
            "Sinh viên Dân sự",
            "Giảng viên"});
            this.cmbHehoc.Location = new System.Drawing.Point(228, 19);
            this.cmbHehoc.Name = "cmbHehoc";
            this.cmbHehoc.Size = new System.Drawing.Size(157, 21);
            this.cmbHehoc.TabIndex = 23;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(463, 75);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(183, 20);
            this.txtDiachi.TabIndex = 22;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(463, 20);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(183, 20);
            this.txtLop.TabIndex = 19;
            // 
            // txtTendocgia
            // 
            this.txtTendocgia.Location = new System.Drawing.Point(228, 75);
            this.txtTendocgia.Name = "txtTendocgia";
            this.txtTendocgia.Size = new System.Drawing.Size(157, 20);
            this.txtTendocgia.TabIndex = 18;
            // 
            // txtMathe
            // 
            this.txtMathe.Location = new System.Drawing.Point(228, 49);
            this.txtMathe.Name = "txtMathe";
            this.txtMathe.Size = new System.Drawing.Size(157, 20);
            this.txtMathe.TabIndex = 17;
            // 
            // btnThemHinhanh
            // 
            this.btnThemHinhanh.Location = new System.Drawing.Point(42, 171);
            this.btnThemHinhanh.Name = "btnThemHinhanh";
            this.btnThemHinhanh.Size = new System.Drawing.Size(78, 25);
            this.btnThemHinhanh.TabIndex = 11;
            this.btnThemHinhanh.Text = "Thêm";
            this.btnThemHinhanh.UseVisualStyleBackColor = true;
            // 
            // pcbHinhanh
            // 
            this.pcbHinhanh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcbHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbHinhanh.Location = new System.Drawing.Point(21, 19);
            this.pcbHinhanh.Name = "pcbHinhanh";
            this.pcbHinhanh.Size = new System.Drawing.Size(124, 146);
            this.pcbHinhanh.TabIndex = 8;
            this.pcbHinhanh.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmbSapxep);
            this.panel2.Controls.Add(this.btnLammoidanhsach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(201, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 50);
            this.panel2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Sắp xếp theo";
            // 
            // cmbSapxep
            // 
            this.cmbSapxep.FormattingEnabled = true;
            this.cmbSapxep.Items.AddRange(new object[] {
            "Hê học",
            "Mã thẻ",
            "Tên độc giả",
            "Giới tính"});
            this.cmbSapxep.Location = new System.Drawing.Point(86, 16);
            this.cmbSapxep.Name = "cmbSapxep";
            this.cmbSapxep.Size = new System.Drawing.Size(182, 21);
            this.cmbSapxep.TabIndex = 9;
            // 
            // btnLammoidanhsach
            // 
            this.btnLammoidanhsach.Location = new System.Drawing.Point(287, 13);
            this.btnLammoidanhsach.Name = "btnLammoidanhsach";
            this.btnLammoidanhsach.Size = new System.Drawing.Size(123, 25);
            this.btnLammoidanhsach.TabIndex = 8;
            this.btnLammoidanhsach.Text = "Làm mới danh sách";
            this.btnLammoidanhsach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhsach);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(201, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(899, 262);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Độc giả";
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsach.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.Size = new System.Drawing.Size(893, 243);
            this.dgvDanhsach.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Quanlythuvien.Properties.Resources.Actions_im_user_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(385, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UCDocgia";
            this.Size = new System.Drawing.Size(1100, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHinhanh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsbDocgia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbGhichu;
        private System.Windows.Forms.DateTimePicker dtpNamsinh;
        private System.Windows.Forms.ComboBox cmbHehoc;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTendocgia;
        private System.Windows.Forms.TextBox txtMathe;
        private System.Windows.Forms.Button btnThemHinhanh;
        private System.Windows.Forms.PictureBox pcbHinhanh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSapxep;
        private System.Windows.Forms.Button btnLammoidanhsach;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Button button1;
    }
}
