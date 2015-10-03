using CMDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMDB.Forms
{
    public partial class SubFormJOBMST : SubForm
    {
        override public DataGridView DataGridView { get { return dataGridView1; } }
        override public BindingSource BindingSource { get { return bindingSource1; } }
        override public string SelectQueryString { get { return "select * from JOBMST order by JOBID"; } }
        override public string TableName { get { return "JOBMST"; } }

        public SubFormJOBMST()
        {
            InitializeComponent();
            base.InitializeComponentEx();
        }
    }
}
