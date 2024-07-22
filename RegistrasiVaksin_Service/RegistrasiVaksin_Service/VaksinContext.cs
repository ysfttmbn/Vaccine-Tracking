using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistrasiVaksin_Service
{
    public class VaksinContext:DbContext
    {
        public DbSet<VaksinData> VaksinDatas { get; set; }
        public VaksinContext() : base("VaksinDataCS")
        {

        }
    }
}