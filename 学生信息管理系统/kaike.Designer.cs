namespace WindowsFormsApp1
{
    partial class kaike
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxteacher = new System.Windows.Forms.TextBox();
            this.textBoxclass = new System.Windows.Forms.TextBox();
            this.comboBoxterm = new System.Windows.Forms.ComboBox();
            this.comboBoxdidian = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxtime = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(44, 30);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(70, 24);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "老师:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(478, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "上课地点:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(496, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "学期:";
            // 
            // textBoxteacher
            // 
            this.textBoxteacher.Location = new System.Drawing.Point(122, 30);
            this.textBoxteacher.Name = "textBoxteacher";
            this.textBoxteacher.Size = new System.Drawing.Size(199, 25);
            this.textBoxteacher.TabIndex = 4;
            // 
            // textBoxclass
            // 
            this.textBoxclass.Location = new System.Drawing.Point(599, 30);
            this.textBoxclass.Name = "textBoxclass";
            this.textBoxclass.Size = new System.Drawing.Size(199, 25);
            this.textBoxclass.TabIndex = 5;
            this.textBoxclass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxterm
            // 
            this.comboBoxterm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxterm.FormattingEnabled = true;
            this.comboBoxterm.Items.AddRange(new object[] {
            "2019年春季学期",
            "2019年秋季学期",
            "2020年春季学期",
            "2020年秋季学期"});
            this.comboBoxterm.Location = new System.Drawing.Point(122, 123);
            this.comboBoxterm.Name = "comboBoxterm";
            this.comboBoxterm.Size = new System.Drawing.Size(199, 23);
            this.comboBoxterm.TabIndex = 6;
            // 
            // comboBoxdidian
            // 
            this.comboBoxdidian.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxdidian.FormattingEnabled = true;
            this.comboBoxdidian.Items.AddRange(new object[] {
            "A101",
            "A102",
            "A103",
            "A104",
            "A105",
            "A201",
            "A202",
            "A203",
            "A204",
            "A205",
            "B101",
            "B102",
            "B103",
            "B104",
            "B105",
            "B201",
            "B202",
            "B203",
            "B204",
            "B205"});
            this.comboBoxdidian.Location = new System.Drawing.Point(609, 123);
            this.comboBoxdidian.Name = "comboBoxdidian";
            this.comboBoxdidian.Size = new System.Drawing.Size(189, 23);
            this.comboBoxdidian.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "上课时间:";
            // 
            // checkedListBoxtime
            // 
            this.checkedListBoxtime.FormattingEnabled = true;
            this.checkedListBoxtime.Items.AddRange(new object[] {
            "星期一第一节",
            "星期一第二节",
            "星期一第三节",
            "星期一第四节",
            "星期二第一节",
            "星期二第二节",
            "星期二第三节",
            "星期二第四节",
            "星期三第一节",
            "星期三第二节",
            "星期三第三节",
            "星期三第四节",
            "星期四第一节",
            "星期四第二节",
            "星期四第三节",
            "星期四第四节",
            "星期五第一节",
            "星期五第二节",
            "星期五第三节",
            "星期五第四节"});
            this.checkedListBoxtime.Location = new System.Drawing.Point(146, 205);
            this.checkedListBoxtime.Name = "checkedListBoxtime";
            this.checkedListBoxtime.Size = new System.Drawing.Size(175, 124);
            this.checkedListBoxtime.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(135, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "开设课程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(513, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kaike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxtime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxdidian);
            this.Controls.Add(this.comboBoxterm);
            this.Controls.Add(this.textBoxclass);
            this.Controls.Add(this.textBoxteacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "kaike";
            this.Text = "kaike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxteacher;
        private System.Windows.Forms.TextBox textBoxclass;
        private System.Windows.Forms.ComboBox comboBoxterm;
        private System.Windows.Forms.ComboBox comboBoxdidian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}