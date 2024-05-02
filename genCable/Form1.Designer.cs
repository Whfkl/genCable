namespace genCable
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_line_num = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_select_line = new System.Windows.Forms.Button();
            this.tbCadPy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCadPx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFlacPz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFlacPx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_segments = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_flow = new System.Windows.Forms.RichTextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_dis = new System.Windows.Forms.TextBox();
            this.tb_group = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.combo_unit = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Developed by WJX";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(159, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "力学与土木工程学院";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "AutoCAD参考点";
            this.toolTip1.SetToolTip(this.label2, "CAD中参考点的坐标");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "FLAC3D参考点";
            this.toolTip1.SetToolTip(this.label1, "FLAC3D中参考点的坐标");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "单位换算";
            this.toolTip1.SetToolTip(this.label5, "若CAD中单位为mm，请设置为1000");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "段数划分";
            this.toolTip1.SetToolTip(this.label6, "segments参数");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "组名设定";
            this.toolTip1.SetToolTip(this.label8, "group参数");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "锚杆排距";
            this.toolTip1.SetToolTip(this.label13, "单位（mm）");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_line_num);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_select_line);
            this.panel1.Controls.Add(this.tbCadPy);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbCadPx);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbFlacPz);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbFlacPx);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 106);
            this.panel1.TabIndex = 4;
            // 
            // label_line_num
            // 
            this.label_line_num.AutoSize = true;
            this.label_line_num.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_line_num.Location = new System.Drawing.Point(338, 74);
            this.label_line_num.Name = "label_line_num";
            this.label_line_num.Size = new System.Drawing.Size(80, 20);
            this.label_line_num.TabIndex = 9;
            this.label_line_num.Text = "0 selected";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 58);
            this.button3.TabIndex = 12;
            this.button3.Text = "点选";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_select_line
            // 
            this.btn_select_line.Location = new System.Drawing.Point(336, 14);
            this.btn_select_line.Name = "btn_select_line";
            this.btn_select_line.Size = new System.Drawing.Size(82, 48);
            this.btn_select_line.TabIndex = 0;
            this.btn_select_line.Text = "选取线段";
            this.btn_select_line.UseVisualStyleBackColor = true;
            this.btn_select_line.Click += new System.EventHandler(this.btn_select_line_Click);
            // 
            // tbCadPy
            // 
            this.tbCadPy.Location = new System.Drawing.Point(216, 69);
            this.tbCadPy.Name = "tbCadPy";
            this.tbCadPy.Size = new System.Drawing.Size(70, 25);
            this.tbCadPy.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(193, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Y";
            // 
            // tbCadPx
            // 
            this.tbCadPx.Location = new System.Drawing.Point(216, 43);
            this.tbCadPx.Name = "tbCadPx";
            this.tbCadPx.Size = new System.Drawing.Size(70, 25);
            this.tbCadPx.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(193, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "X";
            // 
            // tbFlacPz
            // 
            this.tbFlacPz.Location = new System.Drawing.Point(33, 69);
            this.tbFlacPz.Name = "tbFlacPz";
            this.tbFlacPz.Size = new System.Drawing.Size(70, 25);
            this.tbFlacPz.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Z";
            // 
            // tbFlacPx
            // 
            this.tbFlacPx.Location = new System.Drawing.Point(33, 43);
            this.tbFlacPx.Name = "tbFlacPx";
            this.tbFlacPx.Size = new System.Drawing.Size(70, 25);
            this.tbFlacPx.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(10, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.combo_unit);
            this.panel2.Controls.Add(this.tb_segments);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 75);
            this.panel2.TabIndex = 5;
            // 
            // tb_segments
            // 
            this.tb_segments.Location = new System.Drawing.Point(97, 43);
            this.tb_segments.Name = "tb_segments";
            this.tb_segments.Size = new System.Drawing.Size(113, 25);
            this.tb_segments.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_flow);
            this.panel3.Location = new System.Drawing.Point(12, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 170);
            this.panel3.TabIndex = 6;
            // 
            // tb_flow
            // 
            this.tb_flow.Location = new System.Drawing.Point(-1, -1);
            this.tb_flow.Name = "tb_flow";
            this.tb_flow.Size = new System.Drawing.Size(482, 170);
            this.tb_flow.TabIndex = 0;
            this.tb_flow.Text = "";
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(12, 205);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(75, 51);
            this.btn_gen.TabIndex = 7;
            this.btn_gen.Text = "生成";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tb_dis);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.tb_group);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(243, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 75);
            this.panel4.TabIndex = 6;
            // 
            // tb_dis
            // 
            this.tb_dis.Location = new System.Drawing.Point(117, 43);
            this.tb_dis.Name = "tb_dis";
            this.tb_dis.Size = new System.Drawing.Size(101, 25);
            this.tb_dis.TabIndex = 16;
            // 
            // tb_group
            // 
            this.tb_group.Location = new System.Drawing.Point(117, 12);
            this.tb_group.Name = "tb_group";
            this.tb_group.Size = new System.Drawing.Size(101, 25);
            this.tb_group.TabIndex = 15;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(105, 205);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 51);
            this.btn_copy.TabIndex = 8;
            this.btn_copy.Text = "复制";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // combo_unit
            // 
            this.combo_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_unit.FormattingEnabled = true;
            this.combo_unit.Items.AddRange(new object[] {
            "1:1000",
            "1:1"});
            this.combo_unit.Location = new System.Drawing.Point(97, 8);
            this.combo_unit.Name = "combo_unit";
            this.combo_unit.Size = new System.Drawing.Size(113, 23);
            this.combo_unit.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 503);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "genCable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCadPy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCadPx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFlacPz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFlacPx;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_line_num;
        private System.Windows.Forms.Button btn_select_line;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_segments;
        private System.Windows.Forms.TextBox tb_dis;
        private System.Windows.Forms.TextBox tb_group;
        private System.Windows.Forms.RichTextBox tb_flow;
        private System.Windows.Forms.ComboBox combo_unit;
    }
}