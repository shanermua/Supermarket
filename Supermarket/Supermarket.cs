﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Supermarket : Form
    {
        public Supermarket()
        {
            InitializeComponent();
        }

        private void Supermarket_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
    }
}
