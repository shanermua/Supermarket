
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
            this.Personnel_List = new System.Windows.Forms.DataGridView();
            this.button_Entry = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Personnel_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Personnel_List
            // 
            this.Personnel_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personnel_List.Location = new System.Drawing.Point(20, 42);
            this.Personnel_List.Name = "Personnel_List";
            this.Personnel_List.RowHeadersVisible = false;
            this.Personnel_List.RowHeadersWidth = 51;
            this.Personnel_List.RowTemplate.Height = 29;
            this.Personnel_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Personnel_List.Size = new System.Drawing.Size(602, 698);
            this.Personnel_List.TabIndex = 1;
            this.Personnel_List.SelectionChanged += new System.EventHandler(this.Personnel_List_SelectionChanged);
            // 
            // button_Entry
            // 
            this.button_Entry.Location = new System.Drawing.Point(684, 546);
            this.button_Entry.Margin = new System.Windows.Forms.Padding(2);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(92, 28);
            this.button_Entry.TabIndex = 2;
            this.button_Entry.Text = "入职";
            this.button_Entry.UseVisualStyleBackColor = true;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(684, 597);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(92, 28);
            this.button_Quit.TabIndex = 2;
            this.button_Quit.Text = "离职";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(684, 646);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(92, 28);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "更新信息";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(684, 705);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(92, 28);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(668, 52);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 20);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(756, 50);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(150, 27);
            this.textBox_name.TabIndex = 4;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(668, 123);
            this.label_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(39, 20);
            this.label_position.TabIndex = 3;
            this.label_position.Text = "职位";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(756, 121);
            this.textBox_position.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(150, 27);
            this.textBox_position.TabIndex = 4;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(668, 156);
            this.label_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(69, 20);
            this.label_contact.TabIndex = 3;
            this.label_contact.Text = "联系方式";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(756, 153);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(150, 27);
            this.textBox_contact.TabIndex = 4;
            // 
            // label_wages
            // 
            this.label_wages.AutoSize = true;
            this.label_wages.Location = new System.Drawing.Point(668, 192);
            this.label_wages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_wages.Name = "label_wages";
            this.label_wages.Size = new System.Drawing.Size(39, 20);
            this.label_wages.TabIndex = 3;
            this.label_wages.Text = "工资";
            // 
            // textBox_wages
            // 
            this.textBox_wages.Location = new System.Drawing.Point(756, 189);
            this.textBox_wages.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_wages.Name = "textBox_wages";
            this.textBox_wages.Size = new System.Drawing.Size(150, 27);
            this.textBox_wages.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(668, 228);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(39, 20);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "密码";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(756, 225);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(150, 27);
            this.textBox_password.TabIndex = 4;
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.Location = new System.Drawing.Point(668, 265);
            this.label_confirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(69, 20);
            this.label_confirmPassword.TabIndex = 3;
            this.label_confirmPassword.Text = "确认密码";
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Location = new System.Drawing.Point(756, 262);
            this.textBox_confirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '*';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(150, 27);
            this.textBox_confirmPassword.TabIndex = 4;
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(668, 91);
            this.label_sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(39, 20);
            this.label_sex.TabIndex = 3;
            this.label_sex.Text = "性别";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_sex.Location = new System.Drawing.Point(756, 88);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(150, 28);
            this.comboBox_sex.TabIndex = 5;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 762);
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
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.Personnel_List);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Personnel";
            this.Text = "人事管理";
            this.Load += new System.EventHandler(this.Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Personnel_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Personnel_List;
        private System.Windows.Forms.Button button_Entry;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Refresh;
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