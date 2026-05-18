namespace Restaurant_project
{
    partial class Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSalesSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmostOrderedmeal = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnBackToLogin);
            this.panel1.Controls.Add(this.dtpFilterDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(952, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.Brown;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 5F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogin.Location = new System.Drawing.Point(901, 35);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(48, 30);
            this.btnBackToLogin.TabIndex = 2;
            this.btnBackToLogin.Text = "logout";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtpFilterDate.Location = new System.Drawing.Point(659, 2);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(290, 30);
            this.dtpFilterDate.TabIndex = 1;
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.dtpFilterDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager controler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(952, 143);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel5.Controls.Add(this.lblTotalSalesSum);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(624, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(318, 123);
            this.panel5.TabIndex = 2;
            // 
            // lblTotalSalesSum
            // 
            this.lblTotalSalesSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSalesSum.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalesSum.ForeColor = System.Drawing.Color.White;
            this.lblTotalSalesSum.Location = new System.Drawing.Point(15, 50);
            this.lblTotalSalesSum.Name = "lblTotalSalesSum";
            this.lblTotalSalesSum.Size = new System.Drawing.Size(288, 58);
            this.lblTotalSalesSum.TabIndex = 2;
            this.lblTotalSalesSum.Text = "0.0";
            this.lblTotalSalesSum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total sales for the day";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.lblOrdersCount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(299, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(643, 123);
            this.panel4.TabIndex = 1;
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblOrdersCount.ForeColor = System.Drawing.Color.White;
            this.lblOrdersCount.Location = new System.Drawing.Point(120, 54);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(77, 54);
            this.lblOrdersCount.TabIndex = 2;
            this.lblOrdersCount.Text = "0.0";
            this.lblOrdersCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of orders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblmostOrderedmeal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(289, 123);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Most requested meal";
            // 
            // lblmostOrderedmeal
            // 
            this.lblmostOrderedmeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblmostOrderedmeal.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblmostOrderedmeal.ForeColor = System.Drawing.Color.White;
            this.lblmostOrderedmeal.Location = new System.Drawing.Point(15, 54);
            this.lblmostOrderedmeal.Name = "lblmostOrderedmeal";
            this.lblmostOrderedmeal.Size = new System.Drawing.Size(259, 54);
            this.lblmostOrderedmeal.TabIndex = 1;
            this.lblmostOrderedmeal.Text = "..";
            this.lblmostOrderedmeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.ColumnHeadersHeight = 35;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory.RowTemplate.Height = 35;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(317, 349);
            this.dgvHistory.TabIndex = 2;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderDetails.ColumnHeadersHeight = 35;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.EnableHeadersVisualStyles = false;
            this.dgvOrderDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderDetails.RowTemplate.Height = 35;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(631, 349);
            this.dgvOrderDetails.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 265);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvHistory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrderDetails);
            this.splitContainer1.Size = new System.Drawing.Size(952, 349);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 4;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessTokenCallback = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.SspiContextProvider = null;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Daily Orders History";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 213);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(952, 52);
            this.panel7.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox2.Location = new System.Drawing.Point(324, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(628, 52);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "                       Order Details";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblmostOrderedmeal;
        private System.Windows.Forms.Label lblTotalSalesSum;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox2;
    }
}