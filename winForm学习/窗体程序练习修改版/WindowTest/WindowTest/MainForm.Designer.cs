namespace WindowTest
{
    partial class MainForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardid = new System.Windows.Forms.TextBox();
            this.password_card = new System.Windows.Forms.TextBox();
            this.bankName = new System.Windows.Forms.TextBox();
            this.tradeMoney = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.TextBox();
            this.search_card = new System.Windows.Forms.Button();
            this.funTest = new System.Windows.Forms.Button();
            this.addCard = new System.Windows.Forms.Button();
            this.okMain = new System.Windows.Forms.Button();
            this.ModifyCard = new System.Windows.Forms.Button();
            this.tradeManage = new System.Windows.Forms.Button();
            this.exitMain = new System.Windows.Forms.Button();
            this.addMoney = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.outMoney = new System.Windows.Forms.RadioButton();
            this.currentUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "交易备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "交易金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "交易类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "银行名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "卡号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardid
            // 
            this.cardid.Location = new System.Drawing.Point(99, 46);
            this.cardid.Name = "cardid";
            this.cardid.Size = new System.Drawing.Size(120, 21);
            this.cardid.TabIndex = 0;
            // 
            // password_card
            // 
            this.password_card.Location = new System.Drawing.Point(99, 73);
            this.password_card.Name = "password_card";
            this.password_card.PasswordChar = '*';
            this.password_card.Size = new System.Drawing.Size(120, 21);
            this.password_card.TabIndex = 1;
            // 
            // bankName
            // 
            this.bankName.Location = new System.Drawing.Point(99, 107);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(120, 21);
            this.bankName.TabIndex = 2;
            // 
            // tradeMoney
            // 
            this.tradeMoney.Location = new System.Drawing.Point(99, 178);
            this.tradeMoney.Name = "tradeMoney";
            this.tradeMoney.Size = new System.Drawing.Size(120, 21);
            this.tradeMoney.TabIndex = 5;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(99, 212);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(120, 21);
            this.about.TabIndex = 6;
            // 
            // search_card
            // 
            this.search_card.Location = new System.Drawing.Point(240, 46);
            this.search_card.Name = "search_card";
            this.search_card.Size = new System.Drawing.Size(50, 20);
            this.search_card.TabIndex = 8;
            this.search_card.Text = "查找";
            this.search_card.UseVisualStyleBackColor = true;
            this.search_card.Click += new System.EventHandler(this.search_card_Click);
            // 
            // funTest
            // 
            this.funTest.Location = new System.Drawing.Point(240, 73);
            this.funTest.Name = "funTest";
            this.funTest.Size = new System.Drawing.Size(61, 21);
            this.funTest.TabIndex = 9;
            this.funTest.Text = "功能测试";
            this.funTest.UseVisualStyleBackColor = true;
            // 
            // addCard
            // 
            this.addCard.Location = new System.Drawing.Point(26, 283);
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(58, 23);
            this.addCard.TabIndex = 10;
            this.addCard.Text = "添加卡";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // okMain
            // 
            this.okMain.Location = new System.Drawing.Point(93, 283);
            this.okMain.Name = "okMain";
            this.okMain.Size = new System.Drawing.Size(58, 23);
            this.okMain.TabIndex = 11;
            this.okMain.Text = "确定";
            this.okMain.UseVisualStyleBackColor = true;
            this.okMain.Click += new System.EventHandler(this.okMain_Click);
            // 
            // ModifyCard
            // 
            this.ModifyCard.Location = new System.Drawing.Point(163, 283);
            this.ModifyCard.Name = "ModifyCard";
            this.ModifyCard.Size = new System.Drawing.Size(58, 23);
            this.ModifyCard.TabIndex = 12;
            this.ModifyCard.Text = "修改卡";
            this.ModifyCard.UseVisualStyleBackColor = true;
            this.ModifyCard.Click += new System.EventHandler(this.ModifyCard_Click);
            // 
            // tradeManage
            // 
            this.tradeManage.Location = new System.Drawing.Point(45, 323);
            this.tradeManage.Name = "tradeManage";
            this.tradeManage.Size = new System.Drawing.Size(64, 23);
            this.tradeManage.TabIndex = 13;
            this.tradeManage.Text = "交易管理";
            this.tradeManage.UseVisualStyleBackColor = true;
            this.tradeManage.Click += new System.EventHandler(this.tradeManage_Click);
            // 
            // exitMain
            // 
            this.exitMain.Location = new System.Drawing.Point(137, 323);
            this.exitMain.Name = "exitMain";
            this.exitMain.Size = new System.Drawing.Size(58, 23);
            this.exitMain.TabIndex = 14;
            this.exitMain.Text = "退出";
            this.exitMain.UseVisualStyleBackColor = true;
            this.exitMain.Click += new System.EventHandler(this.exitMain_Click);
            // 
            // addMoney
            // 
            this.addMoney.AutoSize = true;
            this.addMoney.Location = new System.Drawing.Point(102, 145);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(47, 16);
            this.addMoney.TabIndex = 3;
            this.addMoney.TabStop = true;
            this.addMoney.Text = "存钱";
            this.addMoney.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "存钱";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // outMoney
            // 
            this.outMoney.AutoSize = true;
            this.outMoney.Location = new System.Drawing.Point(172, 145);
            this.outMoney.Name = "outMoney";
            this.outMoney.Size = new System.Drawing.Size(47, 16);
            this.outMoney.TabIndex = 4;
            this.outMoney.TabStop = true;
            this.outMoney.Text = "取钱";
            this.outMoney.UseVisualStyleBackColor = true;
            this.outMoney.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.currentUser.Location = new System.Drawing.Point(12, 9);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(87, 15);
            this.currentUser.TabIndex = 3;
            this.currentUser.Text = "当前用户：";
            this.currentUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "卡内余额：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(99, 244);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(120, 21);
            this.balance.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 374);
            this.Controls.Add(this.outMoney);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.addMoney);
            this.Controls.Add(this.exitMain);
            this.Controls.Add(this.tradeManage);
            this.Controls.Add(this.ModifyCard);
            this.Controls.Add(this.okMain);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.funTest);
            this.Controls.Add(this.search_card);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.about);
            this.Controls.Add(this.tradeMoney);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.password_card);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cardid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家庭财务管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardid;
        private System.Windows.Forms.TextBox password_card;
        private System.Windows.Forms.TextBox bankName;
        private System.Windows.Forms.TextBox tradeMoney;
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.Button search_card;
        private System.Windows.Forms.Button funTest;
        private System.Windows.Forms.Button addCard;
        private System.Windows.Forms.Button okMain;
        private System.Windows.Forms.Button ModifyCard;
        private System.Windows.Forms.Button tradeManage;
        private System.Windows.Forms.Button exitMain;
        private System.Windows.Forms.RadioButton addMoney;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton outMoney;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox balance;

    }
}