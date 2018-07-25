using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfADO.Core;

namespace WpfADO.DataAccess.Models
{
    public class Supplier : BaseModel
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public virtual Kelurahan Kelurahan { get; set; }
        public virtual Kecamatan Kecamatan { get; set; }

        public Supplier() { }

        public Supplier(string name, string phone, string address, string postalCode, Kelurahan id_Kelurahan, Kecamatan id_Kecamatan, DateTimeOffset createDate)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.PostalCode = postalCode;
            this.Kelurahan = id_Kelurahan;
            this.Kecamatan = id_Kecamatan;
            this.CreateDate = createDate;
        }

        public virtual void Update(string name, string phone, string address, string postalCode, int id_Kelurahan, int id_Kecamatan, DateTimeOffset updateDate)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.PostalCode = postalCode;
            this.Kelurahan.Id = id_Kelurahan;
            this.Kecamatan.Id = id_Kecamatan;
            this.UpdateDate = updateDate;
        }

        public virtual void Delete(DateTimeOffset deleteDate)
        {
            this.IsDelete = true;
            this.DeleteDate = deleteDate;
        }
    }
}
