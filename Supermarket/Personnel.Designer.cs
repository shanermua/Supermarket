
namespace Supermarket
{
    partial class Personnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.人事列表 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_position = new System.Windows.Forms.Label();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label_wages = new System.Windows.Forms.Label();
            this.textBox_wages = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_confirmPassword = new System.Windows.Forms.Label();
            this.textBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.label_sex = new System.Windows.Forms.Label();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.人事列表)).BeginInit();
            this.SuspendLayout();
            // 
            // 人事列表
            // 
            this.人事列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.人事列表.Location = new System.Drawing.Point(24, 51);
            this.人事列表.Margin = new System.Windows.Forms.Padding(4);
            this.人事列表.Name = "人事列表";
            this.人事列表.RowHeadersVisible = false;
            this.人事列表.RowHeadersWidth = 51;
            this.人事列表.RowTemplate.Height = 29;
            this.人事列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.人事列表.Size = new System.Drawing.Size(736, 837);
            this.人事列表.TabIndex = 1;
            this.人事列表.SelectionChanged += new System.EventHandler(this.人事列表_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "入职";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 716);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "离职";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(836, 775);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "更新信息";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(836, 846);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(817, 63);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(46, 24);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(924, 60);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(182, 30);
            this.textBox_name.TabIndex = 4;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(817, 148);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(46, 24);
            this.label_position.TabIndex = 3;
            this.label_position.Text = "职位";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(924, 145);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(182, 30);
            this.textBox_position.TabIndex = 4;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(817, 187);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(82, 24);
            this.label_contact.TabIndex = 3;
            this.label_contact.Text = "联系方式";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(924, 184);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(182, 30);
            this.textBox_contact.TabIndex = 4;
            // 
            // label_wages
            // 
            this.label_wages.AutoSize = true;
            this.label_wages.Location = new System.Drawing.Point(817, 230);
            this.label_wages.Name = "label_wages";
            this.label_wages.Size = new System.Drawing.Size(46, 24);
            this.label_wages.TabIndex = 3;
            this.label_wages.Text = "工资";
            // 
            // textBox_wages
            // 
            this.textBox_wages.Location = new System.Drawing.Point(924, 227);
            this.textBox_wages.Name = "textBox_wages";
            this.textBox_wages.Size = new System.Drawing.Size(182, 30);
            this.textBox_wages.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(817, 273);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(46, 24);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "密码";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(924, 270);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(182, 30);
            this.textBox_password.TabIndex = 4;
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.Location = new System.Drawing.Point(817, 318);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(82, 24);
            this.label_confirmPassword.TabIndex = 3;
            this.label_confirmPassword.Text = "确认密码";
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Location = new System.Drawing.Point(924, 315);
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '*';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(182, 30);
            this.textBox_confirmPassword.TabIndex = 4;
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(817, 109);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(46, 24);
            this.label_sex.TabIndex = 3;
            this.label_sex.Text = "性别";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_sex.Location = new System.Drawing.Point(924, 106);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(182, 32);
            this.comboBox_sex.TabIndex = 5;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 914);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.textBox_confirmPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_wages);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_position);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_confirmPassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_wages);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.人事列表);
            this.Name = "Personnel";
            this.Text = "人事管理";
            this.Load += new System.EventHandler(this.Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.人事列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 人事列表;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label_wages;
        private System.Windows.Forms.TextBox textBox_wages;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_confirmPassword;
        private System.Windows.Forms.TextBox textBox_confirmPassword;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.ComboBox comboBox_sex;
    }
}