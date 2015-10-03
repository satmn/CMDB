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
    public partial class SubForm担当者MST : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from 担当者MST order by 担当者ID"; } }
        override public string TableName { get { return "担当者MST"; } }

        public SubForm担当者MST()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
