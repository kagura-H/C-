using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)//在文本框中的节点选择做判断
            {
                case "添加管理员信息":
                    addmanFrom f1 = new addmanFrom();
                    f1.TopLevel = false;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f1);
                    f1.Show();
                    break;
                case "修改管理员信息":
                    modifymanForm f2 = new modifymanForm();
                    f2.TopLevel = false;
                    f2.FormBorderStyle = FormBorderStyle.None;
                    f2.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f2);
                    f2.Show();
                    break;
                case "退出系统":
                    Application.Exit();
                    break;
                case "开设课程":
                    kaike f3 = new kaike();
                    f3.TopLevel = false;
                    f3.FormBorderStyle = FormBorderStyle.None;
                    f3.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f3);
                    f3.Show();
                    break;
                case "查询课程":
                    searchclass f4 = new searchclass();
                    f4.TopLevel = false;
                    f4.FormBorderStyle = FormBorderStyle.None;
                    f4.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f4);
                    f4.Show();
                    break;
                case "添加学生信息":
                    addstu f5 = new addstu();
                    f5.TopLevel = false;
                    f5.FormBorderStyle = FormBorderStyle.None;
                    f5.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f5);
                    f5.Show();
                    break;
                case "修改学生信息":
                    modifystu f6 = new modifystu();
                    f6.TopLevel = false;
                    f6.FormBorderStyle = FormBorderStyle.None;
                    f6.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f6);
                    f6.Show();
                    break;
                case "关于":
                    about f7 = new about();
                    f7.TopLevel = false;
                    f7.FormBorderStyle = FormBorderStyle.None;
                    f7.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f7);
                    f7.Show();
                    break;

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
    }
