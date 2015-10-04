using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMDB.Forms
{
    public class SubForm : Form
    {
        readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataTable table;
        string connectionStringKey = "CMDB.Properties.Settings.CMDB";

        virtual public DataGridView DataGridView { get { return null; } }
        virtual public BindingSource BindingSource { get { return null; } }
        virtual public string SelectQueryString { get { return null; } }
        virtual public string TableName { get { return null; } }

        protected void InitializeComponentEx()
        {
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubForm_FormClosing);

            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            dataAdapter = new SqlDataAdapter(SelectQueryString, conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = new SqlCommand();

            List<string> cols = new List<string>();
            List<string> colparams = new List<string>();
            foreach (DataGridViewColumn col in DataGridView.Columns)
            {
                if (col.ReadOnly)
                    continue;

                SqlParameter p1 = new SqlParameter();
                p1.ParameterName = "@" + col.DataPropertyName;
                p1.SourceColumn = col.DataPropertyName;
                dataAdapter.InsertCommand.Parameters.Add(p1);

                colparams.Add(p1.ParameterName);
                cols.Add(p1.SourceColumn);
            }

            string colParamJoin = string.Join(",", colparams);
            string colJoin = string.Join(",", cols);

            dataAdapter.InsertCommand.CommandText = 
                string.Format(
                "INSERT INTO " + TableName + "(" + colJoin + ") VALUES (" + colParamJoin + ")", 
                colParamJoin, 
                colJoin);
            log.Info(dataAdapter.SelectCommand.CommandText);
            log.Info(dataAdapter.InsertCommand.CommandText);
        }

        protected void SubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        protected void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                DataGridView dataGridView = sender as DataGridView;
                dataGridView.Rows[e.RowIndex].ErrorText = e.Exception.Message;
            }
        }

        virtual public void SelectFromDB()
        {
            using (table) { }
            table = new DataTable();
            dataAdapter.Fill(table);

            BindingSource.DataSource = table;
        }

        protected void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                BindingSource.EndEdit();
                DataTable dt = (DataTable)BindingSource.DataSource;
                DataTable changedTable = dt.GetChanges();
                dataAdapter.Update(dt);
                if (changedTable != null && changedTable.Rows != null)
                {
                    bool add = false;
                    foreach (System.Data.DataRow row in changedTable.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            add = true;
                            break;
                        }
                    }
                    if (add)
                        SelectFromDB();
                }

                DataGridView dataGridView = sender as DataGridView;
                dataGridView.Rows[e.RowIndex].ErrorText = string.Empty;
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                DataGridView dataGridView = sender as DataGridView;
                dataGridView.Rows[e.RowIndex].ErrorText = ex.ToString();
            }
        }
    }
}
