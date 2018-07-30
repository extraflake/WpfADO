using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfADO.BussinessLogic.Repositories;
using WpfADO.Common.Interfaces;
using WpfADO.DataAccess.Context;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;
using WpfADO.Interface.Repository;

namespace WpfADO.BussinessLogic.Services
{
    public class SupplierService : ISupplier
    {
        ApplicationContext _context = new ApplicationContext();
        ISupplierRepository _supplierRepository = new SupplierRepository();

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
            if (getSupplier == null)
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
            try
            {
                Supplier push = new Supplier(param.Name, param.Phone, param.Address, param.PostalCode, getKelurahan, getKecataman, DateTimeOffset.UtcNow.LocalDateTime);
                _supplierRepository.Save(push);
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
                Console.Write(ex.StackTrace);
                Console.Write(ex.Message);
            }
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
