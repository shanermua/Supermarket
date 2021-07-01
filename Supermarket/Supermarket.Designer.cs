
namespace Supermarket
{
    partial class Supermarket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Warehouse_Status = new System.Windows.Forms.DataGridView();
            this.Shelves_Status = new System.Windows.Forms.DataGridView();
            this.Sale_Status = new System.Windows.Forms.DataGridView();
            this.Supplier = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Button();
            this.Shelves = new System.Windows.Forms.Button();
            this.Warehouse = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Personnel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shelves_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_Status)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Warehouse_Status
            // 
            this.Warehouse_Status.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Warehouse_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Warehouse_Status.Location = new System.Drawing.Point(8, 8);
            this.Warehouse_Status.Margin = new System.Windows.Forms.Padding(4);
            this.Warehouse_Status.Name = "Warehouse_Status";
            this.Warehouse_Status.RowHeadersVisible = false;
            this.Warehouse_Status.RowHeadersWidth = 51;
            this.Warehouse_Status.RowTemplate.Height = 29;
            this.Warehouse_Status.Size = new System.Drawing.Size(904, 566);
            this.Warehouse_Status.TabIndex = 0;
            // 
            // Shelves_Status
            // 
            this.Shelves_Status.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Shelves_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shelves_Status.Location = new System.Drawing.Point(8, 8);
            this.Shelves_Status.Margin = new System.Windows.Forms.Padding(4);
            this.Shelves_Status.Name = "Shelves_Status";
            this.Shelves_Status.RowHeadersVisible = false;
            this.Shelves_Status.RowHeadersWidth = 51;
            this.Shelves_Status.RowTemplate.Height = 29;
            this.Shelves_Status.Size = new System.Drawing.Size(900, 566);
            this.Shelves_Status.TabIndex = 0;
            // 
            // Sale_Status
            // 
            this.Sale_Status.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sale_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sale_Status.Location = new System.Drawing.Point(8, 8);
            this.Sale_Status.Margin = new System.Windows.Forms.Padding(4);
            this.Sale_Status.Name = "Sale_Status";
            this.Sale_Status.RowHeadersVisible = false;
            this.Sale_Status.RowHeadersWidth = 51;
            this.Sale_Status.RowTemplate.Height = 29;
            this.Sale_Status.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sale_Status.Size = new System.Drawing.Size(904, 566);
            this.Sale_Status.TabIndex = 0;
            // 
            // Supplier
            // 
            this.Supplier.Enabled = false;
            this.Supplier.Location = new System.Drawing.Point(326, 90);
            this.Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(115, 35);
            this.Supplier.TabIndex = 1;
            this.Supplier.Text = "供应商管理";
            this.Supplier.UseVisualStyleBackColor = true;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // Sale
            // 
            this.Sale.Enabled = false;
            this.Sale.Location = new System.Drawing.Point(326, 206);
            this.Sale.Margin = new System.Windows.Forms.Padding(4);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(115, 35);
            this.Sale.TabIndex = 1;
            this.Sale.Text = "销售管理";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Shelves
            // 
            this.Shelves.Enabled = false;
            this.Shelves.Location = new System.Drawing.Point(178, 206);
            this.Shelves.Margin = new System.Windows.Forms.Padding(4);
            this.Shelves.Name = "Shelves";
            this.Shelves.Size = new System.Drawing.Size(115, 35);
            this.Shelves.TabIndex = 1;
            this.Shelves.Text = "货架管理";
            this.Shelves.UseVisualStyleBackColor = true;
            this.Shelves.Click += new System.EventHandler(this.Shelves_Click);
            // 
            // Warehouse
            // 
            this.Warehouse.Enabled = false;
            this.Warehouse.Location = new System.Drawing.Point(24, 206);
            this.Warehouse.Margin = new System.Windows.Forms.Padding(4);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(115, 35);
            this.Warehouse.TabIndex = 1;
            this.Warehouse.Text = "仓库管理";
            this.Warehouse.UseVisualStyleBackColor = true;
            this.Warehouse.Click += new System.EventHandler(this.Warehouse_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(144, 200);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(117, 35);
            this.Login.TabIndex = 1;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Personnel
            // 
            this.Personnel.Enabled = false;
            this.Personnel.Location = new System.Drawing.Point(177, 90);
            this.Personnel.Margin = new System.Windows.Forms.Padding(4);
            this.Personnel.Name = "Personnel";
            this.Personnel.Size = new System.Drawing.Size(115, 35);
            this.Personnel.TabIndex = 1;
            this.Personnel.Text = "人事管理";
            this.Personnel.UseVisualStyleBackColor = true;
            this.Personnel.Click += new System.EventHandler(this.Personnel_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 90);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(144, 70);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(255, 30);
            this.ID.TabIndex = 2;
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(144, 132);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(255, 30);
            this.PassWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.PassWord);
            this.groupBox5.Controls.Add(this.ID);
            this.groupBox5.Controls.Add(this.Logout);
            this.groupBox5.Controls.Add(this.Login);
            this.groupBox5.Location = new System.Drawing.Point(947, 47);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(457, 278);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "账号";
            // 
            // Logout
            // 
            this.Logout.Enabled = false;
            this.Logout.Location = new System.Drawing.Point(282, 200);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(117, 35);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "注销";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 619);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Sale_Status);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(916, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "销售列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Shelves_Status);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(916, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "货架状态";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Warehouse_Status);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(916, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "仓库状态";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Supplier);
            this.groupBox1.Controls.Add(this.Sale);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.Shelves);
            this.groupBox1.Controls.Add(this.Personnel);
            this.groupBox1.Controls.Add(this.Warehouse);
            this.groupBox1.Location = new System.Drawing.Point(947, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理";
            // 
            // Supermarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1452, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supermarket";
            this.Text = "超市管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supermarket_FormClosing);
            this.Load += new System.EventHandler(this.Supermarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shelves_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_Status)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Personnel;
        private System.Windows.Forms.Button Warehouse;
        private System.Windows.Forms.Button Shelves;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.DataGridView Warehouse_Status;
        private System.Windows.Forms.DataGridView Shelves_Status;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.DataGridView Sale_Status;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

