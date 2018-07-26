using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfADO.Common.Interfaces;
using WpfADO.DataAccess.Context;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;

namespace WpfADO.BussinessLogic.Services
{
    public class SupplierService : ISupplier
    {
        ApplicationContext _context = new ApplicationContext();
        public void Delete(int id)
        {
            var getSupplier = Get(id);
            getSupplier.Delete(DateTimeOffset.UtcNow.LocalDateTime);
            _context.SaveChanges();
        }

        public Supplier Get(int? id)
        {
            if(id == null)
            {
                Console.Write("Id not found in Application");
            }
            var getSupplier = _context.Suppliers.Find(id);
            if(getSupplier == null)
            {
                Console.Write("Id not found in Database");
            }
            return getSupplier;
        }

        public IEnumerable<Supplier> Get()
        {
            var get = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public void Insert(SupplierParam param)
        {
            var getKecataman = _context.Kecamatans.Find(param.Id_Kecamatan);
            var getKelurahan = _context.Kelurahans.Find(param.Id_Kelurahan);
            Supplier insert = new Supplier(param.Name, param.Phone, param.Address, param.PostalCode, getKelurahan, getKecataman, DateTimeOffset.UtcNow.LocalDateTime);
            _context.Suppliers.Add(insert);
            _context.SaveChanges();
        }

        public void Update(int id, SupplierParam param)
        {
            var getKecataman = _context.Kecamatans.Find(param.Id_Kecamatan);
            var getKelurahan = _context.Kelurahans.Find(param.Id_Kelurahan);
            var getSupplier = Get(id);
            getSupplier.Update(param.Name, param.Phone, param.Address, param.PostalCode, getKelurahan, getKecataman, DateTimeOffset.UtcNow.LocalDateTime);
            _context.Entry(getSupplier).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
