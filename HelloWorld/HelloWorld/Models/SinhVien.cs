using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class SinhVien
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class SinhVienDBContext: DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
    }
}