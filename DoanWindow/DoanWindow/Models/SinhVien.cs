//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoanWindow.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVien
    {
        public string ID { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string DeTai { get; set; }
    
        public virtual DeTai DeTai1 { get; set; }
    }
}
