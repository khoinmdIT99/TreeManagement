﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiThucVat
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThucVatEntities : DbContext
    {
        public QuanLyThucVatEntities()
            : base("name=QuanLyThucVatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Bo> Tb_Bo { get; set; }
        public virtual DbSet<Tb_GiaTriKinhTe> Tb_GiaTriKinhTe { get; set; }
        public virtual DbSet<Tb_HinhAnh> Tb_HinhAnh { get; set; }
        public virtual DbSet<Tb_Ho> Tb_Ho { get; set; }
        public virtual DbSet<Tb_KhaNangSinhTruong> Tb_KhaNangSinhTruong { get; set; }
        public virtual DbSet<Tb_KhaNangTaiSinh> Tb_KhaNangTaiSinh { get; set; }
        public virtual DbSet<Tb_NguoiDung> Tb_NguoiDung { get; set; }
        public virtual DbSet<Tb_TinTuc> Tb_TinTuc { get; set; }
        public virtual DbSet<Tb_ThucVat> Tb_ThucVat { get; set; }
    }
}
