using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j07_btrade_sync.Model
{
    public class SalesPersonType
    {
        public SalesPersonType(string salesPersonId, string salesPersonCode, string salesPersonName)
        {
            SalesPersonId = salesPersonId;
            SalesPersonCode = salesPersonCode;
            SalesPersonName = salesPersonName;
        }
        public string SalesPersonId { get; set; }
        public string SalesPersonCode { get; set; }
        public string SalesPersonName { get; set; }
    }
}
