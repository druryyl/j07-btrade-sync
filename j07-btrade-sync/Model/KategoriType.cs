using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j07_btrade_sync.Model
{
    public class KategoriType
    {
        public KategoriType(string kategoriId, string kategoriName)
        {
            KategoriId = kategoriId;
            KategoriName = kategoriName;
        }
        public string KategoriId { get; set; }
        public string KategoriName { get; set; }
    }
}
