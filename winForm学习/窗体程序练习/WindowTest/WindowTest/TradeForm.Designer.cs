namespace WindowTest
{
    partial class tradForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkTrade = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.trade_type = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.about = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_income = new System.Windows.Forms.Label();
            this.accountDataSet = new WindowTest.accountDataSet();
            this.tradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeTableAdapter = new WindowTest.accountDataSetTableAdapters.tradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易日期从：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "到：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "交易类型：";
            // 
            // checkTrade
            // 
            this.checkTrade.Location = new System.Drawing.Point(527, 12);
            this.checkTrade.Name = "checkTrade";
            this.checkTrade.Size = new System.Drawing.Size(63, 23);
            this.checkTrade.TabIndex = 2;
            this.checkTrade.Text = "查询交易";
            this.checkTrade.UseVisualStyleBackColor = true;
            this.checkTrade.Click += new System.EventHandler(this.checkTrade_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 15);
            this.dateTimePicker1.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2012, 7, 18, 10, 16, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(244, 15);
            this.dateTimePicker2.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // trade_type
            // 
            this.trade_type.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trade_type.FormattingEnabled = true;
            this.trade_type.Location = new System.Drawing.Point(441, 14);
            this.trade_type.Name = "trade_type";
            this.trade_type.Size = new System.Drawing.Size(77, 20);
            this.trade_type.TabIndex = 5;
            this.trade_type.Text = "不限";
            this.trade_type.SelectedIndexChanged += new System.EventHandler(this.trade_type_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardid,
            this.tradeTime,
            this.tradeType,
            this.tradeMoney,
            this.about});
            this.dataGridView.Location = new System.Drawing.Point(17, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(567, 245);
            this.dataGridView.TabIndex = 6;
            // 
            // cardid
            // 
            this.cardid.HeaderText = "卡号";
            this.cardid.Name = "cardid";
            // 
            // tradeTime
            // 
            this.tradeTime.HeaderText = "交易时间";
            this.tradeTime.Name = "tradeTime";
            // 
            // tradeType
            // 
            this.tradeType.HeaderText = "交易类型";
            this.tradeType.Name = "tradeType";
            // 
            // tradeMoney
            // 
            this.tradeMoney.HeaderText = "交易金额";
            this.tradeMoney.Name = "tradeMoney";
            // 
            // about
            // 
            this.about.HeaderText = "备注";
            this.about.Name = "about";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "本时段合计 ";
            // 
            // label_income
            // 
            this.label_income.AutoSize = true;
            this.label_income.Location = new System.Drawing.Point(329, 318);
            this.label_income.Name = "label_income";
            this.label_income.Size = new System.Drawing.Size(125, 12);
            this.label_income.TabIndex = 9;
            this.label_income.Text = "收入： 支出： 盈亏：";
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "accountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradeBindingSource
            // 
            this.tradeBindingSource.DataMember = "trade";
            this.tradeBindingSource.DataSource = this.accountDataSet;
            // 
            // tradeTableAdapter
            // 
            this.tradeTableAdapter.ClearBeforeFill = true;
            // 
            // tradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 351);
            this.Controls.Add(this.label_income);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.trade_type);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkTrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "tradForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交易管理 当前卡号：";
            this.Load += new System.EventHandler(this.TradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkTrade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox trade_type;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_income;
        private accountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource tradeBindingSource;
        private WindowTest.accountDataSetTableAdapters.tradeTableAdapter tradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn about;

    }
}