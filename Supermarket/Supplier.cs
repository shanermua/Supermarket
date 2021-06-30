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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        public void Initgonghuoshsng()
        {
            string statement = "select * from gonghuoshang";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "gonghuoshang");
            供货商列表.DataSource = dataSet;
            供货商列表.DataMember = "gonghuoshang";
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            Initgonghuoshsng();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statement = "insert into gonghuoshang values('{0}','{1}','{2}','{3}','{4}','{5}')";
            statement = string.Format(statement, textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox4.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Initgonghuoshsng();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string statement = "delete from gonghuoshang where 供货商编号='{0}'";
            statement = string.Format(statement,textBox1.Text);
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Initgonghuoshsng();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string statement = "update gonghuoshang set 供货商名='{0}',负责人='{1}',联系方式='{2}',邮箱='{3}',地址='{4}'where 供货商编号='{5}'";
            statement = string.Format(statement, textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox4.Text, textBox1.Text);

            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            Initgonghuoshsng();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Initgonghuoshsng();
        }
    }
}
