using Dapper;
using j07_btrade_sync.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j07_btrade_sync.Repository
{
    public class CustomerDal
    {
        public IEnumerable<CustomerType> ListData()
        {
            const string sql = @"
                SELECT
                    aa.CustomerId, aa.CustomerCode, aa.CustomerName,
                    aa.Address1 as Alamat, ISNULL(bb.WilayahName, '') AS Wilayah
                FROM
                    BTR_Customer aa
                    LEFT JOIN BTR_Wilayah bb ON aa.WilayahId = bb.WilayahId";
            
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
            {
                var result = conn.Query<CustomerType>(sql).ToList();
                return result;
            }
        }
    }
}
