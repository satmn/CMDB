namespace CMDB.Forms
{
    partial class SubForm顧客MST
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.顧客IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登録日時DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登録者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.顧客IDDataGridViewTextBoxColumn,
            this.顧客名DataGridViewTextBoxColumn,
            this.登録日時DataGridViewTextBoxColumn,
            this.登録者DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CMDB.Models.顧客MST);
            // 
            // 顧客IDDataGridViewTextBoxColumn
            // 
            this.顧客IDDataGridViewTextBoxColumn.DataPropertyName = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.HeaderText = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.Name = "顧客IDDataGridViewTextBoxColumn";
            // 
            // 顧客名DataGridViewTextBoxColumn
            // 
            this.顧客名DataGridViewTextBoxColumn.DataPropertyName = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.HeaderText = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.Name = "顧客名DataGridViewTextBoxColumn";
            // 
            // 登録日時DataGridViewTextBoxColumn
            // 
            this.登録日時DataGridViewTextBoxColumn.DataPropertyName = "登録日時";
            this.登録日時DataGridViewTextBoxColumn.HeaderText = "登録日時";
            this.登録日時DataGridViewTextBoxColumn.Name = "登録日時DataGridViewTextBoxColumn";
            // 
            // 登録者DataGridViewTextBoxColumn
            // 
            this.登録者DataGridViewTextBoxColumn.DataPropertyName = "登録者";
            this.登録者DataGridViewTextBoxColumn.HeaderText = "登録者";
            this.登録者DataGridViewTextBoxColumn.Name = "登録者DataGridViewTextBoxColumn";
            // 
            // SubForm顧客MST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubForm顧客MST";
            this.Text = "顧客MST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登録日時DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登録者DataGridViewTextBoxColumn;
    }
}