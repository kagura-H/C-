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
    public partial class modifymanForm : Form
    {
        public modifymanForm()
        {
            InitializeComponent();
        }
        private void modifymanForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }
        private void MOS_click(object sender, DataGridViewCellMouseEventArgs e)
        {//写窗口的鼠标事件点击赋值
            if (dataGridView1.SelectedCells.Count != 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        private void getRusult()
        {//数据库显示信息
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            conn.Open();
            string sql = "select manid as 用户id, manname as 用户名,manpasswd as 密码 from manager";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//在dataGridview显示数据
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {//在数据库中更改信息
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            conn.Open();
            int id = 0;
            int.TryParse(textBox1.Text, out id);
            string sql = "update manager set manname = '" + textBox2.Text + "',manpasswd = '" + textBox3.Text + "' where  manid = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                this.getRusult();
                MessageBox.Show("更改成功！");
            }
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {//通过ID去删除
            SqlConnection conn = new SqlConnection(Form1.connectionString);
            conn.Open();
            int id = 0;
            int.TryParse(textBox1.Text, out id);
            string sql = "delete from  manager  where  manid = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                this.getRusult();
                MessageBox.Show("删除成功！");
            }

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
