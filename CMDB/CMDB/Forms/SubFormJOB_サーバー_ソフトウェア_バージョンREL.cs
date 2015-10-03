using CMDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMDB.Forms
{
    public partial class SubFormJOB_サーバー_ソフトウェア_バージョンREL : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from JOB_サーバーソフトウェアバージョンREL order by JOB_サーバーソフトウェアバージョンID"; } }
        override public string TableName { get { return "JOB_サーバーソフトウェアバージョンREL"; } }

        public SubFormJOB_サーバー_ソフトウェア_バージョンREL()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
