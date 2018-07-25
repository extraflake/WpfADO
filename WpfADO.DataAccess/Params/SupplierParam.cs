using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfADO.DataAccess.Params
{
    public class SupplierParam
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public int Id_Kelurahan { get; set; }
        public int Id_Kecamatan { get; set; }
    }
}
