namespace QuickPools
{
    partial class Pool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferee = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvPoolTable = new System.Windows.Forms.DataGridView();
            this.btnXLS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoolNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoolTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Strip:";
            // 
            // txtStrip
            // 
            this.txtStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStrip.Location = new System.Drawing.Point(88, 438);
            this.txtStrip.Name = "txtStrip";
            this.txtStrip.Size = new System.Drawing.Size(39, 20);
            this.txtStrip.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Referee:";
            // 
            // txtReferee
            // 
            this.txtReferee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferee.Location = new System.Drawing.Point(88, 475);
            this.txtReferee.Name = "txtReferee";
            this.txtReferee.Size = new System.Drawing.Size(100, 20);
            this.txtReferee.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(243, 392);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 32);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Refresh Calculations";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvPoolTable
            // 
            this.dgvPoolTable.AllowUserToAddRows = false;
            this.dgvPoolTable.AllowUserToDeleteRows = false;
            this.dgvPoolTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoolTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoolTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoolTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPoolTable.EnableHeadersVisualStyles = false;
            this.dgvPoolTable.Location = new System.Drawing.Point(0, 0);
            this.dgvPoolTable.Name = "dgvPoolTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoolTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPoolTable.RowHeadersVisible = false;
            this.dgvPoolTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPoolTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPoolTable.Size = new System.Drawing.Size(972, 387);
            this.dgvPoolTable.TabIndex = 6;
            this.dgvPoolTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoolTable_CellEndEdit);
            this.dgvPoolTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPoolTable_CellFormatting);
            // 
            // btnXLS
            // 
            this.btnXLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLS.Location = new System.Drawing.Point(243, 468);
            this.btnXLS.Name = "btnXLS";
            this.btnXLS.Size = new System.Drawing.Size(146, 32);
            this.btnXLS.TabIndex = 12;
            this.btnXLS.Text = "Export to XLS";
            this.btnXLS.UseVisualStyleBackColor = true;
            this.btnXLS.Click += new System.EventHandler(this.btnXLS_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pool #:";
            // 
            // txtPoolNum
            // 
            this.txtPoolNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoolNum.Location = new System.Drawing.Point(88, 399);
            this.txtPoolNum.Name = "txtPoolNum";
            this.txtPoolNum.Size = new System.Drawing.Size(39, 20);
            this.txtPoolNum.TabIndex = 13;
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoolNum);
            this.Controls.Add(this.btnXLS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReferee);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgvPoolTable);
            this.Name = "Pool";
            this.Size = new System.Drawing.Size(972, 624);
            this.Load += new System.EventHandler(this.Pool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoolTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvPoolTable;
        private System.Windows.Forms.Button btnXLS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoolNum;
    }
}
