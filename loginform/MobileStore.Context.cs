﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laptop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyDienThoaiEntities8 : DbContext
    {
        public QuanLyDienThoaiEntities8()
            : base("name=QuanLyDienThoaiEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<GetProductsSoldTheMost_Result> GetProductsSoldTheMost()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsSoldTheMost_Result>("GetProductsSoldTheMost");
        }
    
        public virtual ObjectResult<USP_GetListBillByDate_Result> USP_GetListBillByDate(Nullable<System.DateTime> checkDateStart, Nullable<System.DateTime> checkDateFinish)
        {
            var checkDateStartParameter = checkDateStart.HasValue ?
                new ObjectParameter("CheckDateStart", checkDateStart) :
                new ObjectParameter("CheckDateStart", typeof(System.DateTime));
    
            var checkDateFinishParameter = checkDateFinish.HasValue ?
                new ObjectParameter("CheckDateFinish", checkDateFinish) :
                new ObjectParameter("CheckDateFinish", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListBillByDate_Result>("USP_GetListBillByDate", checkDateStartParameter, checkDateFinishParameter);
        }
    }
}
