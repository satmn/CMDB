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
    public partial class SubForm顧客MST : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from 顧客MST order by 顧客ID"; } }
        override public string TableName { get { return "顧客MST"; } }

        public SubForm顧客MST()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
