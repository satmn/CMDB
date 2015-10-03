using CMDB.Forms;
using CMDB.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CMDB
{
    public partial class MainForm : Form
    {
        readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        Dictionary<Type, ControlMapper> maps;
        public MainForm()
        {
            InitializeComponent();
        }

        class ControlMapper
        {
            public Type FormType { get; set; }
            public dynamic DataSource { get; set; }
            public SubForm FormMaint { get; set; }
            public string DisplayName { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitControll();

                SetupControll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InitControll()
        {
            maps = new Dictionary<Type, ControlMapper>()
                {
                    {
                        typeof(SubFormJOBMST),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormJOBMST),
                            DisplayName = "JOBMST",
                        }
                    },
                    {
                        typeof(SubFormJOB_サーバー_ソフトウェア_バージョンREL),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormJOB_サーバー_ソフトウェア_バージョンREL),
                            DisplayName = "JOB_サーバー_ソフトウェア_バージョンREL",
                        }
                    },
                    {
                        typeof(SubFormJOB_担当者REL),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormJOB_担当者REL),
                            DisplayName = "JOB_担当者REL",
                        }
                    },
                    {
                        typeof(SubFormサーバーMST),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormサーバーMST),
                            DisplayName = "サーバーMST",
                        }
                    },
                    {
                        typeof(SubFormサーバー管理者MST),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormサーバー管理者MST),
                            DisplayName = "サーバー管理者MST",
                        }
                    },
                    {
                        typeof(SubFormサーバー_ソフトウェア別_バージョンREL),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormサーバー_ソフトウェア別_バージョンREL),
                            DisplayName = "サーバー_ソフトウェア別_バージョンREL",
                        }
                    },
                    {
                        typeof(SubFormソフトウェアMST),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormソフトウェアMST),
                            DisplayName = "ソフトウェアMST",
                        }
                    },
                    {
                        typeof(SubFormソフトウェア_バージョンREL),
                        new ControlMapper
                        {
                            FormType = typeof(SubFormソフトウェア_バージョンREL),
                            DisplayName = "ソフトウェア_バージョンREL",
                        }
                    },
                    {
                        typeof(SubForm担当者MST),
                        new ControlMapper
                        {
                            FormType = typeof(SubForm担当者MST),
                            DisplayName = "担当者MST",
                        }
                    },
                    {
                        typeof(SubForm顧客MST),
                        new ControlMapper
                        {
                            FormType = typeof(SubForm顧客MST),
                            DisplayName = "顧客MST",
                        }
                    },
                };

            List<ControlMapper> list = new List<ControlMapper>();
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
            {
                var f = Activator.CreateInstance(pair.Value.FormType) as SubForm;
                pair.Value.FormMaint = f;
                f.Enter += f_Enter;
                /////サイズ変更
                //f.Size = panel1.Size;
                //zオーダー修正
                f.TopLevel = false;
                //コントロールに追加
                panel1.Controls.Add(f);
                //フォームを表示する
                f.Show();
                //最前面へ移動
                f.BringToFront();
                f.SelectFromDB();

                list.Add(pair.Value);
            }

            listBox1.DataSource = list;
            listBox1.DisplayMember = "DisplayName";
            listBox1.ValueMember = "FormMaint";

            checkBox1.Checked = true;
        }

        void f_Enter(object sender, EventArgs e)
        {
            SubForm form = sender as SubForm;
            if (sender == null)
                return;

            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
            {
                if (pair.Value.FormMaint == form)
                {
                    listBox1.SelectedItem = pair.Value;
                    break;
                }
            }
        }

        private void SeachJob()
        {
            string queryBaseString = 
@"
SELECT
JOBMST.JOBID,
JOBMST.JOB名,
顧客MST.顧客ID,
顧客MST.顧客名,
担当者MST.担当者ID,
担当者MST.担当者名,
サーバーMST.サーバー名,
サーバー管理者MST.サーバー管理者ID,
サーバー管理者MST.サーバー管理者名,
ソフトウェアMST.ソフトウェアID,
ソフトウェアMST.ソフトウェア名, ソフトウェアバージョンMST.バージョン
FROM       JOBMST
LEFT JOIN JOB_担当者REL ON JOBMST.JOBID = JOB_担当者REL.JOBID
LEFT JOIN JOB_サーバーソフトウェアバージョンREL ON JOB_サーバーソフトウェアバージョンREL.JOBID = JOBMST.JOBID
LEFT JOIN サーバー_ソフトウェアバージョンREL ON JOB_サーバーソフトウェアバージョンREL.サーバーソフトウェアバージョンID = サーバー_ソフトウェアバージョンREL.サーバーソフトウェアバージョンID
LEFT JOIN サーバーMST ON サーバー_ソフトウェアバージョンREL.サーバーID = サーバーMST.サーバーID
LEFT JOIN サーバー管理者MST ON サーバーMST.サーバー管理者ID = サーバー管理者MST.サーバー管理者ID
LEFT JOIN ソフトウェアバージョンMST ON サーバー_ソフトウェアバージョンREL.ソフトウェアバージョンID = ソフトウェアバージョンMST.ソフトウェアバージョンID
LEFT JOIN ソフトウェアMST ON ソフトウェアバージョンMST.ソフトウェアID = ソフトウェアMST.ソフトウェアID
LEFT JOIN 顧客MST ON JOBMST.顧客ID = 顧客MST.顧客ID
LEFT JOIN 担当者MST ON JOB_担当者REL.担当者ID = 担当者MST.担当者ID
WHERE 1 = 1 
{0}
ORDER BY
JOBMST.JOBID,
JOBMST.JOB名,
顧客MST.顧客ID,
顧客MST.顧客名,
担当者MST.担当者ID,
担当者MST.担当者名,
サーバーMST.サーバー名,
サーバー管理者MST.サーバー管理者ID,
サーバー管理者MST.サーバー管理者名,
ソフトウェアMST.ソフトウェアID,
ソフトウェアMST.ソフトウェア名,
ソフトウェアバージョンMST.バージョン";

            string whereQueryString = string.Empty;

            if (checkedListBoxjOBMST.CheckedItems.Count > 0)
            {
                List<int?> ids = new List<int?>();
                foreach (var item in checkedListBoxjOBMST.CheckedItems)
                {
                    if (item != null)
                    { 
                        ids.Add(((JOBMST)item).JOBID);
                    }
                }
                whereQueryString += "AND JOBMST.JOBID in(" + string.Join(",", ids) + ")" + System.Environment.NewLine;
            }

            if (checkedListBox担当者MST.CheckedItems.Count > 0)
            {
                List<int?> ids = new List<int?>();
                foreach (var item in checkedListBox担当者MST.CheckedItems)
                {
                    if (item != null)
                    {
                        ids.Add(((担当者MST)item).担当者ID);
                    }
                }
                whereQueryString += "AND 担当者MST.担当者ID in(" + string.Join(",", ids) + ")" + System.Environment.NewLine;
            }

            if (checkedListBox顧客MST.CheckedItems.Count > 0)
            {
                List<int?> ids = new List<int?>();
                foreach (var item in checkedListBox顧客MST.CheckedItems)
                {
                    if (item != null)
                    {
                        ids.Add(((顧客MST)item).顧客ID);
                    }
                }
                whereQueryString += "AND 顧客MST.顧客ID in(" + string.Join(",", ids) + ")" + System.Environment.NewLine;
            }

            if (checkedListBoxソフトウェアバージョンREL.CheckedItems.Count > 0)
            {
                List<int?> ids = new List<int?>();
                foreach (var item in checkedListBoxソフトウェアバージョンREL.CheckedItems)
                {
                    if (item != null)
                    {
                        ids.Add(((ソフトウェアバージョン)item).ソフトウェアバージョンID);
                    }
                }
                whereQueryString += "AND ソフトウェアバージョンMST.ソフトウェアバージョンID in(" + string.Join(",", ids) + ")" + System.Environment.NewLine;
            }

            if (checkedListBoxサーバーMST.CheckedItems.Count > 0)
            {
                List<int?> ids = new List<int?>();
                foreach (var item in checkedListBoxサーバーMST.CheckedItems)
                {
                    if (item != null)
                    {
                        ids.Add(((サーバーMST)item).サーバーID);
                    }
                }
                whereQueryString += "AND サーバーMST.サーバーID in(" + string.Join(",", ids) + ")" + System.Environment.NewLine;
            }

            string connectionStringKey = "CMDB.Properties.Settings.CMDB";
            string selectQueryString = string.Format(queryBaseString, whereQueryString);

            log.Info(selectQueryString);

            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQueryString, conn))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
        }

        private void SetupControll()
        {
            SetSearchItems();

            SeachJob();
        }

        private void SetSearchItems(ListBox listBox, string displayMember, string ValueMember, dynamic dataSource)
        {
            listBox.DataSource = dataSource;
            listBox.DisplayMember = displayMember;
            listBox.ValueMember = ValueMember;
        }
        private void SetSearchItems()
        {
            using (CMDBEntities ent = new CMDBEntities())
            {
                SetSearchItems(
                    checkedListBoxjOBMST,
                    "JOB名", 
                    "JOBID",
                    ent.JOBMST.Select(x => x).OrderBy(x => x.JOBID).ToList());

                SetSearchItems(
                    checkedListBox担当者MST,
                    "担当者名",
                    "担当者ID",
                    ent.担当者MST.Select(x => x).OrderBy(x => x.担当者ID).ToList());

                SetSearchItems(
                    checkedListBox顧客MST,
                    "顧客名",
                    "顧客ID",
                    ent.顧客MST.Select(x => x).OrderBy(x => x.顧客ID).ToList());

                SetSearchItems(
                    checkedListBoxサーバーMST,
                    "サーバー名",
                    "サーバーID",
                    ent.サーバーMST.Select(x => x).OrderBy(x => x.サーバーID).ToList());

                SetSearchItems(
                    checkedListBoxソフトウェアバージョンREL,
                    "ソフトウェアバージョンバージョン名",
                    "ソフトウェアバージョンID",
                    (from x in ent.ソフトウェアバージョンMST
                     orderby x.ソフトウェアバージョンID
                     select new ソフトウェアバージョン()
                     {
                         ソフトウェアバージョンID = x.ソフトウェアバージョンID,
                         ソフトウェア名 = x.ソフトウェアMST.ソフトウェア名,
                         バージョン = x.バージョン
                     }).ToList());
            }
        }

        class ソフトウェアバージョン
        {
            public int ソフトウェアバージョンID { get; set; }
            public string ソフトウェア名 { get; set; }
            public string バージョン { get; set; }
            public string ソフトウェアバージョンバージョン名
            {
                get { return ソフトウェア名 + " " + バージョン; }
            }
        }

        private void SetSearchItems(Type t, Func<dynamic, string> del, CheckedListBox target)
        {
            target.Items.Clear();
            var value = maps[t];
            foreach (var item in value.DataSource)
                target.Items.Add(del(item));
        }

        private void checkBoxSerchPanel_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !checkBox1.Checked;
        }

        private void tabControlSearch_Selected(object sender, TabControlEventArgs e)
        {
            SetSearchItems();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SeachJob();
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
                pair.Value.FormMaint.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
                pair.Value.FormMaint.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
                pair.Value.FormMaint.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
                pair.Value.FormMaint.SelectFromDB();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Type, ControlMapper> pair in maps)
            {
                if (pair.Value == (ControlMapper)listBox1.SelectedItem)
                {
                    pair.Value.FormMaint.BringToFront();
                    break;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //List<SearchModelFromJob> list = bindingSource1.DataSource as List<SearchModelFromJob>;
            //SortOrder sortOrder = dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;
            //switch(sortOrder)
            //{
            //    case SortOrder.Descending:
            //    case SortOrder.None:
            //        {
            //            switch (e.ColumnIndex)
            //            {
            //                case 0:
            //                    list = list.OrderBy(item => item.JOBID).ToList();
            //                    bindingSource1.Sort = "JOBID";
            //                    break;
            //                case 1:
            //                    list = list.OrderBy(item => item.JOB名).ToList();
            //                    break;
            //                case 2:
            //                    list = list.OrderBy(item => item.顧客ID).ToList();
            //                    break;
            //                case 3:
            //                    list = list.OrderBy(item => item.顧客名).ToList();
            //                    break;
            //                case 4:
            //                    list = list.OrderBy(item => item.担当者ID).ToList();
            //                    break;
            //                case 5:
            //                    list = list.OrderBy(item => item.担当者名).ToList();
            //                    break;
            //                case 6:
            //                    list = list.OrderBy(item => item.サーバーID).ToList();
            //                    break;
            //                case 7:
            //                    list = list.OrderBy(item => item.サーバー名).ToList();
            //                    break;
            //                case 8:
            //                    list = list.OrderBy(item => item.サーバー管理者ID).ToList();
            //                    break;
            //                case 9:
            //                    list = list.OrderBy(item => item.サーバー管理者名).ToList();
            //                    break;
            //                case 10:
            //                    list = list.OrderBy(item => item.ソフトウェアバージョンID).ToList();
            //                    break;
            //                case 11:
            //                    list = list.OrderBy(item => item.ソフトウェアID).ToList();
            //                    break;
            //                case 12:
            //                    list = list.OrderBy(item => item.ソフトウェア名).ToList();
            //                    break;
            //                case 13:
            //                    list = list.OrderBy(item => item.バージョン).ToList();
            //                    break;
            //            }
            //            dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            //            break;
            //        }
            //    default:
            //        {
            //            switch (e.ColumnIndex)
            //            {
            //                case 0:
            //                    list = list.OrderByDescending(item => item.JOBID).ToList();
            //                    break;
            //                case 1:
            //                    list = list.OrderByDescending(item => item.JOB名).ToList();
            //                    break;
            //                case 2:
            //                    list = list.OrderByDescending(item => item.顧客ID).ToList();
            //                    break;
            //                case 3:
            //                    list = list.OrderByDescending(item => item.顧客名).ToList();
            //                    break;
            //                case 4:
            //                    list = list.OrderByDescending(item => item.担当者ID).ToList();
            //                    break;
            //                case 5:
            //                    list = list.OrderByDescending(item => item.担当者名).ToList();
            //                    break;
            //                case 6:
            //                    list = list.OrderByDescending(item => item.サーバーID).ToList();
            //                    break;
            //                case 7:
            //                    list = list.OrderByDescending(item => item.サーバー名).ToList();
            //                    break;
            //                case 8:
            //                    list = list.OrderByDescending(item => item.サーバー管理者ID).ToList();
            //                    break;
            //                case 9:
            //                    list = list.OrderByDescending(item => item.サーバー管理者名).ToList();
            //                    break;
            //                case 10:
            //                    list = list.OrderByDescending(item => item.ソフトウェアバージョンID).ToList();
            //                    break;
            //                case 11:
            //                    list = list.OrderByDescending(item => item.ソフトウェアID).ToList();
            //                    break;
            //                case 12:
            //                    list = list.OrderByDescending(item => item.ソフトウェア名).ToList();
            //                    break;
            //                case 13:
            //                    list = list.OrderByDescending(item => item.バージョン).ToList();
            //                    break;
            //            }
            //            dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            //            break;
            //        }
            //}

            //bindingSource1.DataSource = list;
        }
    }
}
