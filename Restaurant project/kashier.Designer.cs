namespace Restaurant_project
{
    partial class kashier
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderList.ColumnHeadersHeight = 35;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPrice,
            this.colQty,
            this.colMealId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrderList.EnableHeadersVisualStyles = false;
            this.dgvOrderList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderList.RowTemplate.Height = 35;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(315, 446);
            this.dgvOrderList.TabIndex = 0;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Location = new System.Drawing.Point(4, 528);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(123, 64);
            this.btnConfirmOrder.TabIndex = 1;
            this.btnConfirmOrder.Text = "insert";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteRow.FlatAppearance.BorderSize = 0;
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRow.Location = new System.Drawing.Point(180, 528);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(131, 64);
            this.btnDeleteRow.TabIndex = 2;
            this.btnDeleteRow.Text = "clear";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click_1);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(111, 451);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 54);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnConfirmOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteRow);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalPrice);
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrderList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.flp);
            this.splitContainer1.Size = new System.Drawing.Size(858, 597);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(3, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "TP : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(269, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Location = new System.Drawing.Point(265, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(274, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 32);
            this.flp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(539, 565);
            this.flp.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 125;
            // 
            // colMealId
            // 
            this.colMealId.HeaderText = "ID";
            this.colMealId.MinimumWidth = 6;
            this.colMealId.Name = "colMealId";
            this.colMealId.ReadOnly = true;
            this.colMealId.Visible = false;
            this.colMealId.Width = 125;
            // 
            // kashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(858, 597);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "kashier";
            this.Text = "kashier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMealId;
    }
}

