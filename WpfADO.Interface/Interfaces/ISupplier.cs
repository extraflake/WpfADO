using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfADO.DataAccess.Models;
using WpfADO.DataAccess.Params;

namespace WpfADO.Common.Interfaces
{
    public interface ISupplier
    {
        Supplier Get(int id);
        IEnumerable<Supplier> Get();
        void Insert(SupplierParam param);
        void Update(Supplier model);
        void Delete(Supplier model);
    }
}
