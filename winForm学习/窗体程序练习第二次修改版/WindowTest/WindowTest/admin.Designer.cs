namespace WindowTest
{
    partial class admin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.timeText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(82, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(93, 21);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(82, 87);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(93, 21);
            this.password.TabIndex = 1;
            // 
            // butOK
            // 
            this.butOK.BackColor = System.Drawing.SystemColors.Control;
            this.butOK.Location = new System.Drawing.Point(24, 140);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(56, 23);
            this.butOK.TabIndex = 2;
            this.butOK.Text = "登陆";
            this.butOK.UseVisualStyleBackColor = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(119, 140);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(56, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(22, 186);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(0, 12);
            this.timeText.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(195, 205);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家庭财务管理系统";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Timer timer1;

    }
}

