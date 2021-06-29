using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket
{
   
    public partial class Supermarket : Form
    {
        public Supermarket()
        {
            InitializeComponent();
            SQL.Connection = new SqlConnection("Server=10.5.98.242;Database=Supermarket;User Id=sa;Password=<Shaner@wang.shaner.mua>;");
            SQL.Connection.Open();
            Status_Reload();
        }

        public void Status_Reload()
        {
            string statement = "select * from huojia";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "huojia");
            Shelves_Status.DataSource = dataSet;
            Shelves_Status.DataMember = "huojia";
            command.CommandText = "select * from kucun";
            dataAdapter.Fill(dataSet, "kucun");
            Warehouse_Status.DataSource = dataSet;
            Warehouse_Status.DataMember = "kucun";
            command.CommandText = "select * from xiaoshou";
            dataAdapter.Fill(dataSet, "xiaoshou");
            Sale_Status.DataSource = dataSet;
            Sale_Status.DataMember = "xiaoshou";
        }

        private void Supermarket_Load(object sender, EventArgs e)
        {
            Status_Reload();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Status_Reload();
        }

        private void Supermarket_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Connection.Close();
            SQL.Connection.Dispose();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string statement = "select 密码 from yuangong where 工号=" + ID.Text;
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            try
            {
                dataAdapter.Fill(dataSet, "password");
                if (PassWord.Text == dataSet.Tables[0].Rows[0].ItemArray[0].ToString())
                {
                    MessageBox.Show("登录成功！");
                    ID.Enabled = false;
                    PassWord.Text = "";
                    PassWord.Enabled = false;
                    Login.Enabled = false;
                    Logout.Enabled = true;
                }
                else
                {
                    MessageBox.Show("密码错误！");
                }
            }
            catch
            {
                MessageBox.Show("工号错误！");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            ID.Enabled = true;
            PassWord.Enabled = true;
            Login.Enabled = true;
            Logout.Enabled = false;
            MessageBox.Show("注销成功！");
        }

        private void Personnel_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel.Show();
        }
    }
    public class SQL
    {
        public static SqlConnection Connection { get; set; }
    }
}
