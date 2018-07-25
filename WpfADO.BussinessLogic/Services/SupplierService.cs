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
        public void Delete(Supplier model)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(SupplierParam param)
        {
            var getKecataman = _context.Kecamatans.Find(param.Id_Kecamatan);
            var getKelurahan = _context.Kelurahans.Find(param.Id_Kelurahan);
            Supplier model = new Supplier(param.Name, param.Phone, param.Address, param.PostalCode, getKelurahan, getKecataman, DateTimeOffset.UtcNow.LocalDateTime);
            try
            {
                _context.Suppliers.Add(model);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    Console.Write("Insert Successfully");
                }
                else
                {
                    Console.Write("Insert Failed");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                Console.Write(ex.InnerException.ToString());
            }
        }

        public void Update(Supplier model)
        {
            throw new NotImplementedException();
        }
    }
}
