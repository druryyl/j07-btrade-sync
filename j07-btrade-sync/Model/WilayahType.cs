using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j07_btrade_sync.Model
{
    public class WilayahType
    {
        public WilayahType(string wilayahId, string wilayahName)
        {
            WilayahId = wilayahId;
            WilayahName = wilayahName;
        }
        
        public string WilayahId { get; set; }
        public string WilayahName { get; set; }
    }
}
