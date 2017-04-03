namespace Quanlythuvien.View
{
    partial class Main
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblHuongdan = new System.Windows.Forms.Label();
            this.lblDocgia = new System.Windows.Forms.Label();
            this.lblSach = new System.Windows.Forms.Label();
            this.lblMuonTra = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnDocgia = new System.Windows.Forms.Button();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem1.Text = "Về trang chủ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItem2.Text = "<";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItem3.Text = ">";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.lblHuongdan);
            this.pnlMain.Controls.Add(this.lblDocgia);
            this.pnlMain.Controls.Add(this.lblSach);
            this.pnlMain.Controls.Add(this.lblMuonTra);
            this.pnlMain.Controls.Add(this.btnDocgia);
            this.pnlMain.Controls.Add(this.btnHuongdan);
            this.pnlMain.Controls.Add(this.btnMuonTra);
            this.pnlMain.Controls.Add(this.btnSach);
            this.pnlMain.Controls.Add(this.lblMenu);
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1134, 554);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lblHuongdan
            // 
            this.lblHuongdan.AutoSize = true;
            this.lblHuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongdan.Location = new System.Drawing.Point(655, 415);
            this.lblHuongdan.Name = "lblHuongdan";
            this.lblHuongdan.Size = new System.Drawing.Size(88, 20);
            this.lblHuongdan.TabIndex = 13;
            this.lblHuongdan.Text = "Hướng dẫn";
            // 
            // lblDocgia
            // 
            this.lblDocgia.AutoSize = true;
            this.lblDocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocgia.Location = new System.Drawing.Point(667, 253);
            this.lblDocgia.Name = "lblDocgia";
            this.lblDocgia.Size = new System.Drawing.Size(63, 20);
            this.lblDocgia.TabIndex = 14;
            this.lblDocgia.Text = "Độc giả";
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSach.Location = new System.Drawing.Point(414, 253);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(46, 20);
            this.lblSach.TabIndex = 15;
            this.lblSach.Text = "Sách";
            // 
            // lblMuonTra
            // 
            this.lblMuonTra.AutoSize = true;
            this.lblMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuonTra.Location = new System.Drawing.Point(375, 415);
            this.lblMuonTra.Name = "lblMuonTra";
            this.lblMuonTra.Size = new System.Drawing.Size(123, 20);
            this.lblMuonTra.TabIndex = 16;
            this.lblMuonTra.Text = "Mượn - Trả sách";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMenu.Location = new System.Drawing.Point(356, 45);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(417, 32);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Chương trình quản lý thư viện";
            // 
            // btnDocgia
            // 
            this.btnDocgia.BackgroundImage = global::Quanlythuvien.Properties.Resources.Actions_im_user_icon;
            this.btnDocgia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDocgia.Location = new System.Drawing.Point(620, 123);
            this.btnDocgia.Name = "btnDocgia";
            this.btnDocgia.Size = new System.Drawing.Size(153, 127);
            this.btnDocgia.TabIndex = 9;
            this.btnDocgia.UseVisualStyleBackColor = true;
            this.btnDocgia.Click += new System.EventHandler(this.btnDocgia_Click);
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.BackgroundImage = global::Quanlythuvien.Properties.Resources._1403214593_Symbol_Information;
            this.btnHuongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuongdan.Location = new System.Drawing.Point(620, 285);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(153, 127);
            this.btnHuongdan.TabIndex = 10;
            this.btnHuongdan.UseVisualStyleBackColor = true;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackgroundImage = global::Quanlythuvien.Properties.Resources.acces_cont;
            this.btnMuonTra.Location = new System.Drawing.Point(359, 285);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(153, 127);
            this.btnMuonTra.TabIndex = 11;
            this.btnMuonTra.UseVisualStyleBackColor = true;
            // 
            // btnSach
            // 
            this.btnSach.BackgroundImage = global::Quanlythuvien.Properties.Resources.book_library;
            this.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSach.Location = new System.Drawing.Point(359, 123);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(153, 127);
            this.btnSach.TabIndex = 12;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 581);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.Name = "Main";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblHuongdan;
        private System.Windows.Forms.Label lblDocgia;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblMuonTra;
        private System.Windows.Forms.Button btnDocgia;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}