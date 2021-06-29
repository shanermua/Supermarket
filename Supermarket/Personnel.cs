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
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void List_Reload()
        {
            string statement = "select * from yuangong";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "yuangong");
            Personnel_List.DataSource = dataSet;
            Personnel_List.DataMember = "yuangong";
            for (int i = 0; i < dataSet.Tables["yuangong"].Rows.Count; i++)
            {
                //Personnel_List.Rows[i].Cells[7].ValueType = statement.GetType();
                System.Diagnostics.Debug.WriteLine(dataSet.Tables["yuangong"].Rows[i].ItemArray[7].ToString());
                Personnel_List.Rows[i].Cells[7].Value = "*********";
            }
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            List_Reload();

        }

        private void showInfo()
        {
            try
            {
                textBox_name.Text = Personnel_List.SelectedRows[0].Cells["姓名"].Value.ToString();
                comboBox_sex.SelectedItem = Personnel_List.SelectedRows[0].Cells["性别"].Value.ToString();
                textBox_position.Text = Personnel_List.SelectedRows[0].Cells["职位"].Value.ToString();
                textBox_contact.Text = Personnel_List.SelectedRows[0].Cells["联系方式"].Value.ToString();
                textBox_wages.Text = Personnel_List.SelectedRows[0].Cells["工资"].Value.ToString();
                //textBox_password.Text = Personnel_List.SelectedRows[0].Cells["密码"].Value.ToString();
            }
            catch 
            {
                return;
            }
        }

        private void Personnel_List_SelectionChanged(object sender, EventArgs e)
        {
            showInfo();
        }

        private void button_Entry_Click(object sender, EventArgs e)
        {
            if(textBox_name.TextLength == 0)
            {
                MessageBox.Show("请输入姓名!");
                return;
            }
            //if (comboBox_sex.SelectedValue.ToString() == "")
            //{
            //    MessageBox.Show("请选择性别!");
            //    return;
            //}
            if (textBox_password.Text == "")
            {
                MessageBox.Show("请输入密码!");
                return;
            }
            if(textBox_password.Text != textBox_confirmPassword.Text)
            {
                MessageBox.Show("两次密码输入不一致!");
                return;
            }
            string statement = "insert into yuangong (姓名,性别,职位,联系方式,工资,入职时间,密码) values (N'" + textBox_name.Text + "',N'" + comboBox_sex.Text + "',N'" + textBox_position.Text + "','" + textBox_contact.Text + "','" + textBox_wages.Text + "','" + DateTime.Now.ToString("d") + "','" + textBox_password.Text + "')";
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            List_Reload();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            string statement = "update yuangong set 离职=1 where 工号=" + Personnel_List.SelectedRows[0].Cells["工号"].Value.ToString();
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            List_Reload();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text != textBox_confirmPassword.Text)
            {
                MessageBox.Show("两次密码输入不一致!");
                return;
            }
            string statement = "update yuangong set 姓名=N'" + textBox_name.Text + "',性别=N'" + comboBox_sex.Text + "',职位=N'" + textBox_position.Text + "',联系方式='" + textBox_contact.Text + "',工资='" + textBox_wages.Text + "',密码='" + textBox_password.Text + "' "  + "where 工号=" + Personnel_List.SelectedRows[0].Cells["工号"].Value.ToString();
            System.Diagnostics.Debug.WriteLine(statement);
            SqlCommand command = new(statement, SQL.Connection);
            command.ExecuteNonQuery();
            List_Reload();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            List_Reload();
        }
    }
}
