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
    public partial class SubFormJOB_担当者REL : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from JOB_担当者REL order by JOBID"; } }
        override public string TableName { get { return "JOB_担当者REL"; } }

        public SubFormJOB_担当者REL()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
