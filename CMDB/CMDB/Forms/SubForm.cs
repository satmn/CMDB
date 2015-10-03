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
            this.DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);

            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            dataAdapter = new SqlDataAdapter(SelectQueryString, conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = new SqlCommand();

            List<string> cols = new List<string>();
            List<string> colparams = new List<string>();
            foreach (DataGridViewColumn col in DataGridView.Columns)
            {
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
            table = new DataTable();
            dataAdapter.Fill(table);

            BindingSource.DataSource = table;
        }

        //DataGridView1のKeyDownイベントハンドラ
        protected void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    DataGridView dgv = (DataGridView)sender;

            //    //最終行最終列の場合は、何もしない（最終行最終列で
            //    //Tabキーを送信すると、次のコントロールにフォーカスが移動）
            //    if ((dgv.CurrentCellAddress.X == dgv.ColumnCount - 1) &&
            //        (dgv.CurrentCellAddress.Y == dgv.RowCount - 1))
            //    {
            //        return;
            //    }

            //    //Tabキーを送信する
            //    SendKeys.Send("{TAB}");
            //    //フォーカスが下に移動しないようにする
            //    e.Handled = true;
            //}
        }

        protected void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                if (e.ColumnIndex == dgv.ColumnCount - 1)
                {
                    BindingSource.EndEdit();
                    DataTable dt = (DataTable)BindingSource.DataSource;
                    DataTable changedTable = dt.GetChanges();
                    dataAdapter.Update(dt);
                }

                ////最終行最終列の場合は、何もしない
                //if ((e.ColumnIndex == dgv.ColumnCount - 1) &&
                //    (e.RowIndex == dgv.RowCount - 1))
                //{
                //    return;
                //}

                ////最終行以外では、フォーカスを上に移動
                ////（最終行以外では、編集後、フォーカスが下に移動するため）
                //if (e.RowIndex < dgv.RowCount - 1)
                //{
                //    SendKeys.Send("{UP}");
                //}
                ////Tabキーを送信する
                //SendKeys.Send("{TAB}");

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
