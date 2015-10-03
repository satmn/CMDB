namespace CMDB.Forms
{
    partial class SubFormサーバー_ソフトウェア別_バージョンREL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サーバーIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ソフトウェアバージョンIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn,
            this.サーバーIDDataGridViewTextBoxColumn,
            this.ソフトウェアバージョンIDDataGridViewTextBoxColumn,
            this.登録日時DataGridViewTextBoxColumn,
            this.登録者DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CMDB.Models.サーバー_ソフトウェアバージョンREL);
            // 
            // サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn
            // 
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn.DataPropertyName = "サーバーソフトウェアバージョンID";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn.HeaderText = "サーバーソフトウェアバージョンID";
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn.Name = "サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn";
            this.サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // サーバーIDDataGridViewTextBoxColumn
            // 
            this.サーバーIDDataGridViewTextBoxColumn.DataPropertyName = "サーバーID";
            this.サーバーIDDataGridViewTextBoxColumn.HeaderText = "サーバーID";
            this.サーバーIDDataGridViewTextBoxColumn.Name = "サーバーIDDataGridViewTextBoxColumn";
            // 
            // ソフトウェアバージョンIDDataGridViewTextBoxColumn
            // 
            this.ソフトウェアバージョンIDDataGridViewTextBoxColumn.DataPropertyName = "ソフトウェアバージョンID";
            this.ソフトウェアバージョンIDDataGridViewTextBoxColumn.HeaderText = "ソフトウェアバージョンID";
            this.ソフトウェアバージョンIDDataGridViewTextBoxColumn.Name = "ソフトウェアバージョンIDDataGridViewTextBoxColumn";
            // 
            // 登録日時DataGridViewTextBoxColumn
            // 
            this.登録日時DataGridViewTextBoxColumn.DataPropertyName = "登録日時";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.登録日時DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.登録日時DataGridViewTextBoxColumn.HeaderText = "登録日時";
            this.登録日時DataGridViewTextBoxColumn.Name = "登録日時DataGridViewTextBoxColumn";
            this.登録日時DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 登録者DataGridViewTextBoxColumn
            // 
            this.登録者DataGridViewTextBoxColumn.DataPropertyName = "登録者";
            this.登録者DataGridViewTextBoxColumn.HeaderText = "登録者";
            this.登録者DataGridViewTextBoxColumn.Name = "登録者DataGridViewTextBoxColumn";
            // 
            // SubFormサーバー_ソフトウェア別_バージョンREL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubFormサーバー_ソフトウェア別_バージョンREL";
            this.Text = "サーバー_ソフトウェア別_バージョンREL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバーDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn リソースバージョンDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用途区分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバーソフトウェアバージョンIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバーIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ソフトウェアバージョンIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登録日時DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登録者DataGridViewTextBoxColumn;
    }
}