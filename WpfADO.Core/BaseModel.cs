using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfADO.Core
{
    public class BaseModel : Metadata
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Metadata
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
