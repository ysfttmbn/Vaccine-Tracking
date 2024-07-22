using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CekDataNIK_Service
{
    public class PendudukContext : DbContext
    {
        public DbSet<Data_Penduduk> DataPenduduks { get; set; }
        public PendudukContext() : base("PendudukDataCS")
        {

        }
    }
}