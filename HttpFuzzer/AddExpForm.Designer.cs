﻿namespace LoveCoody
{
    partial class AddExpForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CalcComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VerificationValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VerificationComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LanguafeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RequestMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EncodeComBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormatUrlComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BodyTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HeaderListview = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.清空参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.HeaderMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 325);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "漏洞模块配置";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Location = new System.Drawing.Point(444, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 50);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "操作";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CalcComboBox);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.VerificationValueTextBox);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.VerificationComboBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(444, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 120);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "结果验证配置";
            // 
            // CalcComboBox
            // 
            this.CalcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalcComboBox.FormattingEnabled = true;
            this.CalcComboBox.Items.AddRange(new object[] {
            "等于",
            "包含",
            "匹配"});
            this.CalcComboBox.Location = new System.Drawing.Point(85, 59);
            this.CalcComboBox.Name = "CalcComboBox";
            this.CalcComboBox.Size = new System.Drawing.Size(124, 20);
            this.CalcComboBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "计算符号：";
            // 
            // VerificationValueTextBox
            // 
            this.VerificationValueTextBox.Location = new System.Drawing.Point(85, 89);
            this.VerificationValueTextBox.Name = "VerificationValueTextBox";
            this.VerificationValueTextBox.Size = new System.Drawing.Size(124, 21);
            this.VerificationValueTextBox.TabIndex = 22;
            this.VerificationValueTextBox.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "验证内容：";
            // 
            // VerificationComboBox
            // 
            this.VerificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerificationComboBox.FormattingEnabled = true;
            this.VerificationComboBox.Items.AddRange(new object[] {
            "响应码",
            "响应内容",
            "新文件"});
            this.VerificationComboBox.Location = new System.Drawing.Point(85, 29);
            this.VerificationComboBox.Name = "VerificationComboBox";
            this.VerificationComboBox.Size = new System.Drawing.Size(124, 20);
            this.VerificationComboBox.TabIndex = 20;
            this.VerificationComboBox.SelectedIndexChanged += new System.EventHandler(this.VerificationComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "验证方式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpStatusComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LanguafeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExpNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(444, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本设置";
            // 
            // ExpStatusComboBox
            // 
            this.ExpStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpStatusComboBox.FormattingEnabled = true;
            this.ExpStatusComboBox.Items.AddRange(new object[] {
            "启用",
            "不启用"});
            this.ExpStatusComboBox.Location = new System.Drawing.Point(85, 89);
            this.ExpStatusComboBox.Name = "ExpStatusComboBox";
            this.ExpStatusComboBox.Size = new System.Drawing.Size(124, 20);
            this.ExpStatusComboBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "启用状态：";
            // 
            // LanguafeComboBox
            // 
            this.LanguafeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguafeComboBox.FormattingEnabled = true;
            this.LanguafeComboBox.Items.AddRange(new object[] {
            "全部",
            "ASP",
            "ASP.NET",
            "JAVA",
            "PERL",
            "PHP",
            "PYTHON",
            "RUBY"});
            this.LanguafeComboBox.Location = new System.Drawing.Point(85, 57);
            this.LanguafeComboBox.Name = "LanguafeComboBox";
            this.LanguafeComboBox.Size = new System.Drawing.Size(124, 20);
            this.LanguafeComboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "适用语言：";
            // 
            // ExpNameTextBox
            // 
            this.ExpNameTextBox.Location = new System.Drawing.Point(85, 22);
            this.ExpNameTextBox.Name = "ExpNameTextBox";
            this.ExpNameTextBox.Size = new System.Drawing.Size(124, 21);
            this.ExpNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "漏洞名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RequestMethodComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.EncodeComBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FormatUrlComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTP设置";
            // 
            // RequestMethodComboBox
            // 
            this.RequestMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestMethodComboBox.FormattingEnabled = true;
            this.RequestMethodComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "HEAD"});
            this.RequestMethodComboBox.Location = new System.Drawing.Point(210, 269);
            this.RequestMethodComboBox.Name = "RequestMethodComboBox";
            this.RequestMethodComboBox.Size = new System.Drawing.Size(68, 20);
            this.RequestMethodComboBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "请求方式：";
            // 
            // EncodeComBox
            // 
            this.EncodeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodeComBox.FormattingEnabled = true;
            this.EncodeComBox.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.EncodeComBox.Location = new System.Drawing.Point(355, 269);
            this.EncodeComBox.Name = "EncodeComBox";
            this.EncodeComBox.Size = new System.Drawing.Size(68, 20);
            this.EncodeComBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "编码格式：";
            // 
            // FormatUrlComboBox
            // 
            this.FormatUrlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatUrlComboBox.FormattingEnabled = true;
            this.FormatUrlComboBox.Items.AddRange(new object[] {
            "否",
            "是"});
            this.FormatUrlComboBox.Location = new System.Drawing.Point(87, 269);
            this.FormatUrlComboBox.Name = "FormatUrlComboBox";
            this.FormatUrlComboBox.Size = new System.Drawing.Size(50, 20);
            this.FormatUrlComboBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "格式化网址：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BodyTextBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 116);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Head请求Body配置(支持HEX-UTF8)";
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyTextBox.Location = new System.Drawing.Point(3, 17);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BodyTextBox.Size = new System.Drawing.Size(414, 96);
            this.BodyTextBox.TabIndex = 0;
            this.BodyTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HeaderListview);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 120);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Head头部配置";
            // 
            // HeaderListview
            // 
            this.HeaderListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.HeaderListview.ContextMenuStrip = this.HeaderMenuStrip;
            this.HeaderListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderListview.FullRowSelect = true;
            this.HeaderListview.GridLines = true;
            this.HeaderListview.Location = new System.Drawing.Point(3, 17);
            this.HeaderListview.Name = "HeaderListview";
            this.HeaderListview.Size = new System.Drawing.Size(414, 100);
            this.HeaderListview.TabIndex = 7;
            this.HeaderListview.UseCompatibleStateImageBehavior = false;
            this.HeaderListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "参数名";
            this.columnHeader13.Width = 160;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "参数值";
            this.columnHeader14.Width = 230;
            // 
            // HeaderMenuStrip
            // 
            this.HeaderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.清空参数ToolStripMenuItem});
            this.HeaderMenuStrip.Name = "contextMenuStrip1";
            this.HeaderMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "添加参数";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "修改参数";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "删除参数";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 清空参数ToolStripMenuItem
            // 
            this.清空参数ToolStripMenuItem.Name = "清空参数ToolStripMenuItem";
            this.清空参数ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空参数ToolStripMenuItem.Text = "清空参数";
            this.清空参数ToolStripMenuItem.Click += new System.EventHandler(this.清空参数ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddExpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 332);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 371);
            this.Name = "AddExpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加漏洞模块";
            this.Load += new System.EventHandler(this.AddExpForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.HeaderMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ExpStatusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LanguafeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView HeaderListview;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox VerificationComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox VerificationValueTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox EncodeComBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FormatUrlComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RequestMethodComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip HeaderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 清空参数ToolStripMenuItem;
        private System.Windows.Forms.ComboBox CalcComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox BodyTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}