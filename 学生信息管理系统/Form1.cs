using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Data Source=.;Initial Catalog=学生;Integrated Security=True";
        public static string name;
        public static string role;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        public static String getStudent()
        {
            String stuxuehao = "";
            stuxuehao = Form1.name;
            return stuxuehao;
        }

        public static String getRole()
        {
            String role1 = "";
            role1 = Form1.role;
            return role1;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            name = textBox1.Text.Trim();//获取文本框数值
            role = this.comboBox1.SelectedItem.ToString();//对选择框进行设置 未选报错
            if (name == "" || textBox2.Text.Trim() == "" || role == "")//数值为空跳出提示
            {
                MessageBox.Show("请将信息输入完整！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Form1.connectionString);//创建对象
                conn.Open();//打开数据库
                if (role == "管理员")
                {
                    string sql = "select manname,manpasswd from manager where role='管理员'and manname='" + name +
                     "' and manpasswd='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);//数据库命令
                    DataSet ds = new DataSet();//初始化
                    adp.Fill(ds);//刷新
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        Form2 mainframe = new Form2();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                if (role == "学生")
                {
                    string sql1 = "select stuxuehao,stupasswd from student where role='学生'and stuxuehao='" + name +
                    "' and stupasswd='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);//数据库命令
                    DataSet ds = new DataSet();//初始化
                    adp.Fill(ds);//刷新
                    if (ds.Tables[0].Rows.Count > 0)//克隆查询消息,并将信息带入带下一个from去
                    {
                        conn.Close();
                        Form3 mainframe = new Form3();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }

                }
            }
        }
    }
}
