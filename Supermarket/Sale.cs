using System;
using System.Collections;
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

    public partial class Sale : Form
    {
        public Sale(string id)
        {
            //Static s = new();
            Static.id = id;
            InitializeComponent();
        }

        private void List_Reload()
        {
            string statement = "select * from xiaoshou";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "xiaoshou");
            Sale_List.DataSource = dataSet;
            Sale_List.DataMember = "xiaoshou";
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            List_Reload();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Static.isLegal = false;
                return;
            }
            string statement = "select * from xinxi,huojia where huojia.商品编号 = xinxi.商品编号";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "select");
            for (int i = 0; i < dataSet.Tables["select"].Rows.Count; i++)
            {
                if(dataSet.Tables["select"].Rows[i].ItemArray[0].ToString() == textBox1.Text && dataSet.Tables["select"].Rows[i].ItemArray[11].ToString() == textBox2.Text)
                {
                    textBox4.Text = dataSet.Tables["select"].Rows[i].ItemArray[7].ToString();
                }
            }
            if(textBox4.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                Static.isLegal = false;
                return;
            }
            else
            {
                textBox5.Text = (int.Parse(textBox3.Text) * int.Parse(textBox4.Text)).ToString();
                Static.isLegal = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Static.isLegal)
            {
                textBox6.Text = (int.Parse(textBox5.Text) + int.Parse(textBox6.Text)).ToString();
                Static.statement = new();
                Static.statement.Add("insert into xiaoshou (商品编号,批次,数量,销售员,销售时间) values (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + Static.id.ToString() + ",\'" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "\')");
                Static.statement.Add("update huojia set 数量=数量-" + textBox3.Text + "where 商品编号=" + textBox1.Text + " and 批次=" + textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                Static.isLegal = false;
            }
            else
            {
                MessageBox.Show("检查数据合法性");
            }
        }

        private void button_Buy_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Static.statement.Count; i++)
            //{
            //    SqlCommand command = new(Static.statement., SQL.Connection);
            //    command.ExecuteNonQuery();
            //}
            if(int.Parse(textBox7.Text) >= int.Parse(textBox6.Text))
            {
                textBox8.Text = (int.Parse(textBox7.Text) - int.Parse(textBox6.Text)).ToString();
            }
            else
            {
                MessageBox.Show("金额不足");
            }
            foreach(string i in Static.statement)
            {
                System.Diagnostics.Debug.WriteLine(i);
                SqlCommand command = new(i, SQL.Connection);
                command.ExecuteNonQuery();
            }
            //Array.Clear(Static.statement, 0, Static.statement.Count);
            Static.statement.Clear();
        }
    }
    class Static
    {
        public static bool isLegal { get; set; }
        public static ArrayList statement { get; set; }
        public static string id { get; set; }
    }
}
