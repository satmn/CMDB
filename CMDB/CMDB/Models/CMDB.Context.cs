﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMDBEntities : DbContext
    {
        public CMDBEntities()
            : base("name=CMDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<JOB_サーバーソフトウェアバージョンREL> JOB_サーバーソフトウェアバージョンREL { get; set; }
        public virtual DbSet<JOB_担当者REL> JOB_担当者REL { get; set; }
        public virtual DbSet<JOBMST> JOBMST { get; set; }
        public virtual DbSet<サーバー_ソフトウェアバージョンREL> サーバー_ソフトウェアバージョンREL { get; set; }
        public virtual DbSet<サーバーMST> サーバーMST { get; set; }
        public virtual DbSet<サーバー管理者MST> サーバー管理者MST { get; set; }
        public virtual DbSet<ソフトウェアMST> ソフトウェアMST { get; set; }
        public virtual DbSet<ソフトウェアバージョンMST> ソフトウェアバージョンMST { get; set; }
        public virtual DbSet<顧客MST> 顧客MST { get; set; }
        public virtual DbSet<担当者MST> 担当者MST { get; set; }
    }
}