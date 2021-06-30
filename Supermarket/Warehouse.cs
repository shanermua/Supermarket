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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }
        public void Warehouse_Reload()
        {
            string statement = "select * from kucun";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "kucun");
            仓库列表.DataSource = dataSet;
            仓库列表.DataMember = "kucun";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statement = "insert into kucun values('{0}','{1}','{2}','{3}','{4}')";
            statement = string.Format(statement, textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Warehouse_Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string statement = "update kucun set 数量='{0}',进货员='{1}',批次='{2}',进货时间='{3}'where 商品编号='{4}'";
            statement = string.Format(statement, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox1.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Warehouse_Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string statement = "delete from kucun where 商品编号='{0}'";
            statement = string.Format(statement, textBox1.Text);
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Warehouse_Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warehouse_Reload();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            Warehouse_Reload();
        }
    }
}
