namespace CMDB
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBoxソフトウェアバージョンREL = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxサーバーMST = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox担当者MST = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox顧客MST = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxjOBMST = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOB名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担当者IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担当者名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サーバーIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サーバー名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サーバー管理者IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サーバー管理者名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ソフトウェアIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ソフトウェア名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.バージョンDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 470);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlSearch_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "構成情報の検索";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "検索条件表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxSerchPanel_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 412);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxソフトウェアバージョンREL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxサーバーMST, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox担当者MST, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox顧客MST, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxjOBMST, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 118);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // checkedListBoxソフトウェアバージョンREL
            // 
            this.checkedListBoxソフトウェアバージョンREL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxソフトウェアバージョンREL.FormattingEnabled = true;
            this.checkedListBoxソフトウェアバージョンREL.Location = new System.Drawing.Point(3, 23);
            this.checkedListBoxソフトウェアバージョンREL.Name = "checkedListBoxソフトウェアバージョンREL";
            this.checkedListBoxソフトウェアバージョンREL.Size = new System.Drawing.Size(151, 88);
            this.checkedListBoxソフトウェアバージョンREL.TabIndex = 5;
            // 
            // checkedListBoxサーバーMST
            // 
            this.checkedListBoxサーバーMST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxサーバーMST.FormattingEnabled = true;
            this.checkedListBoxサーバーMST.Location = new System.Drawing.Point(631, 23);
            this.checkedListBoxサーバーMST.Name = "checkedListBoxサーバーMST";
            this.checkedListBoxサーバーMST.Size = new System.Drawing.Size(155, 88);
            this.checkedListBoxサーバーMST.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "サーバー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "JOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "担当者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ソフトウェア＋バージョン";
            // 
            // checkedListBox担当者MST
            // 
            this.checkedListBox担当者MST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox担当者MST.FormattingEnabled = true;
            this.checkedListBox担当者MST.Location = new System.Drawing.Point(317, 23);
            this.checkedListBox担当者MST.Name = "checkedListBox担当者MST";
            this.checkedListBox担当者MST.Size = new System.Drawing.Size(151, 88);
            this.checkedListBox担当者MST.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "顧客";
            // 
            // checkedListBox顧客MST
            // 
            this.checkedListBox顧客MST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox顧客MST.FormattingEnabled = true;
            this.checkedListBox顧客MST.Location = new System.Drawing.Point(474, 23);
            this.checkedListBox顧客MST.Name = "checkedListBox顧客MST";
            this.checkedListBox顧客MST.Size = new System.Drawing.Size(151, 88);
            this.checkedListBox顧客MST.TabIndex = 5;
            // 
            // checkedListBoxjOBMST
            // 
            this.checkedListBoxjOBMST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxjOBMST.FormattingEnabled = true;
            this.checkedListBoxjOBMST.Location = new System.Drawing.Point(160, 23);
            this.checkedListBoxjOBMST.Name = "checkedListBoxjOBMST";
            this.checkedListBoxjOBMST.Size = new System.Drawing.Size(151, 88);
            this.checkedListBoxjOBMST.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOBIDDataGridViewTextBoxColumn,
            this.jOB名DataGridViewTextBoxColumn,
            this.顧客IDDataGridViewTextBoxColumn,
            this.顧客名DataGridViewTextBoxColumn,
            this.担当者IDDataGridViewTextBoxColumn,
            this.担当者名DataGridViewTextBoxColumn,
            this.サーバーIDDataGridViewTextBoxColumn,
            this.サーバー名DataGridViewTextBoxColumn,
            this.サーバー管理者IDDataGridViewTextBoxColumn,
            this.サーバー管理者名DataGridViewTextBoxColumn,
            this.ソフトウェアIDDataGridViewTextBoxColumn,
            this.ソフトウェア名DataGridViewTextBoxColumn,
            this.バージョンDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(795, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            this.jOBIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.jOBIDDataGridViewTextBoxColumn.Width = 64;
            // 
            // jOB名DataGridViewTextBoxColumn
            // 
            this.jOB名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jOB名DataGridViewTextBoxColumn.DataPropertyName = "JOB名";
            this.jOB名DataGridViewTextBoxColumn.HeaderText = "JOB名";
            this.jOB名DataGridViewTextBoxColumn.Name = "jOB名DataGridViewTextBoxColumn";
            this.jOB名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.jOB名DataGridViewTextBoxColumn.Width = 60;
            // 
            // 顧客IDDataGridViewTextBoxColumn
            // 
            this.顧客IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.顧客IDDataGridViewTextBoxColumn.DataPropertyName = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.HeaderText = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.Name = "顧客IDDataGridViewTextBoxColumn";
            this.顧客IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.顧客IDDataGridViewTextBoxColumn.Width = 60;
            // 
            // 顧客名DataGridViewTextBoxColumn
            // 
            this.顧客名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.顧客名DataGridViewTextBoxColumn.DataPropertyName = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.HeaderText = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.Name = "顧客名DataGridViewTextBoxColumn";
            this.顧客名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.顧客名DataGridViewTextBoxColumn.Width = 61;
            // 
            // 担当者IDDataGridViewTextBoxColumn
            // 
            this.担当者IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.担当者IDDataGridViewTextBoxColumn.DataPropertyName = "担当者ID";
            this.担当者IDDataGridViewTextBoxColumn.HeaderText = "担当者ID";
            this.担当者IDDataGridViewTextBoxColumn.Name = "担当者IDDataGridViewTextBoxColumn";
            this.担当者IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.担当者IDDataGridViewTextBoxColumn.Width = 61;
            // 
            // 担当者名DataGridViewTextBoxColumn
            // 
            this.担当者名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.担当者名DataGridViewTextBoxColumn.DataPropertyName = "担当者名";
            this.担当者名DataGridViewTextBoxColumn.HeaderText = "担当者名";
            this.担当者名DataGridViewTextBoxColumn.Name = "担当者名DataGridViewTextBoxColumn";
            this.担当者名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.担当者名DataGridViewTextBoxColumn.Width = 61;
            // 
            // サーバーIDDataGridViewTextBoxColumn
            // 
            this.サーバーIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.サーバーIDDataGridViewTextBoxColumn.DataPropertyName = "サーバーID";
            this.サーバーIDDataGridViewTextBoxColumn.HeaderText = "サーバーID";
            this.サーバーIDDataGridViewTextBoxColumn.Name = "サーバーIDDataGridViewTextBoxColumn";
            this.サーバーIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.サーバーIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // サーバー名DataGridViewTextBoxColumn
            // 
            this.サーバー名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.サーバー名DataGridViewTextBoxColumn.DataPropertyName = "サーバー名";
            this.サーバー名DataGridViewTextBoxColumn.HeaderText = "サーバー名";
            this.サーバー名DataGridViewTextBoxColumn.Name = "サーバー名DataGridViewTextBoxColumn";
            this.サーバー名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.サーバー名DataGridViewTextBoxColumn.Width = 65;
            // 
            // サーバー管理者IDDataGridViewTextBoxColumn
            // 
            this.サーバー管理者IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.サーバー管理者IDDataGridViewTextBoxColumn.DataPropertyName = "サーバー管理者ID";
            this.サーバー管理者IDDataGridViewTextBoxColumn.HeaderText = "サーバー管理者ID";
            this.サーバー管理者IDDataGridViewTextBoxColumn.Name = "サーバー管理者IDDataGridViewTextBoxColumn";
            this.サーバー管理者IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.サーバー管理者IDDataGridViewTextBoxColumn.Width = 87;
            // 
            // サーバー管理者名DataGridViewTextBoxColumn
            // 
            this.サーバー管理者名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.サーバー管理者名DataGridViewTextBoxColumn.DataPropertyName = "サーバー管理者名";
            this.サーバー管理者名DataGridViewTextBoxColumn.HeaderText = "サーバー管理者名";
            this.サーバー管理者名DataGridViewTextBoxColumn.Name = "サーバー管理者名DataGridViewTextBoxColumn";
            this.サーバー管理者名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.サーバー管理者名DataGridViewTextBoxColumn.Width = 87;
            // 
            // ソフトウェアIDDataGridViewTextBoxColumn
            // 
            this.ソフトウェアIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ソフトウェアIDDataGridViewTextBoxColumn.DataPropertyName = "ソフトウェアID";
            this.ソフトウェアIDDataGridViewTextBoxColumn.HeaderText = "ソフトウェアID";
            this.ソフトウェアIDDataGridViewTextBoxColumn.Name = "ソフトウェアIDDataGridViewTextBoxColumn";
            this.ソフトウェアIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ソフトウェアIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // ソフトウェア名DataGridViewTextBoxColumn
            // 
            this.ソフトウェア名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ソフトウェア名DataGridViewTextBoxColumn.DataPropertyName = "ソフトウェア名";
            this.ソフトウェア名DataGridViewTextBoxColumn.HeaderText = "ソフトウェア名";
            this.ソフトウェア名DataGridViewTextBoxColumn.Name = "ソフトウェア名DataGridViewTextBoxColumn";
            this.ソフトウェア名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ソフトウェア名DataGridViewTextBoxColumn.Width = 66;
            // 
            // バージョンDataGridViewTextBoxColumn
            // 
            this.バージョンDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.バージョンDataGridViewTextBoxColumn.DataPropertyName = "バージョン";
            this.バージョンDataGridViewTextBoxColumn.HeaderText = "バージョン";
            this.バージョンDataGridViewTextBoxColumn.Name = "バージョンDataGridViewTextBoxColumn";
            this.バージョンDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.バージョンDataGridViewTextBoxColumn.Width = 56;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CMDB.Models.SearchModelFromJob);
            this.bindingSource1.Sort = "JOBID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "マスターメンテナンス";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 35);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(793, 388);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 364);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 382);
            this.panel1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(739, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "元に戻す";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(673, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "最大化";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "DBから最新の情報を取得する";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(607, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "最小化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "構成管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxサーバーMST;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBoxjOBMST;
        private System.Windows.Forms.CheckedListBox checkedListBox担当者MST;
        private System.Windows.Forms.CheckedListBox checkedListBox顧客MST;
        private System.Windows.Forms.CheckedListBox checkedListBoxソフトウェアバージョンREL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOB名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担当者IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担当者名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバーIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバー名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバー管理者IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サーバー管理者名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ソフトウェアIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ソフトウェア名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn バージョンDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

