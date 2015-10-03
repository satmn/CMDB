using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMDB.Models
{
    public class SearchModelFromJob
    {
        public int? JOBID { get; set; }
        public string JOB名 { get; set; }
        public int? 顧客ID { get; set; }
        public string 顧客名 { get; set; }
        public int? 担当者ID { get; set; }
        public string 担当者名 { get; set; }
        public int? サーバーID { get; set; }
        public string サーバー名 { get; set; }
        public int? サーバー管理者ID { get; set; }
        public string サーバー管理者名 { get; set; }
        public int? ソフトウェアバージョンID { get; set; }
        public int? ソフトウェアID { get; set; }
        public string ソフトウェア名 { get; set; }
        public string バージョン { get; set; }
    }
}
