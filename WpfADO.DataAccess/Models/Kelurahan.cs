using WpfADO.Core;

namespace WpfADO.DataAccess.Models
{
    public class Kelurahan : BaseModel
    {
        public virtual Kecamatan Kecamatan { get; set; }
    }
}