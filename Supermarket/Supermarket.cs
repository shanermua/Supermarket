﻿using System;
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
            SQL.statement = "select * from huojia";
            SqlCommand command = new(SQL.statement, SQL.Connection);
            SqlDataAdapter dataAdapter = new(command);
            DataSet dataSet = new();
            dataAdapter.Fill(dataSet, "huojia");
            货架状态.DataSource = dataSet;
            货架状态.DataMember = "huojia";
            command.CommandText = "select * from kucun";
            dataAdapter.Fill(dataSet, "kucun");
            仓库状态.DataSource = dataSet;
            仓库状态.DataMember = "kucun";
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
    }
    public class SQL
    {
        public static SqlConnection Connection { get; set; }
        public static string statement { get; set; }
    }
}
