namespace trachnghiemTF
{
    partial class excel_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_cauhoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_socaudung = new System.Windows.Forms.Label();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbb_choose = new System.Windows.Forms.ComboBox();
            this.cbb_sheet = new System.Windows.Forms.ComboBox();
            this.bt_thulai = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_excel = new System.Windows.Forms.Button();
            this.bt_thithu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_thoigianlam = new System.Windows.Forms.TextBox();
            this.tb_soluongcau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(775, 214);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(828, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(881, 214);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 648);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(775, 214);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(828, 648);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(881, 214);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_cauhoi
            // 
            this.lb_cauhoi.AutoSize = true;
            this.lb_cauhoi.Location = new System.Drawing.Point(763, 169);
            this.lb_cauhoi.Name = "lb_cauhoi";
            this.lb_cauhoi.Size = new System.Drawing.Size(99, 29);
            this.lb_cauhoi.TabIndex = 4;
            this.lb_cauhoi.Text = "Câu Hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1276, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số câu đúng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1276, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian";
            // 
            // lb_socaudung
            // 
            this.lb_socaudung.AutoSize = true;
            this.lb_socaudung.Location = new System.Drawing.Point(1457, 76);
            this.lb_socaudung.Name = "lb_socaudung";
            this.lb_socaudung.Size = new System.Drawing.Size(0, 29);
            this.lb_socaudung.TabIndex = 7;
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.Location = new System.Drawing.Point(1457, 169);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(0, 29);
            this.lb_thoigian.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // cbb_choose
            // 
            this.cbb_choose.FormattingEnabled = true;
            this.cbb_choose.Location = new System.Drawing.Point(243, 25);
            this.cbb_choose.Name = "cbb_choose";
            this.cbb_choose.Size = new System.Drawing.Size(390, 37);
            this.cbb_choose.TabIndex = 9;
            this.cbb_choose.SelectedValueChanged += new System.EventHandler(this.cbb_choose_SelectedValueChanged);
            // 
            // cbb_sheet
            // 
            this.cbb_sheet.FormattingEnabled = true;
            this.cbb_sheet.Location = new System.Drawing.Point(768, 25);
            this.cbb_sheet.Name = "cbb_sheet";
            this.cbb_sheet.Size = new System.Drawing.Size(390, 37);
            this.cbb_sheet.TabIndex = 10;
            this.cbb_sheet.SelectedValueChanged += new System.EventHandler(this.cbb_sheet_SelectedValueChanged);
            // 
            // bt_thulai
            // 
            this.bt_thulai.Location = new System.Drawing.Point(64, 104);
            this.bt_thulai.Name = "bt_thulai";
            this.bt_thulai.Size = new System.Drawing.Size(134, 59);
            this.bt_thulai.TabIndex = 12;
            this.bt_thulai.Text = "Thử lại";
            this.bt_thulai.UseVisualStyleBackColor = true;
            this.bt_thulai.Click += new System.EventHandler(this.bt_thulai_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(64, 199);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(134, 59);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_excel
            // 
            this.bt_excel.Location = new System.Drawing.Point(255, 104);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(134, 59);
            this.bt_excel.TabIndex = 14;
            this.bt_excel.Text = "Bộ từ vựng";
            this.bt_excel.UseVisualStyleBackColor = true;
            // 
            // bt_thithu
            // 
            this.bt_thithu.Location = new System.Drawing.Point(255, 199);
            this.bt_thithu.Name = "bt_thithu";
            this.bt_thithu.Size = new System.Drawing.Size(134, 59);
            this.bt_thithu.TabIndex = 15;
            this.bt_thithu.Text = "Thi thử";
            this.bt_thithu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_ok);
            this.groupBox1.Controls.Add(this.tb_thoigianlam);
            this.groupBox1.Controls.Add(this.tb_soluongcau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(531, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(582, 43);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(114, 61);
            this.bt_ok.TabIndex = 4;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_thoigianlam
            // 
            this.tb_thoigianlam.Location = new System.Drawing.Point(323, 69);
            this.tb_thoigianlam.Name = "tb_thoigianlam";
            this.tb_thoigianlam.Size = new System.Drawing.Size(202, 35);
            this.tb_thoigianlam.TabIndex = 3;
            // 
            // tb_soluongcau
            // 
            this.tb_soluongcau.Location = new System.Drawing.Point(37, 69);
            this.tb_soluongcau.Name = "tb_soluongcau";
            this.tb_soluongcau.Size = new System.Drawing.Size(202, 35);
            this.tb_soluongcau.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "thời gian làm mỗi câu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "số lượng câu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1258, 148);
            this.textBox1.TabIndex = 17;
            // 
            // excel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 945);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_thithu);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_thulai);
            this.Controls.Add(this.cbb_sheet);
            this.Controls.Add(this.cbb_choose);
            this.Controls.Add(this.lb_thoigian);
            this.Controls.Add(this.lb_socaudung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_cauhoi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "excel_form";
            this.Text = "From Excel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_cauhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_socaudung;
        private System.Windows.Forms.Label lb_thoigian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbb_choose;
        private System.Windows.Forms.ComboBox cbb_sheet;
        private System.Windows.Forms.Button bt_thulai;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_excel;
        private System.Windows.Forms.Button bt_thithu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_thoigianlam;
        private System.Windows.Forms.TextBox tb_soluongcau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}