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
    public partial class SubFormサーバー管理者MST : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from サーバー管理者MST order by サーバー管理者ID"; } }
        override public string TableName { get { return "サーバー管理者MST"; } }

        public SubFormサーバー管理者MST()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
