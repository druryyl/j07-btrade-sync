using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j07_btrade_sync.Model
{
    public class CustomerType
    {
        public CustomerType(string customerId, string customerCode, string customerName, 
            string alamat, string wilayah)
        {
            CustomerId = customerId;
            CustomerCode = customerCode;
            CustomerName = customerName;
            Alamat = alamat;
            Wilayah = wilayah;
        }
        public string CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Alamat { get; set; }
        public string Wilayah { get; set; }
    }
}
