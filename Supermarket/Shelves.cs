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
    public partial class Shelves : Form
    {
        public Shelves()
        {
            InitializeComponent();
        }
        public void Shelves_Reload()
        {
            string statement = "select * from huojia";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "huojia");
            Selves_List.DataSource = dataSet;
            Selves_List.DataMember = "huojia";
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            Shelves_Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statement = "insert into huojia values('{0}','{1}','{2}','{3}','{4}')";
            statement = string.Format(statement, textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Shelves_Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string statement = "update huojia set 数量='{0}',上架员='{1}',批次='{2}',上架时间='{3}'where 商品编号='{4}'";
            statement = string.Format(statement, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox1.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Shelves_Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string statement = "delete from huojia where 商品编号='{0}'";
            statement = string.Format(statement, textBox1.Text);
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Shelves_Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shelves_Reload();
        }
    }
}
