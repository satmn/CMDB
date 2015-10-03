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
    public partial class SubFormサーバーMST : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from サーバーMST order by サーバーID"; } }
        override public string TableName { get { return "サーバーMST"; } }

        public SubFormサーバーMST()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
