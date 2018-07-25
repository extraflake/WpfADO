using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfADO.DataAccess.Models;

namespace WpfADO.DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("WpfADO") { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Kelurahan> Kelurahans { get; set; }
        public DbSet<Kecamatan> Kecamatans { get; set; }
    }
}
