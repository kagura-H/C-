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
    public partial class addmanFrom : Form
    {
        public addmanFrom()
        {
            InitializeComponent();
        }

        private void addmanFrom_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")//判断信息是否完整
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (textBox2.Text.Trim() != textBox3.Text.Trim())//判断密码输入是否一致
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Form1.connectionString);//连接数据库
                    conn.Open();//打开数据库
                    string sql = "select * from manager where manname = '" + textBox1.Text + "'";//找到管理员库
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);//更新数据库
                    DataSet ds = new DataSet();
                    adp.Fill(ds);//清除缓存
                    if (ds.Tables[0].Rows.Count > 0)//判断用户是否存在
                    {
                        MessageBox.Show("已经存在的用户名称！");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();//创建储存过程
                        cmd.Connection = conn;//连接
                        sql = "insert into manager (manname,manpasswd) values ('"
                            + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";//添加
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();//执行
                        MessageBox.Show("添加用户成功！");
                    }
                    conn.Close();//关闭数据库
                }

            }
        }
    }
}
