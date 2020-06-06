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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "选择课程":
                    chooseForm f1 = new chooseForm();
                    f1.TopLevel = false;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f1);
                    f1.Show();
                    break;
                case "查询课程":
                    searchclassForm f2 = new searchclassForm();
                    f2.TopLevel = false;
                    f2.FormBorderStyle = FormBorderStyle.None;
                    f2.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f2);
                    f2.Show();
                    break;
                case "关于":
                    about f3 = new about();
                    f3.TopLevel = false;
                    f3.FormBorderStyle = FormBorderStyle.None;
                    f3.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f3);
                    f3.Show();
                    break;
                case "显示课表":
                    showkebiaoForm f4 = new showkebiaoForm();
                    f4.TopLevel = false;
                    f4.FormBorderStyle = FormBorderStyle.None;
                    f4.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f4);
                    f4.Show();
                    break;
                case "退出系统":
                    Application.Exit();
                    break;

            }
        }
    }
}
