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

        private void Personnel_Load(object sender, EventArgs e)
        {
            string statement = "select * from yuangong";
            SqlCommand command = new(statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "yuangong");
            人事列表.DataSource = dataSet;
            人事列表.DataMember = "yuangong";
        }

        private void showInfo()
        {
            try
            {
                textBox_name.Text = 人事列表.SelectedRows[0].Cells["姓名"].Value.ToString();
                comboBox_sex.SelectedItem = 人事列表.SelectedRows[0].Cells["性别"].Value.ToString();
                textBox_position.Text = 人事列表.SelectedRows[0].Cells["职位"].Value.ToString();
                textBox_contact.Text = 人事列表.SelectedRows[0].Cells["联系方式"].Value.ToString();
                textBox_wages.Text = 人事列表.SelectedRows[0].Cells["工资"].Value.ToString();
                textBox_password.Text = 人事列表.SelectedRows[0].Cells["密码"].Value.ToString();
            }
            catch 
            {
                return;
            }
        }

        private void 人事列表_SelectionChanged(object sender, EventArgs e)
        {
            showInfo();
        }
    }
}
